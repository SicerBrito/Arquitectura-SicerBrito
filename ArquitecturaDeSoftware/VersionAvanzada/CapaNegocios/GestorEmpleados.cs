using VersionAvanzada.CapaDatos;

namespace VersionAvanzada.CapaNegocios;
    public class GestorEmpleados
    {

        private List<Empleado> empleados;

        public GestorEmpleados()
        {
            empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public Empleado ObtenerEmpleadoPorId(int empleadoId)
        {
            return empleados.FirstOrDefault(e => e.Id == empleadoId)!;
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            var empleadoExistente = empleados.FirstOrDefault(e => e.Id == empleado.Id);
            if (empleadoExistente != null)
            {
                empleadoExistente.Nombre = empleado.Nombre;
                empleadoExistente.Salario = empleado.Salario;
            }
        }

        public void EliminarEmpleado(int empleadoId)
        {
            var empleado = empleados.FirstOrDefault(e => e.Id == empleadoId);
            if (empleado != null)
            {
                empleados.Remove(empleado);
            }
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }
        
    }
