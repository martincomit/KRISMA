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
    public partial class ConsultarPerfiles : Form
    {
        public ConsultarPerfiles()
        {
            InitializeComponent();
        }

        private void ConsultarPerfiles_Load(object sender, EventArgs e)
        {
            GestorPerfil gp = new GestorPerfil();
            dgPerfiles.DataSource = gp.Consultar();
            dgPerfiles.DataMember = "perfiles";
            dgPerfiles.Columns[1].Visible = false;
        }

        private void dgPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgPerfiles.Rows[e.RowIndex].Cells[1].Value.ToString());
            GestorPermiso gp = new GestorPermiso();
            global.id_perfil = int.Parse(dgPerfiles.Rows[e.RowIndex].Cells[1].Value.ToString());
            global.nombre_perfil = dgPerfiles.Rows[e.RowIndex].Cells[2].Value.ToString();
            ConsultarPermisos form = new ConsultarPermisos();
            form.Show();



        }
    }
}
