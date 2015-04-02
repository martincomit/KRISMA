using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;
namespace Logica
{
    public class GestorPermiso
    {
        Permiso p = new Permiso();
        MapeoPermisos mp = new MapeoPermisos();
        string guardado;

        //public string Registrar(int id_permiso)
        //{

        //    l.nombre = nombre;

        //    guardado = ml.Existe(l);

        //    if (guardado == "Existe")
        //        return "Existe";
        //    else
        //    {
        //        guardado = ml.Materializar(l);
        //        return guardado;
        //    }

        //}

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar();
            return ds;
        }

        public DataSet Consultar(int id_perfil)
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar(id_perfil);
            return ds;
        }

        public DataSet TodosPermisosMenosCargados(int id_perfil)
        {
            DataSet ds = new DataSet();
            ds = mp.TodosPermisosMenosCargados(id_perfil);
            return ds;
        }


        




    }

}
