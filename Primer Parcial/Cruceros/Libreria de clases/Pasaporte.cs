using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Pasaporte
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string numeroPasaporte; // ZZZ000000 <- formato triple Z + numero de 6 digitos
        private string nacionalidad;
        private DateTime fechaNacimiento;
        private DateTime fechaVencimiento;
        private Sexo sexo;

        public Pasaporte(string nombre, string apellido, int dni, string numeroPasaporte, string nacionalidad,
            DateTime fechaNacimiento, DateTime fechaVencimiento, Sexo sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.numeroPasaporte = numeroPasaporte;
            this.nacionalidad = nacionalidad;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaVencimiento = fechaVencimiento;
            this.sexo = sexo;
        }

        public int Dni { get { return this.dni; } }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public Sexo Sexo { get => sexo; }
        public string NumeroPasaporte { get => numeroPasaporte; }
        public string Nacionalidad { get => nacionalidad; }
        public DateTime FechaNacimiento { get => fechaNacimiento; }
        public DateTime FechaVencimiento { get => fechaVencimiento; }
    }
}
