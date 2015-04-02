using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoPerfil
    {

        public string Existe(Perfil p)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = p.Nombre;

                sql = "Select * from Perfiles where nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Perfiles");


                string test = ds.Tables[0].Rows[0][0].ToString();

                return "Existe"; // true= ya existe
            }

            catch (Exception ex)
            {
                return "No existe"; // no existe esa localidad
            }

        }

        public int ObtenerUltimoID(string nombre)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();

                DataSet ds = new DataSet();

                sql = "Select id_perfil from Perfiles where nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Perfiles");

                return (int.Parse(ds.Tables[0].Rows[0][0].ToString()));
            }

            catch (Exception ex)
            {
                return 0;
            }

        }



        public string Registrar(Perfil p)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = p.Nombre;

                sql = "Insert into Perfiles(nombre) Values ('" + nombre + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Perfiles");

                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }


        public DataSet Consultar()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from Perfiles where tipo_perfil='escritorio'";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Perfiles");

            return ds;
        }

        public DataSet ConsultarTodos()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from Perfiles";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Perfiles");

            return ds;
        }


        public DataSet Consultar(int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from Perfiles where id_perfil = "+id_perfil+" and tipo_perfil='escritorio'";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Perfiles");

            return ds;
        }

        public DataSet ConsultarDNI(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select up.*, p.nombre 
                    from UsuariosXPerfiles up, Perfiles p
                    where up.id_perfil = p.id_perfil
                    and up.documento=" + documento;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }

        public DataSet ConsultarDNIyPerfil(int documento, int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select up.*, p.nombre 
                    from UsuariosXPerfiles up, Perfiles p
                    where up.id_perfil = p.id_perfil
                    and up.documento=" + documento + " and up.id_perfil=" + id_perfil;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }

        public void Eliminar(int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from Perfiles where id_perfil=" + id_perfil;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Perfiles");

        }

        public void EliminarPermisos(int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from PermisosXPerfil where id_perfil=" + id_perfil;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "PermisosXPerfil");

        }


        public void RegistrarIDs(int id_perfil, int id_permisos)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
           

                DataSet ds = new DataSet();

                sql = "Insert into PermisosxPerfil(id_perfil, id_permiso) Values ('" + id_perfil + "','" + id_permisos + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "PermisosxPerfil");

            }

            catch (Exception ex)
            {

            }


        }
    }

}