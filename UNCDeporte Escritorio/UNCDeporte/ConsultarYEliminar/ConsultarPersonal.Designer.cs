namespace UNCDeporte.Interfaz.Admin
{
    partial class ConsultarPersonal
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
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.btnFiltrarDeportista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.panelConsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.groupBox1);
            this.panelConsulta.Controls.Add(this.gbFiltro);
            this.panelConsulta.Controls.Add(this.dgPersonal);
            this.panelConsulta.Location = new System.Drawing.Point(3, 12);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(1013, 401);
            this.panelConsulta.TabIndex = 7;
            this.panelConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsulta_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEliminar);
            this.groupBox1.Location = new System.Drawing.Point(22, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 97);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(13, 29);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 9;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.button1);
            this.gbFiltro.Controls.Add(this.txtDocumento);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.cmbLocalidades);
            this.gbFiltro.Controls.Add(this.btnFiltrarDeportista);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Location = new System.Drawing.Point(113, 3);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(881, 97);
            this.gbFiltro.TabIndex = 8;
            this.gbFiltro.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(759, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(127, 22);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(195, 29);
            this.txtDocumento.TabIndex = 7;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Documento";
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(522, 18);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(210, 28);
            this.cmbLocalidades.TabIndex = 5;
            // 
            // btnFiltrarDeportista
            // 
            this.btnFiltrarDeportista.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFiltrarDeportista.Location = new System.Drawing.Point(759, 16);
            this.btnFiltrarDeportista.Name = "btnFiltrarDeportista";
            this.btnFiltrarDeportista.Size = new System.Drawing.Size(105, 32);
            this.btnFiltrarDeportista.TabIndex = 4;
            this.btnFiltrarDeportista.Text = "Buscar";
            this.btnFiltrarDeportista.UseVisualStyleBackColor = true;
            this.btnFiltrarDeportista.Click += new System.EventHandler(this.btnFiltrarDeportista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localidad";
            // 
            // dgPersonal
            // 
            this.dgPersonal.AllowUserToAddRows = false;
            this.dgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonal.Location = new System.Drawing.Point(22, 105);
            this.dgPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.dgPersonal.Name = "dgPersonal";
            this.dgPersonal.RowTemplate.Height = 28;
            this.dgPersonal.Size = new System.Drawing.Size(972, 272);
            this.dgPersonal.TabIndex = 1;
            this.dgPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonal_CellContentClick);
            // 
            // ConsultarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.panelConsulta);
            this.Name = "ConsultarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Personal";
            this.Load += new System.EventHandler(this.ConsultarProfesores_Load);
            this.panelConsulta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Button btnFiltrarDeportista;
        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}