using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleReserva
    {
        //Atributos
        private Reserva reserva;
        private int item;
        private Deporte deporte;
        private Persona persona;
        private Sector sector;
        private DateTime fecha_reserva;
        private Horario hora_desde;
        private Horario hora_hasta;
        private Estado estado;

        //Propiedades
        public Reserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }
        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public Deporte Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }
        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        public Sector Sector
        {
            get { return sector; }
            set { sector = value; }
        }
        public DateTime Fecha_reserva
        {
            get { return fecha_reserva; }
            set { fecha_reserva = value; }
        }
        public Horario Hora_desde
        {
            get { return hora_desde; }
            set { hora_desde = value; }
        }
        public Horario Hora_hasta
        {
            get { return hora_hasta; }
            set { hora_hasta = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Constructores
        public DetalleReserva()
        {
            this.reserva = null;
            this.item = 1;
            this.deporte = null;
            this.persona = null;
            this.sector = null;
            this.fecha_reserva = DateTime.Now.Date;
            this.hora_desde = null;
            this.hora_hasta =null;            
        }

        public DetalleReserva(Reserva reserva, int item, Deporte deporte, Persona persona, Sector sector, DateTime fecha_reserva, Horario hora_desde, Horario hora_hasta)
        {
            this.reserva = reserva;
            this.item = item;
            this.deporte = deporte;
            this.persona = persona;
            this.sector = sector;
            this.fecha_reserva = fecha_reserva;
            this.hora_desde = hora_desde;
            this.hora_hasta = hora_hasta;
        }


    }
}
