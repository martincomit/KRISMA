using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    public class Personal:Persona 
    {
        private int documento;
        private string apellido;
        private string nombres;
        private char sexo;
        private DateTime fecha_nac;
        private string calleynum;
        private string tel_fijo;
        private string tel_cel;
        private string email;
        private Localidad loc;
        private int id_localidad;
        private int id_barrio;
        public byte[] foto;


        public int Documento
        {
            get { return documento; }
            set { documento = value; }
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

        public string NombreCompleto
        {
            get { return apellido + ", " + nombres; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime Fecha_nac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }


        public Localidad Loc
        {
            get { return loc; }
            set { loc = value; }
        }

        public Personal()
        {
            Localidad loc = new Localidad();
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

        public string Calleynum
        {
            get { return calleynum; }

            set { calleynum = value; }
        }

       
    //    public Personal():base()
    //    {
    //        this.usuario = null;
    //    }

    //    public Personal(int documento, string apellido, string nombre, string sexo, DateTime fecha_nac, Direccion direccion, string tel_fijo, string tel_celular, string email, Usuario usuario)
    //             : base(documento, apellido, nombre, sexo, fecha_nac, direccion, tel_fijo, tel_celular, email)
    //    {
    //        this.usuario = usuario;
    //    }


    }
}
