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
        private char sexo;
        private string apellido;
        private string nombres;
        private Localidad localidad;
        private Barrio barrio;
        private UnidadAcademica unidad;
        private Escuela escuela;
        private Estado estado;
        private Deporte deporte;
        private string direccion;
        private int id_localidad;
        private int id_barrio;
        private int caract_fijo;
        private long tel_fijo;
        private int caract_cel;
        private long tel_cel;
      
        private string email;
        private string condicion;
        private Boolean becado;
        private int id_unidadAcademica;
        private int id_escuela;

        private int id_condicion;
        private int id_deporte;
        public byte[] foto;

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

     

        public char Sexo
        {
            get { return sexo; }

            set { sexo = value; }
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


        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        public UnidadAcademica Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public Escuela Escuela
        {
            get { return escuela; }
            set { escuela = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Deporte Deporte
        {
            get { return deporte; }
            set { deporte = value; }
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

        public int Caract_fijo
        {
            get { return caract_fijo; }

            set { caract_fijo = value; }
        }

        public long Tel_fijo
        {
            get { return tel_fijo; }

            set { tel_fijo = value; }
        }


        public int Caract_cel
        {
            get { return caract_cel; }

            set { caract_cel = value; }
        }

        public long Tel_cel
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

        public string Direccion
        {
            get { return direccion; }

            set { direccion = value; }
        }

        public int Id_condicion
        {
            get { return id_condicion; }

            set { id_condicion = value; }
        }

        public int Id_deporte
        {
            get { return id_deporte; }

            set { id_deporte = value; }
        }

    }




}