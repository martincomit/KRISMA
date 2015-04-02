using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;
using System.IO;
using UNCDeporte.Admin;


namespace UNCDeporte.Interfaz.Admin
{
    public partial class AltaPersonal : Form
    {
        string guardado = "";


        public AltaPersonal()
        {
            InitializeComponent();
        }


        private void AltaPersonal_Load(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
           




            ////luego borrar
            //gbDatos.Enabled = true;
            //btnNuevo.Enabled = false;
            //btnGuardar.Enabled = true;
            //btnCancelar.Enabled = true;
            ////hasta aca


            LLenarComboLocalidad();

            //LLenarComboPerfil();

        }

        //public void LLenarComboPerfil()
        //{

        //    GestorPerfil gp = new GestorPerfil();
        //    cmbPerfil.DataSource = gp.Consultar().Tables[0];
        //    cmbPerfil.DisplayMember = "Nombre";
        //    cmbPerfil.ValueMember = "id_perfil";
        //    cmbPerfil.SelectedIndex = 0;

        //}


        public void LLenarComboLocalidad()
        {

            GestorLocalidad gl = new GestorLocalidad();
            cmbLocalidades.DataSource = gl.Consultar().Tables[0];
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = 0;
            //ojo cuando no tiene nada
            global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
            LLenarComboBarrioDeLocalidad();



        }

        public void LLenarComboBarrioDeLocalidad()
        {

            GestorBarrio gb = new GestorBarrio();
            cmbBarrios.DataSource = gb.Consultar(global.id_localidad).Tables[0]; //.tables[0] pq sino no trae el nombre
            cmbBarrios.DisplayMember = "Nombre";
            cmbBarrios.ValueMember = "id_barrio";

            if(cmbBarrios.Items.Count>0)
            cmbBarrios.SelectedIndex = 0;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese Documento");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese Apellido");
                return;
            }
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Ingrese Nombres");
                return;
            }

            Personal p = new Personal();

            p.Documento = int.Parse(txtDocumento.Text);
            p.Id_usuario = p.Documento;
            p.Apellido = txtApellido.Text;
            p.Nombres = txtNombres.Text;
            p.Fecha_nac = dtpFecNac.Value;
            p.Id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());

            if(cmbBarrios.Items.Count>0)
            p.Id_barrio = int.Parse(cmbBarrios.SelectedValue.ToString());

            p.Calleynum = txtCalleyNum.Text;
            p.Tel_fijo = txtTelFijo.Text;
            p.Tel_cel = txtCel.Text;
            p.Email = txtEmail.Text;

            if (pbFoto.Image != null)
            {
                p.foto = ImgToByte(pbFoto.Image);
               
            }

     


            if (rbMasculino.Checked == true)
                p.Sexo = 'm';
            else
                p.Sexo = 'f';

          //  p.Id_perfil = int.Parse(cmbPerfil.SelectedValue.ToString());

            //ver de no usar entindad aca, sino q el gestor la conozca y use

            GestorPersonal gp = new GestorPersonal();

            guardado = gp.Registrar(p);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente con Usuario: " + txtDocumento.Text;
                limpiar();
                return;
            }

            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtDocumento.Text;
                limpiar();
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, error de escritura";
                limpiar();
                return;
            }




        }

        public static byte[] ImgToByte(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


        // DialogResult dr = MessageBox.Show("Los Datos del PERSONAL se Registraron Correctamente" + System.Environment.NewLine + "" + System.Environment.NewLine + "Desea Registrar el USUARIO", "Mensaje", MessageBoxButtons.YesNo);

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }


        public void limpiar()
        {
            txtDocumento.Text = "";
            txtApellido.Text = "";
            txtNombres.Text = "";
            txtCalleyNum.Text = "";
            txtTelFijo.Text = "";
            txtCel.Text = "";
            txtEmail.Text = "";
            gbDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            pbFoto.Image = null;
        }

        public void modificar()
        {
            txtDocumento.Text = "";
            txtDocumento.Enabled = true;
            txtApellido.Text = "";
            txtNombres.Text = "";
            txtCalleyNum.Text = "";
            txtTelFijo.Text = "";
            txtCel.Text = "";
            txtEmail.Text = "";
            gbDatos.Enabled = true;
            //btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = false;
            pbFoto.Image = null;
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDocumento.MaxLength = 8;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }

            return;
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (cmbLocalidades.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                
                global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                LLenarComboBarrioDeLocalidad();

            }

        }

        private void cmbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBarrios.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int id_localidad = 0;
                id_localidad = int.Parse(cmbBarrios.SelectedValue.ToString());


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz



            //controlar sino cargo una imagen!!!!
            if (result == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(dialog.FileName);
            }

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnLocaliad_Click(object sender, EventArgs e)
        {
            NuevaLocalidad form = new NuevaLocalidad();
            form.Show();
            LLenarComboLocalidad();

        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            RegistrarBarrio form = new RegistrarBarrio();
            form.Show();
            LLenarComboLocalidad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LLenarComboLocalidad();
            int ultimo= cmbLocalidades.Items.Count;
            cmbLocalidades.SelectedIndex = ultimo-1;
        }

    }
     

    }

