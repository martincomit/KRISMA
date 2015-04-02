using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public int documento;
        public string apellido;
        public string nombre;
        public string sexo;
        public DateTime fecha_nac;
        public Direccion direccion;
        public string tel_fijo;
        public string tel_celular;
        public string email;

        public Persona()
        {
    
        }

        public Persona(int documento, string apellido, string nombre, string sexo, DateTime fecha_nac, Direccion direccion, string tel_fijo, string tel_celular, string email)
        {
            this.documento = documento;
            this.apellido = apellido;
            this.nombre = nombre;
            this.sexo = sexo;
            this.fecha_nac = fecha_nac;
            this.direccion = direccion;
            this.tel_fijo = tel_fijo;
            this.tel_celular = tel_celular;
            this.email = email;
        }
    }


}
