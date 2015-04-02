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
    public partial class ModificarLugarDePractica : Form
    {
        string guardado;
        GestorLugarPractica glp = new GestorLugarPractica();
        GestorLocalidad gl = new GestorLocalidad();
        
        public ModificarLugarDePractica()
        {
            InitializeComponent();
            LLenarComboLocalidad();
            lblGuardado.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblGuardado.Text = ""; 
            dg_LugarPractica.Enabled = true;
            int id_localidad;
            string nombre = txtNombre.Text;

            if (txtNombre.Text == "" && (cmbLocalidades.Text == "- Seleccione una Localidad -" || cmbLocalidades.Text == "Todas las localidades"))
            {
                dg_LugarPractica.DataSource = glp.Consultar();
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[1].Visible = false;
            }

            if (txtNombre.Text == "" && (cmbLocalidades.Text != "- Seleccione una Localidad -" && cmbLocalidades.Text != "Todas las localidades"))
            {
                id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                dg_LugarPractica.DataSource = glp.ConsultarPorFiltro(nombre, id_localidad);
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[1].Visible = false;
            }

            if (txtNombre.Text != "" && (cmbLocalidades.Text == "- Seleccione una Localidad -" || cmbLocalidades.Text == "Todas las localidades"))
            {
                dg_LugarPractica.DataSource = glp.ConsultarPorFiltro(nombre);
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[1].Visible = false;
            }

            if (txtNombre.Text != "" && (cmbLocalidades.Text != "- Seleccione una Localidad -" && cmbLocalidades.Text != "Todas las localidades"))
            {
                id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                dg_LugarPractica.DataSource = glp.ConsultarPorFiltro(nombre, id_localidad);
                dg_LugarPractica.DataMember = "LugaresPractica";
                dg_LugarPractica.Columns[1].Visible = false;
            }

            if (dg_LugarPractica.RowCount == 0)
            {
                MessageBox.Show("No se encontró ningún Lugar de Práctica.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                cmbLocalidades.SelectedIndex = 0;
                txtNombre.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_datosAModificar.Enabled = false;

            DialogResult res;
            if (dg_LugarPractica.CurrentCell.ColumnIndex == 0)
            {
                res = MessageBox.Show("¿Está seguro que desea modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        gb_datosAModificar.Enabled = false;
                        dg_LugarPractica.Enabled = false;

                        gb_datosModificados.Enabled = true;
                        btnGuardar.Enabled = true;
                        
                        txtNombreNuevo.Text = dg_LugarPractica.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtDescripcionNueva.Text = dg_LugarPractica.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtDireccionNueva.Text = dg_LugarPractica.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtID.Text = dg_LugarPractica.Rows[e.RowIndex].Cells[1].Value.ToString();
                        LLenarComboLocalidadNueva();
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    gb_datosModificados.Enabled = false;
                    gb_datosAModificar.Enabled = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ModificarLugarDePractica_Load(object sender, EventArgs e)
        {
            dg_LugarPractica.DataSource = glp.Consultar();
            dg_LugarPractica.DataMember = "LugaresPractica";
            dg_LugarPractica.Columns[1].Visible = false;
            LLenarComboLocalidad();
        }


        public void LLenarComboLocalidad()
        {
            List<Localidad> localidades = new List<Localidad>();
            Localidad loc = new Localidad();
            loc.id_localidad = 0;
            loc.nombre = "- Seleccione una Localidad -";
            localidades.Add(loc);

            cmbLocalidades.DataSource = localidades;
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = 0;
        }

        public void LLenarComboLocalidadNueva()
        {
            cmbLocalidadNueva.DataSource = gl.Consultar().Tables[0];
            cmbLocalidadNueva.DisplayMember = "Nombre";
            cmbLocalidadNueva.ValueMember = "id_localidad";
            cmbLocalidadNueva.SelectedIndex = 0;

            global.id_localidad = int.Parse(cmbLocalidadNueva.SelectedValue.ToString());
            LLenarComboBarrioDeLocalidad();
        }


        public void LLenarComboBarrioDeLocalidad()
        {
            GestorBarrio gb = new GestorBarrio();
            cmbBarrioNuevo.DataSource = gb.Consultar(global.id_localidad).Tables[0]; //.tables[0] pq sino no trae el nombre
            cmbBarrioNuevo.DisplayMember = "Nombre";
            cmbBarrioNuevo.ValueMember = "id_barrio";

            if (cmbBarrioNuevo.Items.Count > 0)
                cmbBarrioNuevo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
        }

        private void cmbLocalidadNueva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalidadNueva.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                global.id_localidad = int.Parse(cmbLocalidadNueva.SelectedValue.ToString());
                LLenarComboBarrioDeLocalidad();
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
