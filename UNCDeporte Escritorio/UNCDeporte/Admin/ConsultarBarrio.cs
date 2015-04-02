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
    public partial class ConsultarBarrio : Form
    {
        public ConsultarBarrio()
        {
            InitializeComponent();
        }

        private void ConsultarBarrio_Load(object sender, EventArgs e)
        {
            GestorBarrio gb = new GestorBarrio();
            dgBarrio.DataSource = gb.Consultar();
            dgBarrio.DataMember = "barrios";
            dgBarrio.Columns[0].Visible = false;
            dgBarrio.Columns[3].Visible = false;
        }

        private void dgBarrio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
