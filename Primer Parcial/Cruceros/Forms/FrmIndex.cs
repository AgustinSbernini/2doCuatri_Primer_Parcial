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
    public partial class FrmIndex : Form
    {
        Crucero crucero;
        List<Crucero> cruceros;
        Viaje viaje1;
        Viaje viaje2;
        Viaje viaje3;
        Viaje viaje4;
        Viaje viaje5;
        Viaje viaje6;
        List<Viaje> viajes;
        DataTable tableViajes;
        DataRow filaAux;
        public FrmIndex()
        {
            InitializeComponent();
            tableViajes = new();
            viajes = new();
            cruceros = new();
            crucero = new("ABDW123", "La Nicole", 15);
            cruceros.Add(crucero);
            viaje1 = new(DateTime.Today, crucero, DestinosExtraregionales.Atenas_Grecia);
            viajes.Add(viaje1);
            viaje2 = new(DateTime.Today, crucero, DestinosExtraregionales.Acapulco_Mexico);
            viajes.Add(viaje2);
            viaje3 = new(DateTime.Today, crucero, DestinosExtraregionales.La_Habana_Cuba);
            viajes.Add(viaje3);
            viaje4 = new(DateTime.Today, crucero, DestinosExtraregionales.Nueva_York_EEUU);
            viajes.Add(viaje4);
            viaje5 = new(DateTime.Today, crucero, DestinosExtraregionales.Taipei_Taiwán); 
            viajes.Add(viaje5);
            viaje6 = new(DateTime.Today, crucero, DestinosExtraregionales.Venecia_Italia);
            viajes.Add(viaje6);
        }
        public FrmIndex(string usuarioIngresado) : this()
        {
            this.lblFecha.Text = $"{DateTime.Today:d}";
            this.lblUsuario.Text = $"{usuarioIngresado}";
        }
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            tableViajes.Columns.Add("Crucero");
            tableViajes.Columns.Add("Origen");
            tableViajes.Columns.Add("Destino");
            tableViajes.Columns.Add("Hora de Partida");
            tableViajes.Columns.Add("Precio Turista");
            tableViajes.Columns.Add("Precio Premium");
            
            foreach(Viaje viaje in viajes)
            {
                filaAux = tableViajes.NewRow();

                filaAux[0] = viaje.Crucero.Matricula;
                filaAux[1] = viaje.CiudadDePartida;
                filaAux[2] = viaje.Destino;
                filaAux[3] = viaje.FechaSalida;
                filaAux[4] = viaje.CostoPasajeTurista;
                filaAux[5] = viaje.CostoPasajePremium;

                tableViajes.Rows.Add(filaAux);
            }

            dgvViajes.DataSource = tableViajes;
        }

        private void btnHistorialViajes_Click(object sender, EventArgs e)
        {
             
        }

        private void dgvViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string matricula = tableViajes.Rows[index][0].ToString();

            foreach (Crucero crucero in cruceros)
            {
                if(crucero == matricula)
                {
                    DataGridViewRow filaAux = new();

                    filaAux.CreateCells(dgvCrucero);

                    filaAux.Cells[0].Value = $"{crucero.Nombre} - {crucero.Matricula}";
                    filaAux.Cells[1].Value = $"{crucero.CamarotesDisponibles}/{crucero.CamarotesTotales}";
                    filaAux.Cells[2].Value = $"{crucero.Comedores}";
                    filaAux.Cells[3].Value = $"{crucero.Gimnasio}";
                    filaAux.Cells[4].Value = $"{crucero.Piscinia}";
                    filaAux.Cells[5].Value = $"{crucero.Casino}";
                    filaAux.Cells[6].Value = $"{crucero.Bodega}";
                    filaAux.Cells[7].Value = $"Nada";

                    dgvCrucero.Rows.Add(filaAux);

                    break;
                }
            }
        }
    }
}
