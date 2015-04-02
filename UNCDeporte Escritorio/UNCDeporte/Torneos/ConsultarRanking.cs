using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.TorneosYEventos
{
    public partial class ConsultarRanking : Form
    {
        public ConsultarRanking()
        {
            InitializeComponent();
        }

        private void ConsultarRanking_Load(object sender, EventArgs e)
        {
            cargarDeportesTorneo("Federado");

               

        }


        public void cargarDeportesTorneo(string tipo)
        {
            GestorDeporte gp = new GestorDeporte();
            cmbDeportes.DataSource = gp.Consultar(true, tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;

        }

      
        

        private void cmbDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                GestorTorneo gt = new GestorTorneo();
                dgRanking.DataSource = gt.ConsultarRanking(id_deporte);
                dgRanking.DataMember = "RankingFederados";
            }
            catch (Exception ex) { }



        }

        }
    }

