using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoUsuario
    {
        public string Existe(Usuario u)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int documento = 0;
                string pass = "";

                DataSet ds = new DataSet();

                documento = u.Documento;
                pass = u.Pass;

                sql = "Select * from usuariosxperfiles where documento=" + documento;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "usuariosxperfiles");

                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }


        public string ExistePerfilesXUsuario(Usuario u)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string id_perfil = "";
                string documento = "";

                DataSet ds = new DataSet();

                id_perfil = u.Id_perfil+"";
                documento = u.Documento+"";

                sql = "Select * from UsuariosXPerfiles where documento=" + documento + " and id_perfil=" + id_perfil;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "PerfilesXUsuario");


                //SqlParameter pr = new SqlParameter("@id", txtid.text);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.Add("@id", txtid.text);
                //da.SelectCommand.Parameters.Add("@id", txtid.text);
                //da.SelectCommand.Parameters.Add("@id", txtid.text);
                //da.SelectCommand.Parameters.Add("@id", txtid.text);

                //da.SelectCommand.ExecuteNonQuery();


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }

        public string ExisteDeportePorProfesor(int id_deporte, int documento_profesor, int id_programa)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
            

                DataSet ds = new DataSet();


                sql = "Select * from ProfesoresXDeportesXProgramas where documento_profesor=" + documento_profesor + " and id_deporte=" + id_deporte+" and id_programa="+ id_programa;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "ProfesoresXDeportesXProgramas");


                //SqlParameter pr = new SqlParameter("@id", txtid.text);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.Add("@id", txtid.text);
                //da.SelectCommand.Parameters.Add("@id", txtid.text);
                //da.SelectCommand.Parameters.Add("@id", txtid.text);
                //da.SelectCommand.Parameters.Add("@id", txtid.text);

                //da.SelectCommand.ExecuteNonQuery();


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }

        public string Registrar(Usuario u)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int documento = 0;
                string pass = "";
                int id_perfil = 0;
                int estado = 1;
                DataSet ds = new DataSet();

                documento = u.Documento;
                pass = u.Pass;
                id_perfil = u.Id_perfil;
                estado = u.Estado;

                sql = "Insert into UsuariosXPerfiles (documento, pass, id_perfil, estado) Values ('" + documento + "','" + pass + "','" +id_perfil+"',"+estado+")";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "usuariosxperfiles");

                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }

        public string Modificar(Usuario u)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int documento = 0;
                string pass = "";
                int id_perfil = 0;
                int estado = 1;
                DataSet ds = new DataSet();

                documento = u.Documento;
                pass = u.Pass;
                id_perfil = u.Id_perfil;
                estado = u.Estado;

                sql = "Update usuariosxperfiles set pass='" + pass + "', estado=" + estado + " where documento=" + documento;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "usuariosxperfiles");

                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }


        public string RegistrarOtroPerfil(Usuario u)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int id_perfil = 0;
                int documento = 0;
                string pass = "";
                int estado = 1;
                DataSet ds = new DataSet();

                id_perfil = u.Id_perfil;
                documento = u.Documento;
                estado = u.Estado;
                pass = u.Pass;

                sql = "Insert into UsuariosXPerfiles (id_perfil, documento, pass, estado) Values ('" + id_perfil + "','" + documento + "','"+pass+"','"+estado+"')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "UsuariosXPerfiles");

                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }

        public string RegistrarDeportePorProfesor(int id_deporte, int documento_profesor, int id_programa)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
             
                DataSet ds = new DataSet();


                sql = "Insert into ProfesoresXDeportesXProgramas (id_deporte, documento_profesor, id_programa) Values ('" + id_deporte + "','" + documento_profesor +"','"+id_programa+"')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "ProfesoresXDeportesXProgramas");

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
            sql = "SELECT * from usuariosxperfiles";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }

       

        public DataSet ConsultarConPerfil()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select up.*, p.nombre as Perfil 
                    from UsuariosXPerfiles up, Perfiles p
                    where up.id_perfil = p.id_perfil";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }

        public DataSet ConsultarConPerfil(int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select up.*, p.nombre as Perfil
                    from UsuariosXPerfiles up, Perfiles p
                    where up.id_perfil = p.id_perfil
                    and up.id_perfil="+id_perfil;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }

        public DataSet ConsultarUsuarios(string documento, string perfil, string estado)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select up.*, p.nombre as Perfil
                    from UsuariosXPerfiles up, Perfiles p
                    where up.id_perfil = p.id_perfil
                    and up.estado like '"+estado+"'and up.documento like '"+documento+"' and up.id_perfil like '"+perfil+"'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }

        public DataSet ConsultarDNIyPerfilBaja()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select up.*, p.nombre 
                    from UsuariosXPerfiles up, Perfiles p
                    where up.id_perfil = p.id_perfil
                    and up.estado like '0'
                    and up.documento like '%'
                    and up.id_perfil like '%'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

            return ds;
        }


        public void Eliminar(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Update usuariosxperfiles set estado=0 where documento=" + documento;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "usuariosxperfiles");

        }
    }
}
