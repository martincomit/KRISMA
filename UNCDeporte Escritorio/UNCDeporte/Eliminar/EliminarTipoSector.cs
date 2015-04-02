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
    public partial class EliminarTipoSector : Form
    {
        public EliminarTipoSector()
        {
            InitializeComponent();
        }

        private void EliminarTipoSector_Load(object sender, EventArgs e)
        {
            GestorTipoSector gts = new GestorTipoSector();
            dg_tipo_sector.DataSource = gts.Consultar();

            dg_tipo_sector.DataMember = "tiposSector";
            dg_tipo_sector.Columns[1].Visible = false;
        }

        private void dg_tipo_sector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dg_tipo_sector.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GestorTipoSector gts = new GestorTipoSector();
                    gts.Eliminar(id);

                    //consulto luego de eliminar para refrescar la grilla
                    dg_tipo_sector.DataSource = gts.Consultar();
                    dg_tipo_sector.DataMember = "tipossector";
                    dg_tipo_sector.Columns[1].Visible = false;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
