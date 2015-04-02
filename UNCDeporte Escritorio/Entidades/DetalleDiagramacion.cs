using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleDiagramacion
    {
        //Atributos        
        private Diagramacion diagramacion;
        private int item;
        private Dia dia_semana;
        private Sector sector;
        private Horario hora_desde;
        private Horario hora_hasta;
        private Personal profesor;
        private bool lugar_confirmado;
        private bool horario_confirmado;
        private bool profesor_confirmado;        

        //Propiedades        
        public Diagramacion Diagramacion
        {
            get { return diagramacion; }
            set { diagramacion = value; }
        }
        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public Dia Dia_semana
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
        public bool Lugar_confirmado
        {
            get { return lugar_confirmado; }
            set { lugar_confirmado = value; }
        }
        public bool Horario_confirmado
        {
            get { return horario_confirmado; }
            set { horario_confirmado = value; }
        }
        public bool Profesor_confirmado
        {
            get { return profesor_confirmado; }
            set { profesor_confirmado = value; }
        }
        


        //Constructores
        public DetalleDiagramacion()
        {
            this.diagramacion = null;
            this.item = 1;
            this.dia_semana = null;            
            this.sector = null;            
            this.hora_desde = null;
            this.hora_hasta = null;
            this.profesor = null;
            this.lugar_confirmado = true;
            this.horario_confirmado = true;
            this.profesor_confirmado = true;
        }

        public DetalleDiagramacion(Diagramacion diagramacion, int item, Dia dia_semana, Sector sector, Horario hora_desde, Horario hora_hasta, Personal profesor, bool lugar_confirmado, bool horario_confirmado, bool profesor_confirmado)
        {
            this.diagramacion = diagramacion;
            this.item = item;
            this.dia_semana = dia_semana;            
            this.sector = sector;
            this.hora_desde = hora_desde;
            this.hora_hasta = hora_hasta;
            this.profesor = profesor;
            this.lugar_confirmado = lugar_confirmado;
            this.horario_confirmado = horario_confirmado;
            this.profesor_confirmado = profesor_confirmado;
        }

    }
}
