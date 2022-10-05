
namespace Forms
{
    partial class FrmCrearViajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCruceros = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFechaLlegada = new System.Windows.Forms.ComboBox();
            this.cbFechaInicio = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbExtraRegionales = new System.Windows.Forms.RadioButton();
            this.rbRegionales = new System.Windows.Forms.RadioButton();
            this.cbDestinos = new System.Windows.Forms.ComboBox();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCruceros);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cruceros";
            // 
            // cbCruceros
            // 
            this.cbCruceros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCruceros.FormattingEnabled = true;
            this.cbCruceros.Location = new System.Drawing.Point(6, 26);
            this.cbCruceros.Name = "cbCruceros";
            this.cbCruceros.Size = new System.Drawing.Size(151, 28);
            this.cbCruceros.TabIndex = 0;
            this.cbCruceros.SelectedIndexChanged += new System.EventHandler(this.cbCruceros_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFechaLlegada);
            this.groupBox2.Controls.Add(this.cbFechaInicio);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas Ocupadas";
            // 
            // cbFechaLlegada
            // 
            this.cbFechaLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaLlegada.Enabled = false;
            this.cbFechaLlegada.FormattingEnabled = true;
            this.cbFechaLlegada.Location = new System.Drawing.Point(136, 26);
            this.cbFechaLlegada.Name = "cbFechaLlegada";
            this.cbFechaLlegada.Size = new System.Drawing.Size(118, 28);
            this.cbFechaLlegada.TabIndex = 1;
            // 
            // cbFechaInicio
            // 
            this.cbFechaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaInicio.FormattingEnabled = true;
            this.cbFechaInicio.Location = new System.Drawing.Point(6, 26);
            this.cbFechaInicio.Name = "cbFechaInicio";
            this.cbFechaInicio.Size = new System.Drawing.Size(124, 28);
            this.cbFechaInicio.TabIndex = 0;
            this.cbFechaInicio.SelectedIndexChanged += new System.EventHandler(this.cbFechaInicio_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaSalida);
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 71);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha Salida";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(7, 27);
            this.dtpFechaSalida.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpFechaSalida.MinDate = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(127, 27);
            this.dtpFechaSalida.TabIndex = 0;
            this.dtpFechaSalida.CloseUp += new System.EventHandler(this.dtpFechaSalida_CloseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbExtraRegionales);
            this.groupBox4.Controls.Add(this.rbRegionales);
            this.groupBox4.Controls.Add(this.cbDestinos);
            this.groupBox4.Location = new System.Drawing.Point(287, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 160);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cruceros";
            // 
            // rbExtraRegionales
            // 
            this.rbExtraRegionales.AutoSize = true;
            this.rbExtraRegionales.Location = new System.Drawing.Point(20, 57);
            this.rbExtraRegionales.Name = "rbExtraRegionales";
            this.rbExtraRegionales.Size = new System.Drawing.Size(140, 24);
            this.rbExtraRegionales.TabIndex = 2;
            this.rbExtraRegionales.TabStop = true;
            this.rbExtraRegionales.Text = "Extra Regionales";
            this.rbExtraRegionales.UseVisualStyleBackColor = true;
            this.rbExtraRegionales.CheckedChanged += new System.EventHandler(this.rbExtraRegionales_CheckedChanged);
            // 
            // rbRegionales
            // 
            this.rbRegionales.AutoSize = true;
            this.rbRegionales.Location = new System.Drawing.Point(20, 27);
            this.rbRegionales.Name = "rbRegionales";
            this.rbRegionales.Size = new System.Drawing.Size(103, 24);
            this.rbRegionales.TabIndex = 1;
            this.rbRegionales.TabStop = true;
            this.rbRegionales.Text = "Regionales";
            this.rbRegionales.UseVisualStyleBackColor = true;
            this.rbRegionales.CheckedChanged += new System.EventHandler(this.rbRegionales_CheckedChanged);
            // 
            // cbDestinos
            // 
            this.cbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinos.FormattingEnabled = true;
            this.cbDestinos.Location = new System.Drawing.Point(6, 109);
            this.cbDestinos.Name = "cbDestinos";
            this.cbDestinos.Size = new System.Drawing.Size(225, 28);
            this.cbDestinos.TabIndex = 0;
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Location = new System.Drawing.Point(542, 50);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(94, 70);
            this.btnCrearViaje.TabIndex = 2;
            this.btnCrearViaje.Text = "Crear Viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(542, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 70);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCrearViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 283);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(680, 330);
            this.Name = "FrmCrearViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearViajes";
            this.Load += new System.EventHandler(this.FrmBaseCrearViajeVenderCrucero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCruceros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFechaLlegada;
        private System.Windows.Forms.ComboBox cbFechaInicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbExtraRegionales;
        private System.Windows.Forms.RadioButton rbRegionales;
        private System.Windows.Forms.ComboBox cbDestinos;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnCancelar;
    }
}