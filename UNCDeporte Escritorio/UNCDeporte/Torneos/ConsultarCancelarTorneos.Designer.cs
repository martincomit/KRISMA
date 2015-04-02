namespace UNCDeporte.Torneos
{
    partial class ConsultaryEliminarTorneos
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
            this.button3 = new System.Windows.Forms.Button();
            this.cmbTiposDeporte = new System.Windows.Forms.ComboBox();
            this.lblTipoDeporte = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbDeportes = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.dgTorneos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTorneos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cmbTiposDeporte);
            this.groupBox1.Controls.Add(this.lblTipoDeporte);
            this.groupBox1.Controls.Add(this.cmbEstados);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.cmbDeportes);
            this.groupBox1.Controls.Add(this.lblDeporte);
            this.groupBox1.Location = new System.Drawing.Point(263, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(763, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(515, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbTiposDeporte
            // 
            this.cmbTiposDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposDeporte.FormattingEnabled = true;
            this.cmbTiposDeporte.Location = new System.Drawing.Point(168, 22);
            this.cmbTiposDeporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTiposDeporte.Name = "cmbTiposDeporte";
            this.cmbTiposDeporte.Size = new System.Drawing.Size(276, 28);
            this.cmbTiposDeporte.TabIndex = 5;
            this.cmbTiposDeporte.SelectedIndexChanged += new System.EventHandler(this.cmbTiposDeporte_SelectedIndexChanged);
            this.cmbTiposDeporte.Click += new System.EventHandler(this.cmbTiposDeporte_Click);
            // 
            // lblTipoDeporte
            // 
            this.lblTipoDeporte.AutoSize = true;
            this.lblTipoDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeporte.Location = new System.Drawing.Point(14, 25);
            this.lblTipoDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDeporte.Name = "lblTipoDeporte";
            this.lblTipoDeporte.Size = new System.Drawing.Size(138, 20);
            this.lblTipoDeporte.TabIndex = 4;
            this.lblTipoDeporte.Text = "Tipo de Deporte";
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(168, 110);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(276, 28);
            this.cmbEstados.TabIndex = 3;
            this.cmbEstados.Click += new System.EventHandler(this.cmbEstados_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(86, 115);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // cmbDeportes
            // 
            this.cmbDeportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeportes.Enabled = false;
            this.cmbDeportes.FormattingEnabled = true;
            this.cmbDeportes.Location = new System.Drawing.Point(168, 67);
            this.cmbDeportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDeportes.Name = "cmbDeportes";
            this.cmbDeportes.Size = new System.Drawing.Size(276, 28);
            this.cmbDeportes.TabIndex = 1;
            this.cmbDeportes.Click += new System.EventHandler(this.cmbDeportes_Click);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(78, 71);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(74, 20);
            this.lblDeporte.TabIndex = 0;
            this.lblDeporte.Text = "Deporte";
            // 
            // dgTorneos
            // 
            this.dgTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTorneos.Location = new System.Drawing.Point(66, 202);
            this.dgTorneos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgTorneos.Name = "dgTorneos";
            this.dgTorneos.Size = new System.Drawing.Size(960, 360);
            this.dgTorneos.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEliminar);
            this.groupBox2.Location = new System.Drawing.Point(71, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(175, 158);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEliminar.Location = new System.Drawing.Point(45, 65);
            this.cbEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(106, 24);
            this.cbEliminar.TabIndex = 9;
            this.cbEliminar.Text = "Cancelar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(914, 588);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSalir);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(66, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cargar Ranking";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConsultaryEliminarTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 649);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgTorneos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultaryEliminarTorneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Torneos";
            this.Load += new System.EventHandler(this.ConsultaryEliminarTorneos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTorneos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbDeportes;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.DataGridView dgTorneos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTiposDeporte;
        private System.Windows.Forms.Label lblTipoDeporte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}