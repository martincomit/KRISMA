﻿using System;
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
    public partial class InscribirDeportistaConEstudiosAprobados : Form
    {
        public InscribirDeportistaConEstudiosAprobados()
        {
            InitializeComponent();
        }

        private void ConsultarAprobados_Load(object sender, EventArgs e)
        {
            GestorDeportista gd = new GestorDeportista();
            dgSolicitudes.DataSource = gd.ConsultarInscripciones(6,11); //6aprobado, 11aprobado solo recreativas
            dgSolicitudes.DataMember = "deportistas";

            GestorEstado ge = new GestorEstado();
            cmbEstados.DataSource = ge.ConsultarAprobados("inscripcion").Tables[0];
            cmbEstados.DisplayMember = "Nombre";
            cmbEstados.ValueMember = "id_estado";
            cmbEstados.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filas = dgSolicitudes.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgSolicitudes.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            dgSolicitudes.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;

            DialogResult res;
            res = MessageBox.Show("Desea inscribir?", "Mensaje", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                global.dni = int.Parse(dgSolicitudes.Rows[e.RowIndex].Cells[1].Value.ToString());
                global.id_estado = int.Parse(dgSolicitudes.Rows[e.RowIndex].Cells[26].Value.ToString());
                Inscripcion form = new Inscripcion(); 
                form.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int documento;
            GestorDeportista gd = new GestorDeportista();

            if (cmbEstados.Text != "")
            {
                int id_estado = int.Parse(cmbEstados.SelectedValue.ToString());
                dgSolicitudes.DataSource = gd.ConsultarInscripcionesEstado(id_estado);
                dgSolicitudes.DataMember = "deportistas";


                if (txtDocumento.Text != "" || txtDocumento.Text == "0")
                {


                    documento = int.Parse(txtDocumento.Text);
                    dgSolicitudes.DataSource = gd.ConsultarInscripcionesEstadoDocumento(id_estado, documento);
                    dgSolicitudes.DataMember = "deportistas";


                }

            }




            else
            {
                if (txtDocumento.Text == "")
                {
                    
                    dgSolicitudes.DataSource = gd.ConsultarInscripciones(6, 11); //6aprobado, 11aprobado solo recreativas
                    dgSolicitudes.DataMember = "deportistas";
                }

                else
                {
                    documento = int.Parse(txtDocumento.Text);
                    dgSolicitudes.DataSource = gd.ConsultarInscripciones(documento);
                    dgSolicitudes.DataMember = "deportistas";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cmbEstados.SelectedIndex = -1;
        }
    }
}
