using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace UNCDeporte.TorneosYEventos
{
    public partial class Eliminatoria_8 : Form
    {
        static Random _random = new Random();
        public Eliminatoria_8()
        {
            InitializeComponent();
        }

        private void Eliminatoria_8_Load(object sender, EventArgs e)
        {

            //Deportista d1 = new Deportista();
            //d1.Documento = global.docp1;
            //d1.Apellido = global.p1;

            //Deportista d2 = new Deportista();
            //d1.Documento = global.docp2;
            //d1.Apellido = global.p2;

            //Deportista d3 = new Deportista();
            //d1.Documento = global.docp3;
            //d1.Apellido = global.p3;

            //Deportista d4 = new Deportista();
            //d1.Documento = global.docp4;
            //d1.Apellido = global.p4;

            //Deportista d5 = new Deportista();
            //d1.Documento = global.docp5;
            //d1.Apellido = global.p5;

            //Deportista d6 = new Deportista();
            //d1.Documento = global.docp6;
            //d1.Apellido = global.p6;

            //Deportista d7 = new Deportista();
            //d1.Documento = global.docp7;
            //d1.Apellido = global.p7;

            //Deportista d8 = new Deportista();
            //d1.Documento = global.docp8;
            //d1.Apellido = global.p8;

            int[] vector_participantes = new int[8];
            //List<Deportista> lista_participante = new List<Deportista>();

            //lista_participante.Add(d1);
            //lista_participante.Add(d2);
            //lista_participante.Add(d3);
            //lista_participante.Add(d4);
            //lista_participante.Add(d5);
            //lista_participante.Add(d6);
            //lista_participante.Add(d7);
            //lista_participante.Add(d8);
           


            vector_participantes[0] = global.docp1;
            vector_participantes[1] = global.docp2;
            vector_participantes[2] = global.docp3;
            vector_participantes[3] = global.docp4;
            vector_participantes[4] = global.docp5;
            vector_participantes[5] = global.docp6;
            vector_participantes[6] = global.docp7;
            vector_participantes[7] = global.docp8;

            Shuffle(vector_participantes);

        
            txtDocP1.ReadOnly = true;
            txtDocP2.ReadOnly = true;
            txtDocP3.ReadOnly = true;
            txtDocP4.ReadOnly = true;
            txtDocP5.ReadOnly = true;
            txtDocP6.ReadOnly = true;
            txtDocP7.ReadOnly = true;
            txtDocP8.ReadOnly = true;


            txtP1.ReadOnly = true;
            txtP2.ReadOnly = true;
            txtP3.ReadOnly = true;
            txtP4.ReadOnly = true;
            txtP5.ReadOnly = true;
            txtP6.ReadOnly = true;
            txtP7.ReadOnly = true;
            txtP8.ReadOnly = true;



            txtP1P2.ReadOnly = true;
            txtP3P4.ReadOnly = true;
            txtP5P6.ReadOnly = true;
            txtP7P8.ReadOnly = true;
            txtF1.ReadOnly = true;
            txtF2.ReadOnly = true;
            txtCampeon.ReadOnly = true;



            txtDocP1P2.ReadOnly = true;
            txtDocP3P4.ReadOnly = true;
            txtDocP5P6.ReadOnly = true;
            txtDocP7P8.ReadOnly = true;
            txtDocF1.ReadOnly = true;
            txtDocF2.ReadOnly = true;
            txtDocCampeon.ReadOnly = true;


            txtDocP1.Text = vector_participantes[0] +"";
            txtDocP2.Text = vector_participantes[1] +"";
            txtDocP3.Text = vector_participantes[2] +"";
            txtDocP4.Text = vector_participantes[3] +"";
            txtDocP5.Text = vector_participantes[4] +"";
            txtDocP6.Text = vector_participantes[5] +"";
            txtDocP7.Text = vector_participantes[6] +"";
            txtDocP8.Text = vector_participantes[7] +"";

            obtenerNombreParticipante1();
            obtenerNombreParticipante2();
            obtenerNombreParticipante3();
            obtenerNombreParticipante4();

            obtenerNombreParticipante5();
            obtenerNombreParticipante6();
            obtenerNombreParticipante7();
            obtenerNombreParticipante8();

           
        }
       
        public static void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = random.Next(i); // 0 <= j <= i-1
                // Swap.
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }

        public void obtenerNombreParticipante1()
        {

            if (txtDocP1.Text == global.docp1.ToString())
            {
                txtP1.Text = global.p1;
                return;
            }

            if (txtDocP1.Text == global.docp2.ToString())
            {
                txtP1.Text =  global.p2;
                return;
            }

            if (txtDocP1.Text == global.docp3.ToString())
            {
                txtP1.Text =  global.p3;
                return;
            }

            if (txtDocP1.Text == global.docp4.ToString())
            {
                txtP1.Text =  global.p4;
                return;
            }

            if (txtDocP1.Text == global.docp5.ToString())
            {
                txtP1.Text = global.p5;
                return;
            }

            if (txtDocP1.Text == global.docp6.ToString())
            {
                txtP1.Text = global.p6;
                return;
            }

            if (txtDocP1.Text == global.docp7.ToString())
            {
                txtP1.Text = global.p7;
                return;
            }

            if (txtDocP1.Text == global.docp8.ToString())
            {
                txtP1.Text = global.p8;
                return;
            }

    
        }


        public void obtenerNombreParticipante2()
        {

            if (txtDocP2.Text == global.docp1.ToString())
            {
                txtP2.Text =  global.p1;
                return;
            }

            if (txtDocP2.Text == global.docp2.ToString())
            {
                txtP2.Text =  global.p2;
                return;
            }

            if (txtDocP2.Text == global.docp3.ToString())
            {
                txtP2.Text =  global.p3;
                return;
            }

            if (txtDocP2.Text == global.docp4.ToString())
            {
                txtP2.Text =  global.p4;
                return;
            }

            if (txtDocP2.Text == global.docp5.ToString())
            {
                txtP2.Text =  global.p5;
                return;
            }

            if (txtDocP2.Text == global.docp6.ToString())
            {
                txtP2.Text = global.p6;
                return;
            }

            if (txtDocP2.Text == global.docp7.ToString())
            {
                txtP2.Text =  global.p7;
                return;
            }

            if (txtDocP2.Text == global.docp8.ToString())
            {
                txtP2.Text =  global.p8;
                return;
            }
        }



        public void obtenerNombreParticipante3()
        {

            if (txtDocP3.Text == global.docp1.ToString())
            {
                txtP3.Text =  global.p1;
                return;
            }

            if (txtDocP3.Text == global.docp2.ToString())
            {
                txtP3.Text =  global.p2;
                return;
            }

            if (txtDocP3.Text == global.docp3.ToString())
            {
                txtP3.Text =  global.p3;
                return;
            }

            if (txtDocP3.Text == global.docp4.ToString())
            {
                txtP3.Text =  global.p4;
                return;
            }

            if (txtDocP3.Text == global.docp5.ToString())
            {
                txtP3.Text =  global.p5;
                return;
            }

            if (txtDocP3.Text == global.docp6.ToString())
            {
                txtP3.Text =  global.p6;
                return;
            }

            if (txtDocP3.Text == global.docp7.ToString())
            {
                txtP3.Text =  global.p7;
                return;
            }

            if (txtDocP3.Text == global.docp8.ToString())
            {
                txtP3.Text =  global.p8;
                return;
            }
        }


        public void obtenerNombreParticipante4()
        {

            if (txtDocP4.Text == global.docp1.ToString())
            {
                txtP4.Text =  global.p1;
                return;
            }

            if (txtDocP4.Text == global.docp2.ToString())
            {
                txtP4.Text =  global.p2;
                return;
            }

            if (txtDocP4.Text == global.docp3.ToString())
            {
                txtP4.Text =  global.p3;
                return;
            }

            if (txtDocP4.Text == global.docp4.ToString())
            {
                txtP4.Text =  global.p4;
                return;
            }

            if (txtDocP4.Text == global.docp5.ToString())
            {
                txtP4.Text = global.p5;
                return;
            }

            if (txtDocP4.Text == global.docp6.ToString())
            {
                txtP4.Text =  global.p6;
                return;
            }

            if (txtDocP4.Text == global.docp7.ToString())
            {
                txtP4.Text = global.p7;
                return;
            }

            if (txtDocP4.Text == global.docp8.ToString())
            {
                txtP4.Text = global.p8;
                return;
            }
        }

        public void obtenerNombreParticipante5()
        {

            if (txtDocP5.Text == global.docp1.ToString())
            {
                txtP5.Text =  global.p1;
                return;
            }

            if (txtDocP5.Text == global.docp2.ToString())
            {
                txtP5.Text =  global.p2;
                return;
            }

            if (txtDocP5.Text == global.docp3.ToString())
            {
                txtP5.Text = global.p3;
                return;
            }

            if (txtDocP5.Text == global.docp4.ToString())
            {
                txtP5.Text =  global.p4;
                return;
            }

            if (txtDocP5.Text == global.docp5.ToString())
            {
                txtP5.Text = global.p5;
                return;
            }

            if (txtDocP5.Text == global.docp6.ToString())
            {
                txtP5.Text = global.p6;
                return;
            }

            if (txtDocP5.Text == global.docp7.ToString())
            {
                txtP5.Text =  global.p7;
                return;
            }

            if (txtDocP5.Text == global.docp8.ToString())
            {
                txtP5.Text = global.p8;
                return;
            }
        }

        public void obtenerNombreParticipante6()
        {

            if (txtDocP6.Text == global.docp1.ToString())
            {
                txtP6.Text = global.p1;
                return;
            }

            if (txtDocP6.Text == global.docp2.ToString())
            {
                txtP6.Text =  global.p2;
                return;
            }

            if (txtDocP6.Text == global.docp3.ToString())
            {
                txtP6.Text =  global.p3;
                return;
            }

            if (txtDocP6.Text == global.docp4.ToString())
            {
                txtP6.Text =  global.p4;
                return;
            }

            if (txtDocP6.Text == global.docp5.ToString())
            {
                txtP6.Text =  global.p5;
                return;
            }

            if (txtDocP6.Text == global.docp6.ToString())
            {
                txtP6.Text = global.p6;
                return;
            }

            if (txtDocP6.Text == global.docp7.ToString())
            {
                txtP6.Text =  global.p7;
                return;
            }

            if (txtDocP6.Text == global.docp8.ToString())
            {
                txtP6.Text =  global.p8;
                return;
            }
        }

        public void obtenerNombreParticipante7()
        {

            if (txtDocP7.Text == global.docp1.ToString())
            {
                txtP7.Text =  global.p1;
                return;
            }

            if (txtDocP7.Text == global.docp2.ToString())
            {
                txtP7.Text =  global.p2;
                return;
            }

            if (txtDocP7.Text == global.docp3.ToString())
            {
                txtP7.Text =  global.p3;
                return;
            }

            if (txtDocP7.Text == global.docp4.ToString())
            {
                txtP7.Text =  global.p4;
                return;
            }

            if (txtDocP7.Text == global.docp5.ToString())
            {
                txtP7.Text =  global.p5;
                return;
            }

            if (txtDocP7.Text == global.docp6.ToString())
            {
                txtP7.Text =  global.p6;
                return;
            }

            if (txtDocP7.Text == global.docp7.ToString())
            {
                txtP7.Text = global.p7;
                return;
            }

            if (txtDocP7.Text == global.docp8.ToString())
            {
                txtP7.Text =  global.p8;
                return;
            }
        }


        public void obtenerNombreParticipante8()
        {

            if (txtDocP8.Text == global.docp1.ToString())
            {
                txtP8.Text =  global.p1;
                return;
            }

            if (txtDocP8.Text == global.docp2.ToString())
            {
                txtP8.Text =  global.p2;
                return;
            }

            if (txtDocP8.Text == global.docp3.ToString())
            {
                txtP8.Text =  global.p3;
                return;
            }

            if (txtDocP8.Text == global.docp4.ToString())
            {
                txtP8.Text = global.p4;
                return;
            }

            if (txtDocP8.Text == global.docp5.ToString())
            {
                txtP8.Text = global.p5;
                return;
            }

            if (txtDocP8.Text == global.docp6.ToString())
            {
                txtP8.Text = global.p6;
                return;
            }

            if (txtDocP8.Text == global.docp7.ToString())
            {
                txtP8.Text = global.p7;
                return;
            }

            if (txtDocP8.Text == global.docp8.ToString())
            {
                txtP8.Text =  global.p8;
                return;
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            txtP1P2.Text = txtP1.Text;
            txtDocP1P2.Text = txtDocP1.Text;
         }

        private void button17_Click(object sender, EventArgs e)
        {
            txtF1.Text = txtP3P4.Text;
            txtDocF1.Text = txtDocP3P4.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtF1.Text = txtP1P2.Text;
            txtDocF1.Text = txtDocP1P2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtP1P2.Text = txtP2.Text;
            txtDocP1P2.Text = txtDocP2.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtP3P4.Text = txtP3.Text;
            txtDocP3P4.Text = txtDocP3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtP3P4.Text = txtP4.Text;
            txtDocP3P4.Text = txtDocP4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtP5P6.Text = txtP5.Text;
            txtDocP5P6.Text = txtDocP5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtP5P6.Text = txtP6.Text;
            txtDocP5P6.Text = txtDocP6.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtP7P8.Text = txtP7.Text;
            txtDocP7P8.Text = txtDocP7.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtP7P8.Text = txtP8.Text;
            txtDocP7P8.Text = txtDocP8.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtF2.Text = txtP5P6.Text;
            txtDocF2.Text = txtDocP5P6.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtF2.Text = txtP7P8.Text;
            txtDocF2.Text = txtDocP7P8.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtCampeon.Text = txtF1.Text;
            txtDocCampeon.Text = txtDocF1.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtCampeon.Text = txtF2.Text;
            txtDocCampeon.Text = txtDocF2.Text;
        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     

            GestorTorneo gt = new GestorTorneo();
            int id_torneo= global.id_torneo;
            int id_estado = 17; //17- torneo iniciado. nose puede modificar 
            gt.registrarEnCurso(id_torneo, id_estado);


            lblE.Visible = true;
            lblC.Visible = true;
            MessageBox.Show("Guardado Correctamente");
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = true;
            btnResultado.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtF1.Text == "")
            {
                MessageBox.Show("Seleccione finalista 1");
                return;
            }

            if (txtF2.Text == "")
            {
                MessageBox.Show("Seleccione finalista 2");
                return;
            }

            if (txtCampeon.Text == "")
            {
                MessageBox.Show("Seleccione Campeon");
                return;
            }

            GestorTorneo gt = new GestorTorneo();
            int id_torneo = global.id_torneo;
            int id_estado = 15; //15- finalizado 
            int doc_primero = int.Parse(txtDocCampeon.Text);
            int doc_segundo = 0;
            int f1 = int.Parse(txtDocF1.Text);
            int f2 = int.Parse(txtDocF2.Text);
            int campeon = int.Parse(txtDocCampeon.Text);

            if (f1 == campeon)
                doc_segundo = f2;
            else if (f2 == campeon)
                doc_segundo = f1;



            gt.registrarResultado(id_torneo, id_estado, doc_primero, doc_segundo);
            MessageBox.Show("Resultado Guardado");



            //DialogResult res;
            //res = MessageBox.Show("“¿Desea guardar el resultado al ranking?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //if (res == DialogResult.Yes)
            //{
            //    try
            //    {
                    

            //        gt.registrarRanking(global.id_deporte_torneo, doc_primero, doc_segundo);                   
            //        MessageBox.Show("Ranking Guardado");

            //    }
            //    catch (Exception ex) { MessageBox.Show("No pudo guardar ranking"); }


            lblC.Text = "Finalizado";
            btnResultado.Enabled = false;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtDocP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblE_Click(object sender, EventArgs e)
        {

        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }
    }
}
