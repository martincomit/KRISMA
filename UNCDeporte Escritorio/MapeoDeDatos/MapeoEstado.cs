using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoEstado
    {

        public string Existe(Estado e)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = e.Nombre;

                sql = "Select * from estados where nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "estados");


                string test = ds.Tables[0].Rows[0][0].ToString();

                return "Existe"; // true= ya existe
            }

            catch (Exception ex)
            {
                return "No existe"; // no existe esa localidad
            }

        }





        public string Registrar(Estado e)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = e.Nombre;

                sql = "Insert into estados(nombre) Values ('" + nombre + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "estados");


                //aca vamos a traer el id insertado de localidad e insertarle un barrio centroo por defecto

                //string sql2 = "select * from localidades where nombre=' " + nombre + "'";

                //StringConexion c2 = new StringConexion();

                //cx.ConnectionString = c2.getCadena();
                //cx.Open();
                //SqlCommand cm = new SqlCommand(sql2, cx);

                //SqlDataReader dr = cm.ExecuteReader();

                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //       int id_localidad = dr.GetInt32(0);
                //    }
                //}


                // ahora q tengo el id

                //sql = "Insert into Barrios (nombre, id_localidad) Values ('centro','" + id_localidad + "')";

                //SqlDataAdapter da3 = new SqlDataAdapter(sql, cx);

                //da3.Fill(ds, "Barrios");

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
            sql = "Select * from estados";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }


        public DataSet Consultar(int id_estado)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from estados where id_estado= "+ id_estado;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }

        public DataSet Consultar(string ambito)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from estados where ambito = '" + ambito +"'";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }

        public DataSet ConsultarAprobados(string ambito)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from estados where ambito = '" + ambito + "' and id_estado= 6 or id_estado =11";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }
        public DataSet ConsultarSoloInscripciones(string ambito)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from estados where ambito = '" + ambito + "' and id_estado= 8 or id_estado=9";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }


        public DataSet ConsultarEstadoDetalle(int id_estado)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select e.nombre
                    from Estados e, Detalles_Insc_Disciplina di
                    where e.id_estado = di.id_estado
                    and di.id_estado = " + id_estado;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }


        public void Eliminar(int id)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from estados where id_estado=" + id;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

        }
    }
}
