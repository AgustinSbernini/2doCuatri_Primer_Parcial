using System;
using System.Text;

namespace Libreria_de_clases
{
    public class Crucero
    {
        private string matricula; //alfanumerico 8 digitos
        private string nombre;
        private int cantidadCamarotesTurista;
        private int cantidadCamarotesPremium;
        private int cantidadComedores;
        private int cantidadGimnasios;
        private int cantidadPiscinas;
        private int cantidadCasinos;
        private int pesoBodega;

        private const double porcentajeCamarotesTurista = 0.65;
        private const double porcentajeCamarotesPremium = 0.35;

        private Crucero()
        {
            this.cantidadComedores = 1;
            this.cantidadGimnasios = 0;
            this.cantidadPiscinas = 0;
            this.cantidadCasinos = 0;
            this.pesoBodega = 350;
        }

        public Crucero(string matricula, string nombre, int cantidadCamarotes) : this()
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotesTurista = (int)(Math.Round(cantidadCamarotes * porcentajeCamarotesTurista, MidpointRounding.AwayFromZero));
            this.cantidadCamarotesPremium = (int) (Math.Round(cantidadCamarotes * porcentajeCamarotesPremium, MidpointRounding.ToZero));
        }

        public Crucero(string matricula, string nombre, int cantidadCamarotes, int cantidadComedores, int cantidadGimnasios,
            int cantidadPiscinas, int cantidadCasinos, int pesoBodega) : this(matricula, nombre, cantidadCamarotes)
        {
            this.cantidadComedores = cantidadComedores;
            this.cantidadGimnasios = cantidadGimnasios;
            this.cantidadPiscinas = cantidadPiscinas;
            this.cantidadCasinos = cantidadCasinos;
            this.pesoBodega = pesoBodega;
        }


        public string Matricula { get { return this.matricula; } }
        public string Nombre { get { return this.nombre; } }
        public int CamarotesPremium { get { return this.cantidadCamarotesPremium; } }
        public int CamarotesTurista { get { return this.cantidadCamarotesTurista; } }
        public int Comedores { get { return this.cantidadComedores; } }
        public int Gimnasio { get { return this.cantidadGimnasios; } }
        public int Piscinia { get { return this.cantidadPiscinas; } }
        public int Casino { get { return this.cantidadCasinos; } }
        public int Bodega { get { return this.pesoBodega; } }



        public static bool operator == ( Crucero crucero1, Crucero crucero2)
        {
            return crucero1.matricula == crucero2.matricula;
        }
        public static bool operator != (Crucero crucero1, Crucero crucero2)
        {
            return !(crucero1 == crucero2);
        }
        public static bool operator ==(Crucero crucero1, string matricula)
        {
            return crucero1.matricula == matricula;
        }
        public static bool operator !=(Crucero crucero1, string matricula)
        {
            return !(crucero1 == matricula);
        }
        public override string ToString()
        {
            StringBuilder retorno = new();

            retorno.AppendLine($"Crucero: {this.nombre} - {this.matricula}");
            retorno.AppendLine($"Cuenta con un total de {this.cantidadCamarotesTurista} camarotes para pasajeros clase Turistas.");
            retorno.AppendLine($"Cuenta con un total de {this.cantidadCamarotesPremium} camarotes para pasajeros clase Premium");
            retorno.AppendLine($"Dentro de sus instalaciones posee:");
            retorno.AppendLine($"\t{this.Comedores} Comedor/es");
            if (this.cantidadGimnasios > 0)
            {
                retorno.AppendLine($"\t{this.cantidadGimnasios} Gimnasio/s");
            }
            if (this.cantidadPiscinas > 0)
            {
                retorno.AppendLine($"\t{this.cantidadPiscinas} Piscina/s");
            }
            if (this.cantidadCasinos > 0)
            {
                retorno.AppendLine($"\t{this.cantidadCasinos} Casino/s");
            }

            retorno.Append($"\tY el peso maximo que soporta la bodega es de {this.pesoBodega}kg");

            return retorno.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null)
            {
                if(obj is Crucero)
                {
                    retorno = this == obj as Crucero;
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
