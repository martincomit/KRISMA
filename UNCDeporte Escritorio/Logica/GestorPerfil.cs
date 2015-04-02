using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorPerfil
    {
        Perfil p = new Perfil();
        MapeoPerfil mp = new MapeoPerfil();
        string guardado;

        public string Registrar(string nombre, string descripcion)
        {

            p.Nombre = nombre;
            p.Descripcion = descripcion;

            guardado = mp.Existe(p);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mp.Registrar(p);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar();
            return ds;
        }

        public DataSet ConsultarTodos()
        {
            DataSet ds = new DataSet();
            ds = mp.ConsultarTodos();
            return ds;
        }

        public DataSet ConsultarDNI(int documento)
        {
            DataSet ds = new DataSet();
            ds = mp.ConsultarDNI(documento);
            return ds;
        }


        public DataSet ConsultarDNIyPerfil(int documento, int id_perfil)
        {
            DataSet ds = new DataSet();
            ds = mp.ConsultarDNIyPerfil(documento, id_perfil);
            return ds;
        }

        public DataSet Consultar(int id_perfil)
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar(id_perfil);
            return ds;
        }

        public void Eliminar(int id_perfil)
        {

            mp.Eliminar(id_perfil);

        }

        public void EliminarPermisos(int id_perfil)
        {

            mp.EliminarPermisos(id_perfil);

        }

        public void RegistrarIds(int id_perfil, int id_permisos)
        {

            mp.RegistrarIDs(id_perfil, id_permisos);

        }

        public int ObtenerUltimoID(string nombre)
        {

            return mp.ObtenerUltimoID(p.Nombre);

        }
    }
}
