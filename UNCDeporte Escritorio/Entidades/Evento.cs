using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Evento
    {
        public int id_evento;
        private string nombre;
        private string descripcion;
        private DateTime fecha_alta;
        private DateTime fecha_inicio;

        private DateTime fecha_fin;

        private Deporte deporte;
        private int id_deporte;
        private Perfil perfil;
        private int id_perfil;
        public byte[] foto;

        public Evento()
        {
            deporte = new Deporte();
            perfil = new Perfil();
        }



        public string Descripcion
        {
            get { return descripcion; }

            set { descripcion = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public DateTime Fecha_Alta
        {
            get { return fecha_alta; }

            set { fecha_alta = value; }
        }


        public Deporte Dep
        {
            get { return deporte; }

            set { deporte = value; }
        }

        public int Id_deporte
        {
            get { return id_deporte; }

            set { id_deporte = value; }
        }

        public int Id_evento
        {
            get { return id_evento; }

            set { id_evento = value; }
        }

        public DateTime Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }

        public DateTime Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }

        public Perfil Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public int Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }

    }
}
