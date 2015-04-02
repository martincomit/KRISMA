using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Programa
    {
        private int id_programa;
        private DateTime fecha_alta;
        private int anio;
        private string descripcion;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private List<DetallePrograma> detalle;
        private Estado estado;

        //Propiedades
        public int Id_programa
        {
            get { return id_programa; }
            set { id_programa = value; }
        }
        public DateTime Fecha_alta
        {
            get { return fecha_alta; }
            set { fecha_alta = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;}
        }
        public DateTime Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value;}
        }
        public DateTime Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public List<DetallePrograma> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        //Constructores
        public Programa()
        {
            this.id_programa = 0;
            this.fecha_alta = DateTime.Now.Date;
            this.anio = DateTime.Now.Year; 
            this.descripcion = "";
            this.fecha_inicio = new DateTime(DateTime.Now.Year, 1, 1);
            this.fecha_fin = new DateTime(DateTime.Now.Year, 12, 31);
            this.detalle = null;
            this.estado = null;
        }

        public Programa(int id_programa, DateTime fecha_alta, int anio, string descripcion, DateTime fecha_inicio, DateTime fecha_fin, List<DetallePrograma> detalle, Estado estado)
        {
            this.id_programa = id_programa;
            this.fecha_alta = fecha_alta;
            this.anio = anio;
            this.descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.detalle = detalle;
            this.estado = estado;
        }


        //Metodos
        public void Nuevo_Detalle()
        {
            detalle = new List<DetallePrograma>();
        }

        public void Nuevo_Estado()
        {
            estado = new Estado();
        }


    }
}
