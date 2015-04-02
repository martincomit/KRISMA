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
    public partial class ConfirmarEstudiosMedicos : Form
    {
        Boolean fechaLista = false;

        public ConfirmarEstudiosMedicos()
        {
            InitializeComponent();
        }

        private void ConfirmarTurnosMedicos_Load(object sender, EventArgs e)
        {
            txtEstado.ReadOnly = true;
            lblDocumento.Text = global.dni.ToString();
            LLenarComboEstado();
            SetearEstado();
            
        }


        public void LLenarComboEstado()
        {

            GestorEstado ge = new GestorEstado();
            cmbEstado.DataSource = ge.Consultar("inscripcion").Tables[0];
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "id_estado";
            cmbEstado.SelectedIndex = 0;
        }

      


      

        public void SetearEstado()
        {

            GestorEstado ge = new GestorEstado();
            txtEstado.Text = ge.ConsultarEstadoDetalle(global.id_estado).Tables[0].Rows[0][0].ToString();
            cmbEstado.SelectedValue = global.id_estado;
         
        }

        //public void LLenarComboEstado2()
        //{

        //    GestorEstado ge = new GestorEstado();
        //    cmbEstadoLab.DataSource = ge.Consultar().Tables[0];
        //    cmbEstadoLab.DisplayMember = "Nombre";
        //    cmbEstadoLab.ValueMember = "id_estado";
        //    cmbEstadoLab.SelectedIndex = 0;
        //}

        private void button5_Click(object sender, EventArgs e)
        {

            GestorDeportista gd = new GestorDeportista();
            string guardado;
            int documento = int.Parse(lblDocumento.Text);
            int id_estado = int.Parse(cmbEstado.SelectedValue.ToString());
            if (id_estado == 4 && fechaLista ==false )
            {
                MessageBox.Show("Seleccione fecha de Estudios");
                gbFechas.Enabled = true;
                btnGuardar.Enabled = false;
            }
            else
            {
                gbFechas.Enabled = false;
                guardado = gd.Modificar(documento, id_estado);

                if (guardado == "Guardado")
                {
                   
                    MessageBox.Show( "Guardado Correctamente ");
                    txtEstado.Text = cmbEstado.Text;
                   
                    return;
                }

                if (guardado == "Error")
                {
                  
                   MessageBox.Show( "No Guardado, error de escritura");

                    return;
                }
            }
            
          


        }








    
        

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void gbDeportes_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            lblfechaergo.Visible = true;
            lblfechalab.Visible = true;
            lblfechalab.Text = "Asignado";
            lblfechaergo.Text = "Asignado";
            gbFechas.Enabled = false;
            fechaLista = true;
        }
    }
}
