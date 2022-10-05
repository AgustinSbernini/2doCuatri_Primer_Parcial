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
    public partial class FrmEstadisticaCruceros : FrmBaseEstadisticas
    {
        List<Viaje> listViajes;
        DataGridViewRow filaAux;
        int aux;
        public FrmEstadisticaCruceros()
        {
            InitializeComponent();
        }
        public FrmEstadisticaCruceros(List<Viaje> listViajes) : this()
        {
            this.listViajes = listViajes;
        }
        private void FrmEstadisticaCruceros_Load(object sender, EventArgs e)
        {
            // Setea el titulo y los encabezados con sus nombres correspondientes al form
            lblTitulo.Text = "Estadisticas de Cruceros";
            ColumnaNombre.HeaderText = "Cruceros";
            ColumnaValor.HeaderText = "Horas de viajes Totales";

            Dictionary<string, int> diccionario = new();

            // Recorre la lista de viajes y comprueba si el crucero ya se encuentra dentro del diccionario
            // Si se encuentra aumenta la cantidad de horas que viajo. Si no se encuentra lo agrega al diccionario
            foreach (Viaje viaje in listViajes)
            {
                if (diccionario.ContainsKey(viaje.Crucero.Nombre))
                {
                    diccionario.TryGetValue(viaje.Crucero.Nombre, out aux);
                    diccionario[viaje.Crucero.Nombre] = aux + viaje.DuracionDelViaje;
                }
                else
                {
                    diccionario.Add(viaje.Crucero.Nombre, viaje.DuracionDelViaje);
                }
            }

            // Imprime los valores del diccionario dentro del datagrid
            foreach (KeyValuePair<string, int> dic in diccionario)
            {
                filaAux = new();

                filaAux.CreateCells(this.dgv);

                filaAux.Cells[0].Value = dic.Key;
                filaAux.Cells[1].Value = $"{dic.Value} hs";

                this.dgv.Rows.Add(filaAux);
            }
        }
    }
}
