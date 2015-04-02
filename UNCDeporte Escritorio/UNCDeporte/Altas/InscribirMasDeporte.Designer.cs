namespace UNCDeporte.Altas
{
    partial class InscribirMasDeporte
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDeportes = new System.Windows.Forms.GroupBox();
            this.rbRecreativo = new System.Windows.Forms.RadioButton();
            this.rbFederado = new System.Windows.Forms.RadioButton();
            this.dgDeportes = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDeportes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgInscriptos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDeportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscriptos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 58);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Lime;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(398, 16);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 20);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "aprobado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Estado: ";
            // 
            // gbDeportes
            // 
            this.gbDeportes.Controls.Add(this.rbRecreativo);
            this.gbDeportes.Controls.Add(this.rbFederado);
            this.gbDeportes.Controls.Add(this.dgDeportes);
            this.gbDeportes.Controls.Add(this.button1);
            this.gbDeportes.Controls.Add(this.cmbDeportes);
            this.gbDeportes.Controls.Add(this.label2);
            this.gbDeportes.Location = new System.Drawing.Point(23, 243);
            this.gbDeportes.Name = "gbDeportes";
            this.gbDeportes.Size = new System.Drawing.Size(812, 284);
            this.gbDeportes.TabIndex = 36;
            this.gbDeportes.TabStop = false;
            this.gbDeportes.Text = "Inscribir a mas deportes";
            // 
            // rbRecreativo
            // 
            this.rbRecreativo.AutoSize = true;
            this.rbRecreativo.Checked = true;
            this.rbRecreativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecreativo.Location = new System.Drawing.Point(193, 28);
            this.rbRecreativo.Name = "rbRecreativo";
            this.rbRecreativo.Size = new System.Drawing.Size(103, 24);
            this.rbRecreativo.TabIndex = 17;
            this.rbRecreativo.TabStop = true;
            this.rbRecreativo.Text = "Recreativo";
            this.rbRecreativo.UseVisualStyleBackColor = true;
            this.rbRecreativo.CheckedChanged += new System.EventHandler(this.rbRecreativo_CheckedChanged);
            // 
            // rbFederado
            // 
            this.rbFederado.AutoSize = true;
            this.rbFederado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFederado.Location = new System.Drawing.Point(102, 28);
            this.rbFederado.Name = "rbFederado";
            this.rbFederado.Size = new System.Drawing.Size(96, 24);
            this.rbFederado.TabIndex = 16;
            this.rbFederado.Text = "Federado";
            this.rbFederado.UseVisualStyleBackColor = true;
            this.rbFederado.CheckedChanged += new System.EventHandler(this.rbFederado_CheckedChanged);
            // 
            // dgDeportes
            // 
            this.dgDeportes.AllowUserToAddRows = false;
            this.dgDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Nombre,
            this.tipo,
            this.id_deporte});
            this.dgDeportes.Location = new System.Drawing.Point(302, 28);
            this.dgDeportes.Name = "dgDeportes";
            this.dgDeportes.Size = new System.Drawing.Size(497, 232);
            this.dgDeportes.TabIndex = 15;
            this.dgDeportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeportes_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Quitar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Quitar";
            this.Seleccionar.ToolTipText = "Quitar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            // 
            // id_deporte
            // 
            this.id_deporte.HeaderText = "id_deporte";
            this.id_deporte.Name = "id_deporte";
            this.id_deporte.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDeportes
            // 
            this.cmbDeportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeportes.FormattingEnabled = true;
            this.cmbDeportes.Location = new System.Drawing.Point(21, 62);
            this.cmbDeportes.Name = "cmbDeportes";
            this.cmbDeportes.Size = new System.Drawing.Size(258, 28);
            this.cmbDeportes.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deportes";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(729, 534);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 31);
            this.button6.TabIndex = 35;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(23, 533);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 31);
            this.button5.TabIndex = 34;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgInscriptos
            // 
            this.dgInscriptos.AllowUserToAddRows = false;
            this.dgInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInscriptos.Location = new System.Drawing.Point(302, 13);
            this.dgInscriptos.Name = "dgInscriptos";
            this.dgInscriptos.Size = new System.Drawing.Size(503, 113);
            this.dgInscriptos.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgInscriptos);
            this.groupBox2.Location = new System.Drawing.Point(23, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 145);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Documento: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(123, 16);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(92, 20);
            this.lblDocumento.TabIndex = 25;
            this.lblDocumento.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Deportes Inscriptos";
            // 
            // InscribirMasDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDeportes);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Name = "InscribirMasDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscribirMasDeporte";
            this.Load += new System.EventHandler(this.InscribirMasDeporte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDeportes.ResumeLayout(false);
            this.gbDeportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscriptos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDeportes;
        private System.Windows.Forms.RadioButton rbRecreativo;
        private System.Windows.Forms.RadioButton rbFederado;
        private System.Windows.Forms.DataGridView dgDeportes;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_deporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDeportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInscriptos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}