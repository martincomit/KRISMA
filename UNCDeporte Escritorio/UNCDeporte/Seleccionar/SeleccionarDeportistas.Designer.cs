namespace UNCDeporte.Admin
{
    partial class SeleccionarDeportistas
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
            this.dgDeportistas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDeportistas
            // 
            this.dgDeportistas.AllowUserToAddRows = false;
            this.dgDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgDeportistas.Location = new System.Drawing.Point(12, 24);
            this.dgDeportistas.Name = "dgDeportistas";
            this.dgDeportistas.Size = new System.Drawing.Size(1257, 483);
            this.dgDeportistas.TabIndex = 0;
            this.dgDeportistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeportistas_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.ToolTipText = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // SeleccionarDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 582);
            this.Controls.Add(this.dgDeportistas);
            this.Name = "SeleccionarDeportistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Deportistas";
            this.Load += new System.EventHandler(this.ConsultarDeportistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeportistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDeportistas;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}