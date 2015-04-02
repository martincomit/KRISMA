using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using System.IO;
using Entidades;
using UNCDeporte.Interfaz.Admin;

namespace UNCDeporte.Admin
{
    public partial class ModificarPersonal : Form
    {
        string guardado;

        public ModificarPersonal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese Documento a buscar");
                return;
            }

            GestorPersonal gp = new GestorPersonal();

            DataSet ds = new DataSet();
            int documento = 0; int coldocu = 0;
            DateTime fec_nac = new DateTime(1990, 01, 01); int colfec = 1;
            string apellido = ""; int colape = 2;
            string nombres = ""; int colnom = 3;
            string calleynum = ""; int colcalle = 4;
            int id_barrio = 0; int colidbarrio = 5;
            int id_usuario = 0; int colidusuario = 6;
            byte[] foto = null; int colfoto = 7;
            int id_localidad = 0; int colidloc = 8;
            string email = ""; int colemail = 9;
            string tel_fijo = ""; int coltelfijo = 10;
            string tel_cel = ""; int coltelcel = 11;
            string sexo = "m"; int colsexo = 12;
            int id_perfil = 1; int colid_perfil = 13;

            if (gp.ConsultarDNI(int.Parse(txtDocumento.Text)).Tables[0].Rows.Count > 0)
            {
                btnGuardarModificacion.Enabled = true;
                gbDatos.Enabled = true;
                gbBuscar.Enabled = false;
               
                ds = gp.ConsultarDNI(int.Parse(txtDocumento.Text));


                global.documento = int.Parse(txtDocumento.Text);
                fec_nac = DateTime.Parse(ds.Tables[0].Rows[0][colfec].ToString());
                apellido = ds.Tables[0].Rows[0][colape].ToString();
                nombres = ds.Tables[0].Rows[0][colnom].ToString();
                id_perfil = int.Parse(ds.Tables[0].Rows[0][colid_perfil].ToString());
                cmbPerfil.SelectedValue = id_perfil;
                //los ifs pregunta por si lo q trae de los dataset son nulos.
              
                calleynum = ds.Tables[0].Rows[0][colcalle].ToString();


                if (ds.Tables[0].Rows[0][colidloc].ToString() != "")
                {
                    id_localidad = int.Parse(ds.Tables[0].Rows[0][colidloc].ToString());
                    cmbLocalidades.SelectedValue = id_localidad;

                }


                if (ds.Tables[0].Rows[0][colidbarrio].ToString() != "")
                {
                    id_barrio = int.Parse(ds.Tables[0].Rows[0][colidbarrio].ToString());
                    cmbBarrios.SelectedValue = id_barrio;
                }


                //if (ds.Tables[0].Rows[0][colidusuario].ToString()!= "")
                //id_usuario = int.Parse(ds.Tables[0].Rows[0][colidusuario].ToString());

                if (ds.Tables[0].Rows[0][colfoto].ToString() != "")
                {
                    foto = (byte[])ds.Tables[0].Rows[0][colfoto];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(foto);
                    // Se utiliza el MemoryStream para extraer la imagen
                    pbFoto.Image = Image.FromStream(ms);

                }

               



                if (ds.Tables[0].Rows[0][colemail].ToString() != "")
                    email = ds.Tables[0].Rows[0][colemail].ToString();

                if (ds.Tables[0].Rows[0][coltelfijo].ToString() != "")
                    tel_fijo = ds.Tables[0].Rows[0][coltelfijo].ToString();

                if (ds.Tables[0].Rows[0][coltelcel].ToString() != "")
                    tel_cel = ds.Tables[0].Rows[0][coltelcel].ToString();


                if (ds.Tables[0].Rows[0][colsexo].ToString() != "")
                {
                    sexo = ds.Tables[0].Rows[0][colsexo].ToString();
                    if (sexo == "m")
                        rbMasculino.Checked = true;
                    else if (sexo == "f")
                        rbFemenino.Checked = true;
                }
               
                dtpFecNac.Value = new DateTime(fec_nac.Year,fec_nac.Month,fec_nac.Day);
                txtApellido.Text = apellido;
                txtNombres.Text = nombres;
                txtCalleyNum.Text = calleynum;
                txtTelFijo.Text = tel_fijo;
                txtCel.Text = tel_cel;
                txtEmail.Text = email;

            }
            else
                
            {
                MessageBox.Show("No encontro : " + txtDocumento.Text);
                txtDocumento.Text = "";
            }
        }

        public static byte[] ImgToByte(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void ModificarPersonal_Load(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            LLenarComboLocalidad();
            LLenarComboPerfil();

        }

        public void LLenarComboPerfil()
        {

            GestorPerfil gp = new GestorPerfil();
            cmbPerfil.DataSource = gp.Consultar().Tables[0];
            cmbPerfil.DisplayMember = "Nombre";
            cmbPerfil.ValueMember = "id_perfil";
            cmbPerfil.SelectedIndex = 0;

        }

        private void txtDocuBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDocumento.MaxLength = 8;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }

            return;
        }
        
        
          



        



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

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalidades.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                LLenarComboBarrioDeLocalidad();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        public void limpiar()
        {
            
            txtApellido.Text = "";
            txtNombres.Text = "";
            txtCalleyNum.Text = "";
            txtTelFijo.Text = "";
            txtCel.Text = "";
            txtEmail.Text = "";
            gbDatos.Enabled = false;
           
            btnGuardarModificacion.Enabled = false;
            btnCancelar.Enabled = false;
            pbFoto.Image = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
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
            p.Documento = global.documento;
            p.Fecha_nac = dtpFecNac.Value;
            p.Apellido = txtApellido.Text;
            p.Nombres = txtNombres.Text;
            p.Calleynum = txtCalleyNum.Text;
            p.Id_barrio = int.Parse(cmbBarrios.SelectedValue.ToString());
          
            if (pbFoto.Image != null)
            {
                p.foto = ImgToByte(pbFoto.Image);

            }

            p.Id_localidad= int.Parse(cmbLocalidades.SelectedValue.ToString());
            p.Email = txtEmail.Text;
            p.Tel_fijo = txtTelFijo.Text;
            p.Tel_cel = txtCel.Text; 
           
            if (rbMasculino.Checked == true)
                p.Sexo = 'm';
            else
                p.Sexo = 'f';


            //ver de no usar entindad aca, sino q el gestor la conozca y use

            GestorPersonal gp = new GestorPersonal();

            guardado = gp.Modificar(p);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Modificado Correctamente";
                limpiar();
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Modificado, error de escritura";
                limpiar();
                return;
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            gbBuscar.Enabled = true;
            txtDocumento.Text = "";
        }

        private void btnLocaliad_Click(object sender, EventArgs e)
        {
            NuevaLocalidad form = new NuevaLocalidad();
            form.Show();
        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            RegistrarBarrio form = new RegistrarBarrio();
            form.Show();
        }

 



    }
}
