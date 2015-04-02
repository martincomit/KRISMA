using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNCDeporte.Altas
{
    public partial class AgregarDeporteADeportistaInscripto : Form
    {
        public AgregarDeporteADeportistaInscripto()
        {
            InitializeComponent();
        }

        private void AgregarDeporteADeportistaInscripto_Load(object sender, EventArgs e)
        {
            //dgInscripciones.ReadOnly = true;
            GestorInscripcion gi = new GestorInscripcion();
            dgInscripciones.DataSource = gi.ConsultarDeportistas();
            dgInscripciones.DataMember = "Deportistas";
       
        }

   

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filas = dgInscripciones.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgInscripciones.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            dgInscripciones.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;


            DialogResult res;
            res = MessageBox.Show("Desea agregar mas deportes a deportista?", "Mensaje", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                global.dni = int.Parse(dgInscripciones.Rows[e.RowIndex].Cells[1].Value.ToString());
                //MessageBox.Show(global.dni.ToString());
                InscribirMasDeporte form = new InscribirMasDeporte();
                form.Show();
             

            }

        }

    }
}
