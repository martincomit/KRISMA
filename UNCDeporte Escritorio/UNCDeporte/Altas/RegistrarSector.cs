using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNCDeporte.Altas
{
    public partial class RegistrarSector : Form
    {
        public GestorSector gs;
        string guardado;
        public RegistrarSector()
        {
            InitializeComponent();
        }

        private void RegistrarSector_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de Sector");
                return;
            }
            if (cmbLugarPractica.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Lugar de Práctica");
                return;
            }
            if (cmbTipoSector.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Sector");
                return;
            }
            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado");
                return;
            }
            gs = new GestorSector();
            //Sector s = new Sector();
            TipoSector ts = new TipoSector();
            LugarPractica lp = new LugarPractica();
            Estado es = new Estado();
            //Deporte d = new Deporte();

            /*s.Nombre = txtNombre.Text;
            s.Descipcion = txtDescripcion.Text;*/
            ts.Id_tipo_sector = Convert.ToInt32(cmbTipoSector.SelectedValue);
            ts.Nombre = cmbTipoSector.Text;
            lp.Id_lugar = Convert.ToInt32(cmbLugarPractica.SelectedValue);
            lp.Nombre = cmbLugarPractica.Text;
            es.Id_estado = Convert.ToInt32(cmbEstado.SelectedValue);
            es.Nombre = cmbEstado.Text;

            //d.Id_deporte = Convert.ToInt32(cmbDeporte.SelectedValue);
            //d.Nombre = cmbDeporte.Text;


            guardado = gs.Registrar(txtNombre.Text, txtDescripcion.Text, ts, lp, es);

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                //limpiar();
                return;
            }

            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                //limpiar();
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, error de escritura";
                //limpiar();
                return;
            }

            btnNuevo.Enabled = true;

        }
    }
}
