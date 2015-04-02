namespace UNCDeporte.Admin
{
    partial class EliminarLocalidades
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
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgLocalidades = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Eliminar";
            this.Column1.ToolTipText = "Eliminar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // dgLocalidades
            // 
            this.dgLocalidades.AllowUserToAddRows = false;
            this.dgLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgLocalidades.Location = new System.Drawing.Point(64, 40);
            this.dgLocalidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgLocalidades.Name = "dgLocalidades";
            this.dgLocalidades.RowTemplate.Height = 28;
            this.dgLocalidades.Size = new System.Drawing.Size(615, 389);
            this.dgLocalidades.TabIndex = 0;
            this.dgLocalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocalidades_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(324, 452);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 39);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EliminarLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 531);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgLocalidades);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Localidades";
            this.Load += new System.EventHandler(this.EliminarLocalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridView dgLocalidades;
        private System.Windows.Forms.Button btnSalir;

    }
}