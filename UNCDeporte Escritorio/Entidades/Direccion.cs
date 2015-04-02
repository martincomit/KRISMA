using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Direccion
    {
        public int id_direccion;
        public string calle;
        public int numero;
        public string piso;
        public string departamento;
        public Barrio barrio;

        public Direccion()
        {
            this.id_direccion = 1;
            this.calle = "";
            this.numero = 0;
            this.piso = "";
            this.departamento = "";
            this.barrio = null;
        }

        public Direccion(int id_direccion, string calle, int numero, string piso, string departamento, Barrio barrio)
        {
            this.id_direccion = id_direccion;
            this.calle = calle;
            this.numero = numero;
            this.piso = piso;
            this.departamento = departamento;
            this.barrio = barrio;
        }


    }
}
