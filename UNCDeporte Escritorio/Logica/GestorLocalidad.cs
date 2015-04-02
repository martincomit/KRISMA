using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data.SqlClient;
using System.Data;

namespace Logica
{
    public class GestorLocalidad
    {
        Localidad l = new Localidad();
        MapeoLocalidad ml = new MapeoLocalidad();
        string guardado;

        public string RegistrarConBarrioCentro(string nombre)
        {

            l.nombre = nombre;

            guardado = ml.Existe(l);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = ml.Registrar(l);
                return guardado;
            }

        }





        public string Registrar(string nombre)
        {

            l.nombre = nombre;

            guardado = ml.Existe(l);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = ml.Registrar(l);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds =ml.Consultar();
            return ds;
         }

        public void Eliminar(int id)
        {
            
            ml.Eliminar(id);
            
        }




        }


    
}
