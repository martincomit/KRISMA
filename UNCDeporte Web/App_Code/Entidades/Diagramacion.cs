using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Diagramacion
    {
        private string descripcion;
        private List<DetalleDiagramacion> detalle;
        private Estado estado;


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public List<DetalleDiagramacion> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Diagramacion()
        {
            this.detalle = null;
            this.estado = null;
        }

        public Diagramacion(List<DetalleDiagramacion> detalle, Estado estado)
        {
            this.detalle = detalle;
            this.estado = estado;
        }


        //Metodos
        public void Nuevo_Detalle()
        {
            detalle = new List<DetalleDiagramacion>();
        }
    }
}
