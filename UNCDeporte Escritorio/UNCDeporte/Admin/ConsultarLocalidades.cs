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

namespace UNCDeporte.Admin
{
    public partial class ConsultarLocalidades : Form
    {
       

        public ConsultarLocalidades()
        {
            InitializeComponent();
        }

        private void ConsultarLocalidades_Load(object sender, EventArgs e)
        {
            GestorLocalidad gl = new GestorLocalidad();
            dgLocalidades.DataSource= gl.Consultar();
            dgLocalidades.DataMember = "localidades";
            dgLocalidades.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
