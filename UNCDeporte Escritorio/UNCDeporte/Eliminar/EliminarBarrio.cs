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
    public partial class EliminarBarrio : Form
    {
        public EliminarBarrio()
        {
            InitializeComponent();
        }

        private void EliminarBarrio_Load(object sender, EventArgs e)
        {
            GestorBarrio gb = new GestorBarrio();
            dgBarrio.DataSource = gb.Consultar();

            dgBarrio.DataMember = "Barrios";
            dgBarrio.Columns[1].Visible = false;
            dgBarrio.Columns[4].Visible = false;
    


        }

        private void dgBarrio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int id_barrio = int.Parse(dgBarrio.Rows[e.RowIndex].Cells[1].Value.ToString());
                    int id_localidad = int.Parse(dgBarrio.Rows[e.RowIndex].Cells[4].Value.ToString());
                    GestorBarrio gb = new GestorBarrio();

                    if (gb.unicoBarrio(id_localidad) != true)
                    {
                        gb.Eliminar(id_barrio);
                        //consulto luego de eliminar para refrescar la grilla
                        dgBarrio.DataSource = gb.Consultar();
                        dgBarrio.DataMember = "Barrios";
                        dgBarrio.Columns[1].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar porque es unico barrio de la localidad");
                    }
                   
                }
                catch (Exception ex) { }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
