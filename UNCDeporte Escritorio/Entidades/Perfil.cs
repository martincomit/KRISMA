﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Perfil
    {
        private string nombre;
        private string descripcion;

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
