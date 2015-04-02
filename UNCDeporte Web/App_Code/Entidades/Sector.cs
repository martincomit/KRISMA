using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Sector
    {
        //Atributos
        private int id_sector;
        private string nombre;
        private string descripcion;
        private TipoSector tipo_sector;
        private LugarPractica lugar;

        //Propiedades
        public int Id_sector
        {
            get { return id_sector; }
            set { id_sector = value; }
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
        public string NombreCompleto
        {
            get { return nombre + ", " + descripcion; }
        }
        public TipoSector Tipo_sector
        {
            get { return tipo_sector; }
            set { tipo_sector = value; }
        }
        public LugarPractica Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }


        //Constructores
        public Sector()
        {
            this.nombre = "";
            this.descripcion = "";
            this.tipo_sector = null;
            this.lugar = null;
        }

        public Sector(string nombre, string descripcion, TipoSector tipo_sector, LugarPractica lugar)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo_sector = tipo_sector;
            this.lugar = lugar;
        }



    }
}
