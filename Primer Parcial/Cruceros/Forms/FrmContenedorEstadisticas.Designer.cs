
namespace Forms
{
    partial class FrmContenedorEstadisticas
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
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnCruceros = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.panelEstadistica = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.LimeGreen;
            this.panelBotones.Controls.Add(this.btnPasajeros);
            this.panelBotones.Controls.Add(this.btnCruceros);
            this.panelBotones.Controls.Add(this.btnDestino);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(632, 100);
            this.panelBotones.TabIndex = 0;
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.FlatAppearance.BorderSize = 3;
            this.btnPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasajeros.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPasajeros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPasajeros.Location = new System.Drawing.Point(420, 0);
            this.btnPasajeros.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(210, 100);
            this.btnPasajeros.TabIndex = 2;
            this.btnPasajeros.Text = "Pasajeros";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // btnCruceros
            // 
            this.btnCruceros.FlatAppearance.BorderSize = 3;
            this.btnCruceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCruceros.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCruceros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCruceros.Location = new System.Drawing.Point(210, 0);
            this.btnCruceros.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCruceros.Name = "btnCruceros";
            this.btnCruceros.Size = new System.Drawing.Size(210, 100);
            this.btnCruceros.TabIndex = 1;
            this.btnCruceros.Text = "Cruceros";
            this.btnCruceros.UseVisualStyleBackColor = true;
            this.btnCruceros.Click += new System.EventHandler(this.btnCruceros_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDestino.FlatAppearance.BorderSize = 3;
            this.btnDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestino.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDestino.Location = new System.Drawing.Point(0, 0);
            this.btnDestino.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(210, 100);
            this.btnDestino.TabIndex = 0;
            this.btnDestino.Text = "Destinos";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // panelEstadistica
            // 
            this.panelEstadistica.BackColor = System.Drawing.Color.LightGreen;
            this.panelEstadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstadistica.Location = new System.Drawing.Point(0, 100);
            this.panelEstadistica.Name = "panelEstadistica";
            this.panelEstadistica.Size = new System.Drawing.Size(632, 353);
            this.panelEstadistica.TabIndex = 1;
            // 
            // FrmContenedorEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.panelEstadistica);
            this.Controls.Add(this.panelBotones);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FrmContenedorEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruceros AguasVivas - Estadisticas";
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnCruceros;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Panel panelEstadistica;
    }
}