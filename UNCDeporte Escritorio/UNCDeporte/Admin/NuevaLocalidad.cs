using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;


namespace UNCDeporte.Interfaz.Admin
{
    public partial class NuevaLocalidad : Form
    {
        string sql = "";
        string guardado = "";
        

        public NuevaLocalidad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de localidad");
                return;
            }



            GestorLocalidad gl = new GestorLocalidad();


            guardado = gl.Registrar(txtNombre.Text);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                return;
            }
           
            if(guardado=="Existe"){
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                return;
            }
            
             if(guardado=="Error al Guardar")
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, error de escritura";
                txtNombre.Text = "";
                return;
             }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

    
        }

     
    
}
