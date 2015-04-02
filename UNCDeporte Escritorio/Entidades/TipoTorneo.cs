using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoTorneo
    {
        private int id_tipoTorneo;
        private string nombre;
        private string descripcion;

        public int Id_tipoTorneo
        {
            get { return id_tipoTorneo; }
            set { id_tipoTorneo = value; }
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

