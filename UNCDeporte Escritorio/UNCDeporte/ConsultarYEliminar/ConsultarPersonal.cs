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

namespace UNCDeporte.Interfaz.Admin
{
    public partial class ConsultarPersonal : Form
    {
        
        GestorPersonal gp = new GestorPersonal();

        public ConsultarPersonal()
        {
            InitializeComponent();
        }

        private void ConsultarProfesores_Load(object sender, EventArgs e)
        {


            dgPersonal.DataSource = gp.Consultar();
            dgPersonal.DataMember = "Personal";
            LLenarComboLocalidad();

        }

        public void LLenarComboLocalidad()
        {

            GestorLocalidad gl = new GestorLocalidad();
            cmbLocalidades.DataSource = gl.Consultar().Tables[0];
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = -1;

        }

        private void btnFiltrarDeportista_Click(object sender, EventArgs e)
        {

            if (cmbLocalidades.Text != "")
            {
                int id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                dgPersonal.DataSource = gp.Consultar(id_localidad);
                dgPersonal.DataMember = "Personal";


                if (txtDocumento.Text != "")
                {


                    int documento = int.Parse(txtDocumento.Text);
                    dgPersonal.DataSource = gp.ConsultarDNI(documento);
                    dgPersonal.DataMember = "Personal";


                }

            }




            else
            {
                dgPersonal.DataSource = gp.Consultar();
                dgPersonal.DataMember = "Personal";

            }




        }

        private void panelConsulta_Paint(object sender, PaintEventArgs e)
        {

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
                dgPersonal.Columns.Insert(0, buttonColumn);
                global.eliminar = true;
            }
            else
            {
                dgPersonal.Columns.Remove("Eliminar");
                global.eliminar = true;
            }


        }

        private void dgPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (global.eliminar == true)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbLocalidades.SelectedValue = -1;
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDocumento.MaxLength = 8;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }

            return;
        }

    }
}