
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;
using UNCDeporte.Torneos;
using UNCDeporte.TorneosYEventos;

namespace UNCDeporte.Torneos
{
    public partial class ConsultaryEliminarTorneos : Form
    {
        GestorDeporte gde = new GestorDeporte();
        GestorEstado ge = new GestorEstado();
        GestorTorneo gt = new GestorTorneo();

        public ConsultaryEliminarTorneos()
        {
            InitializeComponent();
        }

        private void ConsultaryEliminarTorneos_Load(object sender, EventArgs e)
        {
            LLenarComboSeleccionTiposDeporte();
            LLenarComboDeportes();
            LLenarComboEstados();
            dgTorneos.DataSource = gt.Consultar();
            dgTorneos.DataMember = "torneos";
            dgTorneos.Columns[0].Visible = false;
        }

        public void LLenarComboSeleccionTiposDeporte()
        {
            List<string> tiposDeporteSeleccion = new List<string>();
            tiposDeporteSeleccion.Add("- Seleccione un Tipo de Deporte -");
            cmbTiposDeporte.DataSource = tiposDeporteSeleccion;
        }

        public void LLenarComboDeportes()
        {
            List<Deporte> deportes = new List<Deporte>();
            Deporte dep = new Deporte();
            dep.Id_deporte = 0;
            dep.Nombre = "- Seleccione un Deporte -";
            dep.Descripcion = "";
            dep.Cod_sanaviron = 0;
            deportes.Add(dep);

            cmbDeportes.DataSource = deportes;
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;
        }

        public void LLenarComboEstados()
        {
            List<string> estadoSeleccion = new List<string>();
            estadoSeleccion.Add("- Seleccione un Estado -");
            cmbEstados.DataSource = estadoSeleccion;
        }

        private void cmbTiposDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTiposDeporte.SelectedValue == "Recreativo")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoRecreativo().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;
            }

            if (cmbTiposDeporte.SelectedValue == "Federado")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoFederado().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;
            }
        }

        private void cmbTiposDeporte_Click(object sender, EventArgs e)
        {
            List<string> tiposDep = new List<string>();
            tiposDep.Add("Recreativo");
            tiposDep.Add("Federado");
            cmbTiposDeporte.DataSource = tiposDep;
            cmbDeportes.Enabled = true;
        }

        private void cmbDeportes_Click(object sender, EventArgs e)
        {
            if (cmbTiposDeporte.SelectedValue == "Recreativo")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoRecreativo().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;
            }

            if (cmbTiposDeporte.SelectedValue == "Federado")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoFederado().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;
            }
        }

        private void cmbEstados_Click(object sender, EventArgs e)
        {
            cmbEstados.DataSource = gt.ConsultarEstadosTorneo().Tables[0];
            cmbEstados.DisplayMember = "Nombre";
            //cmbEstados.ValueMember = "id_torneo";
            cmbEstados.SelectedIndex = 0;
        }


        private void btnSalir(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cbEliminar.Checked = false;
            dgTorneos.Enabled = true;
            int id_deporte;

            if ((cmbTiposDeporte.Text == "- Seleccione un Tipo de Deporte -" && cmbDeportes.Text == "- Seleccione un Deporte -") && (cmbEstados.Text == "- Seleccione un Estado -"))
            {
                MessageBox.Show("Seleccione alguno de los criterios de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTiposDeporte.Focus();
                cmbDeportes.Enabled = false;
            }

            if ((cmbEstados.Text == "- Seleccione un Estado -") && (cmbTiposDeporte.Text != "- Seleccione un Tipo de Deporte -" && cmbDeportes.Text != "- Seleccione un Deporte -"))
            {
                id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                dgTorneos.DataSource = gt.Consultar(id_deporte);
                dgTorneos.DataMember = "torneos";
                dgTorneos.Columns[0].Visible = false;
            }

            if ((cmbEstados.Text != "- Seleccione un Estado -") && (cmbTiposDeporte.Text == "- Seleccione un Tipo de Deporte -" && cmbDeportes.Text == "- Seleccione un Deporte -"))
            {

            }

            if (dgTorneos.RowCount == 1)
            {
                MessageBox.Show("No existen Torneos que cumpla con los filtros de búsqueda.", "Consulta de Deportista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgTorneos.DataSource = gt.Consultar();
                dgTorneos.DataMember = "torneos";
                dgTorneos.Columns[0].Visible = false;
                LLenarComboSeleccionTiposDeporte();
                LLenarComboDeportes();
                LLenarComboEstados();
                cmbDeportes.Enabled = false;
            }
        }
    }
}
