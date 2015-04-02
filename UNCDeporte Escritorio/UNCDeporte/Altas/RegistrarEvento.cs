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

namespace UNCDeporte.TorneosYEventos
{
    public partial class RegistrarEvento : Form
    {
        string guardado = "";

        public RegistrarEvento()
        {
            InitializeComponent();
        }

        private void RegistrarEvento_Load(object sender, EventArgs e)
        {

           
            lblGuardado.Text = "";
            lblGuardado.Visible = false;
            btnGuardar.Enabled = true;
            btnSalir.Enabled = true;
            LLenarComboDeporte();
            LLenarComboPerfil();
            cmbTipoDeporte.Items.Add("Recreativo");
            cmbTipoDeporte.Items.Add("Federado");
            cmbTipoDeporte.Items.Add("Todos");
            cmbTipoDeporte.SelectedIndex = 0;
            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportes("Federado");
                return;
            }
            if (cmbTipoDeporte.Text == "Recreativo")
            {
                cargarDeportes("Recreativo");
                return;
            }
            if (cmbTipoDeporte.Text == "Todos")
            {
                cargarDeportes();
                return;
            }

        }

        public void cargarDeportes(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

        public void cargarDeportes()
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar().Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

        public void LLenarComboDeporte()
        {
            GestorDeporte gl = new GestorDeporte();
            cmbDeportes.DataSource = gl.Consultar().Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;
            cmbDeportes.SelectedIndex = -1;
        }

        public void LLenarComboPerfil()
        {
            GestorPerfil gb = new GestorPerfil();
            cmbPerfil.DataSource = gb.Consultar().Tables[0]; //.tables[0] pq sino no trae el nombre
            cmbPerfil.DisplayMember = "Nombre";
            cmbPerfil.ValueMember = "id_perfil";
            cmbPerfil.SelectedIndex = -1;

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
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

        public static byte[] ImgToByte(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre");
                return;
            }
            if (txtDescrip.Text == "")
            {
                MessageBox.Show("Ingrese Descripcion");
                return;
            }
            if (cmbDeportes.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione el Deporte");
                return;
            }

            if (cmbPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Perfil");
                return;
            }

            if (dtpFechaFin.Value <= dtpFechaInicio.Value)
            {
                MessageBox.Show("Defina correctamente Inicio/Cierre de Evento");
                return;
            }

            
            Evento evento = new Evento();

            //evento.Documento = int.Parse(txtDocumento.Text);
            evento.Descripcion = txtDescrip.Text;
            evento.Nombre = txtNombre.Text;
           
            evento.Fecha_inicio = dtpFechaInicio.Value;
            evento.Fecha_fin = dtpFechaFin.Value;
            evento.Id_perfil = int.Parse(cmbPerfil.SelectedValue.ToString());
            evento.Id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
            if (pbFoto.Image != null)
            {
                evento.foto = ImgToByte(pbFoto.Image);
            }


          //  p.Id_perfil = int.Parse(cmbPerfil.SelectedValue.ToString());

            //ver de no usar entindad aca, sino q el gestor la conozca y use

            GestorEvento gp = new GestorEvento();

            guardado = gp.Registrar(evento);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                limpiar();
                return;
            }

            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
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

        public void limpiar()
        {
            txtDescrip.Text = "";
            txtNombre.Text = "";
            cmbDeportes.SelectedIndex = -1;
            cmbPerfil.SelectedIndex = -1;
         
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            pbFoto.Image = null;
            
            btnGuardar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportes("Federado");
                return;
            }
            if (cmbTipoDeporte.Text == "Recreativo")
            {
                cargarDeportes("Recreativo");
                return;
            }
            if (cmbTipoDeporte.Text == "Todos")
            {
                cargarDeportes();
                return;
            }
        }
    
    }
}
