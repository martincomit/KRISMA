namespace UNCDeporte.Interfaz.Admin
{
    partial class ModificarLugarDePractica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_datosAModificar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.dg_LugarPractica = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_datosModificados = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDireccionNueva = new System.Windows.Forms.TextBox();
            this.lblDireccionNueva = new System.Windows.Forms.Label();
            this.cmbBarrioNuevo = new System.Windows.Forms.ComboBox();
            this.cmbLocalidadNueva = new System.Windows.Forms.ComboBox();
            this.txtDescripcionNueva = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblBarrioNuevo = new System.Windows.Forms.Label();
            this.lblLocalidadNueva = new System.Windows.Forms.Label();
            this.lblDescripcionNueva = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.gb_datosAModificar.SuspendLayout();
            this.gb_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LugarPractica)).BeginInit();
            this.gb_datosModificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_datosAModificar
            // 
            this.gb_datosAModificar.Controls.Add(this.btnBuscar);
            this.gb_datosAModificar.Controls.Add(this.cmbLocalidades);
            this.gb_datosAModificar.Controls.Add(this.txtNombre);
            this.gb_datosAModificar.Controls.Add(this.label3);
            this.gb_datosAModificar.Controls.Add(this.label1);
            this.gb_datosAModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datosAModificar.Location = new System.Drawing.Point(12, 12);
            this.gb_datosAModificar.Name = "gb_datosAModificar";
            this.gb_datosAModificar.Size = new System.Drawing.Size(677, 56);
            this.gb_datosAModificar.TabIndex = 2;
            this.gb_datosAModificar.TabStop = false;
            this.gb_datosAModificar.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(570, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(367, 19);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(161, 21);
            this.cmbLocalidades.TabIndex = 2;
            this.cmbLocalidades.Click += new System.EventHandler(this.cmbLocalidades_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(109, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.dg_LugarPractica);
            this.gb_Consulta.Location = new System.Drawing.Point(12, 68);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(677, 236);
            this.gb_Consulta.TabIndex = 3;
            this.gb_Consulta.TabStop = false;
            this.gb_Consulta.Text = "Lugares de Práctica";
            // 
            // dg_LugarPractica
            // 
            this.dg_LugarPractica.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_LugarPractica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_LugarPractica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_LugarPractica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_LugarPractica.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_LugarPractica.Location = new System.Drawing.Point(5, 19);
            this.dg_LugarPractica.Name = "dg_LugarPractica";
            this.dg_LugarPractica.ReadOnly = true;
            this.dg_LugarPractica.RowTemplate.Height = 28;
            this.dg_LugarPractica.Size = new System.Drawing.Size(663, 197);
            this.dg_LugarPractica.TabIndex = 4;
            this.dg_LugarPractica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // gb_datosModificados
            // 
            this.gb_datosModificados.Controls.Add(this.label6);
            this.gb_datosModificados.Controls.Add(this.label5);
            this.gb_datosModificados.Controls.Add(this.txtID);
            this.gb_datosModificados.Controls.Add(this.txtDireccionNueva);
            this.gb_datosModificados.Controls.Add(this.lblDireccionNueva);
            this.gb_datosModificados.Controls.Add(this.cmbBarrioNuevo);
            this.gb_datosModificados.Controls.Add(this.cmbLocalidadNueva);
            this.gb_datosModificados.Controls.Add(this.txtDescripcionNueva);
            this.gb_datosModificados.Controls.Add(this.txtNombreNuevo);
            this.gb_datosModificados.Controls.Add(this.lblBarrioNuevo);
            this.gb_datosModificados.Controls.Add(this.lblLocalidadNueva);
            this.gb_datosModificados.Controls.Add(this.lblDescripcionNueva);
            this.gb_datosModificados.Controls.Add(this.lblNombreNuevo);
            this.gb_datosModificados.Enabled = false;
            this.gb_datosModificados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datosModificados.Location = new System.Drawing.Point(12, 310);
            this.gb_datosModificados.Name = "gb_datosModificados";
            this.gb_datosModificados.Size = new System.Drawing.Size(677, 200);
            this.gb_datosModificados.TabIndex = 4;
            this.gb_datosModificados.TabStop = false;
            this.gb_datosModificados.Text = "Lugar de Práctica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "*";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(456, 34);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(21, 20);
            this.txtID.TabIndex = 30;
            this.txtID.Visible = false;
            // 
            // txtDireccionNueva
            // 
            this.txtDireccionNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionNueva.Location = new System.Drawing.Point(273, 102);
            this.txtDireccionNueva.Name = "txtDireccionNueva";
            this.txtDireccionNueva.Size = new System.Drawing.Size(154, 20);
            this.txtDireccionNueva.TabIndex = 7;
            // 
            // lblDireccionNueva
            // 
            this.lblDireccionNueva.AutoSize = true;
            this.lblDireccionNueva.Location = new System.Drawing.Point(211, 105);
            this.lblDireccionNueva.Name = "lblDireccionNueva";
            this.lblDireccionNueva.Size = new System.Drawing.Size(61, 13);
            this.lblDireccionNueva.TabIndex = 29;
            this.lblDireccionNueva.Text = "Dirección";
            // 
            // cmbBarrioNuevo
            // 
            this.cmbBarrioNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrioNuevo.FormattingEnabled = true;
            this.cmbBarrioNuevo.Location = new System.Drawing.Point(273, 166);
            this.cmbBarrioNuevo.Name = "cmbBarrioNuevo";
            this.cmbBarrioNuevo.Size = new System.Drawing.Size(154, 21);
            this.cmbBarrioNuevo.TabIndex = 9;
            // 
            // cmbLocalidadNueva
            // 
            this.cmbLocalidadNueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidadNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidadNueva.FormattingEnabled = true;
            this.cmbLocalidadNueva.Location = new System.Drawing.Point(273, 134);
            this.cmbLocalidadNueva.Name = "cmbLocalidadNueva";
            this.cmbLocalidadNueva.Size = new System.Drawing.Size(154, 21);
            this.cmbLocalidadNueva.TabIndex = 8;
            this.cmbLocalidadNueva.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidadNueva_SelectedIndexChanged);
            // 
            // txtDescripcionNueva
            // 
            this.txtDescripcionNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionNueva.Location = new System.Drawing.Point(273, 68);
            this.txtDescripcionNueva.Name = "txtDescripcionNueva";
            this.txtDescripcionNueva.Size = new System.Drawing.Size(154, 20);
            this.txtDescripcionNueva.TabIndex = 6;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevo.Location = new System.Drawing.Point(273, 34);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(154, 20);
            this.txtNombreNuevo.TabIndex = 5;
            // 
            // lblBarrioNuevo
            // 
            this.lblBarrioNuevo.AutoSize = true;
            this.lblBarrioNuevo.Location = new System.Drawing.Point(231, 170);
            this.lblBarrioNuevo.Name = "lblBarrioNuevo";
            this.lblBarrioNuevo.Size = new System.Drawing.Size(40, 13);
            this.lblBarrioNuevo.TabIndex = 22;
            this.lblBarrioNuevo.Text = "Barrio";
            // 
            // lblLocalidadNueva
            // 
            this.lblLocalidadNueva.AutoSize = true;
            this.lblLocalidadNueva.Location = new System.Drawing.Point(211, 139);
            this.lblLocalidadNueva.Name = "lblLocalidadNueva";
            this.lblLocalidadNueva.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidadNueva.TabIndex = 21;
            this.lblLocalidadNueva.Text = "Localidad";
            // 
            // lblDescripcionNueva
            // 
            this.lblDescripcionNueva.AutoSize = true;
            this.lblDescripcionNueva.Location = new System.Drawing.Point(199, 71);
            this.lblDescripcionNueva.Name = "lblDescripcionNueva";
            this.lblDescripcionNueva.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcionNueva.TabIndex = 20;
            this.lblDescripcionNueva.Text = "Descripción";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(221, 37);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(50, 13);
            this.lblNombreNuevo.TabIndex = 19;
            this.lblNombreNuevo.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(445, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(127, 519);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblGuardado
            // 
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Location = new System.Drawing.Point(211, 524);
            this.lblGuardado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(54, 13);
            this.lblGuardado.TabIndex = 39;
            this.lblGuardado.Text = "Guardado";
            // 
            // ModificarLugarDePractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(701, 554);
            this.Controls.Add(this.lblGuardado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gb_datosModificados);
            this.Controls.Add(this.gb_Consulta);
            this.Controls.Add(this.gb_datosAModificar);
            this.Name = "ModificarLugarDePractica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Lugar De Práctica";
            this.Load += new System.EventHandler(this.ModificarLugarDePractica_Load);
            this.gb_datosAModificar.ResumeLayout(false);
            this.gb_datosAModificar.PerformLayout();
            this.gb_Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_LugarPractica)).EndInit();
            this.gb_datosModificados.ResumeLayout(false);
            this.gb_datosModificados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datosAModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.GroupBox gb_datosModificados;
        private System.Windows.Forms.TextBox txtDireccionNueva;
        private System.Windows.Forms.Label lblDireccionNueva;
        private System.Windows.Forms.ComboBox cmbBarrioNuevo;
        private System.Windows.Forms.ComboBox cmbLocalidadNueva;
        private System.Windows.Forms.TextBox txtDescripcionNueva;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label lblBarrioNuevo;
        private System.Windows.Forms.Label lblLocalidadNueva;
        private System.Windows.Forms.Label lblDescripcionNueva;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblGuardado;
        private System.Windows.Forms.DataGridView dg_LugarPractica;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}