using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class ConsultarInscripciones : Form
    {
        public ConsultarInscripciones()
        {
            InitializeComponent();
        }

        private void ConsultarInscripciones_Load(object sender, EventArgs e)
        {
            dgInscripciones.ReadOnly = true;
            GestorInscripcion gi = new GestorInscripcion();
            dgInscripciones.DataSource = gi.Consultar();
            dgInscripciones.DataMember = "InscripcionesDisciplina";

            ocultarCampos();
            GestorDeporte gd = new GestorDeporte();
            cmbDeportes.DataSource = gd.Consultar().Tables[0];
            cmbDeportes.DisplayMember = "nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedValue = -1;

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
        }

        public void cargarDeportes(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }


        public void ocultarCampos()
        {
            dgInscripciones.Columns[0].Visible = false;
            dgInscripciones.Columns[1].Visible = false;
            dgInscripciones.Columns[2].Visible = false;
            dgInscripciones.Columns[3].Visible = false;
            dgInscripciones.Columns[4].Visible = false;
            dgInscripciones.Columns[6].Visible = false;
            dgInscripciones.Columns[8].Visible = false;
            dgInscripciones.Columns[9].Visible = false;
            dgInscripciones.Columns[10].Visible = false;
            dgInscripciones.Columns[15].Visible = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {

            int documento;
            int id_deporte;
            GestorInscripcion gi = new GestorInscripcion();


            try
            {

            if(txtDocumento.Text =="" && cmbDeportes.Text =="")
            {
                
            dgInscripciones.DataSource = gi.Consultar();
            dgInscripciones.DataMember = "InscripcionesDisciplina";

            ocultarCampos();
                
                
                
                return;
            }
            
            
                if (cmbDeportes.Text != "" && txtDocumento.Text =="")
                {
                    id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                    dgInscripciones.DataSource = gi.Consultar(id_deporte);
                    dgInscripciones.DataMember = "InscripcionesDisciplina";
                    ocultarCampos();
                    return;
                }

                if (txtDocumento.Text != "" && cmbDeportes.Text =="")
                {

                        documento = int.Parse(txtDocumento.Text);
                        dgInscripciones.DataSource = gi.ConsultarDocumento(documento);
                        dgInscripciones.DataMember = "InscripcionesDisciplina";
                        ocultarCampos();
                        return;


                }
                if(cmbDeportes.Text != "" && txtDocumento.Text !="")
                {

                            documento = int.Parse(txtDocumento.Text);
                            id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                            dgInscripciones.DataSource = gi.Consultar(documento, id_deporte);
                            dgInscripciones.DataMember = "InscripcionesDisciplina";
                            ocultarCampos();
                            return;
                 }





              }

            catch (Exception ex) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbDeportes.SelectedValue = -1;
            cmbTipoDeporte.SelectedValue = -1;
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
