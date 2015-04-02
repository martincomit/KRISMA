namespace UNCDeporte.Admin
{
    partial class EliminarPersonal
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
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPersonal
            // 
            this.dgPersonal.AllowUserToAddRows = false;
            this.dgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgPersonal.Location = new System.Drawing.Point(40, 42);
            this.dgPersonal.Name = "dgPersonal";
            this.dgPersonal.Size = new System.Drawing.Size(855, 480);
            this.dgPersonal.TabIndex = 3;
            this.dgPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonal_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Eliminar";
            this.Column1.ToolTipText = "Eliminar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // EliminarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 565);
            this.Controls.Add(this.dgPersonal);
            this.Name = "EliminarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarPersonal";
            this.Load += new System.EventHandler(this.EliminarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}