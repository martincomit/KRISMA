namespace UNCDeporte.Admin
{
    partial class EliminarDeporte
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
            this.dgDeportes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDeportes
            // 
            this.dgDeportes.AllowUserToAddRows = false;
            this.dgDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgDeportes.Location = new System.Drawing.Point(114, 43);
            this.dgDeportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgDeportes.Name = "dgDeportes";
            this.dgDeportes.Size = new System.Drawing.Size(810, 602);
            this.dgDeportes.TabIndex = 1;
            this.dgDeportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeportes_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Eliminar";
            this.Column1.ToolTipText = "Eliminar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // EliminarDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 729);
            this.Controls.Add(this.dgDeportes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Deporte";
            this.Load += new System.EventHandler(this.EliminarDeporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDeportes;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}