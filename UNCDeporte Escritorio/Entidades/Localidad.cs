using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Localidad
    {
        public int id_localidad;
        public string nombre;
        public List<Barrio> barrio;

        public int Id_localidad
        {
            get { return id_localidad; }

            set { id_localidad = value; }
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }


        public Localidad()
        {

        }

        public Localidad(string nombre, List<Barrio> barrio, int id_localidad)
        {
            this.id_localidad = id_localidad;
            this.nombre = nombre;
            this.barrio = barrio;          
        }
        
    }
}
