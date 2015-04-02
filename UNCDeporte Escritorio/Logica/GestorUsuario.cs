using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entidades;
using MapeoDeDatos;

namespace Logica
{
    public class GestorUsuario
    {
        Usuario u = new Usuario();
        MapeoUsuario mu = new MapeoUsuario();
        string guardado;

        public string Registrar(int documento, string pass, int id_perfil, int estado)
        {

            u.Documento = documento;
            u.Pass = pass;
            u.Id_perfil = id_perfil;
            u.Estado = estado;

            guardado = mu.Existe(u);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mu.Registrar(u);
                return guardado;
            }

        }



        public string Modificar(int documento, string pass, int id_perfil, int estado)
        {

            u.Documento = documento;
            u.Pass = pass;
            u.Id_perfil = id_perfil;
            u.Estado = estado;

            guardado = mu.Modificar(u);
            mu.Consultar();
            return guardado;
            

        }

        public string RegistrarOtroPerfil(int documento,string pass, int id_perfil, int estado)
        {

            Usuario u = new Usuario();
            u.Documento = documento;
            u.Id_perfil = id_perfil;
            u.Pass = pass;
            u.Estado = estado;
            guardado = mu.ExistePerfilesXUsuario(u);

            if (guardado == "Existe")
                return "Existe";
            else
            {

                guardado = mu.RegistrarOtroPerfil(u);
                return guardado;
            }

        }


        public string RegistrarDeportePorProfesor(int id_deporte, int documento_profesor, int id_programa)
        {

            
            guardado = mu.ExisteDeportePorProfesor(id_deporte, documento_profesor,  id_programa);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mu.RegistrarDeportePorProfesor(id_deporte, documento_profesor, id_programa);
                return guardado;
            }

        }


        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mu.Consultar();
            return ds;
        }

        public DataSet ConsultarConPerfil()
        {
            DataSet ds = new DataSet();
            ds = mu.ConsultarConPerfil();
            return ds;
        }



        public DataSet ConsultarConPerfil(int id_perfil)
        {
            DataSet ds = new DataSet();
            ds = mu.ConsultarConPerfil(id_perfil);
            return ds;
        }


        public DataSet ConsultarUsuarios(string documento, string perfil, string estado)
        {
            DataSet ds = new DataSet();
            ds = mu.ConsultarUsuarios(documento, perfil, estado);
            return ds;
        }

        public DataSet ConsultarDNIyPerfilBaja()
        {
            DataSet ds = new DataSet();
            ds = mu.ConsultarDNIyPerfilBaja();
            return ds;
        }

        public void Eliminar(int documento)
        {

            mu.Eliminar(documento);

        }




    }
}
