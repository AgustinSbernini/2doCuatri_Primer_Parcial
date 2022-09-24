using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmIndex : Form
    {
        string usuarioIngresado;
        public FrmIndex()
        {
            InitializeComponent();
        }
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            this.lblFecha.Text = $"{DateTime.Today:d}";
            this.lblUsuario.Text = $"{usuarioIngresado}";
        }
        private void btnHistorialViajes_Click(object sender, EventArgs e)
        {

        }

        public void cargarUsuario(string usuario)
        {
            this.usuarioIngresado = usuario;
        }
    }
}
