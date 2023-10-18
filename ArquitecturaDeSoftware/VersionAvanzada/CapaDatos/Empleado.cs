namespace VersionAvanzada.CapaDatos;
    public class Empleado
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public Empleado(int id, string nombre, double salario)
        {
            Id = id;
            Nombre = nombre;
            Salario = salario;
        }

    }
