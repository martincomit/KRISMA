namespace UNCDeporte.Admin
{
    partial class ConsultarEliminarDeportistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDeportistas = new System.Windows.Forms.DataGridView();
            this.groupBoxEliminar = new System.Windows.Forms.GroupBox();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.btnBajaATodos = new System.Windows.Forms.Button();
            this.lblAñoInscripcion = new System.Windows.Forms.Label();
            this.txtAñoInscripcion = new System.Windows.Forms.TextBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.cmbDeportes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarDeportista = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbTipoDeporte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportistas)).BeginInit();
            this.groupBoxEliminar.SuspendLayout();
            this.groupBoxConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDeportistas);
            this.panel1.Controls.Add(this.groupBoxEliminar);
            this.panel1.Controls.Add(this.groupBoxConsultar);
            this.panel1.Controls.Add(this.btnTodos);
            this.panel1.Location = new System.Drawing.Point(41, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 560);
            this.panel1.TabIndex = 0;
            // 
            // dgDeportistas
            // 
            this.dgDeportistas.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDeportistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDeportistas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgDeportistas.Location = new System.Drawing.Point(21, 292);
            this.dgDeportistas.Margin = new System.Windows.Forms.Padding(2);
            this.dgDeportistas.Name = "dgDeportistas";
            this.dgDeportistas.ReadOnly = true;
            this.dgDeportistas.RowTemplate.Height = 28;
            this.dgDeportistas.Size = new System.Drawing.Size(1158, 242);
            this.dgDeportistas.TabIndex = 4;
            this.dgDeportistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeportistas_CellContentClick);
            // 
            // groupBoxEliminar
            // 
            this.groupBoxEliminar.Controls.Add(this.cbTodos);
            this.groupBoxEliminar.Controls.Add(this.btnBajaATodos);
            this.groupBoxEliminar.Controls.Add(this.lblAñoInscripcion);
            this.groupBoxEliminar.Controls.Add(this.txtAñoInscripcion);
            this.groupBoxEliminar.Controls.Add(this.cbEliminar);
            this.groupBoxEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEliminar.Location = new System.Drawing.Point(21, 173);
            this.groupBoxEliminar.Name = "groupBoxEliminar";
            this.groupBoxEliminar.Size = new System.Drawing.Size(1159, 114);
            this.groupBoxEliminar.TabIndex = 2;
            this.groupBoxEliminar.TabStop = false;
            this.groupBoxEliminar.Text = "Dar de Baja a Deportista";
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodos.Location = new System.Drawing.Point(10, 50);
            this.cbTodos.Margin = new System.Windows.Forms.Padding(2);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(456, 22);
            this.cbTodos.TabIndex = 5;
            this.cbTodos.Text = "Habilitar la baja de todos los Deportistas del año anterior al actual";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // btnBajaATodos
            // 
            this.btnBajaATodos.Enabled = false;
            this.btnBajaATodos.Location = new System.Drawing.Point(379, 76);
            this.btnBajaATodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnBajaATodos.Name = "btnBajaATodos";
            this.btnBajaATodos.Size = new System.Drawing.Size(325, 30);
            this.btnBajaATodos.TabIndex = 7;
            this.btnBajaATodos.Text = "Dar de Baja a todos los Deportistas";
            this.btnBajaATodos.UseVisualStyleBackColor = true;
            this.btnBajaATodos.Click += new System.EventHandler(this.btnDarBajaATodos_Click);
            // 
            // lblAñoInscripcion
            // 
            this.lblAñoInscripcion.AutoSize = true;
            this.lblAñoInscripcion.Enabled = false;
            this.lblAñoInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoInscripcion.Location = new System.Drawing.Point(29, 83);
            this.lblAñoInscripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñoInscripcion.Name = "lblAñoInscripcion";
            this.lblAñoInscripcion.Size = new System.Drawing.Size(158, 20);
            this.lblAñoInscripcion.TabIndex = 3;
            this.lblAñoInscripcion.Text = "Año de Inscripción";
            // 
            // txtAñoInscripcion
            // 
            this.txtAñoInscripcion.Enabled = false;
            this.txtAñoInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoInscripcion.Location = new System.Drawing.Point(201, 81);
            this.txtAñoInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñoInscripcion.Name = "txtAñoInscripcion";
            this.txtAñoInscripcion.Size = new System.Drawing.Size(50, 24);
            this.txtAñoInscripcion.TabIndex = 6;
            this.txtAñoInscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAñoInscripcion_KeyPress);
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEliminar.Location = new System.Drawing.Point(10, 23);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(214, 22);
            this.cbEliminar.TabIndex = 4;
            this.cbEliminar.Text = "Habilitar botón \"Dar de Baja\'\'";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbBajaDeportistaEspecifico_CheckedChanged);
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.cmbTipoDeporte);
            this.groupBoxConsultar.Controls.Add(this.label3);
            this.groupBoxConsultar.Controls.Add(this.cmbDeportes);
            this.groupBoxConsultar.Controls.Add(this.label2);
            this.groupBoxConsultar.Controls.Add(this.txtDocumento);
            this.groupBoxConsultar.Controls.Add(this.label1);
            this.groupBoxConsultar.Controls.Add(this.btnFiltrarDeportista);
            this.groupBoxConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConsultar.Location = new System.Drawing.Point(13, 0);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(1167, 129);
            this.groupBoxConsultar.TabIndex = 1;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Búsqueda de Deportista";
            // 
            // cmbDeportes
            // 
            this.cmbDeportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeportes.FormattingEnabled = true;
            this.cmbDeportes.Location = new System.Drawing.Point(113, 89);
            this.cmbDeportes.Name = "cmbDeportes";
            this.cmbDeportes.Size = new System.Drawing.Size(279, 28);
            this.cmbDeportes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deporte";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(113, 24);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(280, 24);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento";
            // 
            // btnFiltrarDeportista
            // 
            this.btnFiltrarDeportista.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFiltrarDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarDeportista.Location = new System.Drawing.Point(416, 85);
            this.btnFiltrarDeportista.Name = "btnFiltrarDeportista";
            this.btnFiltrarDeportista.Size = new System.Drawing.Size(105, 34);
            this.btnFiltrarDeportista.TabIndex = 2;
            this.btnFiltrarDeportista.Text = "Buscar";
            this.btnFiltrarDeportista.UseVisualStyleBackColor = true;
            this.btnFiltrarDeportista.Click += new System.EventHandler(this.btnFiltrarDeportista_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(21, 134);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(279, 34);
            this.btnTodos.TabIndex = 3;
            this.btnTodos.Text = "Mostrar todos (De Alta y De Baja)";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1117, 575);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbTipoDeporte
            // 
            this.cmbTipoDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeporte.FormattingEnabled = true;
            this.cmbTipoDeporte.Location = new System.Drawing.Point(113, 55);
            this.cmbTipoDeporte.Name = "cmbTipoDeporte";
            this.cmbTipoDeporte.Size = new System.Drawing.Size(279, 28);
            this.cmbTipoDeporte.TabIndex = 9;
            this.cmbTipoDeporte.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeporte_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TipoDeporte";
            // 
            // ConsultarEliminarDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1233, 607);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarEliminarDeportistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar/Eliminar Deportistas";
            this.Load += new System.EventHandler(this.ConsultarDeportistas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportistas)).EndInit();
            this.groupBoxEliminar.ResumeLayout(false);
            this.groupBoxEliminar.PerformLayout();
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgDeportistas;
        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarDeportista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.Button btnBajaATodos;
        private System.Windows.Forms.Label lblAñoInscripcion;
        private System.Windows.Forms.TextBox txtAñoInscripcion;
        private System.Windows.Forms.ComboBox cmbDeportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDeporte;
        private System.Windows.Forms.Label label3;
    }
}