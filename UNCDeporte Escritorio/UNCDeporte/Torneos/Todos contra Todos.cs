using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNCDeporte.TorneosYEventos
{
    public partial class Todos_contra_Todos : Form
    {
        public Todos_contra_Todos()
        {
            InitializeComponent();
        }

        private void Todos_contra_Todos_Load(object sender, EventArgs e)
        {
            int rondas = global.cantidad_participantes_torneo;
            lblcantidad.Text = rondas + "";

            for (int i = 1; i < rondas+1; i++)
                cmbRondas.Items.Add("Ronda " + i);

        }
    }
}
