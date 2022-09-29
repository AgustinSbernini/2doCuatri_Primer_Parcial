using System;
using System.Text;

namespace Libreria_de_clases
{
    public class Crucero
    {
        private string matricula; //alfanumerico 8 digitos
        private string nombre;
        private int cantidadCamarotesTotales;
        private int cantidadCamarotesDisponibles;
        private int cantidadComedores;
        private int cantidadGimnasios;
        private int cantidadPiscinas;
        private int cantidadCasinos;
        private int cantidadBodegas;
        
        private Crucero()
        {
            this.cantidadComedores = 1;
            this.cantidadGimnasios = 0;
            this.cantidadPiscinas = 0;
            this.cantidadCasinos = 0;
            this.cantidadBodegas = 15;
        }

        public Crucero(string matricula, string nombre, int cantidadCamarotes) : this()
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotesTotales = cantidadCamarotes;
            this.cantidadCamarotesDisponibles = cantidadCamarotes;
        }

        public Crucero(string matricula, string nombre, int cantidadCamarotes, int cantidadComedores, int cantidadGimnasios,
            int cantidadPiscinas, int cantidadCasinos, int cantidadBodegas) : this(matricula, nombre, cantidadCamarotes)
        {
            this.cantidadComedores = cantidadComedores;
            this.cantidadGimnasios = cantidadGimnasios;
            this.cantidadPiscinas = cantidadPiscinas;
            this.cantidadCasinos = cantidadCasinos;
            this.cantidadBodegas = cantidadBodegas;
        }


        public string Matricula { get { return this.matricula; } }
        public string Nombre { get { return this.nombre; } }
        public int CamarotesDisponibles 
        { 
            get { return this.cantidadCamarotesDisponibles; }
            set { this.cantidadCamarotesDisponibles = value; } 
        }
        public int CamarotesTotales { get { return this.cantidadCamarotesTotales; } }
        public int Comedores { get { return this.cantidadComedores; } }
        public int Gimnasio { get { return this.cantidadGimnasios; } }
        public int Piscinia { get { return this.cantidadPiscinas; } }
        public int Casino { get { return this.cantidadCasinos; } }
        public int Bodega { get { return this.cantidadBodegas; } }



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

            retorno.Append($"{this.nombre} - {this.matricula}");
            retorno.Append($"{this.cantidadCamarotesTotales} - {this.cantidadComedores}");
            retorno.Append($"{this.cantidadGimnasios} - {this.cantidadPiscinas}");
            retorno.Append($"{this.cantidadCasinos} - {this.cantidadBodegas}");

            return retorno.ToString();
        }
    }
}
