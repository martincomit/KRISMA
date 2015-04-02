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
    public partial class RegistrarTipoSector : Form
    {
        string guardado = "";

        public RegistrarTipoSector()
        {
            InitializeComponent();
        }

        private void RegistrarTipoSector_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegistrarTipoSector_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de tipo de sector");
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese una descripcion de tipo de sector");
                return;
            }


            GestorTipoSector gts = new GestorTipoSector();

            guardado = gts.Registrar(txtNombre.Text, txtDescripcion.Text);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                return;
            }

            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, error de escritura";
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                return;
            }

        }

    }
}
