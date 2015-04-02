using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.ConsultarEliminar
{

    
    public partial class ConsultarProfesoresPorDeportes : Form
    {
        GestorDeporte gd = new GestorDeporte();
        string id_programa = "";
        string documento = "";
        string id_deporte = "";
        public ConsultarProfesoresPorDeportes()
        {
            InitializeComponent();
        }

        private void ConsultarProfesoresPorDeportes_Load(object sender, EventArgs e)
        {
            GestorDeporte gd = new GestorDeporte();
            dgp.DataSource = gd.ConsultarProfesXDeporte();
            dgp.DataMember = "ProfesoresXDeportesXProgramas";            
            cargarProgramas();
            cmbTipoDeporte.Items.Add("Recreativo");
            cmbTipoDeporte.Items.Add("Federado");

            
            cmbTipoDeporte.SelectedIndex = 0;

            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportes("Federado");
            }
            else
            {
                cargarDeportes("Recreativo");
            }

            cmbTipoDeporte.SelectedIndex = -1;
            cmbDeportes.SelectedIndex = -1;
            cmbPrograma.SelectedIndex = -1;
            txtDocumento.Text = "";

        }


        public void cargarDeportes(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

        public void cargarProgramas()
        {
            GestorPrograma gp = new GestorPrograma();
            cmbPrograma.DataSource = gp.Consulatar_Programa().Tables[0];
            cmbPrograma.DisplayMember = "anio";
            cmbPrograma.ValueMember = "id_programa";
            cmbPrograma.SelectedIndex = 0;

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbTipoDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportes("Federado");
            }
            else
            {
                cargarDeportes("Recreativo");
            }
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbTipoDeporte.SelectedIndex = -1;
            cmbDeportes.SelectedIndex = -1;
            cmbPrograma.SelectedIndex = -1;
            txtDocumento.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (txtDocumento.Text == "")
                documento = "%";
            if (txtDocumento.Text != "")
                documento = txtDocumento.Text;

            if (cmbDeportes.Text == "")
                id_deporte = "%";
            if (cmbDeportes.Text != "")
                id_deporte = cmbDeportes.SelectedValue.ToString();

            if (cmbPrograma.Text == "")
                id_programa = "%";
            if (cmbPrograma.Text != "")
                id_programa = cmbPrograma.SelectedValue.ToString();


           dgp.DataSource = gd.ConsultarProfesXDeporte(documento, id_deporte, id_programa);
           dgp.DataMember = "ProfesoresXDeportesXProgramas";
      


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
                dgp.Columns.Insert(0, buttonColumn);
                global.eliminar = true;
            }
            else
            {
                dgp.Columns.Remove("Eliminar");
                global.eliminar = true;
            }

        }

        private void dgp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (global.eliminar == true)
            {
                DialogResult res;
                res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int documento = int.Parse(dgp.Rows[e.RowIndex].Cells[1].Value.ToString());
                        int id_deporte = int.Parse(dgp.Rows[e.RowIndex].Cells[2].Value.ToString());
                        int programa = int.Parse(dgp.Rows[e.RowIndex].Cells[4].Value.ToString());
                        GestorDeporte gd = new GestorDeporte();
                        gd.EliminarProfeXDeporteXPrograma(documento, id_deporte, programa);

                        //consulto luego de eliminar para refrescar la grilla
                        dgp.DataSource = gd.ConsultarProfesXDeporte();
                        dgp.DataMember = "Personal";

                    }
                    catch (Exception ex) { }
                }

            }
        }




      
        
    }

}