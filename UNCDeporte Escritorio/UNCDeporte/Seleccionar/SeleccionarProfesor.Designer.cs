namespace UNCDeporte.Admin
{
    partial class SeleccionarProfesor
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
            this.dgProfesores = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProfesores
            // 
            this.dgProfesores.AllowUserToAddRows = false;
            this.dgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgProfesores.Location = new System.Drawing.Point(23, 44);
            this.dgProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.dgProfesores.Name = "dgProfesores";
            this.dgProfesores.RowTemplate.Height = 28;
            this.dgProfesores.Size = new System.Drawing.Size(972, 425);
            this.dgProfesores.TabIndex = 3;
            this.dgProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesores_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.ToolTipText = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // SeleccionarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 574);
            this.Controls.Add(this.dgProfesores);
            this.Name = "SeleccionarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarProfesor";
            this.Load += new System.EventHandler(this.SeleccionarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProfesores;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}