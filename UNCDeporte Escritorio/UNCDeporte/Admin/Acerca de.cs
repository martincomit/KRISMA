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
    public partial class Acerca_de : Form
    {

        private static Acerca_de instancia = new Acerca_de(); //atributo estatico y privado de su misma clase UNICO

        public static Acerca_de getInstancia() //funcion getInstancia que asegura solo una instancia de la misma clase controlando con un if que solo la crea sino existe otra instancia
        {
            if (instancia != null && instancia.IsDisposed)
            {

                instancia = new Acerca_de();

            }

            return instancia;

        }


        private Acerca_de() //constructor privado para acceder desde funcion getInstancia solamente 
        {
            InitializeComponent();
        }


        private void Acerca_de_Load(object sender, EventArgs e)
        {

        }
    }
}
