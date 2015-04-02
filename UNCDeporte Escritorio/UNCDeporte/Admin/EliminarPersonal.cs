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
    public partial class EliminarPersonal : Form
    {
        public EliminarPersonal()
        {
            InitializeComponent();
        }

        private void dgPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int documento = int.Parse(dgPersonal.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GestorPersonal gp = new GestorPersonal();
                    gp.Eliminar(documento);

                    //consulto luego de eliminar para refrescar la grilla
                    dgPersonal.DataSource = gp.Consultar();
                    dgPersonal.DataMember = "Personal";
                    
                }
                catch (Exception ex) { }
            }

        }

        private void EliminarPersonal_Load(object sender, EventArgs e)
        {
            GestorPersonal gp = new GestorPersonal();
            dgPersonal.DataSource = gp.Consultar();
            dgPersonal.DataMember = "Personal";
           
        }
    }
}