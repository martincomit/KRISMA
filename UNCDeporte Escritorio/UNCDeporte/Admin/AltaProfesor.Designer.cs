namespace UNCDeporte.Interfaz.Admin
{
    partial class AltaProfesor
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdproyectoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
        
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDeporte = new System.Windows.Forms.ComboBox();
            this.deportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.bdproyectoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdproyectoDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbCategoriaDeporte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyectoDataSetBindingSource)).BeginInit();
  
            ((System.ComponentModel.ISupportInitialize)(this.deportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyectoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyectoDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Localidad";
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(173, 175);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(146, 21);
            this.cmbLocalidades.TabIndex = 29;
            this.cmbLocalidades.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "Localidades";
            this.localidadesBindingSource.DataSource = this.bdproyectoDataSetBindingSource;
            // 
            // bdproyectoDataSetBindingSource
            // 
       
            this.bdproyectoDataSetBindingSource.Position = 0;
            // 
            // bd_proyectoDataSet
            // 
         
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "EMAIL";
            // 
            // lblGuardado
            // 
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Location = new System.Drawing.Point(171, 343);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(54, 13);
            this.lblGuardado.TabIndex = 25;
            this.lblGuardado.Text = "Guardado";
            this.lblGuardado.Visible = false;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(174, 137);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(147, 20);
            this.txtFechaNacimiento.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(339, 60);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(147, 20);
            this.txtNombre2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(174, 100);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Deporte";
            // 
            // cmbDeporte
            // 
            this.cmbDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeporte.FormattingEnabled = true;
            this.cmbDeporte.Location = new System.Drawing.Point(174, 215);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(146, 21);
            this.cmbDeporte.TabIndex = 31;
            this.cmbDeporte.SelectedIndexChanged += new System.EventHandler(this.cmbDeporte_SelectedIndexChanged);
            // 
            // deportesBindingSource
            // 
            this.deportesBindingSource.DataMember = "Deportes";
            // 
            // localidadesTableAdapter
            // 
     
            // 
            // bdproyectoDataSetBindingSource1
            // 
      
            this.bdproyectoDataSetBindingSource1.Position = 0;
            // 
            // bdproyectoDataSetBindingSource2
            // 
     
            this.bdproyectoDataSetBindingSource2.Position = 0;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(174, 24);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(147, 20);
            this.txtDNI.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "DNI";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(174, 249);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(147, 20);
            this.txtTel.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefono";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbCategoriaDeporte
            // 
            this.cmbCategoriaDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaDeporte.FormattingEnabled = true;
            this.cmbCategoriaDeporte.Location = new System.Drawing.Point(378, 215);
            this.cmbCategoriaDeporte.Name = "cmbCategoriaDeporte";
            this.cmbCategoriaDeporte.Size = new System.Drawing.Size(125, 21);
            this.cmbCategoriaDeporte.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Categoria";
            // 
            // AltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 375);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCategoriaDeporte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDeporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGuardado);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaProfesor";
            this.Load += new System.EventHandler(this.AltaProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyectoDataSetBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.deportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyectoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyectoDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGuardado;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDeporte;
        private System.Windows.Forms.BindingSource bdproyectoDataSetBindingSource;
      
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        
        private System.Windows.Forms.BindingSource bdproyectoDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bdproyectoDataSetBindingSource2;
       
        private System.Windows.Forms.BindingSource deportesBindingSource;
       
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbCategoriaDeporte;
        private System.Windows.Forms.Label label9;
    }
}