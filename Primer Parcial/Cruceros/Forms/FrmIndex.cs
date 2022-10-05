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
        #region Declaracion de variables
        FrmCrearViajes frmCrearViajes;
        FrmVenderCrucero frmVenderCrucero;
        FrmInfoDetallada frmInfoDetallada;
        FrmContenedorEstadisticas frmContenedor;

        Crucero crucero1;
        Crucero crucero2;
        Crucero crucero3;
        Crucero crucero4;
        Crucero crucero5;
        Crucero crucero6;
        Crucero crucero7;
        List<Crucero> cruceros;

        Viaje viaje1;
        Viaje viaje2;
        Viaje viaje3;
        Viaje viaje4;
        Viaje viaje5;
        Viaje viaje6;
        List<Viaje> viajes;

        Pasajero pasajero1;
        Pasajero pasajero2;
        Pasajero pasajero3;
        Pasajero pasajero4;
        Pasajero pasajero5;
        List<Pasajero> listaPasajeros;

        DataTable tableViajes;
        DataRow filaAuxViaje;
        DataGridViewRow filaAuxCrucero;
        DataGridViewRow filaAuxPasajero;

        int indexTablaViajes;
        string matricula;
        string fecha;
        string[] matriculaFecha;
        int indiceViajeFrmInfoDetallada;
        #endregion
        public FrmIndex()
        {
            InitializeComponent();

            tableViajes = new();

            cruceros = new();
            #region Instanciar cruceros
            crucero1 = new("ABDW1423", "Braavos", 15);
            cruceros.Add(crucero1);
            crucero2 = new("NDWI0252", "Oros", 20, 2, 1, 0, 1, 500);
            cruceros.Add(crucero2);
            crucero3 = new("MLWQ4523", "Pentos", 23, 3, 1, 2, 1, 600);
            cruceros.Add(crucero3);
            crucero4 = new("ALWJ2351", "King Landing", 30, 4, 2, 2, 2, 1000);
            cruceros.Add(crucero4);
            crucero5 = new("LKWO9148", "Mantarys", 17, 1, 1, 1, 0, 400);
            cruceros.Add(crucero5);
            crucero6 = new("ZMWN2921", "Volantis", 19, 2, 0, 1, 0, 450);
            cruceros.Add(crucero6);
            crucero7 = new("BJUY7753", "Valyria", 22, 3, 2, 1, 1, 500);
            cruceros.Add(crucero7);
            #endregion

            viajes = new();
            #region Instanciar viajes
            viaje1 = new(DateTime.Parse("27/09/2022"), crucero1, DestinosExtraregionales.Atenas_Grecia);
            viajes.Add(viaje1);
            viaje2 = new(DateTime.Parse("05/10/2022"), crucero2, DestinosExtraregionales.Acapulco_Mexico);
            viajes.Add(viaje2);
            viaje3 = new(DateTime.Parse("25/11/2022"), crucero3, DestinosExtraregionales.La1Habana_Cuba);
            viajes.Add(viaje3);
            viaje4 = new(DateTime.Parse("05/10/2022"), crucero4, DestinosRegionales.Lima_Peru);
            viajes.Add(viaje4);
            viaje5 = new(DateTime.Parse("15/11/2022"), crucero5, DestinosRegionales.Recife_Brasil); 
            viajes.Add(viaje5);
            viaje6 = new(DateTime.Parse("15/12/2022"), crucero1, DestinosRegionales.Rio1de1Janeiro_Brasil);
            viajes.Add(viaje6);
            #endregion

            listaPasajeros = new();
            #region Instanciar pasajeros
            pasajero1 = new(Clase.Premium, "Estefania", "Lopez", 40377289, "AAB224551", "Argentina",
                DateTime.Parse("18/07/1997"), DateTime.Parse("19/03/2024"), Sexo.Femenino, true, 2, 30);
            listaPasajeros.Add(pasajero1);
            pasajero2 = new(Clase.Turista, "Patricio", "Gomez", 39555844, "BAS424551", "Brasilera",
                DateTime.Parse("19/06/1850"), DateTime.Parse("08/02/2023"), Sexo.Masculino, false, 1, 20);
            listaPasajeros.Add(pasajero2);
            pasajero3 = new(Clase.Turista, "Cristiana", "Perez", 25415421, "ASC325299", "Uruguaya",
                DateTime.Parse("03/05/2000"), DateTime.Parse("15/09/2025"), Sexo.Femenino, true, 0, 0);
            listaPasajeros.Add(pasajero3);
            pasajero4 = new(Clase.Premium, "Renato", "Dominguez", 36584575, "CAD292149", "Chilena",
                DateTime.Parse("25/12/2004"), DateTime.Parse("25/01/2022"), Sexo.Masculino, false, 1, 10);
            listaPasajeros.Add(pasajero4);
            pasajero5 = new(Clase.Premium, "Luis Alberto", "Alberdi", 79665412, "BCS594123", "Peruana",
                DateTime.Parse("01/01/2001"), DateTime.Parse("25/01/2022"), Sexo.Masculino, true, 2, 25);
            listaPasajeros.Add(pasajero5);
            #endregion

            frmCrearViajes = new(cruceros, viajes);
            frmVenderCrucero = new(cruceros, viajes);
            frmInfoDetallada = new(viajes);
            frmContenedor = new(viajes);
        }
        public FrmIndex(string usuarioIngresado) : this()
        {
            // Rellena los labels con el Usuario recibido y la fecha de hoy
            this.lblFecha.Text = $"{DateTime.Today:d}";
            this.lblUsuario.Text = $"{usuarioIngresado}";
        }
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            // Crea las columna de la tabla de Viaje
            tableViajes.Columns.Add("Crucero");
            tableViajes.Columns.Add("Origen");
            tableViajes.Columns.Add("Destino");
            tableViajes.Columns.Add("Dia Salida");
            tableViajes.Columns.Add("Dia Llegada");
            tableViajes.Columns.Add("PrecioTurista");
            tableViajes.Columns.Add("PrecioPremium");

            // Carga los viajes actuales a la tabla de viaje
            CargarViajes();

            // Agrega pasajeros a algunos viajes creados
            this.viaje1 += listaPasajeros;
            this.viaje2 += listaPasajeros;
            this.viaje3 += listaPasajeros;
            this.viaje1 += listaPasajeros;
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Recolecto la celda clickeada de la tabla de viajes, especificamente el primer indice donde
            // se guarda la matricula y el cuarto indice donde se guarda la fecha de salida
            // y recorro la lista de cruceros para buscar el match y la lista de viajes para buscar el match.
            indexTablaViajes = e.RowIndex;

            // Si el indice es -1 significa que esta clickeando el header de la columna
            if(indexTablaViajes > -1)
            {
                indiceViajeFrmInfoDetallada = 0;

                matricula = dgvViajes.Rows[indexTablaViajes].Cells[0].Value.ToString();
                fecha = dgvViajes.Rows[indexTablaViajes].Cells[3].Value.ToString();

                matriculaFecha = new string[] { matricula, fecha };
            }
            
            // Recorre la lista de viajes hasta encontrar el viaje seleccionado
            foreach (Viaje viaje in viajes)
            {
                if (viaje == matriculaFecha)
                {
                    // Limpia la celda de crucero por si tiene datos cargados anteriormente
                    // Crea una fila y rellena las columna con los datos del crucero del viaje seleccionado
                    // Agrega la fila al DataGridView de Crucero
                    this.dgvCrucero.Rows.Clear();
                    filaAuxCrucero = new();

                    filaAuxCrucero.CreateCells(this.dgvCrucero);

                    filaAuxCrucero.Cells[0].Value = $"{viaje.Crucero.Nombre} - {viaje.Crucero.Matricula}";
                    filaAuxCrucero.Cells[1].Value = $"{viaje.CamarotesTurista}/{viaje.Crucero.CamarotesTurista}";
                    filaAuxCrucero.Cells[2].Value = $"{viaje.CamarotesPremium}/{viaje.Crucero.CamarotesPremium}";
                    filaAuxCrucero.Cells[3].Value = $"{viaje.Crucero.Comedores}";
                    filaAuxCrucero.Cells[4].Value = $"{viaje.Crucero.Gimnasio}";
                    filaAuxCrucero.Cells[5].Value = $"{viaje.Crucero.Piscinia}";
                    filaAuxCrucero.Cells[6].Value = $"{viaje.Crucero.Casino}";
                    filaAuxCrucero.Cells[7].Value = $"{viaje.Bodega}/{viaje.Crucero.Bodega}";

                    this.dgvCrucero.Rows.Add(filaAuxCrucero);

                    // Limpio la lista de pasajeros y muestro los pasajeros del viaje seleccionado

                    this.dgvPasajero.Rows.Clear();

                    if(viaje.ListaPasajeros.Count == 0)
                    {
                        // En caso de no haber pasajeros en la lista se muestra un mensaje aclarandolo
                        filaAuxPasajero = new();
                        filaAuxPasajero.CreateCells(this.dgvPasajero);

                        filaAuxPasajero.Cells[0].Value = "Viaje sin pasajeros";

                        this.dgvPasajero.Rows.Add(filaAuxPasajero);
                    }
                    else
                    {
                        // Recorre la lista de pasajeros que tiene el viaje seleccionado
                        // Por cada uno crea una fila y rellena cada columna con todos sus datos
                        // Por ultimo agrega la fila al DataGridView de Pasajero
                        for (int i = 0; i < viaje.ListaPasajeros.Count; i++)
                        {
                            filaAuxPasajero = new();
                            filaAuxPasajero.CreateCells(this.dgvPasajero);

                            filaAuxPasajero.Cells[0].Value = $"{viaje.ListaPasajeros[i].Apellido}, {viaje.ListaPasajeros[i].Nombre}";
                            filaAuxPasajero.Cells[1].Value = $"{viaje.ListaPasajeros[i].Dni}";
                            filaAuxPasajero.Cells[2].Value = $"{viaje.ListaPasajeros[i].Sexo}";
                            filaAuxPasajero.Cells[3].Value = $"{viaje.ListaPasajeros[i].Edad}";
                            filaAuxPasajero.Cells[4].Value = $"{viaje.ListaPasajeros[i].Equipaje.BolsoDeMano}";
                            filaAuxPasajero.Cells[5].Value = $"{viaje.ListaPasajeros[i].Equipaje.CantidadValijas} - {viaje.ListaPasajeros[i].Equipaje.PesoTotalValijas}";

                            this.dgvPasajero.Rows.Add(filaAuxPasajero);
                        }
                    }

                    break;
                }
                // Guarda el indice viaje seleccionado para poder utilizo por fuera del foreach
                indiceViajeFrmInfoDetallada++;
            }
        }
    

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            // Abre el form donde se podra crear un viaje nuevo, si todo es correcto se agrega a la tabla
            if(frmCrearViajes.ShowDialog() == DialogResult.OK)
            {
                CargarViajes();
            }
        }
       
        private void btnVenderCrucero_Click(object sender, EventArgs e)
        {
            frmVenderCrucero.ShowDialog();
        }
        private void btnInfoDetallada_Click(object sender, EventArgs e)
        {
            frmInfoDetallada.RecolectarIndicePrimerViaje(indiceViajeFrmInfoDetallada);
            frmInfoDetallada.ShowDialog();
        }
        private void btnHistorialViajes_Click(object sender, EventArgs e)
        {
            frmContenedor.ShowDialog();
        }
        private void FrmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mensaje de advertencia cuando se intenta cerrar el formulario. si marca Yes se cierra, si marca No se cancela
            if (MessageBox.Show("Seguro desea cerrar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Recorre todos los viajes que hay cargados en la lista 
        /// Crea tantas filas de la tabla de viajes como viajes haya cargados 
        /// rellena sus campos con los datos de cada viaje y agrega la tabla hecha al DataGrivView de Viajes
        /// </summary>
        private void CargarViajes()
        {
            foreach (Viaje viaje in viajes)
            {
                filaAuxViaje = tableViajes.NewRow();

                filaAuxViaje[0] = viaje.Crucero.Matricula;
                filaAuxViaje[1] = viaje.CiudadDePartida;
                filaAuxViaje[2] = $"{viaje.Destino:c}";
                filaAuxViaje[3] = $"{viaje.FechaSalida:d}";
                filaAuxViaje[4] = $"{viaje.FechaLlegada:d}";
                filaAuxViaje[5] = $"{viaje.CostoPasajeTurista:c}";
                filaAuxViaje[6] = $"{viaje.CostoPasajePremium:c}";

                tableViajes.Rows.Add(filaAuxViaje);
            }

            this.dgvViajes.DataSource = tableViajes;
        }
    }
}
