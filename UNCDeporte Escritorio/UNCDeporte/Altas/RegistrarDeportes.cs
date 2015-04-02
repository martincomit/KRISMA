using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class RegistrarDeportes : Form
    {
        string guardado = "";

        public RegistrarDeportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de deporte");
                return;
            }


            GestorDeporte gd = new GestorDeporte();
            int codSanaviron;
            if (txtSanaviron.Text == "")
                codSanaviron = 0;
            else
            codSanaviron = int.Parse(txtSanaviron.Text);

            guardado = gd.Registrar(txtNombre.Text, txtDescripcion.Text, codSanaviron);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtSanaviron.Text = "";


                DialogResult res;
                res = MessageBox.Show("“¿Quiere registrar planificacion de deporte?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    ProgramaActividades form = new ProgramaActividades();
                    form.Show();
                }


            }


            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtSanaviron.Text = "";
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;

                lblGuardado.Text = "No Guardado, error de escritura";
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtSanaviron.Text = "";
                return;


            }
        }

        private void txtSanaviron_KeyPress_1(object sender, KeyPressEventArgs e)
        {
             int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void RegistrarDeportes_Load(object sender, EventArgs e)
        {

        }

        private void txtSanaviron_TextChanged(object sender, EventArgs e)
        {

        }
        

        

    }
}
