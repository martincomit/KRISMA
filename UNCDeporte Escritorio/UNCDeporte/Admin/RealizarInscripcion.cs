using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class RealizarInscripcion : Form
    {
        public RealizarInscripcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaDeportista form = new AltaDeportista();
            form.Show();
        }

        private void RealizarInscripcion_Load(object sender, EventArgs e)
        {
            dgvDescripcion.Rows.Add("Área deportiva UNC", "Martes/Jueves/Viernes", "14:00 a 16:00/14:00 a 16:00/14:00 a 16:00");
            dgvDescripcion.Rows.Add("Área deportiva UNC", "Martes/Jueves", "21:00 a 23:00/21:00 a 23:00");

            dgvSeleccion.Rows.Add("Fútbol 11","Área deportiva UNC", "Martes/Jueves", "21:00 a 23:00/21:00 a 23:00");
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
