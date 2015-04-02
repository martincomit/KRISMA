using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace MapeoDeDatos
{
    public class MapeoTipoSector
    {
        public string Existe(TipoSector ts)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                string descripcion = "";
                DataSet ds = new DataSet();

                nombre = ts.Nombre;
                descripcion = ts.Descripcion;


                sql = "Select * from TiposSector where nombre='" + nombre + "' and descripcion= " + descripcion;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "TiposSector");

                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }





        public string Registrar(TipoSector ts)
        {
            try
            {
                //Hace falta nombre = ts. Nombre; No funcionaria tb si se pone ts.Nombre directamente en la consulta?
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                string descripcion = "";
                DataSet ds = new DataSet();

                nombre = ts.Nombre;
                descripcion = ts.Descripcion;

                sql = "Insert into TiposSector (nombre, descripcion) Values ('" + nombre + "','" + descripcion + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "TiposSector");

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
            sql = @"SELECT id_tipo_sector, nombre AS Nombre, descripcion As Descripción
            FROM TiposSector";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "TiposSector");

            return ds;
        }

        public DataSet Consultar(int id_tipo_sector)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * from TiposSector where id_tipo_sector=" + id_tipo_sector;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "TiposSector");

            return ds;
        }
        public DataSet ConsultarPorNombre(string nombre)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from TiposSector where nombre like '%"+nombre+"%'";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "TiposSector");

            return ds;
        }


        public void Eliminar(int id_tipo_sector)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from TiposSector where id_tipo_sector=" + id_tipo_sector;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "tiposSector");
        }


        //public void Modificar()
        //{
        //    string sql = "";
        //    TipoSector ts;
        //    SqlConnection cx = new SqlConnection();
        //    DataSet ds = new DataSet();
        //    sql = "Update TiposSector Set nombre = ts.Nombre, descripcion = ts.Descripcion where id_sector=" + id;
        //    StringConexion c = new StringConexion();
        //    cx.ConnectionString = c.getCadena();
        //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        //    da.Fill(ds, "tiposSector");    
        //}
        /*
         UPDATE nombre_tabla 
        SET columna1 = valor1, columna2 = valor2 
        WHERE columna3 = valor3
         * */

    }
}