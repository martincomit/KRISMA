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
    public partial class EliminarLocalidades : Form
    {
        public EliminarLocalidades()
        {
            InitializeComponent();
        }

        private void EliminarLocalidades_Load(object sender, EventArgs e)
        {
            GestorLocalidad gl = new GestorLocalidad();
            dgLocalidades.DataSource = gl.Consultar();     
           
            dgLocalidades.DataMember = "localidades";
            dgLocalidades.Columns[1].Visible = false;
            
        }

        private void dgLocalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res= MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dgLocalidades.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GestorLocalidad gl = new GestorLocalidad();
                    gl.Eliminar(id);

                    //consulto luego de eliminar para refrescar la grilla
                    dgLocalidades.DataSource = gl.Consultar();
                    dgLocalidades.DataMember = "localidades";
                    dgLocalidades.Columns[1].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("No se puede eliminar la localidad"); }
            }
                

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
