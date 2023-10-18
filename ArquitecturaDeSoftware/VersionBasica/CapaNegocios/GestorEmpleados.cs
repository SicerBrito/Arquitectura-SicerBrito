using VersionBasica.CapaDatos;

namespace VersionBasica.CapaNegocios;
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
