using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Escuela
/// </summary>
public class Escuela
{
     private int id_escuela;
        private string nombre;
        private int id_unidad;

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public int Id_unidad
        {
            get { return id_unidad; }

            set { id_unidad = value; }
        }

        public int Id_escuela
        {
            get { return id_escuela; }

            set { id_escuela = value; }
        }


    
}