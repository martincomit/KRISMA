using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Torneo
    {
        private int id_torneo;
        private string nombre;
        private string descripcion;

        public int Id_torneo
        {
            get { return id_torneo; }
            set { id_torneo = value; }
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




    }
}
