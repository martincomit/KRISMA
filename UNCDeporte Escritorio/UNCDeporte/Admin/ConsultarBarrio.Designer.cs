namespace UNCDeporte.Admin
{
    partial class ConsultarBarrio
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
            this.dgBarrio = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBarrio
            // 
            this.dgBarrio.AllowUserToAddRows = false;
            this.dgBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBarrio.Location = new System.Drawing.Point(47, 31);
            this.dgBarrio.Name = "dgBarrio";
            this.dgBarrio.RowTemplate.Height = 28;
            this.dgBarrio.Size = new System.Drawing.Size(428, 304);
            this.dgBarrio.TabIndex = 0;
            this.dgBarrio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBarrio_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(353, 346);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 26);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 383);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgBarrio);
            this.Name = "ConsultarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Barrios";
            this.Load += new System.EventHandler(this.ConsultarBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBarrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBarrio;
        private System.Windows.Forms.Button btnSalir;
    }
}