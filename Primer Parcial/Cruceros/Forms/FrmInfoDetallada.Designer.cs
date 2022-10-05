
namespace Forms
{
    partial class FrmInfoDetallada
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
            this.txtViajes = new System.Windows.Forms.TextBox();
            this.txtCrucero = new System.Windows.Forms.TextBox();
            this.txtPasajeros1 = new System.Windows.Forms.TextBox();
            this.cbViajes = new System.Windows.Forms.ComboBox();
            this.txtPasajeros2 = new System.Windows.Forms.TextBox();
            this.btnApellido = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNacionalidad = new System.Windows.Forms.Button();
            this.btnDNI = new System.Windows.Forms.Button();
            this.btnSexo = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtViajes
            // 
            this.txtViajes.Location = new System.Drawing.Point(31, 67);
            this.txtViajes.Multiline = true;
            this.txtViajes.Name = "txtViajes";
            this.txtViajes.ReadOnly = true;
            this.txtViajes.Size = new System.Drawing.Size(484, 265);
            this.txtViajes.TabIndex = 0;
            // 
            // txtCrucero
            // 
            this.txtCrucero.Location = new System.Drawing.Point(544, 67);
            this.txtCrucero.Multiline = true;
            this.txtCrucero.Name = "txtCrucero";
            this.txtCrucero.ReadOnly = true;
            this.txtCrucero.Size = new System.Drawing.Size(484, 265);
            this.txtCrucero.TabIndex = 1;
            // 
            // txtPasajeros1
            // 
            this.txtPasajeros1.Location = new System.Drawing.Point(31, 338);
            this.txtPasajeros1.Multiline = true;
            this.txtPasajeros1.Name = "txtPasajeros1";
            this.txtPasajeros1.ReadOnly = true;
            this.txtPasajeros1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasajeros1.Size = new System.Drawing.Size(378, 289);
            this.txtPasajeros1.TabIndex = 2;
            // 
            // cbViajes
            // 
            this.cbViajes.FormattingEnabled = true;
            this.cbViajes.Location = new System.Drawing.Point(31, 22);
            this.cbViajes.Name = "cbViajes";
            this.cbViajes.Size = new System.Drawing.Size(808, 28);
            this.cbViajes.TabIndex = 3;
            this.cbViajes.SelectedIndexChanged += new System.EventHandler(this.cbViajes_SelectedIndexChanged);
            // 
            // txtPasajeros2
            // 
            this.txtPasajeros2.Location = new System.Drawing.Point(426, 338);
            this.txtPasajeros2.Multiline = true;
            this.txtPasajeros2.Name = "txtPasajeros2";
            this.txtPasajeros2.ReadOnly = true;
            this.txtPasajeros2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasajeros2.Size = new System.Drawing.Size(378, 289);
            this.txtPasajeros2.TabIndex = 4;
            // 
            // btnApellido
            // 
            this.btnApellido.Location = new System.Drawing.Point(972, 390);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(75, 47);
            this.btnApellido.TabIndex = 5;
            this.btnApellido.Text = "Apellido";
            this.btnApellido.UseVisualStyleBackColor = true;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(830, 400);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(902, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtros";
            // 
            // btnNacionalidad
            // 
            this.btnNacionalidad.Location = new System.Drawing.Point(972, 496);
            this.btnNacionalidad.Name = "btnNacionalidad";
            this.btnNacionalidad.Size = new System.Drawing.Size(75, 57);
            this.btnNacionalidad.TabIndex = 8;
            this.btnNacionalidad.Text = "Nacionalidad";
            this.btnNacionalidad.UseVisualStyleBackColor = true;
            this.btnNacionalidad.Click += new System.EventHandler(this.btnNacionalidad_Click);
            // 
            // btnDNI
            // 
            this.btnDNI.Location = new System.Drawing.Point(972, 443);
            this.btnDNI.Name = "btnDNI";
            this.btnDNI.Size = new System.Drawing.Size(75, 47);
            this.btnDNI.TabIndex = 9;
            this.btnDNI.Text = "DNI";
            this.btnDNI.UseVisualStyleBackColor = true;
            this.btnDNI.Click += new System.EventHandler(this.btnDNI_Click);
            // 
            // btnSexo
            // 
            this.btnSexo.Location = new System.Drawing.Point(862, 570);
            this.btnSexo.Name = "btnSexo";
            this.btnSexo.Size = new System.Drawing.Size(166, 47);
            this.btnSexo.TabIndex = 10;
            this.btnSexo.Text = "Sacar Filtro";
            this.btnSexo.UseVisualStyleBackColor = true;
            this.btnSexo.Click += new System.EventHandler(this.TodosLosPasajeros);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(830, 453);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(125, 27);
            this.txtDNI.TabIndex = 11;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(830, 511);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(125, 27);
            this.txtNacionalidad.TabIndex = 12;
            // 
            // FrmInfoDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 639);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnSexo);
            this.Controls.Add(this.btnDNI);
            this.Controls.Add(this.btnNacionalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.txtPasajeros2);
            this.Controls.Add(this.cbViajes);
            this.Controls.Add(this.txtPasajeros1);
            this.Controls.Add(this.txtCrucero);
            this.Controls.Add(this.txtViajes);
            this.Name = "FrmInfoDetallada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruceros AguasVivas - Informacion Detallada";
            this.Load += new System.EventHandler(this.FrmInfoDetallada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtViajes;
        private System.Windows.Forms.TextBox txtCrucero;
        private System.Windows.Forms.TextBox txtPasajeros1;
        private System.Windows.Forms.ComboBox cbViajes;
        private System.Windows.Forms.TextBox txtPasajeros2;
        private System.Windows.Forms.Button btnApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNacionalidad;
        private System.Windows.Forms.Button btnDNI;
        private System.Windows.Forms.Button btnSexo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNacionalidad;
    }
}