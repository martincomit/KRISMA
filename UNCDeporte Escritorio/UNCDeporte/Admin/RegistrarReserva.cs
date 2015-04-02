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
    public partial class RegistrarReserva : Form
    {
        public RegistrarReserva()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarReservas form = new ConsultarReservas();
            form.Show();
        }

        private void RegistrarReserva_Load(object sender, EventArgs e)
        {
            dgvReserva.Rows.Add("08:00");
            dgvReserva.Rows.Add("08:05");
            dgvReserva.Rows.Add("08:10");
            dgvReserva.Rows.Add("08:15");
            dgvReserva.Rows.Add("08:20");
            dgvReserva.Rows.Add("08:25");
            dgvReserva.Rows.Add("08:30");
            dgvReserva.Rows.Add("08:35");
            dgvReserva.Rows.Add("08:40");
            dgvReserva.Rows.Add("08:45");
            dgvReserva.Rows.Add("08:50");
            dgvReserva.Rows.Add("08:55");
            dgvReserva.Rows.Add("09:00");
            dgvReserva.Rows.Add("09:05");
            dgvReserva.Rows.Add("09:10");
            dgvReserva.Rows.Add("09:15");
            dgvReserva.Rows.Add("09:20");
            dgvReserva.Rows.Add("09:25");
            dgvReserva.Rows.Add("09:30");
            dgvReserva.Rows.Add("09:35");
            dgvReserva.Rows.Add("09:40");
            dgvReserva.Rows.Add("09:45");
            dgvReserva.Rows.Add("09:50");
            dgvReserva.Rows.Add("09:55");
            dgvReserva.Rows.Add("10:00");
            dgvReserva.Rows.Add("10:05");
            dgvReserva.Rows.Add("10:10");
            dgvReserva.Rows.Add("10:15");
            dgvReserva.Rows.Add("10:20");
            dgvReserva.Rows.Add("10:25");
            dgvReserva.Rows.Add("10:30");
            dgvReserva.Rows.Add("10:35");
            dgvReserva.Rows.Add("10:40");
            dgvReserva.Rows.Add("10:45");
            dgvReserva.Rows.Add("10:50");
            dgvReserva.Rows.Add("10:55");
            dgvReserva.Rows.Add("11:00");
            dgvReserva.Rows.Add("11:05");
            dgvReserva.Rows.Add("11:10");
            dgvReserva.Rows.Add("11:15");
            dgvReserva.Rows.Add("11:20");
            dgvReserva.Rows.Add("11:25");
            dgvReserva.Rows.Add("11:30");
            dgvReserva.Rows.Add("11:35");
            dgvReserva.Rows.Add("11:40");
            dgvReserva.Rows.Add("11:45");
            dgvReserva.Rows.Add("11:50");
            dgvReserva.Rows.Add("11:55");
            dgvReserva.Rows.Add("12:00");
            dgvReserva.Rows.Add("12:05");
            dgvReserva.Rows.Add("12:10");
            dgvReserva.Rows.Add("12:15");
            dgvReserva.Rows.Add("12:20");
            dgvReserva.Rows.Add("12:25");
            dgvReserva.Rows.Add("12:30");
            dgvReserva.Rows.Add("12:35");
            dgvReserva.Rows.Add("12:40");
            dgvReserva.Rows.Add("12:45");
            dgvReserva.Rows.Add("12:50");
            dgvReserva.Rows.Add("12:55");
            dgvReserva.Columns[0].DefaultCellStyle.BackColor= Color.Aqua;
            dgvReserva.ClearSelection();
            foreach (DataGridViewRow row in dgvReserva.Rows)
            {
                row.Height = 12;
            }
            
            dgvReserva.Rows[3].Cells[3].Style.BackColor = Color.Black;
            
        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReserva.CurrentCell.ColumnIndex==0)
            {
                dgvReserva.ClearSelection();
            }
        }

     
    }
}
