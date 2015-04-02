using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de GestorEscuela
/// </summary>
public class GestorEscuela
{
 
        Escuela e = new Escuela();
        MapeoEscuela me = new MapeoEscuela();
        string guardado;

        public string Registrar(string nombre)
        {

            e.Nombre = nombre;

            guardado = me.Existe(e);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = me.Registrar(e);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = me.Consultar();
            return ds;
        }


        public DataSet Consultar(int id_unidad)
        {
            DataSet ds = new DataSet();
            ds = me.Consultar(id_unidad);
            return ds;
        }

        public void Eliminar(int id)
        {

            me.Eliminar(id);

        }




    

}