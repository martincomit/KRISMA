using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleDiagramacion
    {
        //Atributos        
        private Deporte deporte;
        private int item;
        private string dia_semana;
        private Sector sector;
        private Horario hora_desde;
        private Horario hora_hasta;
        private Personal profesor;
        private bool espacio_asignado;
        private bool horario_asignado;
        private bool profesor_asignado;

        //Propiedades        
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
        public string Dia_semana
        {
            get { return dia_semana; }
            set { dia_semana = value; }
        }
        public Sector Sector
        {
            get { return sector; }
            set { sector = value; }
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
        public Personal Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }
        public bool Espacio_asignado
        {
            get { return espacio_asignado; }
            set { espacio_asignado = value; }
        }
        public bool Horario_asignado
        {
            get { return horario_asignado; }
            set { horario_asignado = value; }
        }
        public bool Profesor_asignado
        {
            get { return profesor_asignado; }
            set { profesor_asignado = value; }
        }

        //Constructores
        public DetalleDiagramacion()
        {            
            this.deporte = null;
            this.item = 1;
            this.dia_semana = "";            
            this.sector = null;            
            this.hora_desde = null;
            this.hora_hasta = null;
            this.profesor = null;
        }

        public DetalleDiagramacion(Deporte deporte, int item, string dia_semana, Sector sector, Horario hora_desde, Horario hora_hasta, Personal profesor)
        {            
            this.deporte = deporte;
            this.item = item;
            this.dia_semana = dia_semana;            
            this.sector = sector;
            this.hora_desde = hora_desde;
            this.hora_hasta = hora_hasta;
            this.profesor = profesor;
        }


    }
}
