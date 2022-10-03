using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Pasajero : Pasaporte
    {
        private int edad;
        private Pasaporte pasaporte;
        private Equipaje equipaje;
        private Clase clase;

        public int Edad { get => edad; }
        public Clase Clase { get => clase; }
        public Equipaje Equipaje { get => equipaje; }

        public Pasajero(Clase clase, string nombre, string apellido, int dni, string numeroPasaporte, string nacionalidad,
            DateTime fechaNacimiento, DateTime fechaVencimiento, Sexo sexo, bool bolsoDeMano, int cantidadValijas, int pesoTotalValijas) 
            : base(nombre, apellido, dni, numeroPasaporte, nacionalidad, fechaNacimiento, fechaVencimiento, sexo)
        {
            this.equipaje = new(bolsoDeMano, cantidadValijas, pesoTotalValijas);
            this.pasaporte = new(nombre, apellido, dni, numeroPasaporte, nacionalidad, fechaNacimiento, fechaVencimiento, sexo);
            this.clase = clase;
            this.edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        }



        public static bool operator == (Pasajero p1, Pasajero p2)
        {
            return p1.Dni == p2.Dni;
        }
        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Pasajero)
                {
                    retorno = this == obj as Pasajero;
                }
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
