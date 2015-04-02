using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNCDeporte.Admin
{
    public partial class Eliminatoria4 : Form
    {
        public Eliminatoria4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Eliminatoria4_Load(object sender, EventArgs e)
        {
            txtParticipante1.Text = global.p1;
            txtParticipante2.Text = global.p2;
            txtParticipante3.Text = global.p3;
            txtParticipante4.Text = global.p4;
        }

        private void txtParticipante1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
