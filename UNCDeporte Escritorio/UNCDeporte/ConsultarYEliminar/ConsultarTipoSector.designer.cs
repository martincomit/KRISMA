namespace UNCDeporte.Admin
{
    partial class ConsultarTipoSector
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
            this.dg_tipo_sector = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tipo_sector)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_tipo_sector
            // 
            this.dg_tipo_sector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tipo_sector.Location = new System.Drawing.Point(18, 8);
            this.dg_tipo_sector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_tipo_sector.Name = "dg_tipo_sector";
            this.dg_tipo_sector.ReadOnly = true;
            this.dg_tipo_sector.RowTemplate.Height = 28;
            this.dg_tipo_sector.Size = new System.Drawing.Size(263, 259);
            this.dg_tipo_sector.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(115, 280);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 22);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultarTipoSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 310);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dg_tipo_sector);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarTipoSector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tipos de Sector";
            this.Load += new System.EventHandler(this.ConsultarTipoSector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tipo_sector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_tipo_sector;
        private System.Windows.Forms.Button btnSalir;
    }
}