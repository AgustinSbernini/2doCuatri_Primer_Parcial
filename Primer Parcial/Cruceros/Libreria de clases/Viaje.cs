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
        private DateTime fechaVuelta;
        private Crucero crucero;
        private List<Pasajero> listaPasajeros;
        private int cantidadCamarotesDisponiblesPremium;
        private int cantidadCamarotesDisponiblesTurista;
        private int cantidadBodegaDisponible;
        private double costoPasajeTurista;
        private double costoPasajePremium;
        private int duracionDelViaje;
        private Random generarDuracion;

        private static readonly double precioExtraPremium = 1.2;
        private static readonly int precioPorHoraRegional = 57;
        private static readonly int precioPorHoraExtraregional = 120;
        private static readonly int duracionMinimaRegional = 72;
        private static readonly int duracionMaximaRegional = 360 + 1;
        private static readonly int duracionMinimaExtraregional = 480;
        private static readonly int duracionMaximaExtraregional = 720 + 1;

        public string CiudadDePartida { get { return this.ciudadDePartida; } }
        public string Destino { get { return this.destino; } }
        public int CamarotesTurista {
            get { return this.cantidadCamarotesDisponiblesTurista; }
            set { this.cantidadCamarotesDisponiblesTurista = value; }
        }
        public int CamarotesPremium { get { return this.cantidadCamarotesDisponiblesPremium; }
            set { this.cantidadCamarotesDisponiblesPremium = value; }
        }
        public int Bodega { get { return this.cantidadBodegaDisponible; }
            set { this.cantidadBodegaDisponible = value; }
        }
        public static int DuracionMaximaRegional { get { return Viaje.duracionMaximaRegional; } }
        public static int DuracionMaximaExtraRegional { get { return Viaje.duracionMaximaExtraregional; } }

        public DateTime FechaSalida { get { return this.fechaSalida; } }
        public DateTime FechaLlegada { get { return this.fechaVuelta; } }
        public string CostoPasajeTurista { get { return $"{this.costoPasajeTurista:c}"; } }
        public string CostoPasajePremium { get { return $"{this.costoPasajePremium:c}"; } }
        public Crucero Crucero { get { return this.crucero; } }
        public List<Pasajero> ListaPasajeros { get { return this.listaPasajeros; } }
        private Viaje(DateTime fechaSalida, Crucero crucero)
        {
            this.ciudadDePartida = "Buenos Aires";
            this.fechaSalida = fechaSalida;
            this.crucero = crucero;
            this.cantidadCamarotesDisponiblesTurista = crucero.CamarotesTurista;
            this.cantidadCamarotesDisponiblesPremium = crucero.CamarotesPremium;
            this.cantidadBodegaDisponible = crucero.Bodega;
            this.generarDuracion = new();
            this.listaPasajeros = new();
            this.fechaVuelta = new();
        }

        public Viaje(DateTime fechaSalida, Crucero crucero, DestinosRegionales destino) : this(fechaSalida, crucero)
        {
            this.duracionDelViaje = this.generarDuracion.Next(duracionMinimaRegional, duracionMaximaRegional);
            this.destino = destino.ToString();
            this.costoPasajeTurista = this.duracionDelViaje * precioPorHoraRegional;
            this.costoPasajePremium = this.costoPasajeTurista * precioExtraPremium;
            this.fechaVuelta = this.fechaSalida.AddDays(duracionDelViaje / 24);
        }
        public Viaje(DateTime fechaSalida, Crucero crucero, DestinosExtraregionales destino) : this(fechaSalida, crucero)
        {
            this.duracionDelViaje = this.generarDuracion.Next(duracionMinimaExtraregional, duracionMaximaExtraregional);
            this.destino = destino.ToString();
            this.costoPasajeTurista = this.duracionDelViaje * precioPorHoraExtraregional;
            this.costoPasajePremium = this.costoPasajeTurista * precioExtraPremium;
            this.fechaVuelta = this.fechaSalida.AddDays(duracionDelViaje / 24);
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

        public static bool operator ==(Viaje viaje, string[] matriculaFecha)
        {
            return viaje.crucero.Matricula == matriculaFecha[0] && $"{viaje.FechaSalida:d}" == matriculaFecha[1];
        }
        public static bool operator !=(Viaje viaje, string[] matriculaFecha)
        {
            return !(viaje == matriculaFecha);
        }
        public static bool operator ==(Viaje viaje, Crucero crucero)
        {
            return viaje.crucero == crucero;
        }
        public static bool operator !=(Viaje viaje, Crucero crucero)
        {
            return !(viaje == crucero);
        }
        public static Viaje operator + (Viaje viaje, List<Pasajero> listPasajeros)
        {
            foreach(Pasajero pasajero in listPasajeros)
            {
                viaje += pasajero;
            }

            return viaje;
        }

        public static Viaje operator + (Viaje viaje, Pasajero pasajero)
        {
            if (!viaje.listaPasajeros.Contains(pasajero))
            {
                if(viaje.Bodega >= pasajero.Equipaje.PesoTotalValijas)
                {
                    if(pasajero.Clase == Clase.Turista)
                    {
                        if(viaje.CamarotesTurista > 0)
                        {
                            viaje.listaPasajeros.Add(pasajero);
                            viaje.CamarotesTurista--;
                            viaje.Bodega -= pasajero.Equipaje.PesoTotalValijas;
                        }
                    }
                    else
                    {
                        if (viaje.CamarotesPremium > 0)
                        {
                            viaje.listaPasajeros.Add(pasajero);
                            viaje.CamarotesPremium--;
                            viaje.Bodega -= pasajero.Equipaje.PesoTotalValijas;
                        }
                    }
                }
            }

            return viaje;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Viaje)
                {
                    retorno = this == obj as Viaje;
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
