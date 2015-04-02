using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoDeporte
    {
        public string Existe(Deporte d)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = d.Nombre;

                sql = "Select * from Deportes where nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Deportes");


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }





        public string Registrar(Deporte d)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";
                string descripcion = "";
                int codSanaviron;

                DataSet ds = new DataSet();

                nombre = d.Nombre;
                descripcion = d.Descripcion;
                codSanaviron = d.Cod_sanaviron;

                //controlar si nombre esta vacio

                sql = "Insert into Deportes (nombre, descripcion, cod_sanaviron) Values ('" + nombre + "','" + descripcion + "','" + codSanaviron + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Deportes");

                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }


        public DataSet ConsultarDeportesInscriptos(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select  d.nombre, i.fecha_alta, d.id_deporte
                    from InscripcionesDisciplina i, Detalles_Insc_Disciplina di, Deportes d
                    where i.id_inscripcion = di.id_inscripcion
                    and d.id_deporte = di.id_deporte	
                    and i.documento = " + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet Consultar()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from deportes";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet ConsultarTipoDeportes()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from tipodeportes";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "tipodeportes");

            return ds;
        }



        public DataSet Consultar(string tipo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from deportes where tipo='"+ tipo+"'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet ConsultarProfesXDeporte()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select pdp.documento_profesor, d.id_deporte, d.nombre as deporte, pa.id_programa, pa.anio from ProfesoresXDeportesXProgramas pdp, UsuariosXPerfiles up, Deportes d, ProgramasActividad pa
                    where pdp.id_deporte = d.id_deporte
                    and pdp.documento_profesor = up.documento
                    and pdp.id_programa = pa.id_programa
                    order by pa.anio desc";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "ProfesoresXDeportesXProgramas");

            return ds;
        }

        public DataSet EliminarProfeXDeporteXPrograma(int documento, int id_deporte, int programa)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"DELETE FROM ProfesoresXDeportesXProgramas 
                     WHERE documento_profesor =" +documento + "and id_deporte = "+ id_deporte + "   and id_programa = "+programa ;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "ProfesoresXDeportesXProgramas");

            return ds;
        }

        public DataSet ConsultarProfesXDeporte(string documento, string id_deporte, string id_programa)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select pdp.documento_profesor, d.id_deporte, d.nombre as deporte, pa.id_programa, pa.anio from ProfesoresXDeportesXProgramas pdp, UsuariosXPerfiles up, Deportes d, ProgramasActividad pa
                    where pdp.id_deporte = d.id_deporte
                    and pdp.documento_profesor = up.documento
                    and pdp.id_programa = pa.id_programa
                    and d.id_deporte like '" + id_deporte  + "' and pdp.documento_profesor like'"+documento+"' and pa.id_programa like '"+id_programa+ 
                    "' order by pa.anio desc";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "ProfesoresXDeportesXProgramas");

            return ds;
        }


        public DataSet Consultar(Boolean torneo, string tipo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from deportes where torneo=1 and tipo ='" + tipo +"'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }


        public DataSet Consultar(Boolean torneo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from deportes where torneo=1 ";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet ConsultarTipo(int id_tipo)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            if (id_tipo == 0)
            {
                sql = @"SELECT   d.nombre,  COUNT (*) as cantidad, td.nombre as TipoDeporte
                    from Deportistas de, Deportes d, TipoDeportes td
                    where de.id_deporte = d.id_deporte
                    and td.id_tipo = d.id_tipoDeporte
                    group by de.id_deporte, d.nombre, td.nombre order by cantidad desc";
            }
            else
            {
                sql = @"SELECT   d.nombre,  COUNT (*) as cantidad, td.nombre as TipoDeporte
                    from Deportistas de, Deportes d, TipoDeportes td
                    where de.id_deporte = d.id_deporte
                    and td.id_tipo = d.id_tipoDeporte
                    and d.id_tipoDeporte = " + id_tipo +
                    "group by de.id_deporte, d.nombre, td.nombre order by cantidad desc";
               
            }

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet ConsultarMasSolicitados()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT   d.nombre,  COUNT (*) as cantidad, td.nombre as TipoDeporte
                    from Deportistas de, Deportes d, TipoDeportes td
                    where de.id_deporte = d.id_deporte
                    and td.id_tipo = d.id_tipoDeporte
                    group by de.id_deporte, d.nombre, td.nombre order by cantidad desc";
                    

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }


        public void Eliminar(int id)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from Deportes where id_deporte=" + id;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

        }

        public DataSet ConsultarPorTipoFederado()
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from deportes where tipo='Federado'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet ConsultarPorTipoRecreativo()
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from deportes where tipo='Recreativo'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }

        public DataSet Consultar(int id)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT * FROM Deportes WHERE id_deporte=" + id;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");
            return ds;
        }

    }
}
