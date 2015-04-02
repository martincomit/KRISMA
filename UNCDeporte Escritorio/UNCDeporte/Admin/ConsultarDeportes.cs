using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;

namespace UNCDeporte.Admin
{
    public partial class ConsultarDeportes : Form
    {
        string sql = "";

        public ConsultarDeportes()
        {
            InitializeComponent();
        }

        private void ConsultarDeportes_Load(object sender, EventArgs e)
        {
            GestorDeporte gd = new GestorDeporte();
            dgDeportes.DataSource = gd.Consultar();
            dgDeportes.DataMember = "deportes";
            dgDeportes.Columns[0].Visible = false;
        }

        private void dgDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dgDeportes.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GestorDeporte gd = new GestorDeporte();
                    gd.Eliminar(id);

                    //consulto luego de eliminar para refrescar la grilla
                    dgDeportes.DataSource = gd.Consultar();
                    dgDeportes.DataMember = "deportes";
                    dgDeportes.Columns[1].Visible = false;
                }
                catch (Exception ex) { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.Name = "Eliminar";
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Text = "Eliminar";
            buttonColumn.ToolTipText = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true;
            if (cbEliminar.Checked == true)
            {
                dgDeportes.Columns.Insert(0, buttonColumn);
                global.eliminar = true;
            }
            else
            {
                dgDeportes.Columns.Remove("Eliminar");
                global.eliminar = true;
            }
        }
    }
}
