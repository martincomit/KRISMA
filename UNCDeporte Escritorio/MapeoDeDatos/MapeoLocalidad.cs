using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoLocalidad
    {

        public string Existe(Localidad l)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
               
                DataSet ds = new DataSet();

                nombre = l.nombre;

                sql = "Select * from Localidades where nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Localidades");

                
                string test = ds.Tables[0].Rows[0][0].ToString();

                return "Existe"; // true= ya existe
            }

              catch (Exception ex)
              {
                  return "No existe"; // no existe esa localidad
              }

        }

      



        public string Registrar(Localidad l)
        {
            try
            {
                int id_localidad=1;
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
            
                DataSet ds = new DataSet();

                nombre = l.nombre;
                     
                sql = "Insert into Localidades(nombre) Values ('" + nombre + "')";
                
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Localidades");

             
                //aca vamos a traer el id insertado de localidad e insertarle un barrio centroo por defecto

                DataSet ds2 = new DataSet();

                cx.ConnectionString = c.getCadena();

                string sql2 = "select id_localidad from localidades where nombre='" + nombre + "'";

                SqlDataAdapter da2 = new SqlDataAdapter(sql2, cx);

                da2.Fill(ds2, "Localidades");

                id_localidad = int.Parse(ds2.Tables[0].Rows[0][0].ToString());
             
                //ahora que tengo el id

                DataSet ds3 = new DataSet();

                string sql3 = "Insert into Barrios (nombre, id_localidad) Values ('Centro','" + id_localidad + "')";

                SqlDataAdapter da3 = new SqlDataAdapter(sql3, cx);

                da3.Fill(ds3, "Barrios");

                //falta meter todo en una transaccion

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
           sql = "Select * from localidades order by nombre";
           StringConexion c = new StringConexion();
           cx.ConnectionString = c.getCadena();
           SqlDataAdapter da = new SqlDataAdapter(sql, cx);
           da.Fill(ds, "Localidades");

           return ds;
        }

        public void Eliminar(int id)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from localidades where id_localidad=" + id;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Localidades");
          
        }
    }
}
