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
    public partial class SeleccionarProfesor : Form
    {
        public SeleccionarProfesor()
        {
            InitializeComponent();
        }

        private void dgProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int documento = 1;
            global.documentoProfe = int.Parse(dgProfesores.Rows[e.RowIndex].Cells[documento].Value.ToString());
            AsignarDeportesAProfesor form = new AsignarDeportesAProfesor();
            form.Show();

            this.Close();
        }

        private void SeleccionarProfesor_Load(object sender, EventArgs e)
        {
            GestorPersonal gp = new GestorPersonal();
            dgProfesores.DataSource = gp.ConsultarProfes(6); //6 perfil profesor
            dgProfesores.DataMember = "UsuariosXPerfiles";
        }
    }
}
