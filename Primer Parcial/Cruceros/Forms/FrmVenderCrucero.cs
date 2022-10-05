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
    public partial class FrmVenderCrucero : Form
    {
        List<Crucero> listCruceros;
        List<Viaje> listViajes;
        int cantGimnasioSeleccionado;
        int cantComedoresSeleccionado;
        int cantPiscinasSeleccionado;
        int cantCasinosSeleccionado;
        bool cerrarSeguro = false;
        double ivaTurista;
        double ivaPremium;
        Crucero cruceroSeleccionado;
        Viaje viajeSeleccionado;
        Pasajero pasajeroNuevo;
        string nombrePasajero;
        string apellidoPasajero;
        string nacionalidadPasajero;
        Clase clasePasajero;
        Sexo sexoPasajero;
        bool camaroteDisponiblePasajero = false;

        public FrmVenderCrucero()
        {
            InitializeComponent();
        }
        public FrmVenderCrucero(List<Crucero> listCruceros, List<Viaje> listViajes) : this()
        {
            this.listCruceros = listCruceros;
            this.listViajes = listViajes;
        }
        private void FrmVenderCrucero_Load(object sender, EventArgs e)
        {
            // Agrega todos los cruceros al combobox cruceros
            foreach (Crucero crucero in listCruceros)
            {
                this.cbCruceros.Items.Add(crucero.Nombre);
            }

            // Marca ambos radiobuttons en check para que se active el evento de CheckedChanged
            this.rbRegionales.Checked = true;
            this.rbTurista.Checked = true;

            // Recorre el enumerado de sexo para rellenar el combobox Sexo
            foreach (Sexo sexo in Enum.GetValues(typeof(Sexo)))
            {
                this.cbSexoPasajero.Items.Add(sexo);
            }

            // Setea el dia minimo para la fecha de nacimiento a 100 años atras y el dia maximo al dia actual
            this.dtpFechaNacimientoPasajero.MinDate = DateTime.Today.AddYears(-100);
            this.dtpFechaNacimientoPasajero.MaxDate = DateTime.Today;
            // Setea el dia minimo para la fecha de vencimiento del pasaporte a hoy y el dia maximo a 10 años
            this.dtpFechaVencimientoPasajero.MinDate = DateTime.Today;
            this.dtpFechaVencimientoPasajero.MaxDate = DateTime.Today.AddYears(10);
        }

        public void FiltroDeCrucero(object sender, EventArgs e)
        {
            // Limpia todos los controles del crucero para rellenarlo con nueva informacion
            // O en caso de no encontrar ningun crucero con el filtro dejarlos vacios
            this.cbCruceros.Items.Clear();
            this.txtCamarotesTurista.Clear();
            this.txtCamarotesPremium.Clear();
            this.txtBrutoTurista.Clear();
            this.txtBrutoPremium.Clear();
            this.txtIvaTurista.Clear();
            this.txtIvaPremium.Clear();
            this.txtFinalTurista.Clear();
            this.txtFinalPremium.Clear();
            this.txtBodega.Clear();
            this.cbFechaInicio.Items.Clear();
            this.cbFechaLlegada.Items.Clear();
            this.cbDestinos.Items.Clear();

            // Recolecta los datos de las caracteristicas del crucero
            cantComedoresSeleccionado = (int)this.nudCantidadComedores.Value;
            cantGimnasioSeleccionado = this.checkGimnasio.Checked ? 0 : -1;
            cantPiscinasSeleccionado = this.checkPiscina.Checked ? 0 : -1;
            cantCasinosSeleccionado = this.checkCasino.Checked ? 0 : -1;
            // Recorre la lista de cruceros y por cada crucero comprueba si cumple las condiciones
            // Del filtro establecido, si no estan marcadas las checkbox se setean en -1 los valores
            // Para ignorar el filtro de dicho checkbox
            foreach (Crucero crucero in listCruceros)
            {
                if(crucero.Comedores >= cantComedoresSeleccionado)
                {
                    if(crucero.Gimnasio > cantGimnasioSeleccionado)
                    {
                        if(crucero.Piscinia > cantPiscinasSeleccionado)
                        {
                            if(crucero.Casino > cantCasinosSeleccionado)
                            {
                                this.cbCruceros.Items.Add(crucero.Nombre);
                            }
                        }
                    }
                }
            }
        }

        private void rbRegionales_CheckedChanged(object sender, EventArgs e)
        {
            // Limpia el combo box de los Destinos
            this.cbDestinos.Items.Clear();
            
            // Comprueba que haya un Crucero seleccionado
            if(cbCruceros.SelectedIndex != -1)
            {
                // Recorre la lista de viajes buscando los viajes que utilicen el crucero seleccionado
                // Y agrega al combo box de Destinos dependiendo de cual radiobutton este en check
                foreach (Viaje viaje in listViajes)
                {
                    if(viaje == cruceroSeleccionado)
                    {
                        if (this.rbRegionales.Checked == true)
                        {
                            foreach (DestinosRegionales destino in Enum.GetValues(typeof(DestinosRegionales)))
                            {
                                if (viaje.Destino == destino.ToString().Replace("_", ", ").Replace("1", " "))
                                {
                                    this.cbDestinos.Items.Add((viaje.Destino));
                                }
                            }
                        }
                        else
                        {
                            foreach (DestinosExtraregionales destino in Enum.GetValues(typeof(DestinosExtraregionales)))
                            {
                                if(viaje.Destino == destino.ToString().Replace("_", ", ").Replace("1", " "))
                                {
                                    this.cbDestinos.Items.Add((viaje.Destino));
                                }
                            }
                        }
                    }     
                }

                // Si se encuentra al menos un crucero con los filtros se selecciona el primer indice
                // Sino se limpia todos los controles para evitar errores
                if(this.cbDestinos.Items.Count > 0)
                {
                    this.cbDestinos.SelectedItem = this.cbDestinos.Items[0];
                }
                else
                {
                    this.txtCamarotesTurista.Clear();
                    this.txtCamarotesPremium.Clear();
                    this.txtBrutoTurista.Clear();
                    this.txtBrutoPremium.Clear();
                    this.txtIvaTurista.Clear();
                    this.txtIvaPremium.Clear();
                    this.txtFinalTurista.Clear();
                    this.txtFinalPremium.Clear();
                    this.txtBodega.Clear();
                    this.cbFechaInicio.Items.Clear();
                    this.cbFechaLlegada.Items.Clear();
                }
            }
        }

        private void cbCruceros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se comprueba cada vez que se cambia el indice del combo box Cruceros si se ha seleccionado
            // Un crucero efectivamente. De ser asi recolecta el nombre guardado y lo comprueba con
            // Lista de cruceros para obtener el objeto y guardarlo en un crucero auxiliar para utilizarlo
            // A traves de todo el form. Luego activa el evento CheckedChanged para que se realicen los filtros
            if(cbCruceros.SelectedIndex != -1)
            {
                foreach (Crucero crucero in listCruceros)
                {
                    if(cbCruceros.SelectedItem.ToString() == crucero.Nombre)
                    {
                        cruceroSeleccionado = crucero;
                        rbRegionales_CheckedChanged(sender, e);
                        break;
                    }
                }
            }
        }

        private void cbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles de las fechas
            this.cbFechaInicio.Items.Clear();
            this.cbFechaLlegada.Items.Clear();

            // Cada vez que se selecciona un destino nuevo se recorre la lista de viajes para hacer el match
            // Con el viaje seleccionado efectivamente. Luego se calculan todos los datos relevantes que posee
            // Dicho Viaje y guarda el objeto en una variable auxiliar para utilizarlo por fuera del foreach
            foreach (Viaje viaje in listViajes)
            {
                if(viaje == cruceroSeleccionado && viaje.Destino == cbDestinos.SelectedItem.ToString())
                {
                    ivaTurista = viaje.CostoPasajeTurista * 0.21;
                    ivaPremium = viaje.CostoPasajePremium * 0.21;

                    this.cbFechaInicio.Items.Add(viaje.FechaSalida);
                    this.cbFechaLlegada.Items.Add(viaje.FechaLlegada);
                    this.txtCamarotesTurista.Text = $"{viaje.CamarotesTurista} / {cruceroSeleccionado.CamarotesTurista}";
                    this.txtCamarotesPremium.Text = $"{viaje.CamarotesPremium} / {cruceroSeleccionado.CamarotesPremium}";
                    this.txtBrutoTurista.Text = $"{viaje.CostoPasajeTurista:c}";
                    this.txtBrutoPremium.Text = $"{viaje.CostoPasajePremium:c}";
                    this.txtIvaTurista.Text = $"{ivaTurista:c}";
                    this.txtIvaPremium.Text = $"{ivaPremium:c}";
                    this.txtFinalTurista.Text = $"{viaje.CostoPasajeTurista + ivaTurista:c}";
                    this.txtFinalPremium.Text = $"{viaje.CostoPasajePremium + ivaPremium:c}";
                    this.txtBodega.Text = $"{viaje.Bodega} / {cruceroSeleccionado.Bodega}";

                    viajeSeleccionado = viaje;
                }
            }

            if(this.cbFechaInicio.Items.Count != -1)
            {
                this.cbFechaInicio.SelectedIndex = 0;
            }
        }

        private void cbFechaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al estar bloqueado la Fecha de llegada la forma de cambiarla es a traves de la Fecha de Inicio
            // Para que ambas fechas vayan en sintonia con el viaje y no se preste a confusion
            this.cbFechaLlegada.SelectedIndex = this.cbFechaInicio.SelectedIndex;
        }

        private void rbTurista_CheckedChanged(object sender, EventArgs e)
        {
            // Setea los valores maximo de la cantidad de valijas y el peso total que puede llevar
            // Un pasajero dependiendo de la clase que desee comprar
            if(this.rbTurista.Checked)
            {
                this.nudCantidadValijas.Maximum = 1;
                this.nudPesoValijas.Maximum = 25;
            }
            else
            {
                this.nudCantidadValijas.Maximum = 2;
                this.nudPesoValijas.Maximum = 50;
            }
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            // Evita que se ingresen numeros en el text box
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            // Evita que se ingresen letras en el text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPasaportePasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Los pasaportes estan compuestos por 3 letras y 6 numeros, por eso evita el uso de numeros
            // Durante los primeros 3 digitos y luego evita el uso de letras
            if(this.txtPasaportePasajero.TextLength < 3)
            {
                SoloLetras(sender, e);
            }
            else
            {
                SoloNumeros(sender, e);
            }
        }

        private void btnVenderCrucero_Click(object sender, EventArgs e)
        {
            // Comprueba de que se haya seleccionado un viaje, sino salta un mensaje aclarandolo
            if(viajeSeleccionado is not null)
            {
                // Setea los valores de los datos ingresados por el pasajero
                sexoPasajero = this.cbSexoPasajero.SelectedIndex == 0 ? Sexo.Masculino : Sexo.Femenino;

                if(rbTurista.Checked)
                {
                    clasePasajero = Clase.Turista;
                    camaroteDisponiblePasajero = viajeSeleccionado.CamarotesTurista > 0;
                }
                else
                {
                    clasePasajero = Clase.Premium;
                    camaroteDisponiblePasajero = viajeSeleccionado.CamarotesPremium > 0;
                }
                // Elimina los espacios anteriores y posteriores al texto
                nombrePasajero = this.txtNombrePasajero.Text.Trim();
                apellidoPasajero = this.txtApellidoPasajero.Text.Trim();
                nacionalidadPasajero = this.txtNacionalidadPasajero.Text.Trim();

                // Valida de que se haya ingresado un nombre, se haya ingresado un apellido, se haya ingresado una nacionalidad
                // Se haya seleccionado un sexo, que el pasaporte y el dni este escritos por completo,
                // Que el peso del equipaje no supere a la capacidad maxima de la bodega y que haya espacio para un pasajero nuevo
                if(nombrePasajero.Length == 0 || apellidoPasajero.Length == 0 || nacionalidadPasajero.Length == 0 || 
                    this.cbSexoPasajero.SelectedIndex == -1 || this.txtPasaportePasajero.TextLength != this.txtPasaportePasajero.MaxLength
                    || this.txtDNIPasajero.TextLength != this.txtDNIPasajero.MaxLength || viajeSeleccionado.Bodega < this.nudPesoValijas.Value
                    || !camaroteDisponiblePasajero)
                {
                    // Si falta algun dato salta un mensaje de error
                    MessageBox.Show("Al menos uno de los datos ingresados es incorrecto, verifique de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Si todos los datos son correctos se crea un pasajero nuevo
                    pasajeroNuevo = new(clasePasajero, this.txtNombrePasajero.Text, this.txtApellidoPasajero.Text,
                        int.Parse(this.txtDNIPasajero.Text), this.txtPasaportePasajero.Text, this.txtNacionalidadPasajero.Text, 
                        this.dtpFechaNacimientoPasajero.Value, this.dtpFechaVencimientoPasajero.Value,
                        sexoPasajero, this.cbBolsoDeMano.Checked,(int) this.nudCantidadValijas.Value, 
                        (int) this.nudPesoValijas.Value);

                    // Se verifica de que el pasajero nuevo creado no se encuentre ya dentro de la lista
                    // De pasajeros del viaje. Si se encuentra salta un error y evita la compra, si no se encuentra
                    // Se efectua la compra, agrega al pasajero a la lista y cierra el formulario
                    for(int i = 0; i < listViajes.Count; i++)
                    {
                        if(listViajes[i] == viajeSeleccionado)
                        {
                            if(viajeSeleccionado.ListaPasajeros.Contains(pasajeroNuevo))
                            {
                                MessageBox.Show("El pasajero ya ha comprado un pasaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cerrarSeguro = true;
                                listViajes[i] += pasajeroNuevo;
                                this.Close();
                            }
                        }
                    }  
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado un viaje valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVenderCrucero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!cerrarSeguro)
            {
                if (MessageBox.Show("Seguro desea cerrar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
