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
    public partial class ModificarPerfil : Form
    {
        public ModificarPerfil()
        {
            InitializeComponent();
        }

        private void ModificarPerfil_Load(object sender, EventArgs e)
        {
            GestorPerfil gp = new GestorPerfil();
            dgPerfiles.DataSource = gp.Consultar();

            dgPerfiles.DataMember = "Perfiles";
            dgPerfiles.Columns[1].Visible = false;
        }

        private void dgPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filas = dgPerfiles.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgPerfiles.Rows[i].DefaultCellStyle.BackColor = Color.White;
               
            }
            dgPerfiles.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;


            int id_perfil;
            id_perfil = int.Parse(dgPerfiles.Rows[e.RowIndex].Cells[1].Value.ToString());
            
            GestorPermiso gp = new GestorPermiso();
            dgAgregados.DataSource = gp.Consultar(id_perfil);
            dgAgregados.DataMember = "permisosxperfil";
            //dgPermisos.DataSource = gp.TodosPermisosMenosCargados(id_permiso);
            //dgPermisos.DataSource = "perfiles";

            dgAgregados.Columns[1].Visible = false;
            dgAgregados.Columns[2].Visible = false;
            dgAgregados.Columns[3].Visible = false;




            txtNombre.Text = dgPerfiles.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescripcion.Text= dgPerfiles.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id_permiso=0;
            DataRow dr;
            GestorPermiso gp = new GestorPermiso();
            gb2.Enabled = true;
            gb1.Enabled = false;

            int filas = dgAgregados.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
               
                id_permiso = int.Parse(dgAgregados.Rows[i].Cells[4].Value.ToString());
                MessageBox.Show(id_permiso.ToString());


                //dgPermisos.DataSource = gp.TodosPermisosMenosCargados(id_permiso);
                //dgPermisos.DataSource = "permisos";
             
            }
            dgPermisos.DataSource = gp.TodosPermisosMenosCargados(id_permiso);
            dgPermisos.DataSource = "permisos";

           


        }

        private void dgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
