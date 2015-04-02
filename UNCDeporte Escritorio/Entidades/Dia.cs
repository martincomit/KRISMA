using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Dia
    {
        private int numero;
        private string nombre;
        private string nombre_corto;
        private DateTime fecha;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Nombre_corto
        {
            get { return nombre_corto; }
            set { nombre_corto = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public Dia(int numero, string nombre, string nombre_corto, DateTime fecha)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.nombre_corto = nombre_corto;
            this.fecha = fecha;
        }
    }
}
