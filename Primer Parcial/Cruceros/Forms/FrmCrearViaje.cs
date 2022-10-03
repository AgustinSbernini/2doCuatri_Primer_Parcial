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
    public partial class FrmCrearViaje : Form
    {
        List<Crucero> listCruceros;
        List<Viaje> listViajes;
        Crucero cruceroSeleccionado;
        int indexCrucero;
        bool validarFecha = false;
        bool validarViaje = false;

        public FrmCrearViaje()
        {
            InitializeComponent();
        }

        public FrmCrearViaje(List<Crucero> listCruceros, List<Viaje> listViajes) : this()
        { 
            // Carga del FrmIndex la lista de cruceros y la lista de viajes actuales
            this.listCruceros = listCruceros;
            this.listViajes = listViajes;
        }

        private void FrmCrearViaje_Load(object sender, EventArgs e)
        {
            // Recorre la lista de cruceros y agrega el nombre de cada crucero
            // en el combo box de Crucero
            this.cbCrucero.Items.Clear();

            foreach (Crucero crucero in listCruceros)
            {
                this.cbCrucero.Items.Add(crucero.Nombre);
            }

            // Inicializa el radio button Regionales en check
            this.rbRegionales.Checked = true;
        }

        private void rbRegionales_CheckedChanged(object sender, EventArgs e)
        {
            // Comprueba si el radio button Regionales esta con su check
            // Limpia los items que esten cargados anteriormente en el combo box de Destinos
            // Carga todos los Destinos Regionales y selecciona el primero
            if (this.rbRegionales.Checked == true)
            {
                this.cbDestinos.Items.Clear();

                foreach (DestinosRegionales destino in Enum.GetValues(typeof(DestinosRegionales)))
                {
                    this.cbDestinos.Items.Add((destino).ToString().Replace("_", ", ").Replace("1", " "));
                }

                this.cbDestinos.SelectedItem = this.cbDestinos.Items[0];
            }
        }

        private void rbExtraRegionales_CheckedChanged(object sender, EventArgs e)
        {
            // Comprueba si el radio button Extra Regionales esta con su check
            // Limpia los items que esten cargados anteriormente en el combo box de Destinos
            // Carga todos los destinos Extra Regionales y selecciona el primero
            if (this.rbExtraRegionales.Checked == true)
            {
                this.cbDestinos.Items.Clear();

                foreach (DestinosExtraregionales destino in Enum.GetValues(typeof(DestinosExtraregionales)))
                {
                    this.cbDestinos.Items.Add((destino).ToString().Replace("_", ", ").Replace("1", " "));
                }

                this.cbDestinos.SelectedItem = this.cbDestinos.Items[0];
            }
        }

        private void cbCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recoge del combo box de Cruceros el indice de crucero seleccionado y lo busca dentro de la lista de Cruceros
            indexCrucero = this.cbCrucero.SelectedIndex;
            cruceroSeleccionado = listCruceros[indexCrucero];

            // Limpia los combo box por si tienen datos cargados anteriormente
            this.cbFechaInicio.Items.Clear();
            this.cbFechaFinal.Items.Clear();

            // Recorre la lista de viajes buscando todos los viajes en los que participa el crucero seleccionado
            // E informa todas las fechas de salida y de llegada que tiene dicho crucero en cada viaje
            foreach (Viaje viaje in listViajes)
            {
                if(viaje == cruceroSeleccionado)
                {
                    this.cbFechaInicio.Items.Add(viaje.FechaSalida);
                    this.cbFechaFinal.Items.Add(viaje.FechaLlegada);
                }
            }
            // Selecciona las fechas de salida y de llegada del primer viaje encontrado
            if(cbFechaInicio.Items.Count != 0)
            {
                this.cbFechaInicio.SelectedItem = this.cbFechaInicio.Items[0];
                this.cbFechaFinal.SelectedItem = this.cbFechaFinal.Items[0];
            }
        }

        private void dtpFechaSalida_CloseUp(object sender, EventArgs e)
        {
            // Si el radio button de viajes Regionales esta en check recorre el combo box de Fecha de Inicio
            // Para verificar si es que el crucero tiene algun viaje cargado, de ser asi evita que puedan ser seleccionadas
            // las fechas del DataTimePicker en las que el crucero esta en viaje, ni tampoco las fechas anteriores
            // hasta el maximo de dias que podria durar el viaje creado para evitar una superposicion.
            // De seleccionar una fecha invalida aparece un mensaje de error avisandolo. En caso contrario se valida la fecha
            if (this.rbRegionales.Checked == true)
            {
                for (int i = 0; i < cbFechaInicio.Items.Count; i++)
                {
                    if (this.dtpFechaSalida.Value.AddDays(Viaje.DuracionMaximaRegional / 24) > ((DateTime)this.cbFechaInicio.Items[i]) &&
                        this.dtpFechaSalida.Value < ((DateTime)this.cbFechaFinal.Items[i]).AddDays(1))
                    {
                        MessageBox.Show("La fecha indicada no esta habilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validarFecha = false;
                        break;
                    }
                    else
                    {
                        validarFecha = true;
                    }
                }
            }
            else
            {
                // Mismo procedimiento explicado anteriormente pero con los Destinos Extraregionales los cuales tienen una duracion mayor
                for (int i = 0; i < cbFechaInicio.Items.Count; i++)
                {
                    if (this.dtpFechaSalida.Value.AddDays(Viaje.DuracionMaximaExtraRegional / 24) > ((DateTime)this.cbFechaInicio.Items[i]) &&
                        this.dtpFechaSalida.Value < ((DateTime)cbFechaFinal.Items[i]).AddDays(1))
                    {
                        MessageBox.Show("La fecha indicada no esta habilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validarFecha = false;
                        break;
                    }
                    else
                    {
                        validarFecha = true;
                    }
                }
            }
        }

        private void cbFechaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si cambia la fecha de inicio del crucero se vizualizara tambien la fecha de llegada en conjunto
            this.cbFechaFinal.SelectedIndex = this.cbFechaInicio.SelectedIndex;            
        }

        private void btnCrearCrucero_Click(object sender, EventArgs e)
        {
            // En caso de que el crucero no tenga ningun viaje cargado no se tendra que validar una fecha
            if(cbFechaInicio.Items.Count == 0)
            {
                validarFecha = true;
            }

            // Verifica si se selecciono incorrectamente los Destinos, el Crucero o la Fecha
            // Avisando de dicho inconveniente con un mensaje de error
            // En caso contrario verifica cual radio button esta en Check y crea un viaje nuevo
            // Con la fecha de salida, el crucero y el destino seleccionado.
            if(this.cbDestinos.SelectedIndex == -1 || this.cbCrucero.SelectedIndex == -1 || validarFecha == false)
            {
                MessageBox.Show("Al menos uno de los datos ingresados es incorrecto, verifique de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(rbRegionales.Checked == true)
                {
                    // Recorre el Enum de Destinos Regionales hasta encontrar el match con el seleccionado
                    foreach(DestinosRegionales destino in Enum.GetValues(typeof(DestinosRegionales)))
                    {
                        if(cbDestinos.SelectedIndex == (int) destino)
                        {
                            listViajes.Add(new Viaje(dtpFechaSalida.Value, cruceroSeleccionado, destino));
                            validarViaje = true;
                        }
                    }
                }
                else
                {
                    // Recorre el Enum de Destinos Extra Regionales hasta encontrar el match con el seleccionado
                    foreach (DestinosExtraregionales destino in Enum.GetValues(typeof(DestinosExtraregionales)))
                    {
                        if(cbDestinos.SelectedIndex == (int)destino)
                        {
                            listViajes.Add(new Viaje(dtpFechaSalida.Value, cruceroSeleccionado, destino));
                            validarViaje = true;
                        }
                    }
                }

                // Si el viaje fue creado correctamente actualiza la lista de viajes del Form Index
                // Y cierra el Form CrearViaje
                if(validarViaje)
                {
                    FrmIndex frmIndex = Owner as FrmIndex;
                    frmIndex.Viajes = listViajes;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
