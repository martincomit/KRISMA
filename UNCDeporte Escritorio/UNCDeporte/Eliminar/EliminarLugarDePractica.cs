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
    public partial class EliminarLugarDePractica : Form
    {
        public EliminarLugarDePractica()
        {
            InitializeComponent();
        }

        private void EliminarLugarPractica_Load(object sender, EventArgs e)
        {
            GestorLugarPractica glp = new GestorLugarPractica();
            dg_LugarPractica.DataSource = glp.Consultar();
            dg_LugarPractica.DataMember = "lugaresPractica";
            dg_LugarPractica.Columns[1].Visible = false;
        }

        private void dgLugarPractica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            if (dg_LugarPractica.CurrentCell.ColumnIndex == 0)
            {
                res = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(dg_LugarPractica.Rows[e.RowIndex].Cells[1].Value.ToString());
                        GestorLugarPractica glp = new GestorLugarPractica();
                        glp.Eliminar(id);

                        //consulto luego de eliminar para refrescar la grilla
                        dg_LugarPractica.DataSource = glp.Consultar();
                        dg_LugarPractica.DataMember = "lugaresPractica";
                        dg_LugarPractica.Columns[1].Visible = false;
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
