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

//solo cupo se modifica, lo demas no
// los estados tendrian que filtrar por ambito

namespace UNCDeporte.Torneos
{
    public partial class ModificarTorneo : Form
    {
        string guardado;
        GestorTorneo gt = new GestorTorneo();

        public ModificarTorneo()
        {
            InitializeComponent();
            lblGuardado.Text = "";
        }

        private void ModificarTorneo_Load(object sender, EventArgs e)
        {
            dgTorneos.DataSource = gt.Consultar();
            dgTorneos.DataMember = "Torneos";
            dgTorneos.Columns[1].Visible = false;
            LLenarComboEstados();
        }

        public void LLenarComboEstados()
        {
            List<string> estadosSeleccion = new List<string>();
            estadosSeleccion.Add("- Seleccione un Estado -");
            cmbEstadoInicial.DataSource = estadosSeleccion;
        }

        private void dgTorneo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gbBusqueda.Enabled = false;

            DialogResult res;
            if (dgTorneos.CurrentCell.ColumnIndex == 0)
            {
                res = MessageBox.Show("¿Está seguro que desea modificar el torneo seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        gbBusqueda.Enabled = false;
                        dgTorneos.Enabled = false;

                        gbDatosTorneo.Enabled = true;
                        btnGuardar.Enabled = true;

                        cmbEstados.SelectedItem = dgTorneos.Rows[e.RowIndex].Cells[9].Value.ToString();
                        //cmbEstados.Enabled = false;
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    gbDatosTorneo.Enabled = false;
                    gbBusqueda.Enabled = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblGuardado.Text = "";
            dgTorneos.Enabled = true;
            
            string nombre = txtNombre.Text;

            if (txtNombre.Text == "")
            {
                dgTorneos.DataSource = gt.Consultar();
                dgTorneos.DataMember = "Torneos";
                dgTorneos.Columns[1].Visible = false;
            }
            
            if (txtNombre.Text != "")
            {
               dgTorneos.DataSource = gt.ConsultarPorFiltro(nombre);
                dgTorneos.DataMember = "Torneos";
                dgTorneos.Columns[1].Visible = false;
            }

            if (dgTorneos.RowCount == 0)
            {
                MessageBox.Show("No se encontró ningún Torneo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //falta, copie codigo de modificar lugar de practica

            /*
             
             if (txtNombreNuevo.Text == "" && txtDireccionNueva.Text == "")
            {
                txtNombreNuevo.Focus();
                MessageBox.Show("Completar los campos obligatorios para el Lugar de Práctica.", "Modificación de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNombreNuevo.Text == "")
            {
                txtNombreNuevo.Focus();
                MessageBox.Show("Ingrese un nombre para el Lugar de Práctica.", "Modificación de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (txtDireccionNueva.Text == "")
            {
                txtDireccionNueva.Focus();
                MessageBox.Show("Ingrese una dirección para el Lugar de Práctica.", "Modificación de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GestorLugarPractica glp = new GestorLugarPractica();

            Localidad ln = new Localidad();
            Barrio bn = new Barrio();

            int id_lugar = int.Parse(txtID.Text);
            string nombre = txtNombreNuevo.Text;
            string descripcion = txtDescripcionNueva.Text;
            string direccion = txtDireccionNueva.Text;

            int id_localidad = (int)cmbLocalidadNueva.SelectedValue;
            int id_barrio = (int)cmbBarrioNuevo.SelectedValue;
            
            guardado = glp.Modificar(id_lugar, nombre, descripcion, direccion,id_localidad,id_barrio);

            if (guardado == "Existe")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                MessageBox.Show("Ya existe un Lugar de Práctica con ese nombre.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            
            if (guardado == "Modificado")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                btnGuardar.Enabled = false;
                gb_datosAModificar.Enabled = true;
                gb_datosModificados.Enabled = false;

                dg_LugarPractica.DataSource = glp.Consultar();
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Enabled = true;
                MessageBox.Show("Se modificó correctamente el Lugar de Práctica.", "Modificación de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "No Guardado, error de escritura";
                txtNombre.Text = "";
                MessageBox.Show("No se pudo modificar el Lugar de Práctica.", "Modificación de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
             */
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void gbTorneos_Enter(object sender, EventArgs e)
        {

        }
    }
}
