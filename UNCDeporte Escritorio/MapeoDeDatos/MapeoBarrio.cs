using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace MapeoDeDatos
{
    public class MapeoBarrio
    {
        public string Existe(Barrio b)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                string id_loc;
                DataSet ds = new DataSet();

                nombre = b.Nombre;
                id_loc = b.Id_localidad +""; //convierto entero en string

                sql = "Select * from Barrios where nombre='" + nombre + "' and id_localidad= " +id_loc;

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

                sql = "Insert into Barrios (nombre, id_localidad) Values ('" + nombre + "','"+id_localidad+"')";

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

        public bool unicoBarrio(int id_localidad)
        {
            
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select count(*) 
                    from localidades l, barrios b
                    where l.id_localidad = b.id_localidad
                    and b.id_localidad ="+ id_localidad;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Barrios");

            if (int.Parse(ds.Tables[0].Rows[0][0].ToString()) ==1) //si el count de barrios para la localidad seleccionada es 1, significa q es el unico barrio entonces no se puede borrar. si es distinto si se podra borrar ya q tendra mas de 1 barrio.

                return true;
            else
                return false;

           
        }



        public DataSet Consultar()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT    Barrios.id_barrio, Barrios.nombre as Barrio, Localidades.nombre AS Localidad, Localidades.id_localidad
                    FROM         Barrios INNER JOIN
                      Localidades ON Barrios.id_localidad = Localidades.id_localidad";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Barrios");
       
            return ds;
        }

        public DataSet Consultar(int id_localidad)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * from barrios where id_localidad=" + id_localidad;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Barrios");

            return ds;
        }



        public void Eliminar(int id_barrio)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from Barrios where id_barrio=" + id_barrio;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "barrios");

        }
    }
}