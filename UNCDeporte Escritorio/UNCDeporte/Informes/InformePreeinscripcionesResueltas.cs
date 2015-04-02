using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.Informes
{
    public partial class InformePreeinscripcionesResueltas : Form
    {
        GestorInscripcion gi = new GestorInscripcion();
        public InformePreeinscripcionesResueltas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void InformePreeinscripcionesResueltas_Load(object sender, EventArgs e)
        {

            dgInscripciones.DataSource = gi.ConsultarInscriptos();
            dgInscripciones.DataMember = "Detalles_Insc_Disciplina";

            cmbTipo.Items.Add("Inscripto Recreativo");
            cmbTipo.Items.Add("Inscripto Federado");
            cmbTipo.Items.Add("Todos");
            //-------------------------------------------------------------------------------------
            txtRecreativos.Text = gi.ContarInscripciones(9).ItemArray.GetValue(0).ToString(); //9 id estado recreativo
            txtFederados.Text = gi.ContarInscripciones(8).ItemArray.GetValue(0).ToString();
            txtCancelados.Text = gi.ContarInscripciones(10).ItemArray.GetValue(0).ToString();

            int recreativos = int.Parse(txtRecreativos.Text);
            int federados = int.Parse(txtFederados.Text);
            int cancelados = int.Parse(txtCancelados.Text);
            txtTotal1.Text = (recreativos + federados + cancelados)+"";

            //---------------------------------------------------------------------------------------
            txtAprobados.Text = gi.ContarInscripciones(6).ItemArray.GetValue(0).ToString();
            txtAprobadosRecreativos.Text = gi.ContarInscripciones(11).ItemArray.GetValue(0).ToString();
            txtDesaprobados.Text = gi.ContarInscripciones(7).ItemArray.GetValue(0).ToString();

            int aprobados = int.Parse(txtAprobados.Text);
            int aprobadosrecreativos = int.Parse(txtAprobadosRecreativos.Text);
            int desaprobados = int.Parse(txtDesaprobados.Text);
            txtTotal2.Text = (aprobados + aprobadosrecreativos + desaprobados) + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Todos")
            {
                dgInscripciones.DataSource = gi.ConsultarInscriptos();
                dgInscripciones.DataMember = "Detalles_Insc_Disciplina";
                return;
            }

            if (cmbTipo.Text == "Inscripto Recreativo")
            {
                dgInscripciones.DataSource = gi.ConsultarInscriptos(9);
                dgInscripciones.DataMember = "Detalles_Insc_Disciplina";
                return;
            }

            if (cmbTipo.Text == "Inscripto Federado")
            {
                dgInscripciones.DataSource = gi.ConsultarInscriptos(8);
                dgInscripciones.DataMember = "Detalles_Insc_Disciplina";
                return;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
