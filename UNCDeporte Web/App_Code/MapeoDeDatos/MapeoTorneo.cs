using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MapeoDeDatos
{
    public class MapeoTorneo
    {
        public string Existe(int documento, int id_torneo)
        {
             try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();

                sql = "Select * from ParticipantesXTorneo where documento_participante=" + documento + " and id_torneo= " + id_torneo;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "ParticipantesXTorneo");

                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe"; 
            }

            catch (Exception ex)
            {
                return "No existe";  
            }

        }







        

        public DataSet Consultar(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select t.id_torneo, t.nombre, t.descripcion, t.inicio_torneo, t.cierre_torneo, t.cantidad_participantes, t.puntaje_primer_puesto, t.puntaje_segundo_puesto, t.doc_primero, t.doc_segundo, e.nombre as ESTADO
                    from torneos t, Estados e
                    where t.id_estado = e.id_estado
                    and t.id_deporte = " + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }

        public DataSet ConsultarCupo(int id_torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select  t.cantidad_participantes, e.nombre as estado
                    from torneos t, Estados e
                    where t.id_estado = e.id_estado
                    and t.id_torneo = " + id_torneo;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }



        public DataSet ConsultarDatos(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select d.* 
                        from Torneos t, ParticipantesXTorneo p, Deportistas d
                        where p.id_torneo = t.id_torneo
                        and d.documento = p.documento_participante and t.id_deporte =" + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }

        public DataSet ConsultarInscriptos(int id_torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select COUNT(*)
                    from ParticipantesXTorneo
                    where id_torneo = " + id_torneo;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }
        

        public string registrarParticipante(int documento, int id_torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"insert into ParticipantesXTorneo (id_torneo, documento_participante) values ("+id_torneo+","+ documento + ")";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "ParticipantesXTorneo");

            return "Inscripto";
        }
           

    }
}
