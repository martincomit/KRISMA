using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        public int id_reserva;
        public DateTime fecha_realizacion;
        public string descripcion;
        public Persona persona;
        public List<DetalleReserva> detalle;

        public Reserva()
        {
            this.id_reserva = 1;
            this.fecha_realizacion = DateTime.Now.Date;
            this.descripcion = "";
            this.persona = null;
            this.detalle = null;
        }

        public Reserva(int id_reserva, DateTime fecha_realizacion, string descripcion, Persona persona, List<DetalleReserva> detalle)
        {
            this.id_reserva = id_reserva;
            this.fecha_realizacion = DateTime.Now.Date;
            this.descripcion = descripcion;
            this.persona = null;
            this.detalle = detalle;
        }

        public bool Es_Alumno()
        {
            return true;
        }


    }
}
