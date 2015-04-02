using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoDeportista
    {
    public string Existe(Deportista de)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int dni;

                DataSet ds = new DataSet();

                dni = de.Documento;

                sql = "Select * from deportistas where documento='" + dni + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Deportistas");


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }





        public string Registrar(Deportista de)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int dni;
    

                DataSet ds = new DataSet();


                dni = de.Documento;

                //controlar si nombre esta vacio

                sql = "Insert into Deportistas (documento) Values ('" + dni + "')";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Deportistas");

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
            sql = "select * from Deportistas";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");
      
            return ds;
        }

        public DataSet deportePreinscripto(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Deportes.nombre
                    FROM         Deportistas INNER JOIN
                      Deportes ON Deportistas.id_deporte = Deportes.id_deporte
                      where Deportistas.documento = " + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }


        public DataSet ConsultarDeportes(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select de.nombre
                    from deportistas d, deportes de
                    where d.id_deporte = de.id_deporte
                    and d.documento = " + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataSet ConsultarInscripciones()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, di.*
                    from Deportistas d, InscripcionesDisciplina i, Detalles_Insc_Disciplina di
                    where d.documento = i.documento 
                    and di.id_inscripcion = i.id_inscripcion";


            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataSet ConsultarInscripciones(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, di.*
                    from Deportistas d, InscripcionesDisciplina i, Detalles_Insc_Disciplina di
                    where d.documento = i.documento 
                    and di.id_inscripcion = i.id_inscripcion and d.documento = " +documento;


            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataSet ConsultarInscripciones(string ambito)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, di.*
                    from Deportistas d, InscripcionesDisciplina i, Detalles_Insc_Disciplina di, Estados e
                    where d.documento = i.documento 
                    and di.id_estado = e.id_estado
                    and di.id_inscripcion = i.id_inscripcion and e.ambito = '" + ambito +"'";


            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataSet ConsultarInscripciones(int estadoaprobado, int estadosolorecreativas)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, di.*
                    from Deportistas d, InscripcionesDisciplina i, Detalles_Insc_Disciplina di
                    where d.documento = i.documento 
                    and di.id_inscripcion = i.id_inscripcion and (di.id_estado = " + estadoaprobado +" or di.id_estado ="+estadosolorecreativas+")";


            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }



        public DataSet ConsultarInscripcionesEstado(int id_estado)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, di.*
                    from Deportistas d, InscripcionesDisciplina i, Detalles_Insc_Disciplina di
                    where d.documento = i.documento 
                    and di.id_inscripcion = i.id_inscripcion and di.id_estado = " +id_estado;


            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }
        public DataSet ConsultarInscripcionesEstadoDocumento(int id_estado, int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.*, di.*
                    from Deportistas d, InscripcionesDisciplina i, Detalles_Insc_Disciplina di
                    where d.documento = i.documento 
                    and di.id_inscripcion = i.id_inscripcion and di.id_estado = " +id_estado +" and d.documento = "+ documento ;


            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }
        


        public DataSet Consultar(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from Deportistas where documento=" + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }
        public DataSet ConsultarSinAsignar()
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from Deportistas where id_estadoLaboratorio =5 and id_estadoErgometria=5";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }



        public DataSet Consultar(int documento, int id_estado)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select * from Deportistas where id_estado =" + id_estado + " and documento=" + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public void Eliminar(int dni)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from Deportistas where documento=" + dni;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

        }


        public string Modificar(int documento, int id_estado)
        {
            try
            {
                string sql = "";
                string sql2 = "";
                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();
                //estado = 4 turnos asignados 
                sql = @"update Detalles_Insc_Disciplina
                        set Detalles_Insc_Disciplina.id_estado = "+ id_estado +
                        @"from Detalles_Insc_Disciplina di, Deportistas d, InscripcionesDisciplina i
                        where 
                        d.documento = i.documento
                        and
                        i.id_inscripcion = di.id_inscripcion
                        and d.documento =  " + documento;

             

                StringConexion c = new StringConexion();
                cx.ConnectionString = c.getCadena();
                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.Fill(ds, "Deportistas");

                if (id_estado == 8) //inscripto
                {

                    DataSet ds2 = new DataSet();
                    sql2 = "update usuariosxperfiles set id_perfil = 5 where documento = " +documento;  //5 deportista
                    SqlDataAdapter da2 = new SqlDataAdapter(sql2, cx);
                    da2.Fill(ds, "usuariosxperfiles");
                }
                else
                {
                    DataSet ds2 = new DataSet();
                    sql2 = "update usuariosxperfiles set id_perfil = 8 where documento = " +documento;  //8 sin permisos
                    SqlDataAdapter da2 = new SqlDataAdapter(sql2, cx);
                    da2.Fill(ds, "usuariosxperfiles");

                }
                return "Guardado";
            }
            catch (Exception ex) { return "Error"; }

        }

        public string Modificar(int documento, int id_estadoErgo, int id_estadoLabo)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();
                //estado = 4 asignado
                sql = "Update deportistas set id_estadoLaboratorio = 6 ,id_estadoErgometria = 6  where documento= " + documento;
                StringConexion c = new StringConexion();
                cx.ConnectionString = c.getCadena();
                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.Fill(ds, "Deportistas");
                return "Guardado";
            }
            catch (Exception ex) { return "Error"; }

        }


        public DataSet ConsultarPorDocumento(int doc)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            // el problema puede ser que el id escuela xq es null en algunos casos

            /*
            sql = @"SELECT de.documento AS Documento,de.apellido AS Apellido,de.nombres AS Nombres,de.sexo AS Sexo, 
            de.fec_nac AS FechaNacimiento,b.nombre AS Barrio,de.tel_fijo AS TeléfonoFijo,de.tel_cel AS Celular,de.email AS Email,ua.nombre AS UnidadAcadémica,e.nombre AS Escuela,de.foto AS Foto,de.condicion AS Condición,de.becado AS Becado,l.nombre AS Localidad,est.nombre AS Estado,d.nombre AS Deporte
            FROM Deportistas de,Localidades l,Barrios b,UnidadesAcademicas ua,Escuelas e,Deportes d,Estados est WHERE de.id_localidad = l.id_localidad AND de.id_barrio = b.id_barrio AND de.id_unidad = ua.id_unidad AND de.id_escuela=e.id_escuela AND de.id_deporte=d.id_deporte AND de.id_estado=est.id_estado AND de.id_estado=9 AND de.documento LIKE '" + doc + "%'";
            */

            sql = @"SELECT de.documento AS Documento,de.apellido AS Apellido,de.nombres AS Nombres,de.sexo AS Sexo, 
            de.fec_nac AS FechaNacimiento,b.nombre AS Barrio,de.tel_fijo AS TeléfonoFijo,de.tel_cel AS Celular,de.email AS Email,
            de.id_unidad AS UnidadAcadémica,de.id_escuela AS Escuela,de.foto AS Foto,de.id_condicion AS Condición,de.becado AS Becado,
            l.nombre AS Localidad,est.nombre AS Estado,d.nombre AS Deporte
            FROM Deportistas de,Localidades l,Barrios b,Deportes d,Estados est 
            WHERE de.id_localidad = l.id_localidad AND de.id_barrio = b.id_barrio
            AND de.id_deporte=d.id_deporte AND de.id_estado=est.id_estado AND de.id_estado=1 AND de.documento LIKE '"+doc+"'";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");
            return ds;
        }

        public string DarBaja(int documento)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();

                sql = "Update Deportistas set id_estado = 10 where documento= " + documento;
                StringConexion c = new StringConexion();
                cx.ConnectionString = c.getCadena();
                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.Fill(ds, "Deportistas");
                return "Guardado";
            }
            catch (Exception ex) { return "Error"; }
        }

        public DataSet ConsultarDeportistasDeAlta()
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            //sql = "select * from Deportistas";

            // el problema puede ser que el id escuela xq es null en algunos casos
            /*
            sql = @"SELECT de.documento AS Documento,de.apellido AS Apellido,de.nombres AS Nombres,de.sexo AS Sexo, 
            de.fec_nac AS FechaNacimiento,b.nombre AS Barrio,de.tel_fijo AS TeléfonoFijo,de.tel_cel AS Celular,de.email AS Email,
            ua.nombre AS UnidadAcadémica,e.nombre AS Escuela,de.foto AS Foto,de.condicion AS Condición,de.becado AS Becado,
            l.nombre AS Localidad,est.nombre AS Estado,d.nombre AS Deporte
            FROM Deportistas de,Localidades l,Barrios b,UnidadesAcademicas ua,Escuelas e,Deportes d,Estados est 
            WHERE de.id_localidad = l.id_localidad AND de.id_barrio = b.id_barrio AND (de.id_unidad = ua.id_unidad OR de.id_unidad = NULL) AND (de.id_escuela=e.id_escuela OR de.id_escuela = NULL)
            AND de.id_deporte=d.id_deporte AND de.id_estado=est.id_estado AND de.id_estado=9";
           */

            sql = @"SELECT de.documento AS Documento,de.apellido AS Apellido,de.nombres AS Nombres,de.sexo AS Sexo, 
            de.fec_nac AS FechaNacimiento,b.nombre AS Barrio,de.tel_fijo AS TeléfonoFijo,de.tel_cel AS Celular,de.email AS Email,
            de.id_unidad AS UnidadAcadémica,de.id_escuela AS Escuela,de.foto AS Foto,de.id_condicion AS Condición,de.becado AS Becado,
            l.nombre AS Localidad,est.nombre AS Estado,d.nombre AS Deporte
            FROM Deportistas de,Localidades l,Barrios b,Deportes d,Estados est 
            WHERE de.id_localidad = l.id_localidad AND de.id_barrio = b.id_barrio
            AND de.id_deporte=d.id_deporte AND de.id_estado=est.id_estado AND de.id_estado=1";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataSet DarBajaDeportistasPorAñoInscripcion(int año)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            sql = @"UPDATE Deportistas SET Deportistas.id_estado = 10 WHERE documento IN(SELECT documento FROM InscripcionesDisciplina where year(fecha_alta)=" + año + ")";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }
    }
}

