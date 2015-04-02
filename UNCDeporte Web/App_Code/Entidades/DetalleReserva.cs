using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleReserva
    {
        public Reserva reserva;
        public Deporte deporte;
        public int item;
        public DateTime fecha_reserva;        
        public Sector sector;

        public DetalleReserva()
        {
            this.reserva = null;
            this.deporte = null;
            this.item = 1;
            this.fecha_reserva = DateTime.Now.Date;
            this.sector = null;
        }

        public DetalleReserva(Reserva reserva, Deporte deporte, int item, DateTime fecha_reserva, Sector sector)
        {
            this.reserva = reserva;
            this.deporte = deporte;
            this.item = item;
            this.fecha_reserva = fecha_reserva;
            this.sector = sector;
        }


    }
}
