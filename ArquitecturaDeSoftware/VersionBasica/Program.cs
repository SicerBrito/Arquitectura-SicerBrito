using VersionBasica.CapaDatos;
using VersionBasica.CapaNegocios;

internal class Program
{
    private static void Main(string[] args)
    {
        
        GestorEmpleados gestor = new GestorEmpleados();
        // Agregar empleados
        gestor.AgregarEmpleado(new Empleado(1, "Juan", 30000));
        gestor.AgregarEmpleado(new Empleado(2, "María", 35000));

        // Listar empleados
        var empleados = gestor.ObtenerEmpleados();
        Console.WriteLine("Lista de Empleados:");
        foreach (var empleado in empleados)
        {
            Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
        }

        // Eliminar un empleado
        int empleadoIdAEliminar = 1;
        gestor.EliminarEmpleado(empleadoIdAEliminar);
        Console.WriteLine($"Empleado con ID {empleadoIdAEliminar} eliminado.");

        // Listar empleados después de eliminar
        empleados = gestor.ObtenerEmpleados();
        Console.WriteLine("Lista de Empleados después de eliminar:");
        foreach (var empleado in empleados)
        {
            Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
        }
        
    }
}