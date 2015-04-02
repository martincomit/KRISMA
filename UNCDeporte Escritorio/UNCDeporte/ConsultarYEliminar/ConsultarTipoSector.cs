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
    public partial class ConsultarTipoSector : Form
    {
        public ConsultarTipoSector()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ConsultarTipoSector_Load(object sender, EventArgs e)
        {
            GestorTipoSector gts = new GestorTipoSector();
            dg_tipo_sector.DataSource = gts.Consultar();
            dg_tipo_sector.DataMember = "TiposSector";
            dg_tipo_sector.Columns[0].Visible = false;
        }

        
    }
}
