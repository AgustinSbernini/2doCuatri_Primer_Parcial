
namespace Forms
{
    partial class FrmCrearViaje
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
            this.rbRegionales = new System.Windows.Forms.RadioButton();
            this.rbExtraRegionales = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDestinos = new System.Windows.Forms.ComboBox();
            this.cbCrucero = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cbFechaInicio = new System.Windows.Forms.ComboBox();
            this.btnCrearCrucero = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFechaFinal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRegionales
            // 
            this.rbRegionales.AutoSize = true;
            this.rbRegionales.Location = new System.Drawing.Point(17, 28);
            this.rbRegionales.Name = "rbRegionales";
            this.rbRegionales.Size = new System.Drawing.Size(103, 24);
            this.rbRegionales.TabIndex = 0;
            this.rbRegionales.TabStop = true;
            this.rbRegionales.Text = "Regionales";
            this.rbRegionales.UseVisualStyleBackColor = true;
            this.rbRegionales.CheckedChanged += new System.EventHandler(this.rbRegionales_CheckedChanged);
            // 
            // rbExtraRegionales
            // 
            this.rbExtraRegionales.AutoSize = true;
            this.rbExtraRegionales.Location = new System.Drawing.Point(17, 58);
            this.rbExtraRegionales.Name = "rbExtraRegionales";
            this.rbExtraRegionales.Size = new System.Drawing.Size(132, 24);
            this.rbExtraRegionales.TabIndex = 1;
            this.rbExtraRegionales.TabStop = true;
            this.rbExtraRegionales.Text = "Extraregionales";
            this.rbExtraRegionales.UseVisualStyleBackColor = true;
            this.rbExtraRegionales.CheckedChanged += new System.EventHandler(this.rbExtraRegionales_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDestinos);
            this.groupBox1.Controls.Add(this.rbRegionales);
            this.groupBox1.Controls.Add(this.rbExtraRegionales);
            this.groupBox1.Location = new System.Drawing.Point(276, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // cbDestinos
            // 
            this.cbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinos.FormattingEnabled = true;
            this.cbDestinos.Location = new System.Drawing.Point(17, 98);
            this.cbDestinos.Name = "cbDestinos";
            this.cbDestinos.Size = new System.Drawing.Size(194, 28);
            this.cbDestinos.TabIndex = 7;
            // 
            // cbCrucero
            // 
            this.cbCrucero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrucero.FormattingEnabled = true;
            this.cbCrucero.Location = new System.Drawing.Point(17, 26);
            this.cbCrucero.Name = "cbCrucero";
            this.cbCrucero.Size = new System.Drawing.Size(164, 28);
            this.cbCrucero.TabIndex = 3;
            this.cbCrucero.SelectedIndexChanged += new System.EventHandler(this.cbCrucero_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaSalida);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Salida";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(17, 38);
            this.dtpFechaSalida.MinDate = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(123, 27);
            this.dtpFechaSalida.TabIndex = 0;
            this.dtpFechaSalida.CloseUp += new System.EventHandler(this.dtpFechaSalida_CloseUp);
            // 
            // cbFechaInicio
            // 
            this.cbFechaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaInicio.FormattingEnabled = true;
            this.cbFechaInicio.Location = new System.Drawing.Point(6, 24);
            this.cbFechaInicio.Name = "cbFechaInicio";
            this.cbFechaInicio.Size = new System.Drawing.Size(112, 28);
            this.cbFechaInicio.TabIndex = 4;
            this.cbFechaInicio.SelectedIndexChanged += new System.EventHandler(this.cbFechaInicio_SelectedIndexChanged);
            // 
            // btnCrearCrucero
            // 
            this.btnCrearCrucero.Location = new System.Drawing.Point(533, 41);
            this.btnCrearCrucero.Name = "btnCrearCrucero";
            this.btnCrearCrucero.Size = new System.Drawing.Size(98, 55);
            this.btnCrearCrucero.TabIndex = 5;
            this.btnCrearCrucero.Text = "Crear Viaje";
            this.btnCrearCrucero.UseVisualStyleBackColor = true;
            this.btnCrearCrucero.Click += new System.EventHandler(this.btnCrearCrucero_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbCrucero);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 64);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crucero";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbFechaFinal);
            this.groupBox4.Controls.Add(this.cbFechaInicio);
            this.groupBox4.Location = new System.Drawing.Point(12, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 69);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fechas Ocupadas";
            // 
            // cbFechaFinal
            // 
            this.cbFechaFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaFinal.Enabled = false;
            this.cbFechaFinal.FormattingEnabled = true;
            this.cbFechaFinal.Location = new System.Drawing.Point(124, 24);
            this.cbFechaFinal.Name = "cbFechaFinal";
            this.cbFechaFinal.Size = new System.Drawing.Size(112, 28);
            this.cbFechaFinal.TabIndex = 5;
            // 
            // FrmCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 299);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCrearCrucero);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearViaje";
            this.Load += new System.EventHandler(this.FrmCrearViaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRegionales;
        private System.Windows.Forms.RadioButton rbExtraRegionales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCrucero;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDestinos;
        private System.Windows.Forms.Button btnCrearCrucero;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbFechaInicio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbFechaFinal;
    }
}