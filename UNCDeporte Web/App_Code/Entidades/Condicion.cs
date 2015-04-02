using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Condicion
/// </summary>
public class Condicion
{
        private int id_condicion;
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


        public int Id_condicion
        {
            get { return id_condicion; }

            set { id_condicion = value; }
        }


    
}