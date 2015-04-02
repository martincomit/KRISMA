using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetallePrograma
    {
        //Atributos
        private Programa programa;
        private Deporte deporte;
        private int item;
        private int cupo;
        private Diagramacion diagramacion;
        private Reserva reserva;
        private Estado estado;

        //Propiedades
        public Programa Programa
        {
            get { return programa; }
            set { programa = value; }
        }
        public Deporte Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }
        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }
        public Diagramacion Diagramacion
        {
            get { return diagramacion; }
            set { diagramacion = value; }
        }
        public Reserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Constructores
        public DetallePrograma()
        {
            this.programa = null;
            this.deporte = null;
            this.item = 0;
            this.cupo = 0;
            this.diagramacion = null;
            this.reserva = null;
            this.estado = null;
        }

        public DetallePrograma(Programa programa, Deporte deporte, int item, int cupo, Diagramacion diagramacion, Reserva reserva, Estado estado)
        {
            this.programa = programa;
            this.deporte = deporte;
            this.item = item;
            this.cupo = cupo;
            this.diagramacion = diagramacion;
            this.reserva = reserva;
            this.estado = estado;
        }


        //Metodos
        public void Nueva_Diagramacion()
        {
            diagramacion = new Diagramacion();
        }



    }    

}
