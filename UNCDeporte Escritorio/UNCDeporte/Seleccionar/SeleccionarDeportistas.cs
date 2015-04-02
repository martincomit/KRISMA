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
    public partial class SeleccionarDeportistas : Form
    {
        public SeleccionarDeportistas()
        {
            InitializeComponent();
        }

        private void ConsultarDeportistas_Load(object sender, EventArgs e)
        {
            GestorDeportista gd = new GestorDeportista();
            dgDeportistas.DataSource = gd.Consultar();
            dgDeportistas.DataMember = "deportistas";
          
        }

        private void dgDeportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           global.documentoDeportista = int.Parse(dgDeportistas.Rows[e.RowIndex].Cells[1].Value.ToString());
           //InscribirDeportistaAOtrosDeportes form = new InscribirDeportistaAOtrosDeportes();
           //form.Show();
           this.Close();





        }
    }
}
