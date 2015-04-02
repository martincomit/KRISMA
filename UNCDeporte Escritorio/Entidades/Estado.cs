using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Estado
    {
        private int id_estado;
        private string nombre;
        private string descripcion;
        private string ambito;

        public int Id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
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
        public string Ambito
        {
            get { return ambito; }
            set { ambito = value; }
        }


        public Estado()
        {
            this.id_estado = 0;
            this.nombre = "";
            this.descripcion = "";
            this.ambito = "";
        }

        public Estado(int id_estado, string nombre, string descripcion, string ambito)
        {
            this.id_estado = id_estado;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
        }

    }
}
