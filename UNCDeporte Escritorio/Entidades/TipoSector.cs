using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoSector
    {
        //Atributos
        private int id_tipo_sector;
        private string nombre;
        private string descripcion;

        public int Id_tipo_sector
        {
            get { return id_tipo_sector; }
            set { id_tipo_sector = value; }
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
        //Constructores
        public TipoSector()
        {
            this.id_tipo_sector = 0;
            this.nombre = "";
            this.descripcion = "";
        }

        public TipoSector(int id_tipo_sector, string nombre, string descripcion)
        {
            this.id_tipo_sector = id_tipo_sector;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }

}
