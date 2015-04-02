using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MapeoDeDatos;

/// <summary>
/// Descripción breve de MapeoEscuela
/// </summary>
public class MapeoEscuela
{
  
        public string Existe(Escuela e)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                string id_unidad = "";
                DataSet ds = new DataSet();

                nombre = 
                id_unidad = e+ ""; //convierto entero en string

                sql = "Select * from escuelas where nombre='" + nombre;

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





        public string Registrar(Escuela e)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                int id_unidad;
                DataSet ds = new DataSet();

                nombre = e.Nombre;
                id_unidad = e.Id_unidad;

                sql = "Insert into Escuelas (nombre, id_unidad) Values ('" + nombre + "','" + id_unidad + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Escuelas");

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
            sql = "SELECT * from escuelas";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "escuelas");

            return ds;
        }

 

        public DataSet Consultar(int id_unidad)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * from escuelas where id_unidad=" + id_unidad;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "escuelas");

            return ds;
        }


        public void Eliminar(int id)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from escuelas where id_escuela=" + id;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "escuelas");

        }
    
}