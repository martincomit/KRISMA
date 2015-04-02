using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        //PROPIEDADES
        private string nombre;
        private string pass;
        private int documento;
        private int id_perfil;
        private int estado;
        //METODOS DE SETEO
        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public int Documento
        {
            get { return documento; }

            set { documento = value; }
        }

        public int Id_perfil
        {
            get { return id_perfil; }

            set { id_perfil = value; }
        }

        public string Pass
        {
            get { return pass; }

            set { pass = value; }
        }

        public int Estado
        {
            get { return estado; }

            set { estado = value; }
        }

    }
}
