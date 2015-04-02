using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MapeoDeDatos;
using UNCDeporte.Admin;
using UNCDeporte.Interfaz.Admin;
using Logica;
using UNCDeporte.Seleccionar;
using Entidades;

namespace UNCDeporte
{
    public partial class AltadeUsuarios : Form
    {
        string sql = "";
        string usuario = "";
        string pass = "";
        Usuario us = null;

        public AltadeUsuarios(Usuario u)
        {
            us = u;
            InitializeComponent();
        }

        public AltadeUsuarios()
        {
            InitializeComponent();
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
            int id_perfil = int.Parse(cmbPerfiles.SelectedValue.ToString());
            int documento = int.Parse(txtUsuario.Text);
            string guardado = "";
            string pass = us.Pass;
            int estado = us.Estado;


            guardado = gu.RegistrarOtroPerfil(documento,pass, id_perfil, estado);


            if (guardado == "Guardado")
            {
                MessageBox.Show("Nuevo perfil asignado");
                
                txtUsuario.Text = "";
                return;
            }

            if (guardado == "Existe")
            {
                MessageBox.Show("Ya existe perfil");
             
                txtUsuario.Text = "";
                return;
            }

            if (guardado == "Error al Guardar")
            {
                MessageBox.Show("Error al asignar");
                txtUsuario.Text = "";
                return;
            }
           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form3_Load(object sender, EventArgs e)
        {

            LLenarComboPerfil();

            if (us != null)
            {
                txtUsuario.Text = us.Documento + "";




            }
        }

        public void LLenarComboPerfil()
        {

            GestorPerfil gp = new GestorPerfil();
            cmbPerfiles.DataSource = gp.ConsultarTodos().Tables[0];
            cmbPerfiles.DisplayMember = "Nombre";
            cmbPerfiles.ValueMember = "id_perfil";
            cmbPerfiles.SelectedIndex = 0; //para empezar como administrativo

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //var random = new Random(DateTime.Now.Millisecond);
            //var letras = Enumerable.Range('0', 10).OrderBy(x => random.Next());

            //foreach (char c in letras) 
            //    txtPass.Text = c.ToString();
            //foreach (char c in letras)
            //    txtPass.Text = txtPass.Text + c.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.asignarMasPerfiles = true;
            SeleccionarUsuario form = new SeleccionarUsuario();
            form.Show();
            this.Close();
            txtUsuario.Text = global.documento.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }
    }
}
