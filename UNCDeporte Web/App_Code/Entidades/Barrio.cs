using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Barrio
    {
        private int id_barrio;
        private string nombre;
        private int id_localidad;

        public int Id_barrio
        {
            get { return id_barrio; }
            set { id_barrio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id_localidad
        {
            get { return id_localidad; }

            set { id_localidad = value; }
        }




    }
}
