using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.TorneosYEventos
{
    public partial class TieneFaseAnterior : Form
    {
        GestorTorneo gt = new GestorTorneo();

        public TieneFaseAnterior()
        {
            InitializeComponent();
        }

        private void TieneFaseAnterior_Load(object sender, EventArgs e)
        {
            LLenarComboTorneos();
        }

        public void LLenarComboTorneos()
        {
            List<string> torneosSeleccion = new List<string>();
            torneosSeleccion.Add("- Seleccione un Torneo -");
            cmbTorneos.DataSource = torneosSeleccion;
        }

        private void cmbTorneos_Click(object sender, EventArgs e)
        {
            cmbTorneos.DataSource = gt.Consultar().Tables[0];
            cmbTorneos.DisplayMember = "Nombre";
            cmbTorneos.ValueMember = "id_torneo";
            cmbTorneos.SelectedIndex = 0;                    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbTorneos.Visible = true;
            cmbTorneos.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbTorneos.Visible = false;
            LLenarComboTorneos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
