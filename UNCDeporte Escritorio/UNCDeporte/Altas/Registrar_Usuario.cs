using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using UNCDeporte.Seleccionar;
using Entidades;
using UNCDeporte.Interfaz.Admin;

namespace UNCDeporte.Admin
{
    public partial class Registrar_Usuario : Form
    {
        string guardado="";
        int estado = 1;
        Usuario us = null;
        static Boolean modificar = false;

        public Registrar_Usuario(Usuario u)
        {
            us = u;
            InitializeComponent();
        }

        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void Registrar_Usuario_Load(object sender, EventArgs e)
        {
            GestorPerfil gp = new GestorPerfil();
            cmbPerfil.DataSource = gp.ConsultarTodos().Tables[0];
            cmbPerfil.DisplayMember = "Nombre";
            cmbPerfil.ValueMember = "id_perfil";
            cmbPerfil.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Enabled = false;

            if(modificar== true)
            cmbPerfil.Enabled = false;

            
            if (us!= null)
            {
                txtDocumento.Text = us.Documento + "";
                txtPass.Text = us.Pass;

                cmbPerfil.SelectedValue= us.Id_perfil;
                if (us.Estado == 1)
                    cmbEstado.SelectedIndex = 0;
                else if (us.Estado == 0)
                    cmbEstado.SelectedIndex = 1;

                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                txtPass.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         

            txtDocumento.MaxLength = 8;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }

            return;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDocumento.Enabled = true;
            txtPass.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            modificar = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDocumento.Enabled = false;
            txtPass.Enabled = false;
            txtDocumento.Text = "";
            txtPass.Text="";

            btnGuardar.Enabled = false;
            btnSeleccionar.Visible = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            cmbPerfil.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            modificar = false;
            cmbPerfil.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Ingrese documento y password");
                return;

            }

            GestorUsuario gu = new GestorUsuario();
            int documento = int.Parse(txtDocumento.Text);
            string pass = txtPass.Text;
            int id_perfil = int.Parse(cmbPerfil.SelectedValue.ToString());
            if (cmbEstado.Text == "Alta")
                estado = 1;
            else if (cmbEstado.Text == "Baja")
                estado = 0;

            if (modificar == true)
            {
                guardado = gu.Modificar(documento, pass, id_perfil, estado);

                if (guardado == "Guardado")
                {
                    MessageBox.Show("Usuario Modificado");
                    txtDocumento.Text = "";
                    txtPass.Text = "";
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    return;
                }


                if (guardado == "Error al Guardar")
                {
                    MessageBox.Show("Error al Guardar");
                    txtDocumento.Text = "";
                    txtPass.Text = "";
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    return;
                }

            }

            guardado = gu.Registrar(documento, pass, id_perfil, estado);

            if (guardado == "Guardado")
            {
                MessageBox.Show("Usuario Guardado");
                txtDocumento.Text = "";
                txtPass.Text = "";
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                return;
            }

            if (guardado == "Existe")
            {
                MessageBox.Show("Ya existe");
                txtDocumento.Text = "";
                txtPass.Text = "";
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                return;
            }

            if (guardado == "Error al Guardar")
            {
                MessageBox.Show("Error al Guardar");
                txtDocumento.Text = "";
                txtPass.Text = "";
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                return;
            }


           
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            cmbPerfil.Enabled = false;
            btnNuevo.Enabled = false;
            btnSeleccionar.Visible = true;
            //txtDocumento.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            global.asignarMasPerfiles = false;
            SeleccionarUsuario form = new SeleccionarUsuario();
            form.Show();
            this.Close();
            txtDocumento.Text = global.documento.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios form = new ConsultarUsuarios();
            form.Show();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
    }
}
