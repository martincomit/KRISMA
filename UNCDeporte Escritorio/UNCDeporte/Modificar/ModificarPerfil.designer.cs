namespace UNCDeporte.Admin
{
    partial class ModificarPerfil
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
            this.dgPerfiles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgAgregados = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgPermisos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPermisos)).BeginInit();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPerfiles
            // 
            this.dgPerfiles.AllowUserToAddRows = false;
            this.dgPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgPerfiles.Location = new System.Drawing.Point(16, 19);
            this.dgPerfiles.Name = "dgPerfiles";
            this.dgPerfiles.Size = new System.Drawing.Size(626, 160);
            this.dgPerfiles.TabIndex = 3;
            this.dgPerfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerfiles_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccionar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Seleccionar";
            this.Column1.ToolTipText = "Seleccionar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // lblGuardado
            // 
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardado.Location = new System.Drawing.Point(185, 365);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(81, 20);
            this.lblGuardado.TabIndex = 23;
            this.lblGuardado.Text = "Guardado";
            this.lblGuardado.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 41);
            this.button3.TabIndex = 21;
            this.button3.Text = "Guardar Cambios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(404, 242);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(110, 35);
            this.btnQuitar.TabIndex = 20;
            this.btnQuitar.Text = "<< Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(404, 170);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar >>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgAgregados
            // 
            this.dgAgregados.AllowUserToAddRows = false;
            this.dgAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgAgregados.Location = new System.Drawing.Point(522, 96);
            this.dgAgregados.Name = "dgAgregados";
            this.dgAgregados.Size = new System.Drawing.Size(459, 247);
            this.dgAgregados.TabIndex = 18;
            this.dgAgregados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAgregados_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Text = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            // 
            // dgPermisos
            // 
            this.dgPermisos.AllowUserToAddRows = false;
            this.dgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgPermisos.Location = new System.Drawing.Point(10, 96);
            this.dgPermisos.Name = "dgPermisos";
            this.dgPermisos.Size = new System.Drawing.Size(388, 247);
            this.dgPermisos.TabIndex = 17;
            this.dgPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPermisos_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.ToolTipText = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(168, 51);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(279, 26);
            this.txtDescripcion.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(168, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnModificar);
            this.gb1.Controls.Add(this.dgPerfiles);
            this.gb1.Location = new System.Drawing.Point(12, 4);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(1004, 235);
            this.gb1.TabIndex = 24;
            this.gb1.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(16, 185);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.button2);
            this.gb2.Controls.Add(this.button1);
            this.gb2.Controls.Add(this.lblGuardado);
            this.gb2.Controls.Add(this.button3);
            this.gb2.Controls.Add(this.btnQuitar);
            this.gb2.Controls.Add(this.btnAgregar);
            this.gb2.Controls.Add(this.dgAgregados);
            this.gb2.Controls.Add(this.dgPermisos);
            this.gb2.Controls.Add(this.txtDescripcion);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.txtNombre);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Enabled = false;
            this.gb2.Location = new System.Drawing.Point(12, 245);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(1004, 404);
            this.gb2.TabIndex = 25;
            this.gb2.TabStop = false;
            this.gb2.Enter += new System.EventHandler(this.gb2_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(880, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(735, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ModificarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "ModificarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Perfil";
            this.Load += new System.EventHandler(this.ModificarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPermisos)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPerfiles;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label lblGuardado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgAgregados;
        private System.Windows.Forms.DataGridView dgPermisos;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}