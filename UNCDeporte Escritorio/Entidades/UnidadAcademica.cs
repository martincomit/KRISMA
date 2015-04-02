using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class UnidadAcademica
    {
        private int id_unidadAcademica;
        private string nombre;
        private string descripcion;

        public int Id_unidadAcademica //propiedad de atributos en mayus primera letra, para usar set y get como propiedad
        {
            get { return id_unidadAcademica; }
            set { id_unidadAcademica = value; }
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
