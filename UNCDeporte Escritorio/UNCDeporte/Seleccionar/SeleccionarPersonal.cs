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
    public partial class SeleccionarPersonal : Form
    {
        public SeleccionarPersonal()
        {
            InitializeComponent();
        }

        private void SeleccionarPersonal_Load(object sender, EventArgs e)
        {
            GestorPersonal gp = new GestorPersonal();
            dgPersonal.DataSource = gp.Consultar();
            dgPersonal.DataMember = "Personal";
        }

        private void dgPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int documento = 1;
            global.documento = int.Parse(dgPersonal.Rows[e.RowIndex].Cells[documento].Value.ToString());
            AltadeUsuarios form = new AltadeUsuarios();
            form.Show();

            this.Close();
        }
    }
}
