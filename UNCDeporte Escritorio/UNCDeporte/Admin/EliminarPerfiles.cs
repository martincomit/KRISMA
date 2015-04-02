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
    public partial class EliminarPerfiles : Form
    {
        public EliminarPerfiles()
        {
            InitializeComponent();
        }

        private void EliminarPerfiles_Load(object sender, EventArgs e)
        {
            GestorPerfil gp = new GestorPerfil();
            dgPerfiles.DataSource = gp.Consultar();

            dgPerfiles.DataMember = "Perfiles";
            dgPerfiles.Columns[1].Visible = false;

        }

        private void dgPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dgPerfiles.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GestorPerfil gp = new GestorPerfil();
                    gp.EliminarPermisos(id);
                    gp.Eliminar(id);

                    //consulto luego de eliminar para refrescar la grilla
                    dgPerfiles.DataSource = gp.Consultar();
                    dgPerfiles.DataMember = "Perfiles";
                    dgPerfiles.Columns[1].Visible = false;
                }
                catch (Exception ex) { }
            }
        }
    }
}
