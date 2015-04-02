namespace UNCDeporte.Interfaz.Admin
{
    partial class ProgramaActividades
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDeporte = new System.Windows.Forms.ComboBox();
            this.cbLugar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoSector = new System.Windows.Forms.ComboBox();
            this.gbPrograma = new System.Windows.Forms.GroupBox();
            this.dtpCierre = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnObtenerProgramas = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnioLectivo = new System.Windows.Forms.TextBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.btnVerDiagramacion = new System.Windows.Forms.Button();
            this.btnQuitarDelPrograma = new System.Windows.Forms.Button();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbDiagramacion = new System.Windows.Forms.GroupBox();
            this.gbDia = new System.Windows.Forms.GroupBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardarDiagramacion = new System.Windows.Forms.Button();
            this.gbProfesor = new System.Windows.Forms.GroupBox();
            this.chkConfirmarProfesor = new System.Windows.Forms.CheckBox();
            this.rbConProfesor = new System.Windows.Forms.RadioButton();
            this.rbSinProfesor = new System.Windows.Forms.RadioButton();
            this.btnCancelarDiagramacion = new System.Windows.Forms.Button();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.dudMinutoHasta = new System.Windows.Forms.DomainUpDown();
            this.dudHoraHasta = new System.Windows.Forms.DomainUpDown();
            this.dudMinutoDesde = new System.Windows.Forms.DomainUpDown();
            this.dudHoraDesde = new System.Windows.Forms.DomainUpDown();
            this.cbDuracion = new System.Windows.Forms.ComboBox();
            this.chkDuracion = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkConfirmarHorario = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbEspacio = new System.Windows.Forms.GroupBox();
            this.chkConfirmarEspacio = new System.Windows.Forms.CheckBox();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDiagramacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarDiagramacion = new System.Windows.Forms.Button();
            this.btnAgregarDiagramacion = new System.Windows.Forms.Button();
            this.btnDiagramarDeporte = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnGuardarPrograma = new System.Windows.Forms.Button();
            this.btnCancelarPrograma = new System.Windows.Forms.Button();
            this.gbPrograma.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.gbDiagramacion.SuspendLayout();
            this.gbDia.SuspendLayout();
            this.gbProfesor.SuspendLayout();
            this.gbHorario.SuspendLayout();
            this.gbEspacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagramacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(121, 19);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(190, 21);
            this.cbProfesor.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deporte";
            // 
            // cbDeporte
            // 
            this.cbDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeporte.FormattingEnabled = true;
            this.cbDeporte.Location = new System.Drawing.Point(98, 25);
            this.cbDeporte.Name = "cbDeporte";
            this.cbDeporte.Size = new System.Drawing.Size(241, 21);
            this.cbDeporte.TabIndex = 6;
            // 
            // cbLugar
            // 
            this.cbLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLugar.FormattingEnabled = true;
            this.cbLugar.Location = new System.Drawing.Point(121, 19);
            this.cbLugar.Name = "cbLugar";
            this.cbLugar.Size = new System.Drawing.Size(190, 21);
            this.cbLugar.TabIndex = 11;
            this.cbLugar.SelectedIndexChanged += new System.EventHandler(this.cbLugar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lugar de practica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Sector";
            // 
            // cbTipoSector
            // 
            this.cbTipoSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoSector.FormattingEnabled = true;
            this.cbTipoSector.Location = new System.Drawing.Point(407, 19);
            this.cbTipoSector.Name = "cbTipoSector";
            this.cbTipoSector.Size = new System.Drawing.Size(152, 21);
            this.cbTipoSector.TabIndex = 12;
            this.cbTipoSector.SelectedIndexChanged += new System.EventHandler(this.cbTipoSector_SelectedIndexChanged);
            // 
            // gbPrograma
            // 
            this.gbPrograma.Controls.Add(this.dtpCierre);
            this.gbPrograma.Controls.Add(this.dtpInicio);
            this.gbPrograma.Controls.Add(this.btnObtenerProgramas);
            this.gbPrograma.Controls.Add(this.label16);
            this.gbPrograma.Controls.Add(this.label15);
            this.gbPrograma.Controls.Add(this.txtFechaAlta);
            this.gbPrograma.Controls.Add(this.label14);
            this.gbPrograma.Controls.Add(this.txtAnioLectivo);
            this.gbPrograma.Controls.Add(this.gbDetalle);
            this.gbPrograma.Controls.Add(this.txtDescripcion);
            this.gbPrograma.Controls.Add(this.label6);
            this.gbPrograma.Controls.Add(this.label3);
            this.gbPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrograma.Location = new System.Drawing.Point(9, 2);
            this.gbPrograma.Name = "gbPrograma";
            this.gbPrograma.Size = new System.Drawing.Size(925, 524);
            this.gbPrograma.TabIndex = 0;
            this.gbPrograma.TabStop = false;
            this.gbPrograma.Text = " Programa de Actividades ";
            // 
            // dtpCierre
            // 
            this.dtpCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCierre.Location = new System.Drawing.Point(806, 19);
            this.dtpCierre.Name = "dtpCierre";
            this.dtpCierre.Size = new System.Drawing.Size(93, 20);
            this.dtpCierre.TabIndex = 34;
            this.dtpCierre.Value = new System.DateTime(2014, 8, 10, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(549, 19);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(93, 20);
            this.dtpInicio.TabIndex = 33;
            this.dtpInicio.Value = new System.DateTime(2014, 8, 10, 0, 0, 0, 0);
            // 
            // btnObtenerProgramas
            // 
            this.btnObtenerProgramas.Location = new System.Drawing.Point(678, 47);
            this.btnObtenerProgramas.Name = "btnObtenerProgramas";
            this.btnObtenerProgramas.Size = new System.Drawing.Size(221, 23);
            this.btnObtenerProgramas.TabIndex = 5;
            this.btnObtenerProgramas.Text = "Obtener Programas";
            this.btnObtenerProgramas.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(675, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Cierre de Actividades";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(421, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Inicio de Actividades";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Enabled = false;
            this.txtFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAlta.ForeColor = System.Drawing.Color.Black;
            this.txtFechaAlta.Location = new System.Drawing.Point(110, 20);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(74, 20);
            this.txtFechaAlta.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fecha de Alta";
            // 
            // txtAnioLectivo
            // 
            this.txtAnioLectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioLectivo.Location = new System.Drawing.Point(277, 20);
            this.txtAnioLectivo.Name = "txtAnioLectivo";
            this.txtAnioLectivo.Size = new System.Drawing.Size(74, 20);
            this.txtAnioLectivo.TabIndex = 1;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.btnVerDiagramacion);
            this.gbDetalle.Controls.Add(this.btnQuitarDelPrograma);
            this.gbDetalle.Controls.Add(this.txtCupo);
            this.gbDetalle.Controls.Add(this.label13);
            this.gbDetalle.Controls.Add(this.cbDeporte);
            this.gbDetalle.Controls.Add(this.label2);
            this.gbDetalle.Controls.Add(this.gbDiagramacion);
            this.gbDetalle.Controls.Add(this.btnDiagramarDeporte);
            this.gbDetalle.Location = new System.Drawing.Point(12, 82);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(900, 431);
            this.gbDetalle.TabIndex = 6;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = " Detalle del Programa ";
            // 
            // btnVerDiagramacion
            // 
            this.btnVerDiagramacion.Location = new System.Drawing.Point(741, 23);
            this.btnVerDiagramacion.Name = "btnVerDiagramacion";
            this.btnVerDiagramacion.Size = new System.Drawing.Size(130, 23);
            this.btnVerDiagramacion.TabIndex = 10;
            this.btnVerDiagramacion.Text = "Ver Diagramación";
            this.btnVerDiagramacion.UseVisualStyleBackColor = true;
            // 
            // btnQuitarDelPrograma
            // 
            this.btnQuitarDelPrograma.Location = new System.Drawing.Point(599, 23);
            this.btnQuitarDelPrograma.Name = "btnQuitarDelPrograma";
            this.btnQuitarDelPrograma.Size = new System.Drawing.Size(130, 23);
            this.btnQuitarDelPrograma.TabIndex = 9;
            this.btnQuitarDelPrograma.Text = "Quitar del Programa";
            this.btnQuitarDelPrograma.UseVisualStyleBackColor = true;
            // 
            // txtCupo
            // 
            this.txtCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupo.Location = new System.Drawing.Point(383, 25);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(39, 20);
            this.txtCupo.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(345, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Cupo";
            // 
            // gbDiagramacion
            // 
            this.gbDiagramacion.Controls.Add(this.gbDia);
            this.gbDiagramacion.Controls.Add(this.btnGuardarDiagramacion);
            this.gbDiagramacion.Controls.Add(this.gbProfesor);
            this.gbDiagramacion.Controls.Add(this.btnCancelarDiagramacion);
            this.gbDiagramacion.Controls.Add(this.gbHorario);
            this.gbDiagramacion.Controls.Add(this.gbEspacio);
            this.gbDiagramacion.Controls.Add(this.dgvDiagramacion);
            this.gbDiagramacion.Controls.Add(this.btnQuitarDiagramacion);
            this.gbDiagramacion.Controls.Add(this.btnAgregarDiagramacion);
            this.gbDiagramacion.Location = new System.Drawing.Point(12, 64);
            this.gbDiagramacion.Name = "gbDiagramacion";
            this.gbDiagramacion.Size = new System.Drawing.Size(875, 356);
            this.gbDiagramacion.TabIndex = 11;
            this.gbDiagramacion.TabStop = false;
            this.gbDiagramacion.Text = " Diagramación ";
            // 
            // gbDia
            // 
            this.gbDia.Controls.Add(this.cbDia);
            this.gbDia.Controls.Add(this.label10);
            this.gbDia.Location = new System.Drawing.Point(16, 82);
            this.gbDia.Name = "gbDia";
            this.gbDia.Size = new System.Drawing.Size(179, 55);
            this.gbDia.TabIndex = 33;
            this.gbDia.TabStop = false;
            this.gbDia.Text = " Día de Semana ";
            // 
            // cbDia
            // 
            this.cbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cbDia.Location = new System.Drawing.Point(40, 20);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(117, 21);
            this.cbDia.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Día";
            // 
            // btnGuardarDiagramacion
            // 
            this.btnGuardarDiagramacion.Location = new System.Drawing.Point(103, 317);
            this.btnGuardarDiagramacion.Name = "btnGuardarDiagramacion";
            this.btnGuardarDiagramacion.Size = new System.Drawing.Size(155, 23);
            this.btnGuardarDiagramacion.TabIndex = 28;
            this.btnGuardarDiagramacion.Text = "Guardar Diagramación";
            this.btnGuardarDiagramacion.UseVisualStyleBackColor = true;
            // 
            // gbProfesor
            // 
            this.gbProfesor.Controls.Add(this.chkConfirmarProfesor);
            this.gbProfesor.Controls.Add(this.rbConProfesor);
            this.gbProfesor.Controls.Add(this.rbSinProfesor);
            this.gbProfesor.Controls.Add(this.cbProfesor);
            this.gbProfesor.Controls.Add(this.label1);
            this.gbProfesor.Location = new System.Drawing.Point(16, 143);
            this.gbProfesor.Name = "gbProfesor";
            this.gbProfesor.Size = new System.Drawing.Size(843, 53);
            this.gbProfesor.TabIndex = 21;
            this.gbProfesor.TabStop = false;
            this.gbProfesor.Text = " Profesor";
            // 
            // chkConfirmarProfesor
            // 
            this.chkConfirmarProfesor.AutoSize = true;
            this.chkConfirmarProfesor.Location = new System.Drawing.Point(751, 22);
            this.chkConfirmarProfesor.Name = "chkConfirmarProfesor";
            this.chkConfirmarProfesor.Size = new System.Drawing.Size(91, 17);
            this.chkConfirmarProfesor.TabIndex = 24;
            this.chkConfirmarProfesor.Text = "A Confirmar";
            this.chkConfirmarProfesor.UseVisualStyleBackColor = true;
            // 
            // rbConProfesor
            // 
            this.rbConProfesor.AutoSize = true;
            this.rbConProfesor.Checked = true;
            this.rbConProfesor.Location = new System.Drawing.Point(355, 21);
            this.rbConProfesor.Name = "rbConProfesor";
            this.rbConProfesor.Size = new System.Drawing.Size(98, 17);
            this.rbConProfesor.TabIndex = 22;
            this.rbConProfesor.TabStop = true;
            this.rbConProfesor.Text = "Con Profesor";
            this.rbConProfesor.UseVisualStyleBackColor = true;
            // 
            // rbSinProfesor
            // 
            this.rbSinProfesor.AutoSize = true;
            this.rbSinProfesor.Location = new System.Drawing.Point(471, 21);
            this.rbSinProfesor.Name = "rbSinProfesor";
            this.rbSinProfesor.Size = new System.Drawing.Size(94, 17);
            this.rbSinProfesor.TabIndex = 23;
            this.rbSinProfesor.Text = "Sin Profesor";
            this.rbSinProfesor.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDiagramacion
            // 
            this.btnCancelarDiagramacion.Location = new System.Drawing.Point(700, 317);
            this.btnCancelarDiagramacion.Name = "btnCancelarDiagramacion";
            this.btnCancelarDiagramacion.Size = new System.Drawing.Size(155, 23);
            this.btnCancelarDiagramacion.TabIndex = 29;
            this.btnCancelarDiagramacion.Text = "Cancelar Diagramación";
            this.btnCancelarDiagramacion.UseVisualStyleBackColor = true;
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.dudMinutoHasta);
            this.gbHorario.Controls.Add(this.dudHoraHasta);
            this.gbHorario.Controls.Add(this.dudMinutoDesde);
            this.gbHorario.Controls.Add(this.dudHoraDesde);
            this.gbHorario.Controls.Add(this.cbDuracion);
            this.gbHorario.Controls.Add(this.chkDuracion);
            this.gbHorario.Controls.Add(this.label8);
            this.gbHorario.Controls.Add(this.label9);
            this.gbHorario.Controls.Add(this.chkConfirmarHorario);
            this.gbHorario.Controls.Add(this.label12);
            this.gbHorario.Controls.Add(this.label7);
            this.gbHorario.Location = new System.Drawing.Point(201, 82);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(658, 55);
            this.gbHorario.TabIndex = 15;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = " Horario ";
            // 
            // dudMinutoHasta
            // 
            this.dudMinutoHasta.Items.Add("00");
            this.dudMinutoHasta.Items.Add("05");
            this.dudMinutoHasta.Items.Add("10");
            this.dudMinutoHasta.Items.Add("15");
            this.dudMinutoHasta.Items.Add("20");
            this.dudMinutoHasta.Items.Add("25");
            this.dudMinutoHasta.Items.Add("30");
            this.dudMinutoHasta.Items.Add("35");
            this.dudMinutoHasta.Items.Add("40");
            this.dudMinutoHasta.Items.Add("45");
            this.dudMinutoHasta.Items.Add("50");
            this.dudMinutoHasta.Items.Add("55");
            this.dudMinutoHasta.Location = new System.Drawing.Point(243, 20);
            this.dudMinutoHasta.Name = "dudMinutoHasta";
            this.dudMinutoHasta.Size = new System.Drawing.Size(36, 20);
            this.dudMinutoHasta.TabIndex = 36;
            // 
            // dudHoraHasta
            // 
            this.dudHoraHasta.Items.Add("08");
            this.dudHoraHasta.Items.Add("09");
            this.dudHoraHasta.Items.Add("10");
            this.dudHoraHasta.Items.Add("11");
            this.dudHoraHasta.Items.Add("12");
            this.dudHoraHasta.Items.Add("13");
            this.dudHoraHasta.Items.Add("14");
            this.dudHoraHasta.Items.Add("15");
            this.dudHoraHasta.Items.Add("16");
            this.dudHoraHasta.Items.Add("17");
            this.dudHoraHasta.Items.Add("18");
            this.dudHoraHasta.Items.Add("19");
            this.dudHoraHasta.Items.Add("20");
            this.dudHoraHasta.Items.Add("21");
            this.dudHoraHasta.Items.Add("22");
            this.dudHoraHasta.Items.Add("23");
            this.dudHoraHasta.Location = new System.Drawing.Point(197, 20);
            this.dudHoraHasta.Name = "dudHoraHasta";
            this.dudHoraHasta.Size = new System.Drawing.Size(36, 20);
            this.dudHoraHasta.TabIndex = 35;
            // 
            // dudMinutoDesde
            // 
            this.dudMinutoDesde.Items.Add("00");
            this.dudMinutoDesde.Items.Add("05");
            this.dudMinutoDesde.Items.Add("10");
            this.dudMinutoDesde.Items.Add("15");
            this.dudMinutoDesde.Items.Add("20");
            this.dudMinutoDesde.Items.Add("25");
            this.dudMinutoDesde.Items.Add("30");
            this.dudMinutoDesde.Items.Add("35");
            this.dudMinutoDesde.Items.Add("40");
            this.dudMinutoDesde.Items.Add("45");
            this.dudMinutoDesde.Items.Add("50");
            this.dudMinutoDesde.Items.Add("55");
            this.dudMinutoDesde.Location = new System.Drawing.Point(102, 21);
            this.dudMinutoDesde.Name = "dudMinutoDesde";
            this.dudMinutoDesde.Size = new System.Drawing.Size(36, 20);
            this.dudMinutoDesde.TabIndex = 34;
            // 
            // dudHoraDesde
            // 
            this.dudHoraDesde.Items.Add("08");
            this.dudHoraDesde.Items.Add("09");
            this.dudHoraDesde.Items.Add("10");
            this.dudHoraDesde.Items.Add("11");
            this.dudHoraDesde.Items.Add("12");
            this.dudHoraDesde.Items.Add("13");
            this.dudHoraDesde.Items.Add("14");
            this.dudHoraDesde.Items.Add("15");
            this.dudHoraDesde.Items.Add("16");
            this.dudHoraDesde.Items.Add("17");
            this.dudHoraDesde.Items.Add("18");
            this.dudHoraDesde.Items.Add("19");
            this.dudHoraDesde.Items.Add("20");
            this.dudHoraDesde.Items.Add("21");
            this.dudHoraDesde.Items.Add("22");
            this.dudHoraDesde.Items.Add("23");
            this.dudHoraDesde.Location = new System.Drawing.Point(56, 21);
            this.dudHoraDesde.Name = "dudHoraDesde";
            this.dudHoraDesde.Size = new System.Drawing.Size(36, 20);
            this.dudHoraDesde.TabIndex = 33;
            // 
            // cbDuracion
            // 
            this.cbDuracion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuracion.FormattingEnabled = true;
            this.cbDuracion.Items.AddRange(new object[] {
            "1 h.",
            "1 h.  y 30 min.",
            "2 hs.",
            "2 hs. y 30 min.",
            "3 hs.",
            "3 hs. y 30 min.",
            "4 hs.",
            "4 hs. y 30 min.",
            "5 hs.",
            "8 hs.",
            "10 hs.",
            "12 hs.",
            "14 hs."});
            this.cbDuracion.Location = new System.Drawing.Point(423, 19);
            this.cbDuracion.Name = "cbDuracion";
            this.cbDuracion.Size = new System.Drawing.Size(137, 21);
            this.cbDuracion.TabIndex = 15;
            // 
            // chkDuracion
            // 
            this.chkDuracion.AutoSize = true;
            this.chkDuracion.Location = new System.Drawing.Point(304, 23);
            this.chkDuracion.Name = "chkDuracion";
            this.chkDuracion.Size = new System.Drawing.Size(120, 17);
            this.chkDuracion.TabIndex = 32;
            this.chkDuracion.Text = "Indicar Duracion";
            this.chkDuracion.UseVisualStyleBackColor = true;
            this.chkDuracion.CheckedChanged += new System.EventHandler(this.chkDuracion_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desde";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hasta";
            // 
            // chkConfirmarHorario
            // 
            this.chkConfirmarHorario.AutoSize = true;
            this.chkConfirmarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirmarHorario.Location = new System.Drawing.Point(565, 22);
            this.chkConfirmarHorario.Name = "chkConfirmarHorario";
            this.chkConfirmarHorario.Size = new System.Drawing.Size(91, 17);
            this.chkConfirmarHorario.TabIndex = 20;
            this.chkConfirmarHorario.Text = "A Confirmar";
            this.chkConfirmarHorario.UseVisualStyleBackColor = true;
            this.chkConfirmarHorario.CheckedChanged += new System.EventHandler(this.chkConfirmarHorario_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(233, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // gbEspacio
            // 
            this.gbEspacio.Controls.Add(this.chkConfirmarEspacio);
            this.gbEspacio.Controls.Add(this.cbSector);
            this.gbEspacio.Controls.Add(this.label11);
            this.gbEspacio.Controls.Add(this.label5);
            this.gbEspacio.Controls.Add(this.cbTipoSector);
            this.gbEspacio.Controls.Add(this.label4);
            this.gbEspacio.Controls.Add(this.cbLugar);
            this.gbEspacio.Location = new System.Drawing.Point(16, 21);
            this.gbEspacio.Name = "gbEspacio";
            this.gbEspacio.Size = new System.Drawing.Size(843, 55);
            this.gbEspacio.TabIndex = 11;
            this.gbEspacio.TabStop = false;
            this.gbEspacio.Text = " Espacio ";
            // 
            // chkConfirmarEspacio
            // 
            this.chkConfirmarEspacio.AutoSize = true;
            this.chkConfirmarEspacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirmarEspacio.Location = new System.Drawing.Point(751, 24);
            this.chkConfirmarEspacio.Name = "chkConfirmarEspacio";
            this.chkConfirmarEspacio.Size = new System.Drawing.Size(91, 17);
            this.chkConfirmarEspacio.TabIndex = 14;
            this.chkConfirmarEspacio.Text = "A Confirmar";
            this.chkConfirmarEspacio.UseVisualStyleBackColor = true;
            this.chkConfirmarEspacio.CheckedChanged += new System.EventHandler(this.chkConfirmarEspacio_CheckedChanged);
            // 
            // cbSector
            // 
            this.cbSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(608, 20);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(137, 21);
            this.cbSector.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(562, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sector";
            // 
            // dgvDiagramacion
            // 
            this.dgvDiagramacion.AllowUserToAddRows = false;
            this.dgvDiagramacion.AllowUserToDeleteRows = false;
            this.dgvDiagramacion.AllowUserToResizeColumns = false;
            this.dgvDiagramacion.AllowUserToResizeRows = false;
            this.dgvDiagramacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDiagramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagramacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDiagramacion.Location = new System.Drawing.Point(103, 209);
            this.dgvDiagramacion.MultiSelect = false;
            this.dgvDiagramacion.Name = "dgvDiagramacion";
            this.dgvDiagramacion.ReadOnly = true;
            this.dgvDiagramacion.RowHeadersVisible = false;
            this.dgvDiagramacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagramacion.Size = new System.Drawing.Size(752, 92);
            this.dgvDiagramacion.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lugar";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 238;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo de Sector";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sector";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Día";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // btnQuitarDiagramacion
            // 
            this.btnQuitarDiagramacion.Location = new System.Drawing.Point(16, 263);
            this.btnQuitarDiagramacion.Name = "btnQuitarDiagramacion";
            this.btnQuitarDiagramacion.Size = new System.Drawing.Size(78, 23);
            this.btnQuitarDiagramacion.TabIndex = 26;
            this.btnQuitarDiagramacion.Text = "<< Quitar";
            this.btnQuitarDiagramacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDiagramacion
            // 
            this.btnAgregarDiagramacion.Location = new System.Drawing.Point(16, 234);
            this.btnAgregarDiagramacion.Name = "btnAgregarDiagramacion";
            this.btnAgregarDiagramacion.Size = new System.Drawing.Size(78, 23);
            this.btnAgregarDiagramacion.TabIndex = 25;
            this.btnAgregarDiagramacion.Text = "Agregar >>";
            this.btnAgregarDiagramacion.UseVisualStyleBackColor = true;
            this.btnAgregarDiagramacion.Click += new System.EventHandler(this.btnAgregarDiagramacion_Click);
            // 
            // btnDiagramarDeporte
            // 
            this.btnDiagramarDeporte.Location = new System.Drawing.Point(457, 23);
            this.btnDiagramarDeporte.Name = "btnDiagramarDeporte";
            this.btnDiagramarDeporte.Size = new System.Drawing.Size(130, 23);
            this.btnDiagramarDeporte.TabIndex = 8;
            this.btnDiagramarDeporte.Text = "Diagramar Deporte";
            this.btnDiagramarDeporte.UseVisualStyleBackColor = true;
            this.btnDiagramarDeporte.Click += new System.EventHandler(this.btnDiagramarDeporte_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(110, 49);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(532, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Año Lectivo";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(778, 538);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(130, 23);
            this.btnReservar.TabIndex = 32;
            this.btnReservar.Text = "Reservar ";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPrograma
            // 
            this.btnGuardarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrograma.Location = new System.Drawing.Point(33, 538);
            this.btnGuardarPrograma.Name = "btnGuardarPrograma";
            this.btnGuardarPrograma.Size = new System.Drawing.Size(130, 23);
            this.btnGuardarPrograma.TabIndex = 30;
            this.btnGuardarPrograma.Text = "Guardar Programa";
            this.btnGuardarPrograma.UseVisualStyleBackColor = true;
            this.btnGuardarPrograma.Click += new System.EventHandler(this.btnGuardarPrograma_Click);
            // 
            // btnCancelarPrograma
            // 
            this.btnCancelarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrograma.Location = new System.Drawing.Point(404, 538);
            this.btnCancelarPrograma.Name = "btnCancelarPrograma";
            this.btnCancelarPrograma.Size = new System.Drawing.Size(130, 23);
            this.btnCancelarPrograma.TabIndex = 31;
            this.btnCancelarPrograma.Text = "Cancelar Programa";
            this.btnCancelarPrograma.UseVisualStyleBackColor = true;
            // 
            // ProgramaActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 573);
            this.Controls.Add(this.btnCancelarPrograma);
            this.Controls.Add(this.btnGuardarPrograma);
            this.Controls.Add(this.gbPrograma);
            this.Controls.Add(this.btnReservar);
            this.Name = "ProgramaActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programación de Actividades Deportivas ";
            this.Load += new System.EventHandler(this.RegistrarProgramaActividades_Load);
            this.gbPrograma.ResumeLayout(false);
            this.gbPrograma.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbDiagramacion.ResumeLayout(false);
            this.gbDia.ResumeLayout(false);
            this.gbDia.PerformLayout();
            this.gbProfesor.ResumeLayout(false);
            this.gbProfesor.PerformLayout();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbEspacio.ResumeLayout(false);
            this.gbEspacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagramacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDeporte;
        private System.Windows.Forms.ComboBox cbLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoSector;
        private System.Windows.Forms.GroupBox gbPrograma;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuitarDiagramacion;
        private System.Windows.Forms.Button btnAgregarDiagramacion;
        private System.Windows.Forms.Button btnGuardarPrograma;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.GroupBox gbDiagramacion;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDiagramacion;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkConfirmarHorario;
        private System.Windows.Forms.Button btnCancelarPrograma;
        private System.Windows.Forms.Button btnCancelarDiagramacion;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnDiagramarDeporte;
        private System.Windows.Forms.TextBox txtAnioLectivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbProfesor;
        private System.Windows.Forms.RadioButton rbConProfesor;
        private System.Windows.Forms.RadioButton rbSinProfesor;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.GroupBox gbEspacio;
        private System.Windows.Forms.Button btnQuitarDelPrograma;
        private System.Windows.Forms.CheckBox chkConfirmarProfesor;
        private System.Windows.Forms.CheckBox chkConfirmarEspacio;
        private System.Windows.Forms.Button btnObtenerProgramas;
        private System.Windows.Forms.Button btnVerDiagramacion;
        private System.Windows.Forms.Button btnGuardarDiagramacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cbDuracion;
        private System.Windows.Forms.CheckBox chkDuracion;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpCierre;
        private System.Windows.Forms.GroupBox gbDia;
        private System.Windows.Forms.DomainUpDown dudHoraDesde;
        private System.Windows.Forms.DomainUpDown dudMinutoDesde;
        private System.Windows.Forms.DomainUpDown dudMinutoHasta;
        private System.Windows.Forms.DomainUpDown dudHoraHasta;
    }
}