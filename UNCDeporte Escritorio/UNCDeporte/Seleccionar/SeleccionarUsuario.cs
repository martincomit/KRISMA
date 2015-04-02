using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using UNCDeporte.Admin;

using Entidades;

namespace UNCDeporte.Seleccionar
{
    public partial class SeleccionarUsuario : Form
    {
        GestorPerfil gp = new GestorPerfil();
        GestorUsuario gu = new GestorUsuario();
        string estado = "";
        string documento = "";
        string perfil = "";

        public SeleccionarUsuario()
        {
            InitializeComponent();
        }

        private void SeleccionarUsuario_Load(object sender, EventArgs e)
        {
            GestorUsuario gu = new GestorUsuario();
            dgUsuarios.DataSource = gu.ConsultarUsuarios("%","%","%"); //% todos
            dgUsuarios.DataMember = "Usuariosxperfiles";
                LLenarComboPerfiles();

        }

        public void LLenarComboPerfiles()
        {

            GestorPerfil gp = new GestorPerfil();
            cmbPerfil.DataSource = gp.ConsultarTodos().Tables[0];
            cmbPerfil.DisplayMember = "Nombre";
            cmbPerfil.ValueMember = "id_perfil";
            cmbPerfil.SelectedIndex = -1;

        }
        

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int documento = 1;
            int pass = 2;
            int id_perfil = 3;
            int estado = 4;
            
            //global.documento = int.Parse(dgUsuario.Rows[e.RowIndex].Cells[documento].Value.ToString());

            Usuario u = new Usuario();
            u.Documento = int.Parse(dgUsuarios.Rows[e.RowIndex].Cells[documento].Value.ToString());
            u.Pass = dgUsuarios.Rows[e.RowIndex].Cells[pass].Value.ToString();

            u.Id_perfil = int.Parse(dgUsuarios.Rows[e.RowIndex].Cells[id_perfil].Value.ToString());

            if (dgUsuarios.Rows[e.RowIndex].Cells[estado].Value.ToString() == "True")
                u.Estado = 1;
            else if (dgUsuarios.Rows[e.RowIndex].Cells[estado].Value.ToString() == "False")
                u.Estado = 0;
            
            //u.Estado = int.Parse(dgUsuario.Rows[e.RowIndex].Cells[estado].Value.ToString());



            if (global.asignarMasPerfiles == false)
            {
                Registrar_Usuario form = new Registrar_Usuario(u);
                form.Show();
                this.Close();

            }

            else if (global.asignarMasPerfiles == true)
            {
                AltadeUsuarios form = new AltadeUsuarios(u);
                form.Show();
                this.Close();
            }
        }

        private void btnFiltrarDeportista_Click(object sender, EventArgs e)
        {
            //en caso de alta asigna 1 al estado, y en documento asigna % si es nulo y sino manda el parametro.
            if (cmbEstado.Text == "Alta")
                estado = 1 + "";
            if (cmbEstado.Text == "Baja")
                estado = 0 + "";
            if (cmbEstado.Text == "")
                estado = "%";


            if (txtDocumento.Text == "")
                documento = "%";
            if (txtDocumento.Text != "")
                documento = txtDocumento.Text;

            if (cmbPerfil.Text == "")
                perfil = "%";
            if (cmbPerfil.Text != "")
                perfil = cmbPerfil.SelectedValue.ToString();




            dgUsuarios.DataSource = gu.ConsultarUsuarios(documento, perfil, estado);
            dgUsuarios.DataMember = "usuariosxperfiles";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbPerfil.SelectedValue = -1;
            cmbEstado.SelectedIndex = -1;
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
    }
}
