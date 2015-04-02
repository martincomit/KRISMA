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
    public partial class ConsultarPermisos : Form
    {
        public ConsultarPermisos()
        {
            InitializeComponent();
        }

        private void ConsultarPermisos_Load(object sender, EventArgs e)
        {
            GestorPermiso gp = new GestorPermiso();
            dgPermisos.DataSource = gp.Consultar(global.id_perfil);
            dgPermisos.DataMember = "PermisosXPerfil";
            dgPermisos.Columns[0].Visible = false;
            dgPermisos.Columns[0].Visible = false;
            dgPermisos.Columns[1].Visible = false;
            dgPermisos.Columns[2].Visible = false;
            dgPermisos.Columns[3].Visible = false;
            lblPerfil.Text = global.nombre_perfil;


        }

        private void dgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarPerfiles form = new ConsultarPerfiles();
            form.Show();
            this.Close();
        }
    }
}
