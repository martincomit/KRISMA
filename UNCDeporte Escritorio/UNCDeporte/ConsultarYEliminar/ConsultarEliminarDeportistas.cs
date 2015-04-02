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
    public partial class ConsultarEliminarDeportistas : Form
    {
        GestorDeportista gde = new GestorDeportista();
        //GestorTorneo gt = new GestorTorneo();


        public ConsultarEliminarDeportistas()
        {
            InitializeComponent();
        }

        private void ConsultarDeportistas_Load(object sender, EventArgs e)
        {
            dgDeportistas.DataSource = gde.ConsultarDeportistasDeAlta();
            dgDeportistas.DataMember = "deportistas";

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

            //dgDeportistas.Columns[0].Visible = false;
        }

        public void cargarDeportes(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnFiltrarDeportista_Click(object sender, EventArgs e)
        {
            cbEliminar.Checked = false;
            if (txtDocumento.Text != "")
            {
                int documento = int.Parse(txtDocumento.Text);
               
                dgDeportistas.DataSource = gde.ConsultarPorDocumento(documento);
                dgDeportistas.DataMember = "deportistas";
                //dgDeportistas.Columns[0].Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("No ingresó un Documento, vuelva a intentarlo.", "Consulta de Deportista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumento.Focus();
                return;
            }

            if (dgDeportistas.RowCount == 1)
            {
                MessageBox.Show("No existe Deportista con ese documento.", "Consulta de Deportista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgDeportistas.DataSource = gde.ConsultarDeportistasDeAlta();
                dgDeportistas.DataMember = "deportistas";
                dgDeportistas.Columns[0].Visible = false;
                txtDocumento.Text = ""; 
                txtDocumento.Focus();
                return;
            }
        }

        private void dgDeportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (global.eliminar == true)
            if (global.eliminar == true && dgDeportistas.CurrentCell.ColumnIndex == 0)
            {
                DialogResult res;
                res = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int documento = int.Parse(dgDeportistas.Rows[e.RowIndex].Cells[1].Value.ToString());
                        gde.DarBaja(documento);

                        //consulto luego de eliminar para refrescar la grilla
                        dgDeportistas.DataSource = gde.ConsultarDeportistasDeAlta();
                        dgDeportistas.DataMember = "Deportistas";
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDocumento.MaxLength = 8;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            return;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            cbEliminar.Checked = false;
            dgDeportistas.DataSource = gde.Consultar();
            dgDeportistas.DataMember = "deportistas";
            //dgDeportistas.Columns[0].Visible = false;
        }

        private void cbBajaDeportistaEspecifico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminar.Checked == true)
            {
                cbTodos.Checked = false;
                txtAñoInscripcion.Text = "";
            }    
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Dar De Baja";
            buttonColumn.HeaderText = "Dar De Baja";
            buttonColumn.Text = "Dar De Baja";
            buttonColumn.ToolTipText = "Dar De Baja";
            buttonColumn.UseColumnTextForButtonValue = true;
            if (cbEliminar.Checked == true)
            {
                dgDeportistas.Columns.Insert(0, buttonColumn);
                global.eliminar = true;
            }
            else
            {
                dgDeportistas.Columns.Remove("Dar De Baja");
                global.eliminar = true;
            }
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked == true)
            //if (cbTodos.Checked == true && (gt.hayTorneosEnCurso() == "No existe"))
            {
                //Deberia validar con un if que es un nuevo año de inscripcion y no dejar hacerlo si estan en curso torneos por ejemplo, algo asi. Con metodos como hayTorneoEnCurso(), hayClasesEnCurso()             
                lblAñoInscripcion.Enabled = true;
                btnBajaATodos.Enabled = true;
                cbEliminar.Checked = false;

                /*para probar que andaba
                string añoactual = DateTime.Now.Year.ToString();
                MessageBox.Show("añoactual: " + añoactual + " resultado q deberia dar: 2014");
                int año = int.Parse(añoactual)+1;//puse +1 para que de 2015 porque las altas que tenia cargadas la bd en el momento que probe eran del 2014 nada mas.
                MessageBox.Show("casteo añoActual a  int: " + año + " resultado q deberia dar: 2015");
                int añoAnt = año - 1;//2015-1
                MessageBox.Show("calculo año anterior: " + añoAnt + " resultado q deberia dar: 2014");
                string añoAnterior = añoAnt.ToString();
                MessageBox.Show("casteo año anterior: " + añoAnterior + " resultado q deberia dar: 2014");
                txtAñoInscripcion.Text = añoAnterior;
                */

                string añoactual = DateTime.Now.Year.ToString();
                int año = int.Parse(añoactual);
                int añoAnt = año - 1;
                string añoAnterior = añoAnt.ToString();
                txtAñoInscripcion.Text = añoAnterior;
            }
            else 
            {
                lblAñoInscripcion.Enabled = false;
                txtAñoInscripcion.Enabled = false;
                btnBajaATodos.Enabled = false;
            }
        }

        private void btnDarBajaATodos_Click(object sender, EventArgs e)
        {
            DialogResult res;
            
            if (txtAñoInscripcion.Text != "")
            {
                res = MessageBox.Show("¿Está seguro que desea dar de baja a los deportistas por el año de inscripción indicado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int añoInscripcion = int.Parse(txtAñoInscripcion.Text);
                        //gde.DarBajaDeportistasPorAñoInscripcion(añoInscripcion);
                        MessageBox.Show("Los deportistas se dieron de baja con éxito.", "Baja de Deportistas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAñoInscripcion.Text = "";
                        cbTodos.Checked = false;
                        return;        
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void txtAñoInscripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAñoInscripcion.MaxLength = 4;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}