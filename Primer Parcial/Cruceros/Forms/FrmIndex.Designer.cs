
namespace Forms
{
    partial class FrmIndex
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
            this.boxViajes = new System.Windows.Forms.ListBox();
            this.boxPasajeros = new System.Windows.Forms.RichTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnVenderCrucero = new System.Windows.Forms.Button();
            this.boxCrucero = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHistorialViajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxViajes
            // 
            this.boxViajes.FormattingEnabled = true;
            this.boxViajes.ItemHeight = 20;
            this.boxViajes.Location = new System.Drawing.Point(44, 69);
            this.boxViajes.Name = "boxViajes";
            this.boxViajes.Size = new System.Drawing.Size(320, 144);
            this.boxViajes.TabIndex = 6;
            // 
            // boxPasajeros
            // 
            this.boxPasajeros.Location = new System.Drawing.Point(445, 69);
            this.boxPasajeros.Name = "boxPasajeros";
            this.boxPasajeros.Size = new System.Drawing.Size(569, 144);
            this.boxPasajeros.TabIndex = 7;
            this.boxPasajeros.Text = "";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1065, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1130, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha Actual";
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearViaje.Location = new System.Drawing.Point(1065, 69);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(121, 73);
            this.btnCrearViaje.TabIndex = 10;
            this.btnCrearViaje.Text = "Crear nuevo viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            // 
            // btnVenderCrucero
            // 
            this.btnVenderCrucero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderCrucero.Location = new System.Drawing.Point(1065, 190);
            this.btnVenderCrucero.Name = "btnVenderCrucero";
            this.btnVenderCrucero.Size = new System.Drawing.Size(121, 73);
            this.btnVenderCrucero.TabIndex = 11;
            this.btnVenderCrucero.Text = "Vender Crucero";
            this.btnVenderCrucero.UseVisualStyleBackColor = true;
            // 
            // boxCrucero
            // 
            this.boxCrucero.Location = new System.Drawing.Point(44, 276);
            this.boxCrucero.Name = "boxCrucero";
            this.boxCrucero.Size = new System.Drawing.Size(970, 374);
            this.boxCrucero.TabIndex = 12;
            this.boxCrucero.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1065, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "Informacion detallada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHistorialViajes
            // 
            this.btnHistorialViajes.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialViajes.Location = new System.Drawing.Point(1065, 437);
            this.btnHistorialViajes.Name = "btnHistorialViajes";
            this.btnHistorialViajes.Size = new System.Drawing.Size(121, 73);
            this.btnHistorialViajes.TabIndex = 14;
            this.btnHistorialViajes.Text = "Historial Viajes";
            this.btnHistorialViajes.UseVisualStyleBackColor = true;
            this.btnHistorialViajes.Click += new System.EventHandler(this.btnHistorialViajes_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 717);
            this.Controls.Add(this.btnHistorialViajes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxCrucero);
            this.Controls.Add(this.btnVenderCrucero);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.boxPasajeros);
            this.Controls.Add(this.boxViajes);
            this.Name = "FrmIndex";
            this.Text = "Cruceros - Index";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox boxViajes;
        private System.Windows.Forms.RichTextBox boxPasajeros;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnVenderCrucero;
        private System.Windows.Forms.RichTextBox boxCrucero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHistorialViajes;
    }
}