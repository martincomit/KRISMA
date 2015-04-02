using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Deporte
    {   
        //Atributos
        private int id_deporte;
        private string nombre;
        private string descripcion;
        private int cod_sanaviron;
        private string tipo;
        //agregue
        private int id_tipo;//1 - Recreativo, 2- Federado

        //Propiedades
        public int Id_deporte
        {
            get { return id_deporte; }
            set { id_deporte = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Cod_sanaviron
        {
            get { return cod_sanaviron; }
            set { cod_sanaviron = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Id_tipo
        {
            get { return id_tipo; }
            set { id_tipo = value; }
        }

        //Constructores
        public Deporte()
        {
           
        }

        public Deporte(int id_deporte, string nombre, string descripcion, int cod_sanaviron)
        {
            this.id_deporte = id_deporte;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cod_sanaviron = cod_sanaviron;
        }
    }

    
 


}
