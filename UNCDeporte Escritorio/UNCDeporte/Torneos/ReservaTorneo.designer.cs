namespace UNCDeporte.Admin
{
    partial class ReservaTorneo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbEspacio = new System.Windows.Forms.GroupBox();
            this.txtTipoSector = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleReserva = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDDeporte = new System.Windows.Forms.TextBox();
            this.txtIDtipoSector = new System.Windows.Forms.TextBox();
            this.txtIDLugar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbHorario.SuspendLayout();
            this.gbEspacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHorario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(716, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 563);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Seleccion de Horario ";
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.AllowUserToResizeColumns = false;
            this.dgvHorario.AllowUserToResizeRows = false;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dgvHorario.Location = new System.Drawing.Point(20, 16);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersVisible = false;
            this.dgvHorario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorario.Size = new System.Drawing.Size(230, 527);
            this.dgvHorario.TabIndex = 0;
            this.dgvHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellContentClick);
            this.dgvHorario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvHorario_MouseUp);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Horario";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 84;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Dia";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.gbHorario);
            this.groupBox2.Controls.Add(this.gbEspacio);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.dgvDetalleReserva);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 396);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Detalle de la Reserva ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDeporte);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(343, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 62);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Deporte ";
            // 
            // txtDeporte
            // 
            this.txtDeporte.Location = new System.Drawing.Point(68, 26);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(251, 20);
            this.txtDeporte.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Deporte";
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.dtpFecha);
            this.gbHorario.Controls.Add(this.txtDesde);
            this.gbHorario.Controls.Add(this.label14);
            this.gbHorario.Controls.Add(this.txtHasta);
            this.gbHorario.Controls.Add(this.label4);
            this.gbHorario.Controls.Add(this.label13);
            this.gbHorario.Location = new System.Drawing.Point(343, 99);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(335, 92);
            this.gbHorario.TabIndex = 64;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = " Fecha y Horario de Reserva";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(67, 25);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(253, 20);
            this.dtpFecha.TabIndex = 63;
            // 
            // txtDesde
            // 
            this.txtDesde.Enabled = false;
            this.txtDesde.Location = new System.Drawing.Point(67, 59);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(99, 20);
            this.txtDesde.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(219, 59);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Fecha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Desde";
            // 
            // gbEspacio
            // 
            this.gbEspacio.Controls.Add(this.txtIDDeporte);
            this.gbEspacio.Controls.Add(this.txtTipoSector);
            this.gbEspacio.Controls.Add(this.txtIDtipoSector);
            this.gbEspacio.Controls.Add(this.txtLugar);
            this.gbEspacio.Controls.Add(this.txtIDLugar);
            this.gbEspacio.Controls.Add(this.label12);
            this.gbEspacio.Controls.Add(this.cbSector);
            this.gbEspacio.Controls.Add(this.label8);
            this.gbEspacio.Controls.Add(this.label7);
            this.gbEspacio.Location = new System.Drawing.Point(13, 35);
            this.gbEspacio.Name = "gbEspacio";
            this.gbEspacio.Size = new System.Drawing.Size(321, 156);
            this.gbEspacio.TabIndex = 63;
            this.gbEspacio.TabStop = false;
            this.gbEspacio.Text = " Espacio de Reserva ";
            // 
            // txtTipoSector
            // 
            this.txtTipoSector.Location = new System.Drawing.Point(87, 75);
            this.txtTipoSector.Name = "txtTipoSector";
            this.txtTipoSector.Size = new System.Drawing.Size(223, 20);
            this.txtTipoSector.TabIndex = 47;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(85, 26);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(223, 20);
            this.txtLugar.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Tipo Sector";
            // 
            // cbSector
            // 
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(85, 121);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(225, 21);
            this.cbSector.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Sector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Lugar";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(598, 249);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 23);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(512, 249);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalleReserva
            // 
            this.dgvDetalleReserva.AllowUserToAddRows = false;
            this.dgvDetalleReserva.AllowUserToDeleteRows = false;
            this.dgvDetalleReserva.AllowUserToResizeColumns = false;
            this.dgvDetalleReserva.AllowUserToResizeRows = false;
            this.dgvDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column6});
            this.dgvDetalleReserva.Location = new System.Drawing.Point(13, 275);
            this.dgvDetalleReserva.Name = "dgvDetalleReserva";
            this.dgvDetalleReserva.ReadOnly = true;
            this.dgvDetalleReserva.RowHeadersVisible = false;
            this.dgvDetalleReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleReserva.Size = new System.Drawing.Size(665, 106);
            this.dgvDetalleReserva.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lugar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 162;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de Sector";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sector";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Desde";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hasta";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(856, 586);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(33, 586);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(110, 23);
            this.btnReservar.TabIndex = 59;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Location = new System.Drawing.Point(120, 119);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(223, 20);
            this.dtpFecFin.TabIndex = 73;
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Location = new System.Drawing.Point(120, 77);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(223, 20);
            this.dtpFecInicio.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha Inicio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 20);
            this.txtNombre.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Torneo";
            // 
            // txtIDDeporte
            // 
            this.txtIDDeporte.Location = new System.Drawing.Point(320, 23);
            this.txtIDDeporte.Name = "txtIDDeporte";
            this.txtIDDeporte.Size = new System.Drawing.Size(17, 20);
            this.txtIDDeporte.TabIndex = 76;
            this.txtIDDeporte.Visible = false;
            // 
            // txtIDtipoSector
            // 
            this.txtIDtipoSector.Location = new System.Drawing.Point(87, 97);
            this.txtIDtipoSector.Name = "txtIDtipoSector";
            this.txtIDtipoSector.Size = new System.Drawing.Size(25, 20);
            this.txtIDtipoSector.TabIndex = 75;
            this.txtIDtipoSector.Visible = false;
            // 
            // txtIDLugar
            // 
            this.txtIDLugar.Location = new System.Drawing.Point(87, 49);
            this.txtIDLugar.Name = "txtIDLugar";
            this.txtIDLugar.Size = new System.Drawing.Size(25, 20);
            this.txtIDLugar.TabIndex = 74;
            this.txtIDLugar.Visible = false;
            // 
            // ReservaTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 627);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpFecInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "ReservaTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservaTorneo";
            this.Load += new System.EventHandler(this.ReservaTorneo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbEspacio.ResumeLayout(false);
            this.gbEspacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbEspacio;
        private System.Windows.Forms.TextBox txtTipoSector;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDDeporte;
        private System.Windows.Forms.TextBox txtIDtipoSector;
        private System.Windows.Forms.TextBox txtIDLugar;
    }
}