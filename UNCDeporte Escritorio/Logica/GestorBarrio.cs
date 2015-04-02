using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorBarrio
    {
        Barrio b = new Barrio();
        MapeoBarrio mb = new MapeoBarrio();
        string guardado;

        public string Registrar(string nombre, int id_loc)
        {

            b.Nombre = nombre;
            b.Id_localidad = id_loc;

            guardado = mb.Existe(b);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mb.Registrar(b);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mb.Consultar();
            return ds;
        }

        public bool unicoBarrio(int id_localidad)
        {

            return mb.unicoBarrio(id_localidad);
           
        }




     

        public DataSet Consultar(int id_localidad)
        {
            DataSet ds = new DataSet();
            ds = mb.Consultar(id_localidad);
            return ds;
        }

        public void Eliminar(int id_barrio)
        {

            mb.Eliminar(id_barrio);

        }




    }
}
