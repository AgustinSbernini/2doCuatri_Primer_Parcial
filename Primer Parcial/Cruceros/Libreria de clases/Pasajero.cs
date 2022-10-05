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

        public override string ToString()
        {
            StringBuilder retorno = new();

            retorno.AppendLine($"Pasajero: {this.Apellido}, {this.Nombre} de {this.Edad} años");
            retorno.AppendLine($"Clase: {this.Clase} y lleva consigo: ");
            if(this.Equipaje.BolsoDeMano)
            {
                retorno.AppendLine($"\t1 bolso de mano");
            }
            if(this.Equipaje.CantidadValijas > 0)
            {
                retorno.AppendLine($"\t{this.Equipaje.CantidadValijas} valijas con un peso total de {this.Equipaje.PesoTotalValijas}kg");
            }
            retorno.AppendLine($"************** Datos del Pasaporte  **************");
            retorno.AppendLine($"DNI: {this.Dni}");
            retorno.AppendLine($"Fecha de nacimiento: {this.FechaNacimiento:d}");
            retorno.AppendLine($"Numero del Pasaporte: {this.NumeroPasaporte}");
            retorno.AppendLine($"Fecha de vencimiento: {this.FechaVencimiento:d}");
            retorno.AppendLine($"Nacionalidad: {this.Nacionalidad}");
            retorno.AppendLine($"Sexo: {this.Sexo}");
            retorno.AppendLine($"****************************************************");
            retorno.AppendLine();
            retorno.AppendLine();

            return retorno.ToString();
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
