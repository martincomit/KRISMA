using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Permiso
    {
        private int id_permiso;
        private string nombre;


        public int Id_permiso
        {
            get { return id_permiso; }

            set { id_permiso = value; }
        }



        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }
      


    }
}
