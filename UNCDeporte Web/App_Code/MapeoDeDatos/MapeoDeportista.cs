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
        Conexion conexion;
        public MapeoDeportista()
        {
            conexion = new Conexion();
        }
    

    public string Existe(Deportista de)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int documento;
                string email;

                DataSet ds = new DataSet();

                documento = de.Documento;
                email = de.Email;
                sql = "Select * from deportistas where documento='" + documento + "' or email = '" + email +"'";

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
            SqlConnection cx = new SqlConnection();
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();    
            cx.Open();
            SqlTransaction tran = cx.BeginTransaction();
            SqlCommand cm = cx.CreateCommand();
            SqlCommand cm2 = cx.CreateCommand();
            SqlCommand cm22 = cx.CreateCommand();
            SqlCommand cm222 = cx.CreateCommand();
            SqlCommand cm3 = cx.CreateCommand();
            cm.Transaction = tran;
            cm2.Transaction = tran;
            cm22.Transaction = tran;
            cm222.Transaction = tran;
            try
            {
          
                string sql = "";
                string sql2 = "";
                string sql3 = "";
                string sql22 = "";
                string sql222 = "";
                int documento;
                string email;
                string apellido;
                string nombres;
                DateTime fec_nac;
                char sexo;
                long tel_fijo;
                long tel_cel;
                int caract_fijo;
                int caract_cel;
                Boolean becado;
                string direccion;
                int id_localidad;
                int id_barrio;
                documento = de.Documento;
                fec_nac = de.Fec_nac;
                email = de.Email;
                sexo = de.Sexo;
                caract_fijo = de.Caract_fijo;
                tel_fijo = de.Tel_fijo;
                caract_cel = de.Caract_cel;
                tel_cel = de.Tel_cel;
                becado = de.Becado;
                apellido = de.Apellido;
                nombres = de.Nombres;
                direccion = de.Direccion;
                id_localidad = de.Id_localidad;
                id_barrio = de.Id_barrio;
                int id_condicion = de.Id_condicion;
                int id_deporte = de.Id_deporte;
                int id_escuela = de.Id_escuela;
                int id_unidad = de.Id_unidadAcademica;
                DateTime fecha_alta = DateTime.Today.Date.Date;

                //controlar si nombre esta vacio

                sql = "insert into Deportistas (documento, apellido, nombres, sexo, fec_nac, caract_fijo, tel_fijo,caract_cel, tel_cel, email, becado, direccion, id_localidad, id_barrio, id_condicion, id_deporte, id_unidad, id_escuela, id_estado) values (@documento, @apellido, @nombres, @sexo, @fec_nac, @caract_fijo, @tel_fijo,@caract_cel, @tel_cel, @email, @becado, @direccion, @id_localidad, @id_barrio, @id_condicion, @id_deporte, @id_unidad, @id_escuela, 1)";  //id_estado = 1 alta
                sql2 = " insert into inscripcionesDisciplina(documento,fecha_alta) values(@documento, @fecha_alta)";
                sql22 =  "insert into usuariosxperfiles (documento,  pass, id_perfil, estado) values (" + documento + "," + documento + ", 8, 1)"; //8 perfil sin permisos, estado 1 true, usuario no dado de baja todavia.
                //creo un usuario con documento pass y perfil 8 sin permisos
                //sql222 = "insert into usuariosxdeportes (documento,  id_deporte) values (" + documento + "," + id_deporte +")"; 

                cm = new SqlCommand(sql, cx, tran);
                cm2 = new SqlCommand(sql2, cx, tran);
                cm22 = new SqlCommand(sql22, cx, tran);
                //cm222 = new SqlCommand(sql222, cx, tran);

                SqlParameter pr1 = new SqlParameter("@documento", documento);
                SqlParameter pr2 = new SqlParameter("@fec_nac", fec_nac);
                SqlParameter pr3 = new SqlParameter("@apellido", apellido);
                SqlParameter pr4 = new SqlParameter("@nombres", nombres);
                SqlParameter pr5 = new SqlParameter("@email", email);
                SqlParameter pr6 = new SqlParameter("@tel_fijo", tel_fijo);
                SqlParameter pr7 = new SqlParameter("@tel_cel", tel_cel);
                SqlParameter pr8 = new SqlParameter("@sexo", sexo);
                SqlParameter pr9 = new SqlParameter("@becado", becado);
                SqlParameter pr10 = new SqlParameter("@direccion", direccion);
                SqlParameter pr11 = new SqlParameter("@id_localidad", id_localidad);
                SqlParameter pr12 = new SqlParameter("@id_barrio", id_barrio);
                SqlParameter pr13 = new SqlParameter("@id_condicion", id_condicion);
                SqlParameter pr14 = new SqlParameter("@id_deporte", id_deporte);
                SqlParameter pr15 = new SqlParameter("@id_unidad", id_unidad);
                SqlParameter pr16 = new SqlParameter("@id_escuela", id_escuela);
                SqlParameter pr17 = new SqlParameter("@caract_fijo", caract_fijo);
                SqlParameter pr18 = new SqlParameter("@caract_cel", caract_cel);



                SqlParameter pr01 = new SqlParameter("@documento", documento);
                SqlParameter pr02 = new SqlParameter("@fecha_alta", fecha_alta);

                cm.Parameters.Add(pr1);
                cm.Parameters.Add(pr2);
                cm.Parameters.Add(pr3);
                cm.Parameters.Add(pr4);
                cm.Parameters.Add(pr5);
                cm.Parameters.Add(pr6);
                cm.Parameters.Add(pr7);
                cm.Parameters.Add(pr8);
                cm.Parameters.Add(pr9);
                cm.Parameters.Add(pr10);
                cm.Parameters.Add(pr11);
                cm.Parameters.Add(pr12);
                cm.Parameters.Add(pr13);
                cm.Parameters.Add(pr14);
                cm.Parameters.Add(pr15);
                cm.Parameters.Add(pr16);
                cm.Parameters.Add(pr17);
                cm.Parameters.Add(pr18);

                cm2.Parameters.Add(pr01);
                cm2.Parameters.Add(pr02);

                cm.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm22.ExecuteNonQuery();
                //cm222.ExecuteNonQuery();
                


                tran.Commit();
                //cm2.ExecuteNonQuery();

                int id_inscripcion = int.Parse(ConsultarInscripcion(documento).Tables[0].Rows[0][0].ToString());
                int id_programa = int.Parse(ConsultarPrograma(id_deporte).Tables[0].Rows[0][0].ToString());

                sql3 = "insert into Detalles_Insc_Disciplina(id_inscripcion, id_programa, id_deporte, item, id_estado) values (@id_inscripcion,@id_programa,@id_deporte, 1,5)" ; //item 1, estado 5=creado
                cm3 = new SqlCommand(sql3, cx);

                SqlParameter p1 = new SqlParameter("@id_inscripcion", id_inscripcion);
                SqlParameter p2 = new SqlParameter("@id_programa", id_programa);
                SqlParameter p3 = new SqlParameter("@id_deporte", id_deporte);
    

                cm3.Parameters.Add(p1);
                cm3.Parameters.Add(p2);
                cm3.Parameters.Add(p3);

                cm3.ExecuteNonQuery();

                cx.Close();
                return "Guardado";

            }
            catch (Exception ex)
            {
                
                //tran.Rollback();
                //if (cx.State == ConnectionState.Open)
                //{
                //    cx.Close();
                //}
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

        public DataSet ConsultarDeportistasPorDeporte(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"Select d.*
                    from UsuariosXDeportes ud, Deportistas d
                    where ud.documento = d.documento
                    and ud.id_deporte ="+id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportistas");

            return ds;
        }

        public DataSet ConsultarInscripciones(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select i.fecha_alta, d.nombre 
                    from InscripcionesDisciplina i, Detalles_Insc_Disciplina di, Deportes d, Deportistas de
                    where i.documento = de.documento
                    and i.id_inscripcion = di.id_inscripcion
                    and di.id_deporte = d.id_deporte
                    and i.documento = " + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }


        public DataSet ConsultarDeportesProfe(string documento_profe)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select d.* 
                    from ProfesorXDeportes pd,Deportes d
                    where pd.id_deporte = d.id_deporte
                    and pd.documento_profesor=" + documento_profe;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }



        public DataSet ConsultarDeportes(string documento_deportista)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Deportes.id_deporte, Deportes.nombre, UsuariosXDeportes.documento
                    FROM       UsuariosXDeportes INNER JOIN
                    Deportes ON UsuariosXDeportes.id_deporte = Deportes.id_deporte where UsuariosXDeportes.documento=" + documento_deportista;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Deportes");

            return ds;
        }



        public DataSet Consultar(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT     Estados.nombre, Estados.id_estado
                    FROM         Estados INNER JOIN
                      Detalles_Insc_Disciplina ON Estados.id_estado = Detalles_Insc_Disciplina.id_estado INNER JOIN
                      InscripcionesDisciplina ON Detalles_Insc_Disciplina.id_inscripcion = InscripcionesDisciplina.id_inscripcion
                      where InscripcionesDisciplina.documento = " + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Detalles_Insc_Disciplina");
      
            return ds;
        }

        public DataSet ConsultarInscripcion(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "select id_inscripcion from InscripcionesDisciplina where documento = " + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "InscripcionesDisciplina");

            return ds;
        }

        

       



        public DataSet ConsultarPrograma(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select dp.id_programa
                    from DetallesPrograma dp
                    where dp.id_deporte =
                 " + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds);

            return ds;
        }

        public DataSet ConsultarDeportista(int documento, int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"select i.fecha_alta, d.nombre as Deporte, de.* 
                    from InscripcionesDisciplina i, Detalles_Insc_Disciplina di, Deportes d, Deportistas de
                    where i.documento = de.documento
                     and i.id_inscripcion = di.id_inscripcion
                    and di.id_deporte = d.id_deporte
                    and i.documento = " + documento + " and di.id_deporte = " + id_deporte;
                   

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds);

            return ds;
        }


        public Deportista ConsultarDeportista(int documento)
        {
            try
            {
                conexion.origen.Open();
                conexion.ds = new DataSet();
                conexion.str_sql = "select * from Deportistas where documento= " + documento;
                conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(conexion.ds, "Deportistas");
                Deportista dep = new Deportista();

                conexion.drow = conexion.ds.Tables["Deportistas"].Rows[0];//Traigo como resultado la única fila de la tabla. 
                dep.Documento = (int)conexion.drow["documento"];
                dep.Apellido = conexion.drow["apellido"].ToString();
                dep.Nombres = conexion.drow["nombres"].ToString();
                dep.Sexo = Convert.ToChar(conexion.drow["sexo"]);
                dep.Fec_nac = Convert.ToDateTime(conexion.drow["fec_nac"]);
                if (conexion.drow["id_barrio"] != DBNull.Value)
                {
                    Barrio barrio = new Barrio();
                    barrio.Id_barrio = (int)conexion.drow["id_barrio"];
                    dep.Barrio = barrio;
                }
                if (conexion.drow["tel_fijo"] != DBNull.Value)
                    dep.Tel_fijo = (long)conexion.drow["tel_fijo"];
                if (conexion.drow["tel_cel"] != DBNull.Value)
                    dep.Tel_cel = (long)conexion.drow["tel_cel"]; ;
                dep.Email = conexion.drow["email"].ToString();
                if (conexion.drow["id_unidad"] != DBNull.Value)
                {
                    UnidadAcademica unidad = new UnidadAcademica();
                    unidad.Id_unidadAcademica = (int)conexion.drow["id_unidad"];
                    dep.Unidad = unidad;
                }
                if (conexion.drow["id_escuela"] != DBNull.Value)
                {
                    Escuela esc = new Escuela();
                    esc.Id_escuela = (int)conexion.drow["id_escuela"];
                    dep.Escuela = esc;
                }
                //dep.foto = (byte[])conexion.drow["foto"];
                //dep.Condicion = conexion.drow["condicion"].ToString();
                //dep.Becado = Convert.ToBoolean(conexion.drow["becado"]);
                if (conexion.drow["id_localidad"] != DBNull.Value)
                {
                    Localidad loc = new Localidad();
                    loc.Id_localidad = (int)conexion.drow["id_localidad"];
                    dep.Localidad = loc;
                }
                if (conexion.drow["id_deporte"] != DBNull.Value)
                {
                    Deporte depor = new Deporte();
                    depor.Id_deporte = (int)conexion.drow["id_deporte"];
                    dep.Deporte = depor;
                }



                conexion.origen.Close();
                return dep;
            }
            catch (Exception ex)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
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
    }
}
