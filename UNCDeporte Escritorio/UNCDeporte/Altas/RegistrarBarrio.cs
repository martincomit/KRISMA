using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.Admin
{
    public partial class RegistrarBarrio : Form
    {
        string guardado = "";
        public int index;
        public RegistrarBarrio()
        {
            InitializeComponent();
        }

        private void RegistrarBarrio_Load(object sender, EventArgs e)
        {
            GestorLocalidad gl = new GestorLocalidad();
            cmbLocalidades.DataSource = gl.Consultar().Tables[0];
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            //cmbLocalidades.SelectedIndex = 0;

            if (index != 0)
            {
                cmbLocalidades.SelectedIndex = index;
                cmbLocalidades.Enabled = false;
            }

            else
            { cmbLocalidades.SelectedIndex = 0; }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de barrio");
                return;
            }




            GestorBarrio gb = new GestorBarrio();

            int id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
            //MessageBox.Show(id_localidad.ToString());

            guardado = gb.Registrar(txtNombre.Text, id_localidad);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                return;
            }

            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, error de escritura";
                txtNombre.Text = "";
                return;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

}