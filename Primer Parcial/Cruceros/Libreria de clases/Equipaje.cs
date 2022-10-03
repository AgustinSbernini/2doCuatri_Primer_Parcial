using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Equipaje
    {
        private bool bolsoDeMano;
        private int cantidadValijas;
        private int pesoTotalValijas;

        public Equipaje(bool bolsoDeMano, int cantidadValijas, int pesoTotalValijas)
        {
            this.bolsoDeMano = bolsoDeMano;
            this.cantidadValijas = cantidadValijas;
            this.pesoTotalValijas = pesoTotalValijas;
        }

        public bool BolsoDeMano { get => bolsoDeMano; }
        public int CantidadValijas { get => cantidadValijas; }
        public int PesoTotalValijas { get => pesoTotalValijas; }
    }
}
