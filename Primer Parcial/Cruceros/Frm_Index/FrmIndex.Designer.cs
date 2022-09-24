
namespace Frm_Index
{
    partial class FrmIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnVenderCrucero = new System.Windows.Forms.Button();
            this.btnHistorialViajes = new System.Windows.Forms.Button();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.boxViajes = new System.Windows.Forms.ListBox();
            this.boxPasajeros = new System.Windows.Forms.RichTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.boxCrucero = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1056, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Informacion detallada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVenderCrucero
            // 
            this.btnVenderCrucero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderCrucero.Location = new System.Drawing.Point(1056, 185);
            this.btnVenderCrucero.Name = "btnVenderCrucero";
            this.btnVenderCrucero.Size = new System.Drawing.Size(121, 73);
            this.btnVenderCrucero.TabIndex = 1;
            this.btnVenderCrucero.Text = "Vender Crucero";
            this.btnVenderCrucero.UseVisualStyleBackColor = true;
            // 
            // btnHistorialViajes
            // 
            this.btnHistorialViajes.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialViajes.Location = new System.Drawing.Point(1056, 416);
            this.btnHistorialViajes.Name = "btnHistorialViajes";
            this.btnHistorialViajes.Size = new System.Drawing.Size(121, 73);
            this.btnHistorialViajes.TabIndex = 3;
            this.btnHistorialViajes.Text = "Historial Viajes";
            this.btnHistorialViajes.UseVisualStyleBackColor = true;
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearViaje.Location = new System.Drawing.Point(1056, 68);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(121, 73);
            this.btnCrearViaje.TabIndex = 4;
            this.btnCrearViaje.Text = "Crear nuevo viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // boxViajes
            // 
            this.boxViajes.FormattingEnabled = true;
            this.boxViajes.ItemHeight = 20;
            this.boxViajes.Location = new System.Drawing.Point(38, 68);
            this.boxViajes.Name = "boxViajes";
            this.boxViajes.Size = new System.Drawing.Size(320, 144);
            this.boxViajes.TabIndex = 5;
            // 
            // boxPasajeros
            // 
            this.boxPasajeros.Location = new System.Drawing.Point(439, 68);
            this.boxPasajeros.Name = "boxPasajeros";
            this.boxPasajeros.Size = new System.Drawing.Size(569, 144);
            this.boxPasajeros.TabIndex = 6;
            this.boxPasajeros.Text = "";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1056, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1121, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha Actual";
            // 
            // boxCrucero
            // 
            this.boxCrucero.Location = new System.Drawing.Point(38, 270);
            this.boxCrucero.Name = "boxCrucero";
            this.boxCrucero.Size = new System.Drawing.Size(970, 374);
            this.boxCrucero.TabIndex = 9;
            this.boxCrucero.Text = "";
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 714);
            this.Controls.Add(this.boxCrucero);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.boxPasajeros);
            this.Controls.Add(this.boxViajes);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.btnHistorialViajes);
            this.Controls.Add(this.btnVenderCrucero);
            this.Controls.Add(this.button1);
            this.Name = "FrmIndex";
            this.Text = "Cruceros - Index";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVenderCrucero;
        private System.Windows.Forms.Button btnHistorialViajes;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.ListBox boxViajes;
        private System.Windows.Forms.RichTextBox boxPasajeros;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RichTextBox boxCrucero;
    }
}

