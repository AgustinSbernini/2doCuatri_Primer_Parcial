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
    public partial class FrmLogin : Form
    {
        // Declaracion de variables globales
        string[] usuarios;
        string[] contraseñas;
        int loginCorrecto;
        FrmIndex frm_index;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Seteo de mensajes de ayuda al pasar el mouse por arriba de las cajas de texto o boton
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese el usuario designado en Readme");
            this.ttMensaje.SetToolTip(this.txtContraseña, "Ingrese la contraseña designada en Readme para su usuario");
            this.ttMensaje.SetToolTip(this.btnLogin, "Presione una vez completado los campos anteriores");

            // Creacion de usuarios y contraseñas
            usuarios = new string[] { "Maximiliano", "Facundo", "Felipe", "Agustin" };
            contraseñas = new string[] { "maxi123", "facu123", "feli123", "agus123" };

            // Verificador de login
            loginCorrecto = 1;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Comprobar si usuario y contraseñas son correctos
            loginCorrecto = comprobarLogin();

            // Si logea correctamente se abre el FrmIndex y se cierra el FrmLogin
            if (loginCorrecto == 0)
            {
                this.error.Clear();
                //Inicializo el frmIndex y escondo el frmLogin
                frm_index = new(this.txtUsuario.Text);
                this.Hide();
                if(frm_index.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                // Si el login es incorrecto aparecen los mensajes de errores
                if (loginCorrecto == -1)
                {
                    this.error.Clear();
                    this.error.SetError(this.txtUsuario, "Por favor ingrese un usuario valido");
                }
                else
                {
                    this.error.Clear();
                    this.error.SetError(this.txtContraseña, "Por favor ingrese una contraseña valida");
                }
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si logea correctamente el form se cierra sin problemas
            if (loginCorrecto != 0)
            {
                // Si no logeo se le advierte antes de cerrar el programa si desea hacerlo
                if (MessageBox.Show("Seguro desea cerrar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Verifica si el usuario ingresado es correcto, de ser así verifica si coincide 
        /// la contraseña ingresada con el usuario al que le pertenece.
        /// </summary>
        /// <returns> Retorna 0 si ambos campos estan correctos, -1 si el usuario es incorrecto,
        ///           -2 si la contraseña es incorrecta </returns>
        private int comprobarLogin()
        {
            int retorno = -1;

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == this.txtUsuario.Text)
                {
                    if (contraseñas[i] == this.txtContraseña.Text)
                    {
                        retorno = 0;
                        break;
                    }
                    retorno = -2;
                    break;
                }
            }

            return retorno;
        }

        
    }
}
