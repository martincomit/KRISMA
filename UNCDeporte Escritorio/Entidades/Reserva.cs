using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        private int id_reserva;
        private TipoReserva tipo_reserva;
        private DateTime fecha_realizacion;
        private string descripcion;        
        private List<DetalleReserva> detalle;

        public int Id_reserva
        {
            get { return id_reserva; }
            set { id_reserva = value; }
        }
        public TipoReserva Tipo_reserva
        {
            get { return tipo_reserva; }
            set { tipo_reserva = value; }
        }
        public DateTime Fecha_realizacion
        {
            get { return fecha_realizacion; }
            set { fecha_realizacion = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public List<DetalleReserva> Detalle 
        {
            get { return detalle; }
            set { detalle = value; }
        }



        public Reserva()
        {
            this.id_reserva = 1;
            this.fecha_realizacion = DateTime.Now;
            this.descripcion = "";            
            this.detalle = new List<DetalleReserva>();
        }

        public Reserva(int id_reserva, DateTime fecha_realizacion, string descripcion, List<DetalleReserva> detalle)
        {
            this.id_reserva = id_reserva;
            this.fecha_realizacion = DateTime.Now.Date;
            this.descripcion = descripcion;            
            this.detalle = detalle;
        }

        public bool Es_Alumno()
        {
            return true;
        }


    }
}
