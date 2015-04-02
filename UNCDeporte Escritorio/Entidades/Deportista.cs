using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Deportista
    {
        private int documento;
        private DateTime fec_nac;
        private Boolean sexo;
        private string apellido;
        private string nombres;
        private int id_localidad;
        private int id_barrio;
        private int tel_fijo;
        private int tel_cel;
        private string email;
        private string condicion;
        private Boolean becado;
        private int id_unidadAcademica;
        private int id_escuela;

        public int Documento
        {
            get { return documento; }

            set { documento = value; }
        }

        public DateTime Fec_nac
        {
            get { return fec_nac; }

            set { fec_nac = value; }
        }

        public Boolean Sexo
        {
            get { return Sexo; }

            set { Sexo = value; }
        }

        public string Apellido
        {
            get { return apellido; }

            set { apellido = value; }
        }

        public string Nombres
        {
            get { return nombres; }

            set { nombres = value; }
        }

        public int Id_localidad
        {
            get { return id_localidad; }

            set { id_localidad = value; }
        }


        public int Id_barrio
        {
            get { return id_barrio; }

            set { id_barrio = value; }
        }

        public int Tel_fijo
        {
            get { return tel_fijo; }

            set { tel_fijo = value; }
        }

        public int Tel_cel
        {
            get { return tel_cel; }

            set { tel_cel = value; }
        }

        public string Email
        {
            get { return email; }

            set { email = value; }
        }



        public string Condicion
        {
            get { return condicion; }

            set { condicion = value; }
        }

        public Boolean Becado
        {
            get { return becado; }

            set { becado = value; }
        }

        public int Id_unidadAcademica
        {
            get { return id_unidadAcademica; }

            set { id_unidadAcademica = value; }
        }

        public int Id_escuela
        {
            get { return id_escuela; }

            set { id_escuela = value; }
        }

    }




}