using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace MapeoDeDatos
{
    public class MapeoPermisos
    {
        public string Existe(Permiso p)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                string id_loc;
                DataSet ds = new DataSet();

                //nombre = b.nombre;
                //id_loc = b.id_localidad + ""; //convierto entero en string

                //sql = "Select * from Permisos where nombre='" + nombre + "' and id_localidad= " + id_loc;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Barrio");


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }





        public string Registrar(Barrio b)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                int id_localidad;
                DataSet ds = new DataSet();

                nombre = b.Nombre;
                id_localidad = b.Id_localidad;

                sql = "Insert into Barrios (nombre, id_localidad) Values ('" + nombre + "','" + id_localidad + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Barrios");

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
            sql = "SELECT * from permisos";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "permisos");

            return ds;
        }


        public DataSet Consultar(int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT PermisosXPerfil.id_perfil, Perfiles.nombre, Perfiles.descripcion, PermisosXPerfil.id_permiso, Permisos.nombre AS nombre_permiso, Permisos.descripcion AS descripcion_permiso FROM Perfiles INNER JOIN PermisosXPerfil ON Perfiles.id_perfil = PermisosXPerfil.id_perfil INNER JOIN Permisos ON PermisosXPerfil.id_permiso = Permisos.id_permiso where PermisosXPerfil.id_perfil='" + id_perfil + "'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "PermisosXPerfil");

            return ds;
        }

        public DataSet TodosPermisosMenosCargados(int id_permiso)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * from permisos where id_permiso<>" + id_permiso + "";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "permisos");

            return ds;
        }


        public void Eliminar(int id)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from Barrios where id_barrio=" + id;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "barrios");

        }


     

    }
}
