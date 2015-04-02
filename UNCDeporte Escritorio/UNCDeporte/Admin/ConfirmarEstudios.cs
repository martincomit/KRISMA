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
    public partial class ConfirmarEstudios : Form
    {
        public ConfirmarEstudios()
        {
            InitializeComponent();
        }

        private void ConfirmarEstudiosWeb_Load(object sender, EventArgs e)
        {
            int id_estado = 2; //filtro por solicitudes pendientes
            GestorDeportista gd = new GestorDeportista();
            dgSolicitudes.DataSource = gd.Consultar(id_estado);
            dgSolicitudes.DataMember = "deportistas";
        }

        private void dgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filas = dgSolicitudes.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgSolicitudes.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            dgSolicitudes.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;
            DialogResult dr = MessageBox.Show("Desea Confirmar Estudios Medicos", "Mensaje", MessageBoxButtons.YesNo);
            global.dni = int.Parse(dgSolicitudes.Rows[e.RowIndex].Cells[1].Value.ToString());
            ConfirmarEstudiosMedicos form = new ConfirmarEstudiosMedicos();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
