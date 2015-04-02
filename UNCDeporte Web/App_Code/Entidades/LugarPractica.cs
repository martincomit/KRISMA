using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class LugarPractica
    {
        //Atributos
        private int id_lugar;
        private string nombre;
        private string descripcion;
        private string direccion;
        private Barrio barrio;
        private Localidad localidad;
        private List<Sector> lista_sector;

        //Propiedades
        public int Id_lugar
        {
            get { return id_lugar; }
            set { id_lugar = value; }
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

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        public List<Sector> Lista_sector
        {
            get { return lista_sector; }
            set { lista_sector = value; }
        }

        public LugarPractica()
        {
            //this.id_lugar = 0;
            //this.nombre = "";
            //this.descripcion = "";
            //this.direccion = null;
            //this.lista_sector = null;
        }

        public LugarPractica(int id_lugar, string nombre, string descripcion, string direccion, Barrio barrio, Localidad localidad, List<Sector> sector)
        {
            this.id_lugar = id_lugar;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.barrio = barrio;
            this.localidad = localidad;
            this.lista_sector = sector;
        }
    }
}
