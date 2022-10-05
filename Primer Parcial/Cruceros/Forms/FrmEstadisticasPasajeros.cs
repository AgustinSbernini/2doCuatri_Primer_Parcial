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
    public partial class FrmEstadisticasPasajeros : FrmBaseEstadisticas
    {
        List<Viaje> listViajes;
        DataGridViewRow filaAux;
        int aux;
        public FrmEstadisticasPasajeros()
        {
            InitializeComponent();
        }
        public FrmEstadisticasPasajeros(List<Viaje> listViajes) : this()
        {
            this.listViajes = listViajes;
        }
        private void FrmEstadisticasPasajeros_Load(object sender, EventArgs e)
        {
            // Setea el titulo y los encabezados con sus nombres correspondientes al form
            lblTitulo.Text = "Estadisticas de Pasajeros";
            ColumnaNombre.HeaderText = "Pasajeros";
            ColumnaValor.HeaderText = "Cantidad de Viajes Realizados";

            Dictionary<string, int> diccionario = new();

            // Recorre la lista de viajes y luego recorre la lista de pasajeros
            // Verifica si el pasajero se encuentra dentro del diccionario.
            // Si se encuentra aumenta la cantidad de viajes que realizo. Si no se encuentra lo agrega al diccionario
            foreach (Viaje viaje in listViajes)
            {
                foreach(Pasajero pasajero in viaje.ListaPasajeros)
                {
                    if (diccionario.ContainsKey(pasajero.NombreCompleto))
                    {
                        diccionario.TryGetValue(pasajero.NombreCompleto, out aux);
                        diccionario[pasajero.NombreCompleto] = aux + 1;
                    }
                    else
                    {
                        diccionario.Add(pasajero.NombreCompleto, 1);
                    }
                }
            }

            // Imprime los valores del diccionario dentro del datagrid
            foreach (KeyValuePair<string, int> dic in diccionario)
            {
                filaAux = new();

                filaAux.CreateCells(this.dgv);

                filaAux.Cells[0].Value = dic.Key;
                filaAux.Cells[1].Value = $"{dic.Value} viajes";

                this.dgv.Rows.Add(filaAux);
            }
        }
    }
}
