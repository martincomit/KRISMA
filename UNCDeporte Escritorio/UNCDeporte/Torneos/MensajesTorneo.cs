using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNCDeporte.Torneos;
using Logica;

namespace UNCDeporte.TorneosYEventos
{
    public partial class MensajesTorneo : Form
    {
        public MensajesTorneo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarTorneo form = new ModificarTorneo();
            form.Show();
        }

        //public void LLenarComboTorneos()
        //{
        //    List<string> torneosSeleccion = new List<string>();
        //    torneosSeleccion.Add("- Seleccione un Torneo -");
        //    cmbTorneos.DataSource = torneosSeleccion;
        //}

      









        private void MensajesTorneo_Load(object sender, EventArgs e)
        {
            //try
            //{

            //    LLenarComboTorneos();

            //}
            //catch (Exception ex) { }


            try
            {
                GestorMensaje gm = new GestorMensaje();
                //int id_torneo = int.Parse(cmbTorneos.SelectedValue.ToString());
                dgMensajes.DataSource = gm.ConsultarMensajes();
                dgMensajes.DataMember = "MensajesXTorneo";
            }
            catch (Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //private void cmbTorneos_Click_1(object sender, EventArgs e)
        //{
        //    GestorTorneo gt = new GestorTorneo();
        //    cmbTorneos.DataSource = gt.Consultar().Tables[0];
        //    cmbTorneos.DisplayMember = "Nombre";
        //    cmbTorneos.ValueMember = "id_torneo";
        //    cmbTorneos.SelectedIndex = 0;     
        //}

        private void cmbTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgMensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
                DialogResult res;
                res = MessageBox.Show("“¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int id_mensaje = int.Parse(dgMensajes.Rows[e.RowIndex].Cells[1].Value.ToString());
                        GestorMensaje gm = new GestorMensaje();
                        gm.EliminarMensaje(id_mensaje);

                        //consulto luego de eliminar para refrescar la grilla
                        dgMensajes.DataSource = gm.ConsultarMensajes();
                        dgMensajes.DataMember = "MensajesXTorneo";

                    }
                    catch (Exception ex) { }
                }

            
        }
    }
}
