using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoLugarPractica
    {
        Conexion conexion;

        public MapeoLugarPractica()
        {
            conexion = new Conexion();
        }

        public string Existe(LugarPractica lp)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                int id_localidad;
                int id_barrio;

                DataSet ds = new DataSet();

                nombre = lp.Nombre;
                id_localidad = lp.Localidad.Id_localidad;
                id_barrio = lp.Barrio.Id_barrio;

                sql = "Select * from LugaresPractica where nombre='" + nombre + "'" + "AND id_localidad='" + id_localidad + "'" + "AND id_barrio='" + id_barrio + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "LugaresPractica");

                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }
            catch (Exception ex)
            {
                return "No existe";
            }
        }

        public string Registrar(LugarPractica lp)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();

                DataSet ds = new DataSet();

                sql = "Insert into LugaresPractica (nombre, descripcion, direccion, id_localidad, id_barrio) Values ('" + lp.Nombre + "','" + lp.Descripcion + "','" + lp.Direccion + "','" + lp.Localidad.Id_localidad + "','" + lp.Barrio.Id_barrio + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "LugaresPractica");

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

            sql = @"SELECT LugaresPractica.id_lugar, LugaresPractica.nombre AS Nombre, LugaresPractica.descripcion AS Descripción, LugaresPractica.direccion AS Dirección, 
            Localidades.nombre AS Localidad,Barrios.nombre AS Barrio
            FROM         LugaresPractica,Localidades,Barrios WHERE LugaresPractica.id_localidad = Localidades.id_localidad AND LugaresPractica.id_barrio = Barrios.id_barrio";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");

            return ds;
        }

        public DataSet Consultar(int id_lugar)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * from LugaresPractica where id_lugar=" + id_lugar;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");

            return ds;
        }

        public DataSet Consultar2(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select lp.nombre from Deportes d, LugaresPractica lp where lp.id_lugar=d.id_lugar and d.id_deporte=" + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");

            return ds;
        }


        public DataSet ConsultarPorFiltro(string nom, int id_localidad)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            sql = @"SELECT LugaresPractica.id_lugar, LugaresPractica.nombre AS Nombre, LugaresPractica.descripcion AS Descripción, LugaresPractica.direccion AS Dirección, 
            Localidades.nombre AS Localidad,Barrios.nombre AS Barrio
            FROM         LugaresPractica,Localidades,Barrios WHERE LugaresPractica.id_localidad = Localidades.id_localidad AND LugaresPractica.id_barrio = Barrios.id_barrio AND LugaresPractica.nombre LIKE '" + nom + "%' AND LugaresPractica.id_localidad=" + id_localidad;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");

            return ds;
        }

        public DataSet ConsultarPorFiltro(string nom)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            sql = @"SELECT LugaresPractica.id_lugar, LugaresPractica.nombre AS Nombre, LugaresPractica.descripcion AS Descripción, LugaresPractica.direccion AS Dirección, 
            Localidades.nombre AS Localidad,Barrios.nombre AS Barrio
            FROM         LugaresPractica,Localidades,Barrios WHERE LugaresPractica.id_localidad = Localidades.id_localidad AND LugaresPractica.id_barrio = Barrios.id_barrio AND LugaresPractica.nombre LIKE '" + nom + "%'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");
            return ds;
        }

        public void Eliminar(int id)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from LugaresPractica where id_lugar=" + id;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");
        }

        public string Modificar(LugarPractica lp)
        {
            SqlConnection cx = new SqlConnection();
            StringConexion c = new StringConexion();

            cx.ConnectionString = c.getCadena();
            int id_lugar = lp.Id_lugar;//ojo
            string nombre = lp.Nombre;
            string descripcion = lp.Descripcion;
            string direccion = lp.Direccion;

            int localidad = lp.Localidad.Id_localidad;
            int barrio = lp.Barrio.Id_barrio;

            string sql = "Update LugaresPractica set nombre='" + nombre + "', descripcion = '" + descripcion + "', direccion = '" + direccion + "', id_localidad = '" + localidad + "', id_barrio = '" + barrio + "' where id_lugar=" + id_lugar;

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "LugaresPractica");
            return "Modificado";
        }


        public Localidad obtenerLocalidad(int id_localidad)
        {
            conexion.origen.Open();
            conexion.str_sql = "Select * from Localidades where id_localidad= " + id_localidad;
            conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
            conexion.dr1 = conexion.cmd.ExecuteReader();

            conexion.dr1.Read();
            Localidad l = new Localidad();
            if (conexion.dr1["id_localidad"] != DBNull.Value)
            {
                l.Id_localidad = Convert.ToInt32(conexion.dr1["id_localidad"]);
            }
            if (conexion.dr1["nombre"] != DBNull.Value)
            {
                l.nombre = conexion.dr1["nombre"].ToString();
            }

            conexion.origen.Close();
            return l;

        }

        public Barrio obtenerBarrio(int id_barrio)
        {
            conexion.origen.Open();
            conexion.str_sql = "Select * from Barrios where id_barrio= " + id_barrio;
            conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
            conexion.dr1 = conexion.cmd.ExecuteReader();

            conexion.dr1.Read();
            Barrio b = new Barrio();
            if (conexion.dr1["id_barrio"] != DBNull.Value)
            {
                b.Id_barrio = Convert.ToInt32(conexion.dr1["id_barrio"]);
            }
            if (conexion.dr1["nombre"] != DBNull.Value)
            {
                b.Nombre = conexion.dr1["nombre"].ToString();
            }

            conexion.origen.Close();
            return b;
        }

    }
}