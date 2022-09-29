using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Libreria_de_clases
{
    public class Viaje
    {
        private string ciudadDePartida;
        private string destino;
        private DateTime fechaSalida;
        private Crucero crucero;
        private int cantidadCamarotesDisponiblesPremium;
        private int cantidadCamarotesDisponiblesTurista;
        private double costoPasajeTurista;
        private double costoPasajePremium;
        private int duracionDelViaje;
        private Random generarDuracion;

        private const double precioExtraPremium = 1.2;
        private const int precioPorHoraRegional = 57;
        private const int precioPorHoraExtraregional = 120;
        private const int duracionMinimaRegional = 72;
        private const int duracionMaximaRegional = 360 + 1;
        private const int duracionMinimaExtraregional = 480;
        private const int duracionMaximaExtraregional = 720 + 1;
        private const double porcentajeCamarotesTurista = 0.65;
        private const double porcentajeCamarotesPremium = 0.35;

        public string CiudadDePartida { get { return this.ciudadDePartida; } }
        public string Destino { get { return this.destino; } }
        public string FechaSalida { get { return $"{this.fechaSalida:d}"; } }
        public string CostoPasajeTurista { get { return $"{this.costoPasajeTurista}"; } }
        public string CostoPasajePremium { get { return $"{this.costoPasajePremium}"; } }
        public Crucero Crucero { get { return this.crucero; } }
        private Viaje(DateTime fechaSalida, Crucero crucero)
        {
            this.ciudadDePartida = "Buenos Aires";
            this.fechaSalida = fechaSalida;
            this.crucero = crucero;
            this.cantidadCamarotesDisponiblesTurista = (int)(crucero.CamarotesDisponibles * porcentajeCamarotesTurista);
            this.cantidadCamarotesDisponiblesPremium = (int)(crucero.CamarotesDisponibles * porcentajeCamarotesPremium);
            this.generarDuracion = new();
        }

        public Viaje(DateTime fechaSalida, Crucero crucero, DestinosRegionales destino) : this(fechaSalida, crucero)
        { 
            this.duracionDelViaje = this.generarDuracion.Next(duracionMinimaRegional, duracionMaximaRegional);
            this.destino = destino.ToString();
            this.costoPasajeTurista = this.duracionDelViaje * precioPorHoraRegional;
            this.costoPasajePremium = this.costoPasajeTurista * precioExtraPremium;
        }
        public Viaje(DateTime fechaSalida, Crucero crucero, DestinosExtraregionales destino) : this(fechaSalida, crucero)
        {
            this.duracionDelViaje = this.generarDuracion.Next(duracionMinimaExtraregional, duracionMaximaExtraregional);
            this.destino = destino.ToString();
            this.costoPasajeTurista = this.duracionDelViaje * precioPorHoraExtraregional;
            this.costoPasajePremium = this.costoPasajeTurista * precioExtraPremium;
        }

        public override string ToString()
        {
            StringBuilder retorno = new();

            retorno.AppendLine($"El Viaje se realizará desde {this.ciudadDePartida} a {this.destino}");
            retorno.Append($"El viaje comienza el día {this.fechaSalida:d}");
            retorno.Append($", tendra una duración de {this.duracionDelViaje}hs");
            retorno.AppendLine($"y se viajara en el crucero {this.crucero.Nombre}-{this.crucero.Matricula}");
            retorno.AppendLine($"Quedan {this.cantidadCamarotesDisponiblesPremium} camarotes premiums libres y cuestan ${ this.costoPasajePremium}");
            retorno.AppendLine($"Quedan {this.cantidadCamarotesDisponiblesTurista} camarotes premiums libres y cuestan ${ this.costoPasajeTurista}");

            return retorno.ToString();
        }


    }

}
