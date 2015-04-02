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
    public partial class ConsultarSolicitudes : Form
    {
        public ConsultarSolicitudes()
        {
            InitializeComponent();
        }

        private void SolicitudesWeb_Load(object sender, EventArgs e)
        {
         
            GestorDeportista gd = new GestorDeportista();
            dgSolicitudes.DataSource = gd.ConsultarInscripciones("inscripcion");
            dgSolicitudes.DataMember = "deportistas";

            GestorEstado ge = new GestorEstado();
            cmbEstados.DataSource = ge.Consultar("inscripcion").Tables[0];
            cmbEstados.DisplayMember = "Nombre";
            cmbEstados.ValueMember = "id_estado";
            cmbEstados.SelectedIndex = -1;


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int documento;
            GestorDeportista gd = new GestorDeportista();

            if (cmbEstados.Text != "")
            {
                int id_estado = int.Parse(cmbEstados.SelectedValue.ToString());
                dgSolicitudes.DataSource = gd.ConsultarInscripcionesEstado(id_estado);
                dgSolicitudes.DataMember = "deportistas";


                if (txtDocumento.Text != "" || txtDocumento.Text == "0")
              {


               documento = int.Parse(txtDocumento.Text);
               dgSolicitudes.DataSource = gd.ConsultarInscripcionesEstadoDocumento(id_estado, documento);
               dgSolicitudes.DataMember = "deportistas";


              }

            }




            else
            {
                if (txtDocumento.Text == "")
                {
                    dgSolicitudes.DataSource = gd.ConsultarInscripciones("inscripcion");
                    dgSolicitudes.DataMember = "deportistas";
                }

                else
                {
                    documento = int.Parse(txtDocumento.Text);
                    dgSolicitudes.DataSource = gd.ConsultarInscripciones(documento);
                    dgSolicitudes.DataMember = "deportistas";
                }
            }

            /*
            int documento;
            GestorDeportista gd = new GestorDeportista();

            if (txtDocumento.Text == "" || txtDocumento.Text =="0")
            {

                dgSolicitudes.DataSource = gd.ConsultarInscripciones();
                dgSolicitudes.DataMember = "deportistas";

            }
            else
            {
                documento = int.Parse(txtDocumento.Text);
                dgSolicitudes.DataSource = gd.ConsultarInscripciones(documento);
                dgSolicitudes.DataMember = "deportistas";
            } */
        }

        private void dgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filas = dgSolicitudes.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgSolicitudes.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            dgSolicitudes.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;

             DialogResult res;
            res = MessageBox.Show("Desea modificar el estado de los estudios?", "Mensaje", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                global.dni = int.Parse(dgSolicitudes.Rows[e.RowIndex].Cells[1].Value.ToString());
                global.id_estado = int.Parse(dgSolicitudes.Rows[e.RowIndex].Cells[26].Value.ToString());
                ConfirmarEstudiosMedicos form = new ConfirmarEstudiosMedicos(); global.dni = int.Parse(dgSolicitudes.Rows[e.RowIndex].Cells[1].Value.ToString());
                form.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbEstados.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
