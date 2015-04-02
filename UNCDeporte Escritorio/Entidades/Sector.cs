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
        private string descipcion;
        private TipoSector tipo_sector;
        private LugarPractica lugar;
        private Estado estado;
        private Deporte deporte;

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
        public string Descipcion
        {
            get { return descipcion; }
            set { descipcion = value; }
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
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Deporte Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        //Constructores
        public Sector()
        {
            //this.nombre = "";
            //this.descipcion = "";
            //this.tipo_sector = null;
            //this.lugar = null;
            //this.estado = null;
            //this.deporte = null;
        }

        public Sector(string nombre, string descripcion, TipoSector tipo_sector, LugarPractica lugar, Estado estado, Deporte deporte)
        {
            this.nombre = nombre;
            this.descipcion = descripcion;
            this.tipo_sector = tipo_sector;
            this.lugar = lugar;
            this.estado = estado;
            this.deporte = deporte;
        }



    }
}
