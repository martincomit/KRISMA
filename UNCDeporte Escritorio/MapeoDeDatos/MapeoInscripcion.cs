using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoInscripcion
    {
        string sql = "";
        SqlConnection cx = new SqlConnection();
        DataSet ds = new DataSet();
        StringConexion c = new StringConexion();
        
        
        
        public string Registrar(int documento, int []vector_id_deporte, int cantidad, string []vector_tipo)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();
                sql = "select id_inscripcion from InscripcionesDisciplina where documento =" + documento;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "InscripcionesDisciplina");

                int id_inscripcion = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                //----------------------------
                //borro todas los detalles anteriores con esa misma inscripcion
                try
                {
                    sql = "delete from Detalles_Insc_Disciplina where id_inscripcion = @id_inscripcion";
                   
                  
                    cx.Open();
                    SqlCommand cm = new SqlCommand(sql, cx);

                    SqlParameter pr1 = new SqlParameter("@id_inscripcion", id_inscripcion);

                    cm.Parameters.Add(pr1);

                    cm.ExecuteNonQuery();
                }
                catch (Exception ex) { } //cachea en caso de no necesitar borrar nada
                //ahora inserto los detalles


                for (int i = 0; i < cantidad; i++)
                {
                    int id_estado;
                    if (vector_tipo[i].ToString() == "recreativo")
                        id_estado = 9;
                    else
                        id_estado = 8;

                    sql = "Insert into Detalles_Insc_Disciplina (id_inscripcion, id_programa, id_deporte, item, id_estado, fecha_inscripcion) values (@id_inscripcion, 2, @id_deporte, 1, @id_estado, @fecha_inscripcion)"; //ver el item si sirve, y el programa de donde viene, dependera del deporte
                    string sqlu = "insert into UsuariosXDeportes(documento, id_deporte) values (@documento, @id_deporte)";
                    SqlCommand cm2 = new SqlCommand(sql, cx);
                    SqlCommand cm3 = new SqlCommand(sqlu, cx);
                    SqlParameter pr11 = new SqlParameter("@id_inscripcion", id_inscripcion);
                    SqlParameter pr12 = new SqlParameter("@id_deporte", vector_id_deporte[i]);
                    SqlParameter pr13 = new SqlParameter("@id_estado", id_estado);
                    SqlParameter pr14 = new SqlParameter("@fecha_inscripcion",DateTime.Today);

                    SqlParameter pr1u = new SqlParameter("@id_deporte", vector_id_deporte[i]);
                    SqlParameter pr2u = new SqlParameter("@documento", documento);

                    cm2.Parameters.Add(pr11);
                    cm2.Parameters.Add(pr12);
                    cm2.Parameters.Add(pr13);
                    cm2.Parameters.Add(pr14);

                    cm3.Parameters.Add(pr1u);
                    cm3.Parameters.Add(pr2u);

                    cm2.ExecuteNonQuery();
                    cm3.ExecuteNonQuery();
                  

                }


                string sql3 = "";
                DataSet ds3 = new DataSet();
                sql3 = "update usuariosxperfiles set id_perfil=5 where documento=" + documento;

                SqlDataAdapter da3 = new SqlDataAdapter(sql3, cx);

                da3.Fill(ds3, "usuariosxperfiles");


                cx.Close();

                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }
        public DataSet ConsultarInscriptos()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, e.nombre from Detalles_Insc_Disciplina d, Estados e
                    where (d.id_estado = 8 or d.id_estado =9)
                    and e.id_estado = d.id_estado
                    order by d.fecha_inscripcion desc";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Detalles_Insc_Disciplina");

            return ds;
        }

        public DataSet ConsultarDeportistas()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select distinct i.documento, d.nombres, d.apellido
                        from InscripcionesDisciplina i, Detalles_Insc_Disciplina di, Deportistas d
                        where i.id_inscripcion = di.id_inscripcion
                        and d.documento = i.documento
                        order by i.documento";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataRow ContarInscripciones(int id_estado)
        {

            
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select COUNT(*) from detalles_insc_disciplina d where d.id_estado = " + id_estado;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Detalles_Insc_Disciplina");
            DataRow dr = ds.Tables[0].Rows[0];
            return dr;
        }

        public DataSet ConsultarInscriptos(int estado)
        {



            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, e.nombre from Detalles_Insc_Disciplina d, Estados e
                    where  e.id_estado = " + estado + " and e.id_estado = d.id_estado order by d.fecha_inscripcion desc";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Detalles_Insc_Disciplina");

            return ds;
        }

        public DataSet Consultar()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Detalles_Insc_Disciplina.*, InscripcionesDisciplina.*, Deportes.*
                    FROM         Detalles_Insc_Disciplina INNER JOIN
                      InscripcionesDisciplina ON Detalles_Insc_Disciplina.id_inscripcion = InscripcionesDisciplina.id_inscripcion INNER JOIN
                      Deportes ON Detalles_Insc_Disciplina.id_deporte = Deportes.id_deporte";
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "InscripcionesDisciplina");

            return ds;
        }

        public DataSet Consultar(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Detalles_Insc_Disciplina.*, InscripcionesDisciplina.*, Deportes.*
                    FROM         Detalles_Insc_Disciplina INNER JOIN
                      InscripcionesDisciplina ON Detalles_Insc_Disciplina.id_inscripcion = InscripcionesDisciplina.id_inscripcion INNER JOIN
                      Deportes ON Detalles_Insc_Disciplina.id_deporte = Deportes.id_deporte
                      where Detalles_Insc_Disciplina.id_deporte = " +id_deporte;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "InscripcionesDisciplina");

            return ds;
        }

        public DataSet Consultar(int documento, int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Detalles_Insc_Disciplina.*, InscripcionesDisciplina.*, Deportes.*
                    FROM         Detalles_Insc_Disciplina INNER JOIN
                      InscripcionesDisciplina ON Detalles_Insc_Disciplina.id_inscripcion = InscripcionesDisciplina.id_inscripcion INNER JOIN
                      Deportes ON Detalles_Insc_Disciplina.id_deporte = Deportes.id_deporte
                      where Detalles_Insc_Disciplina.id_deporte = " + id_deporte + " and  InscripcionesDisciplina.documento = " + documento; 
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "InscripcionesDisciplina");

            return ds;
        }



        public DataSet ConsultarDocumento(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Detalles_Insc_Disciplina.*, InscripcionesDisciplina.*, Deportes.*
                    FROM         Detalles_Insc_Disciplina INNER JOIN
                      InscripcionesDisciplina ON Detalles_Insc_Disciplina.id_inscripcion = InscripcionesDisciplina.id_inscripcion INNER JOIN
                      Deportes ON Detalles_Insc_Disciplina.id_deporte = Deportes.id_deporte
                         where InscripcionesDisciplina.documento = " + documento;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "InscripcionesDisciplina");

            return ds;
        }


    }
}
