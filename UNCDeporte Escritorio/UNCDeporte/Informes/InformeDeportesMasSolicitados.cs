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
    public partial class InformeDeportesMasSolicitados : Form
    {
        public InformeDeportesMasSolicitados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DeportesMasSolicitados_Load(object sender, EventArgs e)
        {
            GestorDeporte gd = new GestorDeporte();
            dgDeportes.DataSource = gd.ConsultarMasSolicitados();
            dgDeportes.DataMember = "deportes";
            //dgDeportes.Columns[0].Visible = false;
            
           
            cmbTipo.DataSource = gd.ConsultarTipoDeportes().Tables[0];
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.ValueMember = "id_tipo";
            cmbTipo.SelectedIndex = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeporte gd = new GestorDeporte();
                int id_tipo = int.Parse(cmbTipo.SelectedValue.ToString());
                dgDeportes.DataSource = gd.ConsultarTipo(id_tipo);
                dgDeportes.DataMember = "deportes";
            }
            catch (Exception ex) { }
        }

        private void dgDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
