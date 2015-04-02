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
    public partial class AsignarDeportesAProfesor : Form
    {

        string usuario = "";
        public AsignarDeportesAProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarProfesor form = new SeleccionarProfesor();
            form.Show();
            this.Close();
            txtUsuario.Text = global.documentoProfe.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AsignarDeportesAProfesor_Load(object sender, EventArgs e)
        {
            if (global.documentoProfe != 0)
                txtUsuario.Text = global.documentoProfe + "";
            
            
            //cmbPrograma.Items.Add("2015");
            //cmbPrograma.Items.Add("2014");
            //cmbPrograma.SelectedIndex = 0;



            cmbTipoDeporte.Items.Add("Recreativo");
            cmbTipoDeporte.Items.Add("Federado");
            cmbTipoDeporte.SelectedIndex = 0;

            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportes("Federado");
            }
            else
            {
                cargarDeportes("Recreativo");
            }

            cargarProgramas();
        }


        public void cargarDeportes(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

        public void cargarProgramas()
        {
            GestorPrograma gp = new GestorPrograma();
            cmbPrograma.DataSource = gp.Consulatar_Programa().Tables[0];
            cmbPrograma.DisplayMember = "anio";
            cmbPrograma.ValueMember = "id_programa";
            cmbPrograma.SelectedIndex = 0;

        }


        private void cmbTipoDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportes("Federado");
            }
            else
            {
                cargarDeportes("Recreativo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Seleccione Usuario");
                return;
            }

            usuario = txtUsuario.Text;

            GestorUsuario gu = new GestorUsuario();
            int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
            int documento_profesor = int.Parse(txtUsuario.Text);
            int id_programa = int.Parse(cmbPrograma.SelectedValue.ToString());
            string guardado = "";
            guardado = gu.RegistrarDeportePorProfesor(id_deporte, documento_profesor, id_programa);


            if (guardado == "Guardado")
            {
                MessageBox.Show("Asignado Correctamente");
                txtUsuario.Text = "";
                return;
            }

            if (guardado == "Existe")
            {

                MessageBox.Show("No guardado, ya existe");
                txtUsuario.Text = "";
                return;
            }

            if (guardado == "Error al Guardar")
            {

                MessageBox.Show("No guardado, error");
                txtUsuario.Text = "";
                return;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
