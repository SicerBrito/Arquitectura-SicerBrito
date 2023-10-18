using VersionAvanzada.CapaDatos;
using VersionAvanzada.CapaNegocios;

internal class Program
{
    private static void Main(string[] args)
    {

        GestorEmpleados gestor = new GestorEmpleados();

        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar Empleado");
            Console.WriteLine("2. Mostrar Empleados");
            Console.WriteLine("3. Actualizar Empleado");
            Console.WriteLine("4. Eliminar Empleado");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
            
            string opcion = Console.ReadLine()!;
            
            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.Write("ID del Empleado: ");
                    int id = int.Parse(Console.ReadLine()!);
                    Console.Write("Nombre del Empleado: ");
                    string nombre = Console.ReadLine()!;
                    Console.Write("Salario del Empleado: ");
                    double salario = double.Parse(Console.ReadLine()!);
                    
                    gestor.AgregarEmpleado(new Empleado(id, nombre, salario));
                    Console.WriteLine("Empleado agregado con éxito. Presione Cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
                case "2":
                    Console.Clear();
                    var empleados = gestor.ObtenerEmpleados();
                    Console.WriteLine("Lista de Empleados:");
                    foreach (var empleado in empleados)
                    {
                        Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
                        Console.WriteLine("Presione Cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                    
                case "3":
                    Console.Clear();
                    Console.Write("ID del Empleado a actualizar: ");
                    int idActualizar = int.Parse(Console.ReadLine()!);
                    var empleadoExistente = gestor.ObtenerEmpleadoPorId(idActualizar);
                    if (empleadoExistente != null)
                    {
                        Console.Write("Nuevo Nombre del Empleado: ");
                        empleadoExistente.Nombre = Console.ReadLine()!;
                        Console.Write("Nuevo Salario del Empleado: ");
                        empleadoExistente.Salario = double.Parse(Console.ReadLine()!);
                        gestor.ActualizarEmpleado(empleadoExistente);
                        Console.WriteLine("Empleado actualizado con éxito. Presione Cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Empleado no encontrado. Presione Cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                    
                case "4":
                    Console.Clear();
                    Console.Write("ID del Empleado a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine()!);
                    gestor.EliminarEmpleado(idEliminar);
                    Console.WriteLine("Empleado eliminado con éxito. Presione Cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
                case "5":
                    Console.WriteLine("Muchas Gracias por elegirnos");
                    Environment.Exit(0);
                    break;
                    
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Presione Cualquier tecla para continuar..");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        
    }
}