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
    public partial class InscribirMasDeporte : Form
    {
        public InscribirMasDeporte()
        {
            InitializeComponent();
        }

        private void InscribirMasDeporte_Load(object sender, EventArgs e)
        {
            int documento = global.dni;
            lblDocumento.Text = documento + "";

            llenarDeportes("recreativo");
            cargarEstado();
            cargarDeportesInscriptos();
          
            
        }

        public void cargarDeportesInscriptos()
        {
            try
            {
                GestorDeporte gd = new GestorDeporte();
               
                dgInscriptos.DataSource = gd.ConsultarDeportesInscriptos(global.dni);
                dgInscriptos.DataMember = "Deportes";
                dgInscriptos.Columns[2].Visible = false;
            }
            catch (Exception ex) { }
        }

        public void llenarDeportes(string tipo)
        {

            GestorDeporte gd = new GestorDeporte();
            cmbDeportes.DataSource = gd.Consultar(tipo).Tables[0];
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;
        }

       

        public void cargarEstado()
        {
            try
            {
                GestorEstado ge = new GestorEstado();
                lblEstado.Text = ge.Consultar(global.id_estado).Tables[0].Rows[0][1].ToString();

                if (lblEstado.Text == "aprobado")
                {
                    lblEstado.BackColor = Color.Lime;
                    rbFederado.Enabled = true;
                }
                if (lblEstado.Text == "aprobado_solo_recreativas")
                {
                    lblEstado.BackColor = Color.Yellow;
                    rbFederado.Enabled = false;
                }
                //if (lblEstado.Text == "desaprobado")
                //    lblEstado.BackColor = Color.Red;
            }
            catch (Exception ex) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre_deporte = cmbDeportes.Text;
                string tipo;
                int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
                if (rbRecreativo.Checked == true)
                    tipo = "recreativo";
                else
                    tipo = "federado";


                //MessageBox.Show(nombre_deporte);
                dgDeportes.Rows.Add("", nombre_deporte, tipo, id_deporte);

            }
            catch (Exception ex) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgDeportes.RowCount == 0)
            {
                MessageBox.Show("Ingrese al menos un nuevo deporte");
                return;
            }

            int filasInscriptas = dgInscriptos.RowCount;
            int filas = dgDeportes.RowCount;
            int id_deportes;
            int id_deportes_inscriptos;
            int[] vector_id_deporte_inscriptos = new int[20];
            int[] vector_id_deporte = new int[20]; //ver como hacer vector dinamico 
            string[] vector_tipo = new string[20];


            for (int i = 0; i < filasInscriptas; i++)
            {
                id_deportes_inscriptos = int.Parse(dgInscriptos.Rows[i].Cells[2].Value.ToString()); //2 id en columna oculta
                vector_id_deporte_inscriptos[i] = id_deportes_inscriptos;
                
            }


            for (int i = 0; i < filas; i++)
            {
                id_deportes = int.Parse(dgDeportes.Rows[i].Cells[3].Value.ToString()); //3 id en columna oculta
                vector_id_deporte[i] = id_deportes;
                vector_tipo[i] = dgDeportes.Rows[i].Cells[2].Value.ToString(); // 2 tipo en string recreativo o federado
            }
            Boolean repetidos = false;
            for (int i = 1; i < filas; i++)
            {
                if (vector_id_deporte[i] == vector_id_deporte[i - 1])
                    repetidos = true;
            }

            if (repetidos == true)
                MessageBox.Show("Elimine los deportes repetidos");

            Boolean repetidosInscriptos = false;
            for (int i = 0; i < filasInscriptas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (vector_id_deporte_inscriptos[i] == vector_id_deporte[j])
                    {
                        repetidosInscriptos = true;
                        break;
                    }
                    
                }
            }

            if (repetidosInscriptos == true)
                MessageBox.Show("Ya esta inscripto");


            /*


            int filas = dgDeportes.RowCount;
            int id_deportes;
            int[] vector_id_deporte = new int[20]; //ver como hacer vector dinamico 
            string[] vector_tipo = new string[20];


            for (int i = 0; i < filas; i++)
            {
                id_deportes = int.Parse(dgDeportes.Rows[i].Cells[3].Value.ToString()); //3 id en columna oculta
                vector_id_deporte[i] = id_deportes;
                vector_tipo[i] = dgDeportes.Rows[i].Cells[2].Value.ToString(); // 2 tipo en string recreativo o federado
            }
            Boolean repetidos = false;
            for (int i = 1; i < filas; i++)
            {
                if (vector_id_deporte[i] == vector_id_deporte[i - 1])
                    repetidos = true;
            }
            if (repetidos == true)
                MessageBox.Show("Elimine los deportes repetidos");
            else
            {



                if (filas == 0)
                    MessageBox.Show("Ingrese al menos un deporte");

                else
                {
                    GestorInscripcion gi = new GestorInscripcion();
                    string guardado;
                    int documento = int.Parse(lblDocumento.Text);
                    int cantidad = dgDeportes.RowCount;
                    guardado = gi.Registrar(documento, vector_id_deporte, cantidad, vector_tipo);

                    if (guardado == "Guardado")
                    {

                        MessageBox.Show("Guardado Correctamente");

                        return;
                    }

                    if (guardado == "Error al Guardar")
                    {

                        MessageBox.Show("No Guardado, error de escritura");
                        return;
                    }


                }
            } */
        }

        private void dgDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgDeportes.Rows.RemoveAt(dgDeportes.CurrentRow.Index);
        }

        private void rbFederado_CheckedChanged(object sender, EventArgs e)
        {
            llenarDeportes("federado");
        }

        private void rbRecreativo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDeportes("recreativo");
        } 

    }
}
