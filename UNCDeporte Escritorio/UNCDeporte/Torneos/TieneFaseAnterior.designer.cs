namespace UNCDeporte.TorneosYEventos
{
    partial class TieneFaseAnterior
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
            this.cmbTorneos = new System.Windows.Forms.ComboBox();
            this.lblFaseAnterior = new System.Windows.Forms.Label();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.gbFase = new System.Windows.Forms.GroupBox();
            this.gbFase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTorneos
            // 
            this.cmbTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneos.Enabled = false;
            this.cmbTorneos.FormattingEnabled = true;
            this.cmbTorneos.Location = new System.Drawing.Point(241, 17);
            this.cmbTorneos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTorneos.Name = "cmbTorneos";
            this.cmbTorneos.Size = new System.Drawing.Size(143, 21);
            this.cmbTorneos.TabIndex = 100;
            this.cmbTorneos.Visible = false;
            this.cmbTorneos.SelectedIndexChanged += new System.EventHandler(this.cmbTorneos_SelectedIndexChanged);
            this.cmbTorneos.Click += new System.EventHandler(this.cmbTorneos_Click);
            // 
            // lblFaseAnterior
            // 
            this.lblFaseAnterior.AutoSize = true;
            this.lblFaseAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaseAnterior.Location = new System.Drawing.Point(22, 22);
            this.lblFaseAnterior.Name = "lblFaseAnterior";
            this.lblFaseAnterior.Size = new System.Drawing.Size(132, 13);
            this.lblFaseAnterior.TabIndex = 97;
            this.lblFaseAnterior.Text = "¿Tiene Fase Anterior?";
            // 
            // lblGuardado
            // 
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Location = new System.Drawing.Point(143, 85);
            this.lblGuardado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(54, 13);
            this.lblGuardado.TabIndex = 106;
            this.lblGuardado.Text = "Guardado";
            this.lblGuardado.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(273, 81);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 23);
            this.btnSalir.TabIndex = 105;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(25, 81);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 23);
            this.btnGuardar.TabIndex = 104;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(4, 13);
            this.rbSi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(23, 11);
            this.rbSi.TabIndex = 107;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(4, 32);
            this.rbNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(26, 11);
            this.rbNo.TabIndex = 108;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbFase
            // 
            this.gbFase.Controls.Add(this.rbNo);
            this.gbFase.Controls.Add(this.rbSi);
            this.gbFase.Location = new System.Drawing.Point(157, 8);
            this.gbFase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFase.Name = "gbFase";
            this.gbFase.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFase.Size = new System.Drawing.Size(55, 59);
            this.gbFase.TabIndex = 109;
            this.gbFase.TabStop = false;
            // 
            // TieneFaseAnterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 123);
            this.Controls.Add(this.gbFase);
            this.Controls.Add(this.lblGuardado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTorneos);
            this.Controls.Add(this.lblFaseAnterior);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TieneFaseAnterior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Torneo";
            this.Load += new System.EventHandler(this.TieneFaseAnterior_Load);
            this.gbFase.ResumeLayout(false);
            this.gbFase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTorneos;
        private System.Windows.Forms.Label lblFaseAnterior;
        private System.Windows.Forms.Label lblGuardado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.GroupBox gbFase;
    }
}