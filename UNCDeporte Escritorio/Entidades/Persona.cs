using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private int documento;
        private string apellido;
        private string nombres;
        private char sexo;
        private DateTime fecha_nac;
        private string direccion;
        private string tel_fijo;
        private string tel_celular;
        private string email;
        private Localidad loc;
        private int id_localidad;
        private int id_barrio;
        private byte[] foto;


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
        public string Direccion
        {
            get { return direccion; }

            set { direccion = value; }
        }
        public string Tel_fijo
        {
            get { return tel_fijo; }
            set { tel_fijo = value; }
        }
        public string Tel_celular
        {
            get { return tel_celular; }
            set { tel_celular = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Localidad Loc
        {
            get { return loc; }
            set { loc = value; }
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
        public byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }



        public Persona()
        {
    
        }

        public Persona(int documento, string apellido, string nombres, char sexo, DateTime fecha_nac, string direccion, string tel_fijo, string tel_celular, string email)
        {
            this.documento = documento;
            this.apellido = apellido;
            this.nombres = nombres;
            this.sexo = sexo;
            this.fecha_nac = fecha_nac;
            this.direccion = direccion;
            this.tel_fijo = tel_fijo;
            this.tel_celular = tel_celular;
            this.email = email;
        }
    }


}
