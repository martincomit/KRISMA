using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapeoDeDatos;
using Entidades;
using System.Data;

namespace Logica
{
    public class GestorPersonal
    {

        MapeoPersonal mp = new MapeoPersonal();
        string guardado;
        Personal p = new Personal();

        public string Registrar(Personal p)
        {

            guardado = mp.Existe(p);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mp.Registrar(p);
                return guardado;
            }
           
           
        }

        public string Modificar(Personal p)
        {

                guardado = mp.Modificar(p);
                return guardado;


        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar();
            return ds;
        }

        public DataSet ConsultarProfes(int id_perfil)
        {
            DataSet ds = new DataSet();
            ds = mp.ConsultarProfes(id_perfil);
            return ds;
        }

        public DataSet Consultar(int id_localidad)
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar(id_localidad);
            return ds;
        }


        public DataSet ConsultarDNI(int documento)
        {
            DataSet ds = new DataSet();
            ds = mp.ConsultarDNI(documento);
            return ds;
        }

        public void Eliminar(int documento)
        {

            mp.Eliminar(documento);

        }

     

    }
    
}
