using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorTipoSector
    {
        TipoSector ts = new TipoSector();
        MapeoTipoSector mts = new MapeoTipoSector();
        string guardado;

        public string Registrar(string nombre, string descripcion)
        {

            ts.Nombre = nombre;
            ts.Descripcion = descripcion;

            guardado = mts.Existe(ts);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mts.Registrar(ts);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mts.Consultar();
            return ds;
        }

        public DataSet Consultar(int id_TipoSector)
        {
            DataSet ds = new DataSet();
            ds = mts.Consultar(id_TipoSector);
            return ds;
        }

        public DataSet ConsultarPorNombre(string nom)
        {
            return mts.ConsultarPorNombre(nom);
        }
        public void Eliminar(int id)
        {

            mts.Eliminar(id);

        }




    }
}
