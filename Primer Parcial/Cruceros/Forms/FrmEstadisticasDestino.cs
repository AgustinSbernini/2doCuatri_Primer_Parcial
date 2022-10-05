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
    public partial class FrmEstadisticasDestino : FrmBaseEstadisticas
    {
        List<Viaje> listViajes;
        DataGridViewRow filaAux;
        double acumulador;
        double aux;
        public FrmEstadisticasDestino()
        {
            InitializeComponent();
        }
        public FrmEstadisticasDestino(List<Viaje> listViajes) :this()
        {
            this.listViajes = listViajes;
        }

        private void FrmEstadisticasDestino_Load(object sender, EventArgs e)
        {
            // Setea el titulo y los encabezados con sus nombres correspondientes al form
            lblTitulo.Text = "Estadisticas de Destino";
            ColumnaNombre.HeaderText = "Destinos Visitados";
            ColumnaValor.HeaderText = "Factuarion Total";

            Dictionary<string,double> diccionario = new();

            // Recorre la lista de viajes y calcula la cantidad total de pasajes vendidos en dicho viaje
            // Luego verifica si el Destino se encuentra dentro del diccionario
            // Si se encuentra aumenta la facturacion total. Si no se encuentra lo agrega al diccionario
            foreach (Viaje viaje in listViajes)
            {
                acumulador = 0;
                acumulador = viaje.CostoPasajeTurista * viaje.CamarotesTurista + viaje.CostoPasajePremium * viaje.CamarotesPremium;
                if (diccionario.ContainsKey(viaje.Destino))
                {
                    diccionario.TryGetValue(viaje.Destino, out aux);
                    diccionario[viaje.Destino] = aux + acumulador;
                }
                else
                {
                    diccionario.Add(viaje.Destino, acumulador);
                }
            }

            // Imprime los valores del diccionario dentro del datagrid
            foreach (KeyValuePair<string, double> dic in diccionario)
            {
                filaAux = new();

                filaAux.CreateCells(this.dgv);

                filaAux.Cells[0].Value = dic.Key;
                filaAux.Cells[1].Value = $"{dic.Value:c}";

                this.dgv.Rows.Add(filaAux);
            }
        }
    }
}
