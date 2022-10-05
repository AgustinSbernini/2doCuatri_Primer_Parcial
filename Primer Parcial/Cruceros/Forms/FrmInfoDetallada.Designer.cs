
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
            this.txtViajes.BackColor = System.Drawing.Color.PaleGreen;
            this.txtViajes.Location = new System.Drawing.Point(31, 67);
            this.txtViajes.Multiline = true;
            this.txtViajes.Name = "txtViajes";
            this.txtViajes.ReadOnly = true;
            this.txtViajes.Size = new System.Drawing.Size(484, 265);
            this.txtViajes.TabIndex = 0;
            // 
            // txtCrucero
            // 
            this.txtCrucero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrucero.BackColor = System.Drawing.Color.PaleGreen;
            this.txtCrucero.Location = new System.Drawing.Point(544, 67);
            this.txtCrucero.Multiline = true;
            this.txtCrucero.Name = "txtCrucero";
            this.txtCrucero.ReadOnly = true;
            this.txtCrucero.Size = new System.Drawing.Size(484, 265);
            this.txtCrucero.TabIndex = 1;
            // 
            // txtPasajeros1
            // 
            this.txtPasajeros1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPasajeros1.BackColor = System.Drawing.Color.PaleGreen;
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
            this.cbViajes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbViajes.FormattingEnabled = true;
            this.cbViajes.Location = new System.Drawing.Point(31, 22);
            this.cbViajes.Name = "cbViajes";
            this.cbViajes.Size = new System.Drawing.Size(808, 28);
            this.cbViajes.TabIndex = 3;
            this.cbViajes.SelectedIndexChanged += new System.EventHandler(this.cbViajes_SelectedIndexChanged);
            // 
            // txtPasajeros2
            // 
            this.txtPasajeros2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPasajeros2.BackColor = System.Drawing.Color.PaleGreen;
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
            this.btnApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApellido.BackColor = System.Drawing.Color.Black;
            this.btnApellido.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApellido.ForeColor = System.Drawing.Color.White;
            this.btnApellido.Location = new System.Drawing.Point(972, 390);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(75, 47);
            this.btnApellido.TabIndex = 5;
            this.btnApellido.Text = "Apellido";
            this.btnApellido.UseVisualStyleBackColor = false;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.BackColor = System.Drawing.Color.Black;
            this.txtApellido.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(830, 400);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 28);
            this.txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNacionalidad.BackColor = System.Drawing.Color.Black;
            this.btnNacionalidad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNacionalidad.ForeColor = System.Drawing.Color.White;
            this.btnNacionalidad.Location = new System.Drawing.Point(972, 496);
            this.btnNacionalidad.Name = "btnNacionalidad";
            this.btnNacionalidad.Size = new System.Drawing.Size(75, 57);
            this.btnNacionalidad.TabIndex = 8;
            this.btnNacionalidad.Text = "Nacionalidad";
            this.btnNacionalidad.UseVisualStyleBackColor = false;
            this.btnNacionalidad.Click += new System.EventHandler(this.btnNacionalidad_Click);
            // 
            // btnDNI
            // 
            this.btnDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDNI.BackColor = System.Drawing.Color.Black;
            this.btnDNI.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDNI.ForeColor = System.Drawing.Color.White;
            this.btnDNI.Location = new System.Drawing.Point(972, 443);
            this.btnDNI.Name = "btnDNI";
            this.btnDNI.Size = new System.Drawing.Size(75, 47);
            this.btnDNI.TabIndex = 9;
            this.btnDNI.Text = "DNI";
            this.btnDNI.UseVisualStyleBackColor = false;
            this.btnDNI.Click += new System.EventHandler(this.btnDNI_Click);
            // 
            // btnSexo
            // 
            this.btnSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSexo.BackColor = System.Drawing.Color.Black;
            this.btnSexo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSexo.ForeColor = System.Drawing.Color.White;
            this.btnSexo.Location = new System.Drawing.Point(862, 570);
            this.btnSexo.Name = "btnSexo";
            this.btnSexo.Size = new System.Drawing.Size(166, 47);
            this.btnSexo.TabIndex = 10;
            this.btnSexo.Text = "Sacar Filtro";
            this.btnSexo.UseVisualStyleBackColor = false;
            this.btnSexo.Click += new System.EventHandler(this.TodosLosPasajeros);
            // 
            // txtDNI
            // 
            this.txtDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDNI.BackColor = System.Drawing.Color.Black;
            this.txtDNI.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.ForeColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(830, 453);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(125, 28);
            this.txtDNI.TabIndex = 11;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNacionalidad.BackColor = System.Drawing.Color.Black;
            this.txtNacionalidad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNacionalidad.ForeColor = System.Drawing.Color.White;
            this.txtNacionalidad.Location = new System.Drawing.Point(830, 511);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(125, 28);
            this.txtNacionalidad.TabIndex = 12;
            // 
            // FrmInfoDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
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
            this.MinimumSize = new System.Drawing.Size(1095, 686);
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