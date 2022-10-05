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
    public partial class FrmInfoDetallada : Form
    {
        List<Viaje> listViajes;
        Viaje viajeAux;
        int indiceViajeSelec;
        int contadorFiltro;
        public FrmInfoDetallada()
        {
            InitializeComponent();
        }
        public FrmInfoDetallada(List<Viaje> listViajes) : this()
        {
            this.listViajes = listViajes;
        }

        private void FrmInfoDetallada_Load(object sender, EventArgs e)
        {
            // Carga en el combo box los viajes que hay en la lista y selecciona el indice
            // Del viaje seleccionado en el FrmIndex
            foreach (Viaje viaje in listViajes)
            {
                cbViajes.Items.Add($"Viaje de {viaje.CiudadDePartida} hasta {viaje.Destino} del dia {viaje.FechaSalida:d} con el crucero {viaje.Crucero.Nombre}");
            }

            cbViajes.SelectedIndex = indiceViajeSelec;
        }
        // Llamado en el FrmIndex para almacenar el valor del indice del Viaje seleccionado
        public void RecolectarIndicePrimerViaje(int i)
        {
            this.indiceViajeSelec = i;
        }

        private void cbViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            viajeAux = listViajes[cbViajes.SelectedIndex];

            // Imprime en los text box la sobrecarga de ToString() de viaje y de crucero
            this.txtViajes.Text = viajeAux.ToString();
            this.txtCrucero.Text = viajeAux.Crucero.ToString();

            TodosLosPasajeros(sender, e);
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            // Comprueba de que no se hayan ingresado solo espacios
            if(txtApellido.Text.Trim().Length > 0)
            {
                // Limpia los textbox y reinicia el contador
                txtPasajeros1.Clear();
                txtPasajeros2.Clear();
                contadorFiltro = 0;

                // Recorre la lista de pasajeros del viaje seleccionado y busca si alguno de sus pasajeros
                // inicia su apellido con lo ingresado en el textbox Apellido
                // De ser así imprime los pares en el textbox de la izquierda y los pares en el de la derecha
                for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
                {
                    if(viajeAux.ListaPasajeros[i].Apellido.Contains(txtApellido.Text.Trim()))
                    {
                        if (contadorFiltro % 2 == 0)
                        {
                            txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        else
                        {
                            txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                        }

                        contadorFiltro++;
                    }
                }
            }
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            // Comprueba de que no se hayan ingresado solo espacios
            if (txtDNI.Text.Trim().Length > 0)
            {
                // Limpia los textbox y reinicia el contador
                txtPasajeros1.Clear();
                txtPasajeros2.Clear();
                contadorFiltro = 0;

                for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
                {
                    // Recorre la lista de pasajeros del viaje seleccionado y busca si alguno de sus pasajeros
                    // inicia su dni con lo ingresado en el textbox DNI
                    // De ser así imprime los pares en el textbox de la izquierda y los impares en el de la derecha
                    if (viajeAux.ListaPasajeros[i].Dni.ToString().Contains(txtDNI.Text.Trim()))
                    {
                        if (contadorFiltro % 2 == 0)
                        {
                            txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        else
                        {
                            txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                        }

                        contadorFiltro++;
                    }
                }
            }
        }

        private void btnNacionalidad_Click(object sender, EventArgs e)
        {
            // Comprueba de que no se hayan ingresado solo espacios
            if (txtNacionalidad.Text.Trim().Length > 0)
            {
                // Limpia los textbox y reinicia el contador
                txtPasajeros1.Clear();
                txtPasajeros2.Clear();
                contadorFiltro = 0;

                for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
                {
                    // Recorre la lista de pasajeros del viaje seleccionado y busca si alguno de sus pasajeros
                    // inicia su nacionalidad con lo ingresado en el textbox Nacionalidad
                    // De ser así imprime los pares en el textbox de la izquierda y los impares en el de la derecha
                    if (viajeAux.ListaPasajeros[i].Nacionalidad.Contains(txtNacionalidad.Text.Trim()))
                    {
                        if (contadorFiltro % 2 == 0)
                        {
                            txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        else
                        {
                            txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                        }

                        contadorFiltro++;
                    }
                }
            }
        }

        private void TodosLosPasajeros(object sender, EventArgs e)
        {
            // Limpia los textbox
            txtPasajeros1.Clear();
            txtPasajeros2.Clear();

            // Recorre la lista de pasajeros del viaje seleccionado imprime los pasajeros pares
            // En el textbox de la izquierda y los impares en el de la derecha
            for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
            {
                if (i % 2 == 0)
                {
                    txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                }
                else
                {
                    txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                }
            }
        }
    }
}
