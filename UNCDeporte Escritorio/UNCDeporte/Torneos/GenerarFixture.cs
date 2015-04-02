using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNCDeporte.Admin;
using Logica;
using UNCDeporte.TorneosYEventos;
using System.Data.SqlClient;

namespace UNCDeporte.Torneos
{
    public partial class GenerarFixture : Form
    {
        int id_deporte;
        int id_torneo;
        
        public GenerarFixture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                global.id_torneo = int.Parse(cmbTorneos.SelectedValue.ToString());
                //Todos_contra_Todos form = new Todos_contra_Todos();
                
                global.cantidad_participantes_torneo= dgParticipantes.RowCount;


                //MessageBox.Show(global.cantidad_participantes_torneo + "");
                Eliminatoria_8 form = new Eliminatoria_8();
                form.Show();
            }
            catch (Exception ex) { }
        }

        private void GenerarFixture_Load(object sender, EventArgs e)
        {
            cmbTipoDeporte.Items.Add("Federado");
            cmbTipoDeporte.Items.Add("Recreativo");
            cmbTipoDeporte.SelectedIndex = 0;

            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportesTorneo("Federado"); 
            }
            else
            {
                 cargarDeportesTorneo("Recreativo");
            }

            try
            {
                int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                cargarTorneos(id_deporte);
            }
            catch (Exception ex) { }

        }


        public void cargarDeportesTorneo(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(true, tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

      
        public void cargarTorneos(int id_deporte)
        {
            //int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
            GestorTorneo gt = new GestorTorneo();
            cmbTorneos.DataSource = gt.Consultar(id_deporte).Tables[0];
            cmbTorneos.DisplayMember = "Nombre";
            cmbTorneos.ValueMember = "id_torneo";
            cmbTorneos.SelectedIndex = 0;

        }

        private void cmbTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestorTorneo gt = new GestorTorneo();
            try
            {
                global.id_deporte_torneo = int.Parse(cmbDeportes.SelectedValue.ToString());

                id_torneo = int.Parse(cmbTorneos.SelectedValue.ToString());
                dgParticipantes.DataSource = gt.ConsultarDatos(id_torneo).Tables[0];
                listCarcteristicas.Items.Clear();
                listCarcteristicas.Items.Add("Descripcion: " + gt.ConsultarDescripcion(id_torneo).Tables[0].Rows[0][0].ToString());
                string estado = gt.ConsultarEstado(id_torneo).Tables[0].Rows[0][0].ToString();
                listCarcteristicas.Items.Add("Estado: "+ estado);

                if (estado == "finalizado")
                {
                    btnConfirmar.Enabled = false;
                }
                else
                {
                    btnConfirmar.Enabled = true;
                }


            }
            catch (Exception ex) { listCarcteristicas.Items.Clear(); }
            
                try
                {
                    if (dgParticipantes.Rows[0].Cells[2].Value != null)
                        global.p1 = dgParticipantes.Rows[0].Cells[2].Value.ToString();


                    if (dgParticipantes.Rows[1].Cells[2].Value != null)
                        global.p2 = dgParticipantes.Rows[1].Cells[2].Value.ToString();

                    if (dgParticipantes.Rows[2].Cells[2].Value != null)
                        global.p3 = dgParticipantes.Rows[2].Cells[2].Value.ToString();

                    if (dgParticipantes.Rows[3].Cells[2].Value != null)
                        global.p4 = dgParticipantes.Rows[3].Cells[2].Value.ToString();

                    if (dgParticipantes.Rows[4].Cells[2].Value != null)
                        global.p5 = dgParticipantes.Rows[4].Cells[2].Value.ToString();

                    if (dgParticipantes.Rows[5].Cells[2].Value != null)
                        global.p6 = dgParticipantes.Rows[5].Cells[2].Value.ToString();

                    if (dgParticipantes.Rows[6].Cells[2].Value != null)
                        global.p7 = dgParticipantes.Rows[6].Cells[2].Value.ToString();

                    if (dgParticipantes.Rows[7].Cells[2].Value != null)
                        global.p8 = dgParticipantes.Rows[7].Cells[2].Value.ToString();



                }
                catch (Exception ex) { }



                try
                {

                    if (dgParticipantes.Rows[0].Cells[1].Value != null)
                        global.docp1 = int.Parse(dgParticipantes.Rows[0].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[1].Cells[1].Value != null)
                        global.docp2 = int.Parse(dgParticipantes.Rows[1].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[2].Cells[1].Value != null)
                        global.docp3 = int.Parse(dgParticipantes.Rows[2].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[3].Cells[1].Value != null)
                        global.docp4 = int.Parse(dgParticipantes.Rows[3].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[4].Cells[1].Value != null)
                        global.docp5 = int.Parse(dgParticipantes.Rows[4].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[5].Cells[1].Value != null)
                        global.docp6 = int.Parse(dgParticipantes.Rows[5].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[6].Cells[1].Value != null)
                        global.docp7 = int.Parse(dgParticipantes.Rows[6].Cells[1].Value.ToString());

                    if (dgParticipantes.Rows[7].Cells[1].Value != null)
                        global.docp8 = int.Parse(dgParticipantes.Rows[7].Cells[1].Value.ToString());

                }
                catch (Exception ex) { }
            
         
        }

        private void dgParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int documento = int.Parse(dgParticipantes.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GestorTorneo gt = new GestorTorneo();
                    gt.Eliminar(documento);

                    //consulto luego de eliminar para refrescar la grilla
                    dgParticipantes.DataSource = gt.ConsultarDatos(id_deporte).Tables[0];
                    dgParticipantes.DataMember = "Torneos";
                
                }
                catch (Exception ex) { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbTipoDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeporte.Text == "Federado")
            {
                cargarDeportesTorneo("Federado"); 
            }
            else
            {
                cargarDeportesTorneo("Recreativo");
            }

        }

        private void cmbDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                cargarTorneos(id_deporte);
            }
            catch (Exception ex) { }
        }
    }
}
