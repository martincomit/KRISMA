using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace MapeoDeDatos
{
    public class MapeoTorneo
    {
        public string Existe(Torneo t)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = t.Nombre;

                sql = "Select * from Torneos where nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Torneos");

                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }
            catch (Exception ex)
            {
                return "No existe";
            }
        }

        public string Registrar(Torneo t)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();

                sql = "Insert into Torneos (nombre, descripcion, id_deporte, inicio_torneo, cierre_torneo, tipo_torneo, cantidad_participantes, id_estado, puntaje_primer_puesto, puntaje_segundo_puesto,id_tipo_deporte) Values (@nombre,@descripcion,@id_deporte,@inicio_torneo,@cierre_torneo,@tipo_torneo,@cantidad_participantes,@id_estado,@puntaje_primer_puesto,@puntaje_segundo_puesto,@id_tipo_deporte)";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.Add("@nombre", t.Nombre);
                cmd.Parameters.Add("@descripcion", t.Descripcion);
                cmd.Parameters.Add("@id_deporte", t.Deporte.Id_deporte);
                cmd.Parameters.Add("@inicio_torneo", t.Inicio_Torneo);
                cmd.Parameters.Add("@cierre_torneo", t.Cierre_Torneo);
                cmd.Parameters.Add("@tipo_torneo", t.Tipo_Torneo.Id_tipoTorneo);
                cmd.Parameters.Add("@cantidad_participantes", t.Cantidad_participantes);
                cmd.Parameters.Add("@id_estado", t.Estado.Id_estado);
                cmd.Parameters.Add("@puntaje_primer_puesto", t.Puntaje_primer_puesto);
                cmd.Parameters.Add("@puntaje_segundo_puesto", t.Puntaje_segundo_puesto);
                cmd.Parameters.Add("@id_tipo_deporte", t.Deporte.Id_tipo);

                cmd.ExecuteNonQuery();
                cx.Close();

                return "Guardado";
            }
            catch (Exception ex)
            {
                return "Error al Guardar";
            }
        }

        public string RegistrarClasificatorio(Torneo t)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();

                sql = "Insert into Torneos (nombre, descripcion, id_deporte, inicio_torneo, cierre_torneo, tipo_torneo, cantidad_participantes, id_estado, cant_grupos, cant_particip_por_grupo, cant_clasifican_por_grupo, puntaje_primer_puesto, puntaje_segundo_puesto, id_tipo_deporte) Values (@nombre,@descripcion,@id_deporte,@inicio_torneo,@cierre_torneo,@tipo_torneo,@cantidad_participantes,@id_estado,@cant_grupos,@cant_particip_por_grupo,@cant_clasifican_por_grupo,@puntaje_primer_puesto,@puntaje_segundo_puesto,@id_tipo_deporte)";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.Add("@nombre", t.Nombre);
                cmd.Parameters.Add("@descripcion", t.Descripcion);
                cmd.Parameters.Add("@id_deporte", t.Deporte.Id_deporte);
                cmd.Parameters.Add("@inicio_torneo", t.Inicio_Torneo);
                cmd.Parameters.Add("@cierre_torneo", t.Cierre_Torneo);
                cmd.Parameters.Add("@tipo_torneo", t.Tipo_Torneo.Id_tipoTorneo);
                cmd.Parameters.Add("@cantidad_participantes", t.Cantidad_participantes);
                cmd.Parameters.Add("@id_estado", t.Estado.Id_estado);
                cmd.Parameters.Add("@cant_grupos", t.Cantidad_grupos);
                cmd.Parameters.Add("@cant_particip_por_grupo", t.Cantidad_participantes_grupo);
                cmd.Parameters.Add("@cant_clasifican_por_grupo", t.Cantidad_clasificados_grupo);
                cmd.Parameters.Add("@puntaje_primer_puesto", t.Puntaje_primer_puesto);
                cmd.Parameters.Add("@puntaje_segundo_puesto", t.Puntaje_segundo_puesto);
                cmd.Parameters.Add("@id_tipo_deporte", t.Deporte.Id_tipo);

                cmd.ExecuteNonQuery();
                cx.Close();

                return "Guardado";
            }
            catch (Exception ex)
            {
                return "Error al Guardar";
            }
        }

        public void registrarEnCurso(int id_torneo, int id_estado)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();

                sql = "update torneos set id_estado ="+id_estado+" where id_torneo = "+id_torneo;
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.ExecuteNonQuery();
                cx.Close();

          
            }
            catch (Exception ex)
            {
               
            }
        }

        public void registrarResultado(int id_torneo, int id_estado, int doc_primero, int doc_segundo)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();

                sql = "update torneos set id_estado =" + id_estado + ", doc_primero="+ doc_primero +", doc_segundo= "+ doc_segundo + " where id_torneo = " + id_torneo;
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.ExecuteNonQuery();
                cx.Close();


            }
            catch (Exception ex)
            {

            }
        }


        //public void registrarRanking(int id_deporte, int doc_primero, int doc_segundo)
        //{
        //    try
        //    {
        //        string sql = "";
        //        SqlConnection cx = new SqlConnection();
        //        StringConexion c = new StringConexion();

        //        cx.ConnectionString = c.getCadena();
        //        cx.Open();

        //        sql = "insert into rankingfederados (doc_federado, id_deporte, puntaje) values (@doc_federado, @id_deporte, @puntaje)";
                
        //        SqlCommand cmd = new SqlCommand(sql, cx);
                
        //        cmd.Parameters.Add("@doc_federado", doc_primero);
        //        cmd.Parameters.Add("@id_deporte", id_deporte);
        //        cmd.Parameters.Add("@puntaje", );
               



        //        cmd.ExecuteNonQuery();
        //        cx.Close();


        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        public DataSet Consultar(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select * from torneos where id_deporte =" + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }


        public DataSet ConsultarRanking(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select d.documento, d.apellido, d.nombres, r.puntaje 
                    from RankingFederados r, Deportistas d
                     where r.doc_federado = d.documento
                    and r.id_deporte =" + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "RankingFederados");

            return ds;
        }



        public DataSet Consultar()
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select * from torneos";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }

        public DataSet ConsultarDatos(int id_torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select d.*, t.*
                    from Deportistas d, ParticipantesXTorneo pt, Torneos t
                    where d.documento = pt.documento_participante
                    and t.id_torneo = pt.id_torneo
                    and pt.id_torneo =" + id_torneo + "";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "ParticipantesXTorneo");

            return ds;
        }

        public DataSet ConsultarDescripcion(int id_torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select descripcion from torneos where id_torneo =" + id_torneo;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }


        public DataSet ConsultarEstado(int id_torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select e.nombre
                    from Torneos t, Estados e
                    where t.id_estado = e.id_estado
                    and t.id_torneo =" + id_torneo;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "torneos");

            return ds;
        }

        public void Eliminar(int documento)
        {

            string sql = "";
     

            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from ParticipantesXTorneo where documento_participante=" + documento;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            da.Fill(ds, "ParticipantesXTorneo");

        }


        public DataSet ConsultarPorFiltro(string nom)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            sql = @"SELECT * FROM Torneos WHERE nombre LIKE '" + nom + "%'";

            /*
            //ver where y los atributos que arrancan con .
            sql = @"SELECT t.id_torneo, t.nombre AS Nombre, t.descripcion AS Descripción, t.id_deporte AS Deporte, 
            t.inicio_torneo AS Fecha_Inicio,t.cierre_torneo AS Fecha_Cierre, tt.Nombre AS Tipo_Torneo,t.cantidad_participantes AS Cantidad_Participantes,est.nombre AS Estado,t.cant_grupos AS Cantidad_Grupos,t.cant_particip_por_grupo AS Participantes_Por_Grupo,t.cant_clasifican_por_grupo AS Clasificados_Por_Grupo,.id_torneo_siguiente_fase AS Fase_Anterior,.id_resultados,t.puntaje_primer_puesto AS Puntaje_Primer_Puesto,t.puntaje_segundo_puesto AS Puntaje_Segundo_Puesto
            FROM         Torneos t,Deportes de,TiposTorneo tt, Estados est 
            WHERE LugaresPractica.id_localidad = Localidades.id_localidad AND LugaresPractica.id_barrio = Barrios.id_barrio AND LugaresPractica.nombre LIKE '" + nom + "%'";
            */

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Torneos");
            return ds;
        }

        public DataSet ConsultarEstadosTorneo()
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select e.nombre
                    from Estados e
                    where e.ambito='torneos'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "estados");

            return ds;
        }
    }
}
