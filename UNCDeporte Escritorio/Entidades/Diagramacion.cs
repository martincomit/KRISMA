using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Diagramacion
    {
        private int id_diagramacion;
        private Deporte deporte;
        private List<DetalleDiagramacion> detalle;


        public int Id_diagramacion
        {
            get { return id_diagramacion; }
            set { id_diagramacion = value; }
        }
        public Deporte Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }
        public List<DetalleDiagramacion> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        

        public Diagramacion()
        {
            this.deporte = null;
            this.detalle = null;            
        }

        public Diagramacion(Deporte deporte, List<DetalleDiagramacion> detalle)
        {
            this.deporte = deporte;
            this.detalle = detalle;            
        }


        //Metodos
        public void Nuevo_Deporte()
        {
            deporte = new Deporte();
        }

        public void Nuevo_Detalle()
        {
            detalle = new List<DetalleDiagramacion>();
        }        

    }
}
