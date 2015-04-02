using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de GestorCondicion
/// </summary>
public class GestorCondicion
{

        Condicion cond = new Condicion();
        MapeoCondicion mc = new MapeoCondicion();
        string guardado;

        public string Registrar(string nombre, string descripcion)
        {

            cond.Nombre = nombre;
            cond.Descripcion = descripcion;

            guardado = mc.Existe(cond);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mc.Registrar(cond);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mc.Consultar();
            return ds;
        }

        public DataSet Consultar(int id_localidad)
        {
            DataSet ds = new DataSet();
            ds = mc.Consultar(id_localidad);
            return ds;
        }

        public void Eliminar(int id)
        {

            mc.Eliminar(id);

        }




    
}