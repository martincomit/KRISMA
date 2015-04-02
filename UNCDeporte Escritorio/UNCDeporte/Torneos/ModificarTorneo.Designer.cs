namespace UNCDeporte.Torneos
{
    partial class ModificarTorneo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTorneos = new System.Windows.Forms.GroupBox();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEstadoInicial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.dgTorneos = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosTorneo = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantParticipantes = new System.Windows.Forms.TextBox();
            this.btnCalcularCantParticipantes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantidadParticipantesPorClasificatorioO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCantidadParticipantes = new System.Windows.Forms.ComboBox();
            this.cmbClasificadosPorGrupo = new System.Windows.Forms.ComboBox();
            this.cmbParticipantesPorGrupo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCantidadGrupos = new System.Windows.Forms.ComboBox();
            this.lblCantidadParticipantes = new System.Windows.Forms.Label();
            this.gbFase = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.cmbTorneoAnterior = new System.Windows.Forms.ComboBox();
            this.lblFaseAnterior = new System.Windows.Forms.Label();
            this.cmbSubcampeon = new System.Windows.Forms.ComboBox();
            this.cmbCampeon = new System.Windows.Forms.ComboBox();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSubcampeon = new System.Windows.Forms.Label();
            this.lblCampeon = new System.Windows.Forms.Label();
            this.lbl2doPuesto = new System.Windows.Forms.Label();
            this.cmbPuntajeSegundoPuesto = new System.Windows.Forms.ComboBox();
            this.lbl1erPuesto = new System.Windows.Forms.Label();
            this.cmbPuntajePrimerPuesto = new System.Windows.Forms.ComboBox();
            this.cbClasificatorio = new System.Windows.Forms.CheckBox();
            this.cbTCTDobleVuelta = new System.Windows.Forms.CheckBox();
            this.cbEliminatoria = new System.Windows.Forms.CheckBox();
            this.cbTCTUnaVuelta = new System.Windows.Forms.CheckBox();
            this.cmbTiposDeporte = new System.Windows.Forms.ComboBox();
            this.lblTipoDeporte = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblTipoTorneo = new System.Windows.Forms.Label();
            this.dtFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbDeportes = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCierreTorneo = new System.Windows.Forms.Label();
            this.lblInicioTorneo = new System.Windows.Forms.Label();
            this.gbTorneos.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTorneos)).BeginInit();
            this.gbDatosTorneo.SuspendLayout();
            this.gbFase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTorneos
            // 
            this.gbTorneos.Controls.Add(this.gbBusqueda);
            this.gbTorneos.Controls.Add(this.lblGuardado);
            this.gbTorneos.Controls.Add(this.gbConsulta);
            this.gbTorneos.Controls.Add(this.btnSalir);
            this.gbTorneos.Controls.Add(this.btnGuardar);
            this.gbTorneos.Controls.Add(this.gbDatosTorneo);
            this.gbTorneos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTorneos.Location = new System.Drawing.Point(18, 9);
            this.gbTorneos.Name = "gbTorneos";
            this.gbTorneos.Size = new System.Drawing.Size(834, 670);
            this.gbTorneos.TabIndex = 2;
            this.gbTorneos.TabStop = false;
            this.gbTorneos.Enter += new System.EventHandler(this.gbTorneos_Enter);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.txtNombre);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.cmbEstadoInicial);
            this.gbBusqueda.Controls.Add(this.label4);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Location = new System.Drawing.Point(14, 11);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBusqueda.Size = new System.Drawing.Size(804, 52);
            this.gbBusqueda.TabIndex = 160;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(126, 19);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 21);
            this.txtNombre.TabIndex = 164;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(330, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 23);
            this.btnBuscar.TabIndex = 163;
            this.btnBuscar.Text = "Buscar Torneo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEstadoInicial
            // 
            this.cmbEstadoInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoInicial.Enabled = false;
            this.cmbEstadoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoInicial.FormattingEnabled = true;
            this.cmbEstadoInicial.Location = new System.Drawing.Point(623, 19);
            this.cmbEstadoInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstadoInicial.Name = "cmbEstadoInicial";
            this.cmbEstadoInicial.Size = new System.Drawing.Size(164, 23);
            this.cmbEstadoInicial.TabIndex = 162;
            this.cmbEstadoInicial.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "Estado del Torneo";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Nombre del Torneo";
            // 
            // lblGuardado
            // 
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Location = new System.Drawing.Point(231, 639);
            this.lblGuardado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(62, 13);
            this.lblGuardado.TabIndex = 74;
            this.lblGuardado.Text = "Guardado";
            this.lblGuardado.Visible = false;
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.dgTorneos);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(14, 68);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(804, 229);
            this.gbConsulta.TabIndex = 159;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Torneos";
            // 
            // dgTorneos
            // 
            this.dgTorneos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTorneos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTorneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTorneos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTorneos.Location = new System.Drawing.Point(11, 19);
            this.dgTorneos.Name = "dgTorneos";
            this.dgTorneos.ReadOnly = true;
            this.dgTorneos.RowTemplate.Height = 28;
            this.dgTorneos.Size = new System.Drawing.Size(780, 204);
            this.dgTorneos.TabIndex = 5;
            this.dgTorneos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTorneo_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(672, 634);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 23);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(113, 634);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 23);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "Guardar Torneo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbDatosTorneo
            // 
            this.gbDatosTorneo.Controls.Add(this.richTextBox1);
            this.gbDatosTorneo.Controls.Add(this.label1);
            this.gbDatosTorneo.Controls.Add(this.txtCantParticipantes);
            this.gbDatosTorneo.Controls.Add(this.btnCalcularCantParticipantes);
            this.gbDatosTorneo.Controls.Add(this.label8);
            this.gbDatosTorneo.Controls.Add(this.lblCantidadParticipantesPorClasificatorioO);
            this.gbDatosTorneo.Controls.Add(this.label5);
            this.gbDatosTorneo.Controls.Add(this.cmbCantidadParticipantes);
            this.gbDatosTorneo.Controls.Add(this.cmbClasificadosPorGrupo);
            this.gbDatosTorneo.Controls.Add(this.cmbParticipantesPorGrupo);
            this.gbDatosTorneo.Controls.Add(this.label7);
            this.gbDatosTorneo.Controls.Add(this.cmbCantidadGrupos);
            this.gbDatosTorneo.Controls.Add(this.lblCantidadParticipantes);
            this.gbDatosTorneo.Controls.Add(this.gbFase);
            this.gbDatosTorneo.Controls.Add(this.cmbTorneoAnterior);
            this.gbDatosTorneo.Controls.Add(this.lblFaseAnterior);
            this.gbDatosTorneo.Controls.Add(this.cmbSubcampeon);
            this.gbDatosTorneo.Controls.Add(this.cmbCampeon);
            this.gbDatosTorneo.Controls.Add(this.cmbEstados);
            this.gbDatosTorneo.Controls.Add(this.lblEstado);
            this.gbDatosTorneo.Controls.Add(this.lblSubcampeon);
            this.gbDatosTorneo.Controls.Add(this.lblCampeon);
            this.gbDatosTorneo.Controls.Add(this.lbl2doPuesto);
            this.gbDatosTorneo.Controls.Add(this.cmbPuntajeSegundoPuesto);
            this.gbDatosTorneo.Controls.Add(this.lbl1erPuesto);
            this.gbDatosTorneo.Controls.Add(this.cmbPuntajePrimerPuesto);
            this.gbDatosTorneo.Controls.Add(this.cbClasificatorio);
            this.gbDatosTorneo.Controls.Add(this.cbTCTDobleVuelta);
            this.gbDatosTorneo.Controls.Add(this.cbEliminatoria);
            this.gbDatosTorneo.Controls.Add(this.cbTCTUnaVuelta);
            this.gbDatosTorneo.Controls.Add(this.cmbTiposDeporte);
            this.gbDatosTorneo.Controls.Add(this.lblTipoDeporte);
            this.gbDatosTorneo.Controls.Add(this.rtbDescripcion);
            this.gbDatosTorneo.Controls.Add(this.lblTipoTorneo);
            this.gbDatosTorneo.Controls.Add(this.dtFechaCierre);
            this.gbDatosTorneo.Controls.Add(this.dtFechaInicio);
            this.gbDatosTorneo.Controls.Add(this.cmbDeportes);
            this.gbDatosTorneo.Controls.Add(this.lblDeporte);
            this.gbDatosTorneo.Controls.Add(this.lblDescripcion);
            this.gbDatosTorneo.Controls.Add(this.lblCierreTorneo);
            this.gbDatosTorneo.Controls.Add(this.lblInicioTorneo);
            this.gbDatosTorneo.Enabled = false;
            this.gbDatosTorneo.Location = new System.Drawing.Point(14, 303);
            this.gbDatosTorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosTorneo.Name = "gbDatosTorneo";
            this.gbDatosTorneo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosTorneo.Size = new System.Drawing.Size(804, 321);
            this.gbDatosTorneo.TabIndex = 115;
            this.gbDatosTorneo.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(549, 46);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 21);
            this.richTextBox1.TabIndex = 188;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 187;
            this.label1.Text = "CUPO";
            // 
            // txtCantParticipantes
            // 
            this.txtCantParticipantes.Enabled = false;
            this.txtCantParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantParticipantes.Location = new System.Drawing.Point(549, 227);
            this.txtCantParticipantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantParticipantes.Name = "txtCantParticipantes";
            this.txtCantParticipantes.Size = new System.Drawing.Size(33, 21);
            this.txtCantParticipantes.TabIndex = 186;
            this.txtCantParticipantes.Visible = false;
            // 
            // btnCalcularCantParticipantes
            // 
            this.btnCalcularCantParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCantParticipantes.Location = new System.Drawing.Point(549, 224);
            this.btnCalcularCantParticipantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcularCantParticipantes.Name = "btnCalcularCantParticipantes";
            this.btnCalcularCantParticipantes.Size = new System.Drawing.Size(66, 23);
            this.btnCalcularCantParticipantes.TabIndex = 185;
            this.btnCalcularCantParticipantes.Text = "Calcular";
            this.btnCalcularCantParticipantes.UseVisualStyleBackColor = true;
            this.btnCalcularCantParticipantes.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 182;
            this.label8.Text = "Clasificados por Grupo";
            // 
            // lblCantidadParticipantesPorClasificatorioO
            // 
            this.lblCantidadParticipantesPorClasificatorioO.AutoSize = true;
            this.lblCantidadParticipantesPorClasificatorioO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadParticipantesPorClasificatorioO.Location = new System.Drawing.Point(590, 231);
            this.lblCantidadParticipantesPorClasificatorioO.Name = "lblCantidadParticipantesPorClasificatorioO";
            this.lblCantidadParticipantesPorClasificatorioO.Size = new System.Drawing.Size(12, 15);
            this.lblCantidadParticipantesPorClasificatorioO.TabIndex = 184;
            this.lblCantidadParticipantesPorClasificatorioO.Text = "*";
            this.lblCantidadParticipantesPorClasificatorioO.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 181;
            this.label5.Text = "Cantidad de Grupos";
            // 
            // cmbCantidadParticipantes
            // 
            this.cmbCantidadParticipantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadParticipantes.Enabled = false;
            this.cmbCantidadParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidadParticipantes.FormattingEnabled = true;
            this.cmbCantidadParticipantes.Location = new System.Drawing.Point(549, 226);
            this.cmbCantidadParticipantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCantidadParticipantes.Name = "cmbCantidadParticipantes";
            this.cmbCantidadParticipantes.Size = new System.Drawing.Size(174, 23);
            this.cmbCantidadParticipantes.TabIndex = 183;
            // 
            // cmbClasificadosPorGrupo
            // 
            this.cmbClasificadosPorGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificadosPorGrupo.Enabled = false;
            this.cmbClasificadosPorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificadosPorGrupo.FormattingEnabled = true;
            this.cmbClasificadosPorGrupo.Location = new System.Drawing.Point(174, 226);
            this.cmbClasificadosPorGrupo.Name = "cmbClasificadosPorGrupo";
            this.cmbClasificadosPorGrupo.Size = new System.Drawing.Size(174, 23);
            this.cmbClasificadosPorGrupo.TabIndex = 180;
            // 
            // cmbParticipantesPorGrupo
            // 
            this.cmbParticipantesPorGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParticipantesPorGrupo.Enabled = false;
            this.cmbParticipantesPorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticipantesPorGrupo.FormattingEnabled = true;
            this.cmbParticipantesPorGrupo.Location = new System.Drawing.Point(549, 197);
            this.cmbParticipantesPorGrupo.Name = "cmbParticipantesPorGrupo";
            this.cmbParticipantesPorGrupo.Size = new System.Drawing.Size(174, 23);
            this.cmbParticipantesPorGrupo.TabIndex = 178;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 176;
            this.label7.Text = "Participantes por Grupo";
            // 
            // cmbCantidadGrupos
            // 
            this.cmbCantidadGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadGrupos.Enabled = false;
            this.cmbCantidadGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidadGrupos.FormattingEnabled = true;
            this.cmbCantidadGrupos.Location = new System.Drawing.Point(174, 200);
            this.cmbCantidadGrupos.Name = "cmbCantidadGrupos";
            this.cmbCantidadGrupos.Size = new System.Drawing.Size(174, 23);
            this.cmbCantidadGrupos.TabIndex = 177;
            // 
            // lblCantidadParticipantes
            // 
            this.lblCantidadParticipantes.AutoSize = true;
            this.lblCantidadParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadParticipantes.Location = new System.Drawing.Point(391, 229);
            this.lblCantidadParticipantes.Name = "lblCantidadParticipantes";
            this.lblCantidadParticipantes.Size = new System.Drawing.Size(153, 13);
            this.lblCantidadParticipantes.TabIndex = 179;
            this.lblCantidadParticipantes.Text = "Cantidad de Participantes";
            // 
            // gbFase
            // 
            this.gbFase.Controls.Add(this.rbNo);
            this.gbFase.Controls.Add(this.rbSi);
            this.gbFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFase.Location = new System.Drawing.Point(549, 130);
            this.gbFase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFase.Name = "gbFase";
            this.gbFase.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFase.Size = new System.Drawing.Size(55, 59);
            this.gbFase.TabIndex = 160;
            this.gbFase.TabStop = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(4, 32);
            this.rbNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(41, 19);
            this.rbNo.TabIndex = 108;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(4, 13);
            this.rbSi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(36, 19);
            this.rbSi.TabIndex = 107;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // cmbTorneoAnterior
            // 
            this.cmbTorneoAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneoAnterior.Enabled = false;
            this.cmbTorneoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTorneoAnterior.FormattingEnabled = true;
            this.cmbTorneoAnterior.Location = new System.Drawing.Point(644, 140);
            this.cmbTorneoAnterior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTorneoAnterior.Name = "cmbTorneoAnterior";
            this.cmbTorneoAnterior.Size = new System.Drawing.Size(143, 23);
            this.cmbTorneoAnterior.TabIndex = 159;
            this.cmbTorneoAnterior.Visible = false;
            // 
            // lblFaseAnterior
            // 
            this.lblFaseAnterior.AutoSize = true;
            this.lblFaseAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaseAnterior.Location = new System.Drawing.Point(413, 144);
            this.lblFaseAnterior.Name = "lblFaseAnterior";
            this.lblFaseAnterior.Size = new System.Drawing.Size(132, 13);
            this.lblFaseAnterior.TabIndex = 158;
            this.lblFaseAnterior.Text = "¿Tiene Fase Anterior?";
            // 
            // cmbSubcampeon
            // 
            this.cmbSubcampeon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubcampeon.Enabled = false;
            this.cmbSubcampeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubcampeon.FormattingEnabled = true;
            this.cmbSubcampeon.Location = new System.Drawing.Point(549, 283);
            this.cmbSubcampeon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSubcampeon.Name = "cmbSubcampeon";
            this.cmbSubcampeon.Size = new System.Drawing.Size(174, 23);
            this.cmbSubcampeon.TabIndex = 157;
            // 
            // cmbCampeon
            // 
            this.cmbCampeon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampeon.Enabled = false;
            this.cmbCampeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampeon.FormattingEnabled = true;
            this.cmbCampeon.Location = new System.Drawing.Point(174, 285);
            this.cmbCampeon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCampeon.Name = "cmbCampeon";
            this.cmbCampeon.Size = new System.Drawing.Size(174, 23);
            this.cmbCampeon.TabIndex = 156;
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(174, 18);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(240, 23);
            this.cmbEstados.TabIndex = 155;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(55, 23);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(111, 13);
            this.lblEstado.TabIndex = 154;
            this.lblEstado.Text = "Estado del Torneo";
            // 
            // lblSubcampeon
            // 
            this.lblSubcampeon.AutoSize = true;
            this.lblSubcampeon.Location = new System.Drawing.Point(404, 289);
            this.lblSubcampeon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubcampeon.Name = "lblSubcampeon";
            this.lblSubcampeon.Size = new System.Drawing.Size(145, 13);
            this.lblSubcampeon.TabIndex = 153;
            this.lblSubcampeon.Text = "Subcampeón del Torneo";
            // 
            // lblCampeon
            // 
            this.lblCampeon.AutoSize = true;
            this.lblCampeon.Location = new System.Drawing.Point(49, 290);
            this.lblCampeon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCampeon.Name = "lblCampeon";
            this.lblCampeon.Size = new System.Drawing.Size(124, 13);
            this.lblCampeon.TabIndex = 152;
            this.lblCampeon.Text = "Campeón del Torneo";
            // 
            // lbl2doPuesto
            // 
            this.lbl2doPuesto.AutoSize = true;
            this.lbl2doPuesto.Location = new System.Drawing.Point(382, 261);
            this.lbl2doPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2doPuesto.Name = "lbl2doPuesto";
            this.lbl2doPuesto.Size = new System.Drawing.Size(168, 13);
            this.lbl2doPuesto.TabIndex = 151;
            this.lbl2doPuesto.Text = "Puntaje del Segundo Puesto";
            // 
            // cmbPuntajeSegundoPuesto
            // 
            this.cmbPuntajeSegundoPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuntajeSegundoPuesto.Enabled = false;
            this.cmbPuntajeSegundoPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuntajeSegundoPuesto.FormattingEnabled = true;
            this.cmbPuntajeSegundoPuesto.Location = new System.Drawing.Point(549, 255);
            this.cmbPuntajeSegundoPuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPuntajeSegundoPuesto.Name = "cmbPuntajeSegundoPuesto";
            this.cmbPuntajeSegundoPuesto.Size = new System.Drawing.Size(174, 23);
            this.cmbPuntajeSegundoPuesto.TabIndex = 149;
            // 
            // lbl1erPuesto
            // 
            this.lbl1erPuesto.AutoSize = true;
            this.lbl1erPuesto.Location = new System.Drawing.Point(18, 262);
            this.lbl1erPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1erPuesto.Name = "lbl1erPuesto";
            this.lbl1erPuesto.Size = new System.Drawing.Size(153, 13);
            this.lbl1erPuesto.TabIndex = 150;
            this.lbl1erPuesto.Text = "Puntaje del Primer Puesto";
            // 
            // cmbPuntajePrimerPuesto
            // 
            this.cmbPuntajePrimerPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuntajePrimerPuesto.Enabled = false;
            this.cmbPuntajePrimerPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuntajePrimerPuesto.FormattingEnabled = true;
            this.cmbPuntajePrimerPuesto.Location = new System.Drawing.Point(174, 257);
            this.cmbPuntajePrimerPuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPuntajePrimerPuesto.Name = "cmbPuntajePrimerPuesto";
            this.cmbPuntajePrimerPuesto.Size = new System.Drawing.Size(174, 23);
            this.cmbPuntajePrimerPuesto.TabIndex = 148;
            // 
            // cbClasificatorio
            // 
            this.cbClasificatorio.AutoSize = true;
            this.cbClasificatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificatorio.Location = new System.Drawing.Point(175, 171);
            this.cbClasificatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClasificatorio.Name = "cbClasificatorio";
            this.cbClasificatorio.Size = new System.Drawing.Size(85, 17);
            this.cbClasificatorio.TabIndex = 135;
            this.cbClasificatorio.Text = "Clasificatorio";
            this.cbClasificatorio.UseVisualStyleBackColor = true;
            // 
            // cbTCTDobleVuelta
            // 
            this.cbTCTDobleVuelta.AutoSize = true;
            this.cbTCTDobleVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTCTDobleVuelta.Location = new System.Drawing.Point(175, 151);
            this.cbTCTDobleVuelta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTCTDobleVuelta.Name = "cbTCTDobleVuelta";
            this.cbTCTDobleVuelta.Size = new System.Drawing.Size(187, 17);
            this.cbTCTDobleVuelta.TabIndex = 134;
            this.cbTCTDobleVuelta.Text = "Todos Contra Todos Doble Vuelta";
            this.cbTCTDobleVuelta.UseVisualStyleBackColor = true;
            // 
            // cbEliminatoria
            // 
            this.cbEliminatoria.AutoSize = true;
            this.cbEliminatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEliminatoria.Location = new System.Drawing.Point(175, 112);
            this.cbEliminatoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEliminatoria.Name = "cbEliminatoria";
            this.cbEliminatoria.Size = new System.Drawing.Size(79, 17);
            this.cbEliminatoria.TabIndex = 131;
            this.cbEliminatoria.Text = "Eliminatoria";
            this.cbEliminatoria.UseVisualStyleBackColor = true;
            // 
            // cbTCTUnaVuelta
            // 
            this.cbTCTUnaVuelta.AutoSize = true;
            this.cbTCTUnaVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTCTUnaVuelta.Location = new System.Drawing.Point(175, 132);
            this.cbTCTUnaVuelta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTCTUnaVuelta.Name = "cbTCTUnaVuelta";
            this.cbTCTUnaVuelta.Size = new System.Drawing.Size(179, 17);
            this.cbTCTUnaVuelta.TabIndex = 133;
            this.cbTCTUnaVuelta.Text = "Todos Contra Todos Una Vuelta";
            this.cbTCTUnaVuelta.UseVisualStyleBackColor = true;
            // 
            // cmbTiposDeporte
            // 
            this.cmbTiposDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposDeporte.FormattingEnabled = true;
            this.cmbTiposDeporte.Location = new System.Drawing.Point(175, 49);
            this.cmbTiposDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTiposDeporte.Name = "cmbTiposDeporte";
            this.cmbTiposDeporte.Size = new System.Drawing.Size(239, 23);
            this.cmbTiposDeporte.TabIndex = 124;
            // 
            // lblTipoDeporte
            // 
            this.lblTipoDeporte.AutoSize = true;
            this.lblTipoDeporte.Location = new System.Drawing.Point(72, 54);
            this.lblTipoDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDeporte.Name = "lblTipoDeporte";
            this.lblTipoDeporte.Size = new System.Drawing.Size(99, 13);
            this.lblTipoDeporte.TabIndex = 143;
            this.lblTipoDeporte.Text = "Tipo de Deporte";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescripcion.Location = new System.Drawing.Point(549, 18);
            this.rtbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(239, 21);
            this.rtbDescripcion.TabIndex = 126;
            this.rtbDescripcion.Text = "";
            // 
            // lblTipoTorneo
            // 
            this.lblTipoTorneo.AutoSize = true;
            this.lblTipoTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTorneo.Location = new System.Drawing.Point(73, 113);
            this.lblTipoTorneo.Name = "lblTipoTorneo";
            this.lblTipoTorneo.Size = new System.Drawing.Size(94, 13);
            this.lblTipoTorneo.TabIndex = 139;
            this.lblTipoTorneo.Text = "Tipo de Torneo";
            // 
            // dtFechaCierre
            // 
            this.dtFechaCierre.Enabled = false;
            this.dtFechaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCierre.Location = new System.Drawing.Point(549, 105);
            this.dtFechaCierre.Name = "dtFechaCierre";
            this.dtFechaCierre.Size = new System.Drawing.Size(239, 21);
            this.dtFechaCierre.TabIndex = 130;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Location = new System.Drawing.Point(549, 77);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(239, 20);
            this.dtFechaInicio.TabIndex = 129;
            // 
            // cmbDeportes
            // 
            this.cmbDeportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeportes.Enabled = false;
            this.cmbDeportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeportes.FormattingEnabled = true;
            this.cmbDeportes.Location = new System.Drawing.Point(175, 77);
            this.cmbDeportes.Name = "cmbDeportes";
            this.cmbDeportes.Size = new System.Drawing.Size(239, 23);
            this.cmbDeportes.TabIndex = 127;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(117, 84);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(52, 13);
            this.lblDeporte.TabIndex = 128;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(471, 21);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcion.TabIndex = 125;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCierreTorneo
            // 
            this.lblCierreTorneo.AutoSize = true;
            this.lblCierreTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierreTorneo.Location = new System.Drawing.Point(442, 110);
            this.lblCierreTorneo.Name = "lblCierreTorneo";
            this.lblCierreTorneo.Size = new System.Drawing.Size(102, 13);
            this.lblCierreTorneo.TabIndex = 136;
            this.lblCierreTorneo.Text = "Cierre de Torneo";
            // 
            // lblInicioTorneo
            // 
            this.lblInicioTorneo.AutoSize = true;
            this.lblInicioTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioTorneo.Location = new System.Drawing.Point(445, 83);
            this.lblInicioTorneo.Name = "lblInicioTorneo";
            this.lblInicioTorneo.Size = new System.Drawing.Size(100, 13);
            this.lblInicioTorneo.TabIndex = 132;
            this.lblInicioTorneo.Text = "Inicio de Torneo";
            // 
            // ModificarTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 681);
            this.Controls.Add(this.gbTorneos);
            this.Name = "ModificarTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Torneo";
            this.Load += new System.EventHandler(this.ModificarTorneo_Load);
            this.gbTorneos.ResumeLayout(false);
            this.gbTorneos.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTorneos)).EndInit();
            this.gbDatosTorneo.ResumeLayout(false);
            this.gbDatosTorneo.PerformLayout();
            this.gbFase.ResumeLayout(false);
            this.gbFase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTorneos;
        private System.Windows.Forms.GroupBox gbDatosTorneo;
        private System.Windows.Forms.CheckBox cbClasificatorio;
        private System.Windows.Forms.CheckBox cbTCTDobleVuelta;
        private System.Windows.Forms.CheckBox cbEliminatoria;
        private System.Windows.Forms.CheckBox cbTCTUnaVuelta;
        private System.Windows.Forms.ComboBox cmbTiposDeporte;
        private System.Windows.Forms.Label lblTipoDeporte;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblTipoTorneo;
        private System.Windows.Forms.DateTimePicker dtFechaCierre;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.ComboBox cmbDeportes;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCierreTorneo;
        private System.Windows.Forms.Label lblInicioTorneo;
        private System.Windows.Forms.Label lblSubcampeon;
        private System.Windows.Forms.Label lblCampeon;
        private System.Windows.Forms.Label lbl2doPuesto;
        private System.Windows.Forms.ComboBox cmbPuntajeSegundoPuesto;
        private System.Windows.Forms.Label lbl1erPuesto;
        private System.Windows.Forms.ComboBox cmbPuntajePrimerPuesto;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbSubcampeon;
        private System.Windows.Forms.ComboBox cmbCampeon;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Label lblGuardado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbEstadoInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgTorneos;
        private System.Windows.Forms.GroupBox gbFase;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.ComboBox cmbTorneoAnterior;
        private System.Windows.Forms.Label lblFaseAnterior;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.TextBox txtCantParticipantes;
        private System.Windows.Forms.Button btnCalcularCantParticipantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCantidadParticipantesPorClasificatorioO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCantidadParticipantes;
        private System.Windows.Forms.ComboBox cmbClasificadosPorGrupo;
        private System.Windows.Forms.ComboBox cmbParticipantesPorGrupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCantidadGrupos;
        private System.Windows.Forms.Label lblCantidadParticipantes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}