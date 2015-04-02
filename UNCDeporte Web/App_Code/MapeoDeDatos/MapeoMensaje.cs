using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MapeoDeDatos;
using System.Data;

/// <summary>
/// Descripción breve de MapeoMensaje
/// </summary>
namespace MapeoDeDatos
{
	public class MapeoMensaje
	{
		public void EnviarMensaje(int id_deporte, string mensaje)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();


                DateTime fecha_hoy = DateTime.Now.Date;

                sql = "insert into MensajesXDeporte (id_deporte, mensaje, fecha) values (@id_deporte, @mensaje, @fecha_hoy)";

                StringConexion c = new StringConexion();
                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql, cx);


                SqlParameter pr1 = new SqlParameter("@id_deporte", id_deporte);
                SqlParameter pr2 = new SqlParameter("@mensaje", mensaje);
                SqlParameter pr3 = new SqlParameter("@fecha_hoy", fecha_hoy);

                cm.Parameters.Add(pr1);
                cm.Parameters.Add(pr2);
                cm.Parameters.Add(pr3);
                cm.ExecuteNonQuery();

              

                cx.Close();
            }
            catch (Exception ex) { }
        
        }


        public void EnviarMensajeTorneo(int id_torneo, string mensaje)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();


                DateTime fecha_hoy = DateTime.Now.Date;

                sql = "insert into MensajesXTorneo (id_torneo, mensaje, fecha) values (@id_torneo, @mensaje, @fecha_hoy)";

                StringConexion c = new StringConexion();
                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql, cx);


                SqlParameter pr1 = new SqlParameter("@id_torneo", id_torneo);
                SqlParameter pr2 = new SqlParameter("@mensaje", mensaje);
                SqlParameter pr3 = new SqlParameter("@fecha_hoy", fecha_hoy);

                cm.Parameters.Add(pr1);
                cm.Parameters.Add(pr2);
                cm.Parameters.Add(pr3);
                cm.ExecuteNonQuery();



                cx.Close();
            }
            catch (Exception ex) { }

        }

        public DataSet ConsultarMensajes(int id_deporte)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            sql = @"Select id_mensaje, fecha, mensaje
                    from MensajesXDeporte m
                    where m.id_deporte =" + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "MensajesXDeporte");
            return ds;

        }

        public void EliminarMensaje(int id_mensaje)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                sql = "Delete from MensajesXDeporte where id_mensaje=" + id_mensaje;

                StringConexion c = new StringConexion();
                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql, cx);

                cm.ExecuteNonQuery();

                cx.Close();
            }
            catch (Exception ex) { }

        }

	}
}