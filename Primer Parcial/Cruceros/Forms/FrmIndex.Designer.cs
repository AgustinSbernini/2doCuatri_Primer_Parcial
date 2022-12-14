
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnVenderCrucero = new System.Windows.Forms.Button();
            this.btnInfoDetallada = new System.Windows.Forms.Button();
            this.btnHistorialViajes = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.dgvCrucero = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gimnasio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piscina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPasajero = new System.Windows.Forms.DataGridView();
            this.NombrePasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolsoMano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ValijaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Black;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
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
            this.lblFecha.BackColor = System.Drawing.Color.Black;
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1127, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha Actual";
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearViaje.BackColor = System.Drawing.Color.Black;
            this.btnCrearViaje.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearViaje.ForeColor = System.Drawing.Color.White;
            this.btnCrearViaje.Location = new System.Drawing.Point(1062, 61);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(121, 73);
            this.btnCrearViaje.TabIndex = 10;
            this.btnCrearViaje.Text = "Crear nuevo viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = false;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // btnVenderCrucero
            // 
            this.btnVenderCrucero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVenderCrucero.BackColor = System.Drawing.Color.Black;
            this.btnVenderCrucero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderCrucero.ForeColor = System.Drawing.Color.White;
            this.btnVenderCrucero.Location = new System.Drawing.Point(1062, 176);
            this.btnVenderCrucero.Name = "btnVenderCrucero";
            this.btnVenderCrucero.Size = new System.Drawing.Size(121, 73);
            this.btnVenderCrucero.TabIndex = 11;
            this.btnVenderCrucero.Text = "Vender Crucero";
            this.btnVenderCrucero.UseVisualStyleBackColor = false;
            this.btnVenderCrucero.Click += new System.EventHandler(this.btnVenderCrucero_Click);
            // 
            // btnInfoDetallada
            // 
            this.btnInfoDetallada.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInfoDetallada.BackColor = System.Drawing.Color.Black;
            this.btnInfoDetallada.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfoDetallada.ForeColor = System.Drawing.Color.White;
            this.btnInfoDetallada.Location = new System.Drawing.Point(1062, 295);
            this.btnInfoDetallada.Name = "btnInfoDetallada";
            this.btnInfoDetallada.Size = new System.Drawing.Size(121, 73);
            this.btnInfoDetallada.TabIndex = 13;
            this.btnInfoDetallada.Text = "Informacion detallada";
            this.btnInfoDetallada.UseVisualStyleBackColor = false;
            this.btnInfoDetallada.Click += new System.EventHandler(this.btnInfoDetallada_Click);
            // 
            // btnHistorialViajes
            // 
            this.btnHistorialViajes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHistorialViajes.BackColor = System.Drawing.Color.Black;
            this.btnHistorialViajes.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialViajes.ForeColor = System.Drawing.Color.White;
            this.btnHistorialViajes.Location = new System.Drawing.Point(1062, 423);
            this.btnHistorialViajes.Name = "btnHistorialViajes";
            this.btnHistorialViajes.Size = new System.Drawing.Size(121, 73);
            this.btnHistorialViajes.TabIndex = 14;
            this.btnHistorialViajes.Text = "Historial Viajes";
            this.btnHistorialViajes.UseVisualStyleBackColor = false;
            this.btnHistorialViajes.Click += new System.EventHandler(this.btnHistorialViajes_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.AllowUserToOrderColumns = true;
            this.dgvViajes.AllowUserToResizeColumns = false;
            this.dgvViajes.AllowUserToResizeRows = false;
            this.dgvViajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.GridColor = System.Drawing.Color.Black;
            this.dgvViajes.Location = new System.Drawing.Point(47, 45);
            this.dgvViajes.MultiSelect = false;
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.RowHeadersVisible = false;
            this.dgvViajes.RowHeadersWidth = 51;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvViajes.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvViajes.RowTemplate.Height = 29;
            this.dgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViajes.Size = new System.Drawing.Size(968, 204);
            this.dgvViajes.TabIndex = 15;
            this.dgvViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellClick);
            // 
            // dgvCrucero
            // 
            this.dgvCrucero.AllowUserToAddRows = false;
            this.dgvCrucero.AllowUserToDeleteRows = false;
            this.dgvCrucero.AllowUserToResizeColumns = false;
            this.dgvCrucero.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCrucero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCrucero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCrucero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrucero.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrucero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrucero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Camarotes,
            this.Equipaje,
            this.Comedor,
            this.Gimnasio,
            this.Piscina,
            this.Casino,
            this.Bodega});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCrucero.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCrucero.GridColor = System.Drawing.Color.Black;
            this.dgvCrucero.Location = new System.Drawing.Point(47, 295);
            this.dgvCrucero.MultiSelect = false;
            this.dgvCrucero.Name = "dgvCrucero";
            this.dgvCrucero.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrucero.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCrucero.RowHeadersVisible = false;
            this.dgvCrucero.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvCrucero.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCrucero.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCrucero.RowTemplate.Height = 29;
            this.dgvCrucero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCrucero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrucero.Size = new System.Drawing.Size(968, 59);
            this.dgvCrucero.TabIndex = 16;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre - Matricula";
            this.Nombre.MinimumWidth = 170;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Camarotes
            // 
            this.Camarotes.HeaderText = "Camarotes Turista";
            this.Camarotes.MinimumWidth = 160;
            this.Camarotes.Name = "Camarotes";
            this.Camarotes.ReadOnly = true;
            // 
            // Equipaje
            // 
            this.Equipaje.HeaderText = "Camarotes Premium";
            this.Equipaje.MinimumWidth = 170;
            this.Equipaje.Name = "Equipaje";
            this.Equipaje.ReadOnly = true;
            // 
            // Comedor
            // 
            this.Comedor.HeaderText = "Comedor";
            this.Comedor.MinimumWidth = 95;
            this.Comedor.Name = "Comedor";
            this.Comedor.ReadOnly = true;
            // 
            // Gimnasio
            // 
            this.Gimnasio.HeaderText = "Gimansio";
            this.Gimnasio.MinimumWidth = 95;
            this.Gimnasio.Name = "Gimnasio";
            this.Gimnasio.ReadOnly = true;
            // 
            // Piscina
            // 
            this.Piscina.HeaderText = "Piscina";
            this.Piscina.MinimumWidth = 90;
            this.Piscina.Name = "Piscina";
            this.Piscina.ReadOnly = true;
            // 
            // Casino
            // 
            this.Casino.HeaderText = "Casino";
            this.Casino.MinimumWidth = 85;
            this.Casino.Name = "Casino";
            this.Casino.ReadOnly = true;
            // 
            // Bodega
            // 
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.MinimumWidth = 100;
            this.Bodega.Name = "Bodega";
            this.Bodega.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Apellido - Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 189;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPasajero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePasajero,
            this.DNI,
            this.SexoPasajero,
            this.Edad,
            this.BolsoMano,
            this.ValijaPeso});
            this.dgvPasajero.GridColor = System.Drawing.Color.Black;
            this.dgvPasajero.Location = new System.Drawing.Point(47, 402);
            this.dgvPasajero.MultiSelect = false;
            this.dgvPasajero.Name = "dgvPasajero";
            this.dgvPasajero.ReadOnly = true;
            this.dgvPasajero.RowHeadersVisible = false;
            this.dgvPasajero.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvPasajero.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPasajero.RowTemplate.Height = 29;
            this.dgvPasajero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPasajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasajero.Size = new System.Drawing.Size(968, 289);
            this.dgvPasajero.TabIndex = 17;
            // 
            // NombrePasajero
            // 
            this.NombrePasajero.FillWeight = 503.7433F;
            this.NombrePasajero.HeaderText = "Apellido - Nombre";
            this.NombrePasajero.MinimumWidth = 200;
            this.NombrePasajero.Name = "NombrePasajero";
            this.NombrePasajero.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.FillWeight = 19.25134F;
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 150;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // SexoPasajero
            // 
            this.SexoPasajero.FillWeight = 19.25134F;
            this.SexoPasajero.HeaderText = "Sexo";
            this.SexoPasajero.MinimumWidth = 100;
            this.SexoPasajero.Name = "SexoPasajero";
            this.SexoPasajero.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.FillWeight = 19.25134F;
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 100;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // BolsoMano
            // 
            this.BolsoMano.FillWeight = 19.25134F;
            this.BolsoMano.HeaderText = "Bolso de Mano";
            this.BolsoMano.MinimumWidth = 150;
            this.BolsoMano.Name = "BolsoMano";
            this.BolsoMano.ReadOnly = true;
            this.BolsoMano.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BolsoMano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ValijaPeso
            // 
            this.ValijaPeso.FillWeight = 19.25134F;
            this.ValijaPeso.HeaderText = "Valija - Peso";
            this.ValijaPeso.MinimumWidth = 200;
            this.ValijaPeso.Name = "ValijaPeso";
            this.ValijaPeso.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Viajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(433, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cruceros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(433, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pasajeros";
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruceros AguasVivas - Index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIndex_FormClosing);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BolsoMano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValijaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gimnasio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piscina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}