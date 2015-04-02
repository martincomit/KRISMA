using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoReserva
    {
        //Atributos
        private int id_tipo_reserva;
        private string nombre;
        private string descripcion;

        //Propiedades
        public int Id_tipo_reserva
        {
            get { return id_tipo_reserva; }
            set { id_tipo_reserva = value; }
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


        //Constructores

        public TipoReserva()
        {
            this.id_tipo_reserva = 1;
            this.nombre = "";
            this.descripcion = "";
        }

        public TipoReserva(int id_tipo_reserva, string nombre, string descripcion)
        {
            this.id_tipo_reserva = id_tipo_reserva;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
