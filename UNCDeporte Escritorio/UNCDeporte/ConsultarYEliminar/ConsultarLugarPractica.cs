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

namespace UNCDeporte.Interfaz.Admin
{
    public partial class ConsultarLugarPractica : Form
    {
        GestorLugarPractica glp = new GestorLugarPractica();
        GestorLocalidad gl = new GestorLocalidad();

        public ConsultarLugarPractica()
        {
            InitializeComponent();
        }
 
        private void ConsultarLugarPractica_Load(object sender, EventArgs e)
        {
            /*dg_LugarPractica.DataSource = glp.Consultar();
            dg_LugarPractica.DataMember = "lugaresPractica";
            dg_LugarPractica.Columns[0].Visible = false;
            */
            //InitializeComponent();
            dg_LugarPractica.Enabled = false;
            dg_LugarPractica.DataSource = glp.Consultar();
            dg_LugarPractica.DataMember = "LugaresPractica";
            dg_LugarPractica.Columns[0].Visible = false;
            LLenarComboLocalidad();
        }

        public void LLenarComboLocalidad()
        {
            List<Localidad> localidades = new List<Localidad>();
            Localidad loc = new Localidad();
            loc.id_localidad = 0;
            loc.nombre = "- Seleccione una Localidad -";
            localidades.Add(loc);

            foreach (DataRow dr in gl.Consultar().Tables[0].Rows)
            {
                localidades.Add(new Localidad { id_localidad = Convert.ToInt32(dr["id_localidad"]), nombre = Convert.ToString(dr["nombre"]) });
            }

            cmbLocalidades.DataSource = localidades;
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gb_Consulta.Enabled = true;
            dg_LugarPractica.Enabled = true;
            int id_localidad;
            string nombre = txtNombre.Text;

            if (txtNombre.Text == "" && (cmbLocalidades.Text == "- Seleccione una Localidad -" || cmbLocalidades.Text == "Todas las localidades"))
            {
                dg_LugarPractica.DataSource = glp.Consultar();
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[0].Visible = false;
            }

            if (txtNombre.Text == "" && (cmbLocalidades.Text != "- Seleccione una Localidad -" && cmbLocalidades.Text != "Todas las localidades"))
            {
                id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                dg_LugarPractica.DataSource = glp.ConsultarPorFiltro(nombre, id_localidad);
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[0].Visible = false;
            } 
            
            if (txtNombre.Text != "" && (cmbLocalidades.Text == "- Seleccione una Localidad -" || cmbLocalidades.Text == "Todas las localidades"))
            {
                dg_LugarPractica.DataSource = glp.ConsultarPorFiltro(nombre);
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[0].Visible = false;
            }

            if (txtNombre.Text != "" && (cmbLocalidades.Text != "- Seleccione una Localidad -" && cmbLocalidades.Text != "Todas las localidades"))
            {
                id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                dg_LugarPractica.DataSource = glp.ConsultarPorFiltro(nombre, id_localidad);
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[0].Visible = false;
            }

            if (dg_LugarPractica.RowCount == 0)
            {
               MessageBox.Show("No se encontró ningún Lugar de Práctica.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtNombre.Text = "";
               cmbLocalidades.SelectedIndex = 0;
               txtNombre.Focus();
            }
        }

        private void cmbLocalidades_Click(object sender, EventArgs e)
        {
            List<Localidad> localidades = new List<Localidad>();
            Localidad loc = new Localidad();
            loc.id_localidad = 0;
            loc.nombre = "Todas las localidades";
            localidades.Add(loc);

            foreach (DataRow dr in gl.Consultar().Tables[0].Rows)
            {
                localidades.Add(new Localidad { id_localidad = Convert.ToInt32(dr["id_localidad"]), nombre = Convert.ToString(dr["nombre"]) });
            }
            
            cmbLocalidades.DataSource = localidades;
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = 0;
        }
    }
}