using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class ConsultarUsuarios : Form
    {
        GestorPerfil gp = new GestorPerfil();
        GestorUsuario gu = new GestorUsuario();
        string estado = "";
        string documento = "";
        string perfil = "";

        public ConsultarUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (global.eliminar == true)
            {
                DialogResult res;
                res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int documento = int.Parse(dgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                      
                        gu.Eliminar(documento);

                        //consulto luego de eliminar para refrescar la grilla
                        dgUsuarios.DataSource = gu.ConsultarConPerfil();
                        dgUsuarios.DataMember = "UsuariosxPerfiles";

                    }
                    catch (Exception ex) { }
                }

            }
        }

        private void ConsultarUsuarios_Load(object sender, EventArgs e)
        {

            GestorUsuario gu = new GestorUsuario();
            dgUsuarios.DataSource = gu.ConsultarConPerfil();
            dgUsuarios.DataMember = "usuariosxperfiles";
            LLenarComboPerfiles();

        }

        public void LLenarComboPerfiles()
        {

            GestorPerfil gp = new GestorPerfil();
            cmbPerfil.DataSource = gp.ConsultarTodos().Tables[0];
            cmbPerfil.DisplayMember = "Nombre";
            cmbPerfil.ValueMember = "id_perfil";
            cmbPerfil.SelectedIndex = -1;

        }


        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
           // DataGridViewButtonColumn buttonColumn =
           //new DataGridViewButtonColumn();
           // buttonColumn.Name = "Eliminar";
           // buttonColumn.HeaderText = "Eliminar";
           // buttonColumn.Text = "Eliminar";
           // buttonColumn.ToolTipText = "Eliminar";
           // buttonColumn.UseColumnTextForButtonValue = true;
           // if (cbEliminar.Checked == true)
           // {
           //     dgUsuarios.Columns.Insert(0, buttonColumn);
           //     global.eliminar = true;
           // }
           // else
           // {
           //     dgUsuarios.Columns.Remove("Eliminar");
           //     global.eliminar = true;
           // }
        }

        private void cbEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.Name = "Eliminar";
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Text = "Eliminar";
            buttonColumn.ToolTipText = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true;
            if (cbEliminar.Checked == true)
            {
                dgUsuarios.Columns.Insert(0, buttonColumn);
                global.eliminar = true;
            }
            else
            {
                dgUsuarios.Columns.Remove("Eliminar");
                global.eliminar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnFiltrarDeportista_Click(object sender, EventArgs e)
        {


            //en caso de alta asigna 1 al estado, y en documento asigna % si es nulo y sino manda el parametro.
            if (cmbEstado.Text == "Alta")
                estado = 1+"";
            if (cmbEstado.Text == "Baja")
                estado = 0+"";
            if (cmbEstado.Text == "")
                estado = "%";


            if (txtDocumento.Text == "")
                documento = "%";
            if (txtDocumento.Text !="")
                documento = txtDocumento.Text;

            if (cmbPerfil.Text == "")
                perfil = "%";
            if (cmbPerfil.Text != "")
                perfil = cmbPerfil.SelectedValue.ToString();




            dgUsuarios.DataSource = gu.ConsultarUsuarios(documento, perfil, estado);
            dgUsuarios.DataMember = "usuariosxperfiles";
 
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbPerfil.SelectedValue = -1;
            cmbEstado.SelectedIndex = -1;
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDocumento.MaxLength = 8;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }

            return;
        }

        }
    }

