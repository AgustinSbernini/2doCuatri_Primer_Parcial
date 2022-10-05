using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_de_clases;

namespace Forms
{
    public partial class FrmContenedorEstadisticas : Form
    {
        private Form frmActual;
        List<Viaje> listaViajes;
        public FrmContenedorEstadisticas()
        {
            InitializeComponent();
        }
        public FrmContenedorEstadisticas(List<Viaje> listaViajes) : this()
        {
            this.listaViajes = listaViajes;
        }
        private void mostrarEstadistica(Form frmEstadistica, object btnUsado)
        {
            if(frmActual is not null)
            {
                frmActual.Close();
            }

            frmActual = frmEstadistica;
            frmEstadistica.TopLevel = false;
            frmEstadistica.Dock = DockStyle.Fill;
            this.panelEstadistica.Controls.Add(frmEstadistica);
            this.panelEstadistica.Tag = frmEstadistica;
            frmEstadistica.BringToFront();
            frmEstadistica.Show();
        }
        private void btnDestino_Click(object sender, EventArgs e)
        {
            mostrarEstadistica(new FrmEstadisticasDestino(listaViajes), sender);
        }

        private void btnCruceros_Click(object sender, EventArgs e)
        {
            mostrarEstadistica(new FrmEstadisticaCruceros(listaViajes), sender);
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            mostrarEstadistica(new FrmEstadisticasPasajeros(listaViajes), sender);
        }
    }
}
