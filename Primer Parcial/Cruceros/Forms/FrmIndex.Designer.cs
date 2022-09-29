
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnVenderCrucero = new System.Windows.Forms.Button();
            this.btnInfoDetallada = new System.Windows.Forms.Button();
            this.btnHistorialViajes = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.dgvCrucero = new System.Windows.Forms.DataGridView();
            this.dgvPasajero = new System.Windows.Forms.DataGridView();
            this.Equipaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piscina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gimnasio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1062, 9);
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
            this.lblFecha.Location = new System.Drawing.Point(1127, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha Actual";
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearViaje.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearViaje.Location = new System.Drawing.Point(1062, 61);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(121, 73);
            this.btnCrearViaje.TabIndex = 10;
            this.btnCrearViaje.Text = "Crear nuevo viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            // 
            // btnVenderCrucero
            // 
            this.btnVenderCrucero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVenderCrucero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderCrucero.Location = new System.Drawing.Point(1062, 176);
            this.btnVenderCrucero.Name = "btnVenderCrucero";
            this.btnVenderCrucero.Size = new System.Drawing.Size(121, 73);
            this.btnVenderCrucero.TabIndex = 11;
            this.btnVenderCrucero.Text = "Vender Crucero";
            this.btnVenderCrucero.UseVisualStyleBackColor = true;
            // 
            // btnInfoDetallada
            // 
            this.btnInfoDetallada.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInfoDetallada.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfoDetallada.Location = new System.Drawing.Point(1062, 295);
            this.btnInfoDetallada.Name = "btnInfoDetallada";
            this.btnInfoDetallada.Size = new System.Drawing.Size(121, 73);
            this.btnInfoDetallada.TabIndex = 13;
            this.btnInfoDetallada.Text = "Informacion detallada";
            this.btnInfoDetallada.UseVisualStyleBackColor = true;
            // 
            // btnHistorialViajes
            // 
            this.btnHistorialViajes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHistorialViajes.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialViajes.Location = new System.Drawing.Point(1062, 423);
            this.btnHistorialViajes.Name = "btnHistorialViajes";
            this.btnHistorialViajes.Size = new System.Drawing.Size(121, 73);
            this.btnHistorialViajes.TabIndex = 14;
            this.btnHistorialViajes.Text = "Historial Viajes";
            this.btnHistorialViajes.UseVisualStyleBackColor = true;
            this.btnHistorialViajes.Click += new System.EventHandler(this.btnHistorialViajes_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.AllowUserToOrderColumns = true;
            this.dgvViajes.AllowUserToResizeColumns = false;
            this.dgvViajes.AllowUserToResizeRows = false;
            this.dgvViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajes.BackgroundColor = System.Drawing.Color.White;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.GridColor = System.Drawing.Color.Black;
            this.dgvViajes.Location = new System.Drawing.Point(47, 45);
            this.dgvViajes.MultiSelect = false;
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.RowHeadersVisible = false;
            this.dgvViajes.RowHeadersWidth = 51;
            this.dgvViajes.RowTemplate.Height = 29;
            this.dgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViajes.Size = new System.Drawing.Size(950, 204);
            this.dgvViajes.TabIndex = 15;
            this.dgvViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellContentClick);
            // 
            // dgvCrucero
            // 
            this.dgvCrucero.AllowUserToAddRows = false;
            this.dgvCrucero.AllowUserToDeleteRows = false;
            this.dgvCrucero.AllowUserToResizeColumns = false;
            this.dgvCrucero.AllowUserToResizeRows = false;
            this.dgvCrucero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCrucero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrucero.BackgroundColor = System.Drawing.Color.White;
            this.dgvCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrucero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Camarotes,
            this.Comedor,
            this.Gimnasio,
            this.Piscina,
            this.Casino,
            this.Bodega,
            this.Equipaje});
            this.dgvCrucero.GridColor = System.Drawing.Color.Black;
            this.dgvCrucero.Location = new System.Drawing.Point(47, 295);
            this.dgvCrucero.MultiSelect = false;
            this.dgvCrucero.Name = "dgvCrucero";
            this.dgvCrucero.ReadOnly = true;
            this.dgvCrucero.RowHeadersVisible = false;
            this.dgvCrucero.RowHeadersWidth = 51;
            this.dgvCrucero.RowTemplate.Height = 29;
            this.dgvCrucero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCrucero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrucero.Size = new System.Drawing.Size(950, 59);
            this.dgvCrucero.TabIndex = 16;
            // 
            // dgvPasajero
            // 
            this.dgvPasajero.AllowUserToAddRows = false;
            this.dgvPasajero.AllowUserToDeleteRows = false;
            this.dgvPasajero.AllowUserToOrderColumns = true;
            this.dgvPasajero.AllowUserToResizeColumns = false;
            this.dgvPasajero.AllowUserToResizeRows = false;
            this.dgvPasajero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasajero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasajero.BackgroundColor = System.Drawing.Color.White;
            this.dgvPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajero.GridColor = System.Drawing.Color.Black;
            this.dgvPasajero.Location = new System.Drawing.Point(47, 378);
            this.dgvPasajero.MultiSelect = false;
            this.dgvPasajero.Name = "dgvPasajero";
            this.dgvPasajero.ReadOnly = true;
            this.dgvPasajero.RowHeadersVisible = false;
            this.dgvPasajero.RowHeadersWidth = 51;
            this.dgvPasajero.RowTemplate.Height = 29;
            this.dgvPasajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasajero.Size = new System.Drawing.Size(950, 289);
            this.dgvPasajero.TabIndex = 17;
            // 
            // Equipaje
            // 
            this.Equipaje.HeaderText = "Equipaje";
            this.Equipaje.MinimumWidth = 95;
            this.Equipaje.Name = "Equipaje";
            this.Equipaje.ReadOnly = true;
            // 
            // Bodega
            // 
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.MinimumWidth = 95;
            this.Bodega.Name = "Bodega";
            this.Bodega.ReadOnly = true;
            // 
            // Casino
            // 
            this.Casino.HeaderText = "Casino";
            this.Casino.MinimumWidth = 95;
            this.Casino.Name = "Casino";
            this.Casino.ReadOnly = true;
            // 
            // Piscina
            // 
            this.Piscina.HeaderText = "Piscina";
            this.Piscina.MinimumWidth = 95;
            this.Piscina.Name = "Piscina";
            this.Piscina.ReadOnly = true;
            // 
            // Gimnasio
            // 
            this.Gimnasio.HeaderText = "Gimansio";
            this.Gimnasio.MinimumWidth = 95;
            this.Gimnasio.Name = "Gimnasio";
            this.Gimnasio.ReadOnly = true;
            // 
            // Comedor
            // 
            this.Comedor.HeaderText = "Comedor";
            this.Comedor.MinimumWidth = 95;
            this.Comedor.Name = "Comedor";
            this.Comedor.ReadOnly = true;
            // 
            // Camarotes
            // 
            this.Camarotes.HeaderText = "Cantidad Camarotes";
            this.Camarotes.MinimumWidth = 175;
            this.Camarotes.Name = "Camarotes";
            this.Camarotes.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre - Matricula";
            this.Nombre.MinimumWidth = 175;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.dgvPasajero);
            this.Controls.Add(this.dgvCrucero);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.btnHistorialViajes);
            this.Controls.Add(this.btnInfoDetallada);
            this.Controls.Add(this.btnVenderCrucero);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "FrmIndex";
            this.Text = "Cruceros - Index";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnVenderCrucero;
        private System.Windows.Forms.Button btnInfoDetallada;
        private System.Windows.Forms.Button btnHistorialViajes;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.DataGridView dgvCrucero;
        private System.Windows.Forms.DataGridView dgvPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gimnasio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piscina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipaje;
    }
}