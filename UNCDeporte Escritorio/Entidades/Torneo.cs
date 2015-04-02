using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Torneo
    {
        private int id_torneo;
        private string nombre;
        private string descripcion;
        private Deporte deporte;
        private DateTime fecha_alta;
        private DateTime inicio_torneo;
        private DateTime cierre_torneo;
        private TipoTorneo tipo_torneo;
        private int cantidad_participantes;
        private Estado estado;
        private int cantidad_grupos;
        private int cantidad_participantes_grupo;
        private int cantidad_clasificados_grupo;
        private int puntaje_primer_puesto;
        private int puntaje_segundo_puesto;

        public int Id_torneo
        {
            get { return id_torneo; }
            set { id_torneo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }

            set { descripcion = value; }
        }


        public Deporte Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public DateTime Fecha_Alta
        {
            get { return fecha_alta; }
            set { fecha_alta = value; }
        }


        public DateTime Inicio_Torneo
        {
            get { return inicio_torneo; }
            set { inicio_torneo = value; }
        }


        public DateTime Cierre_Torneo
        {
            get { return cierre_torneo; }
            set { cierre_torneo = value; }
        }

        public TipoTorneo Tipo_Torneo
        {
            get { return tipo_torneo; }
            set { tipo_torneo = value; }
        }

        public int Cantidad_participantes
        {
            get { return cantidad_participantes; }
            set { cantidad_participantes = value; }
        }

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Cantidad_grupos
        {
            get { return cantidad_grupos; }
            set { cantidad_grupos = value; }
        }

        public int Cantidad_participantes_grupo
        {
            get { return cantidad_participantes_grupo; }
            set { cantidad_participantes_grupo = value; }
        }

        public int Cantidad_clasificados_grupo
        {
            get { return cantidad_clasificados_grupo; }
            set { cantidad_clasificados_grupo = value; }
        }

        public int Puntaje_primer_puesto
        {
            get { return puntaje_primer_puesto; }
            set { puntaje_primer_puesto = value; }
        }

        public int Puntaje_segundo_puesto
        {
            get { return puntaje_segundo_puesto; }
            set { puntaje_segundo_puesto = value; }
        }
    }
}
