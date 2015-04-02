using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoEvento
    {
        public string Existe(Evento e)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                string nombre = "";

                DataSet ds = new DataSet();

                nombre = e.Nombre;

                sql = "SELECT * FROM Eventos WHERE nombre='" + nombre + "'";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "eventos");


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }





        public string Registrar(Evento e)
        {
            try
            {
                string sql = "";

                int id_evento;
                string nombre;
                string descripcion;
                DateTime fec_alta;
                DateTime fec_inicio;
                DateTime fec_fin;
                int id_deporte;
                int id_perfil;
                byte[] foto;


                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();

                id_evento = e.id_evento;
                fec_alta = e.Fecha_Alta;
                fec_inicio = e.Fecha_inicio;
                fec_fin = e.Fecha_fin;
                descripcion = e.Descripcion;
                nombre = e.Nombre;
                foto = e.foto;
                id_deporte = e.Id_deporte;
                id_perfil = e.Id_perfil;


                sql = "INSERT INTO Eventos (nombre, descripcion,id_deporte, fecha_alta,fecha_inicio,fecha_fin,id_perfil_dirigido,foto) ";
                sql+= "VALUES (@nombre, @descripcion, @id_deporte, @fec_alta,@fec_inicio,@fec_fin,@id_perfil_dirigido, @foto)";
                //  sql2 = "Insert into Usuarios (id_usuario, pass, id_perfil) Values (@id_usuario, @id_usuario, @id_perfil)"; //guardo en id_usuario y pass el docu. todo lo mismo.
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql, cx);

                //SqlParameter pr7 = new SqlParameter("@id_usuario", id_evento);
                SqlParameter pr1 = new SqlParameter("@nombre", nombre);
                SqlParameter pr2 = new SqlParameter("@descripcion", descripcion);
                SqlParameter pr3 = new SqlParameter("@id_deporte", id_deporte);
                SqlParameter pr4 = new SqlParameter("@fec_alta", fec_alta);
                SqlParameter pr5 = new SqlParameter("@fec_inicio", fec_inicio);
                SqlParameter pr6 = new SqlParameter("@fec_fin", fec_fin);
                SqlParameter pr7 = new SqlParameter("@id_perfil_dirigido", id_perfil);
                SqlParameter pr8 = new SqlParameter("@foto", foto);

                cm.Parameters.Add(pr1);
                cm.Parameters.Add(pr2);
                cm.Parameters.Add(pr3);
                cm.Parameters.Add(pr4);
                cm.Parameters.Add(pr5);
                cm.Parameters.Add(pr6);
                cm.Parameters.Add(pr7);
                cm.Parameters.Add(pr8);

                cm.ExecuteNonQuery();

                //cm2.ExecuteNonQuery();

                cx.Close();
                return "Guardado";

            }
            catch (Exception ex)
            {
                return "Error al Guardar";

            }



        }


        public string Modificar(Evento e)
        {
            try
            {
                string sql = "";

                int id_evento;
                string nombre;
                string descripcion;
                DateTime fec_alta;
                DateTime fec_inicio;
                DateTime fec_fin;
                int id_deporte;
                int id_perfil;
                byte[] foto;


                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();

                id_evento = e.id_evento;
                fec_alta = e.Fecha_Alta;
                fec_inicio = e.Fecha_inicio;
                fec_fin = e.Fecha_fin;
                descripcion = e.Descripcion;
                nombre = e.Nombre;
                foto = e.foto;
                id_deporte = e.Id_deporte;
                id_perfil = e.Id_perfil;

                sql = "UPDATE Evento SET nombre = @nombre,descripcion=@descripcion, id_deporte = @id_deporte,fec_alta=@fec_alta,fec_inicio=@fec_inicio,";
                sql += "fec_fin=@fec_fin,foto=@foto,id_perfil_dirigido=@id_perfil_dirigido WHERE id_evento=@id_evento";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql, cx);

                //SqlParameter pr7 = new SqlParameter("@id_usuario", id_evento);
                SqlParameter pr1 = new SqlParameter("@nombre", nombre);
                SqlParameter pr2 = new SqlParameter("@descripcion", descripcion);
                SqlParameter pr3 = new SqlParameter("@id_deporte", id_deporte);
                SqlParameter pr4 = new SqlParameter("@fec_alta", fec_alta);
                SqlParameter pr5 = new SqlParameter("@fec_inicio", fec_inicio);
                SqlParameter pr6 = new SqlParameter("@fec_fin", fec_fin);
                SqlParameter pr7 = new SqlParameter("@id_perfil_dirigido", id_perfil);
                SqlParameter pr8 = new SqlParameter("@foto", foto);


                cm.Parameters.Add(pr1);
                cm.Parameters.Add(pr2);
                cm.Parameters.Add(pr3);
                cm.Parameters.Add(pr4);
                cm.Parameters.Add(pr5);
                cm.Parameters.Add(pr6);
                cm.Parameters.Add(pr7);
                cm.Parameters.Add(pr8);

                cm.ExecuteNonQuery();

                cx.Close();
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
            sql = "SELECT * FROM Eventos";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "eventos");

            return ds;
        }

        //        public DataSet ConsultarJOIN()
        //        {

        //            string sql = "";
        //            SqlConnection cx = new SqlConnection();
        //            DataSet ds = new DataSet();

        //            //el @ es para continuar texto abajo, datediff ver con fecha actual, faltaba un año siempre
        //            sql = @"SELECT     Personal.documento, Personal.fec_nac, DATEDIFF(yy,fec_nac, GETDATE()) AS edad, Personal.apellido, Personal.nombres, Personal.sexo, Personal.calleynum, Personal.tel_fijo, Personal.tel_cel, Personal.email,
        //                  Personal.foto, Localidades.nombre as localidad, Barrios.nombre as barrio
        //                  FROM Personal, Localidades, Barrios
        //                  where Personal.id_localidad = Localidades.id_localidad and Barrios.id_barrio= personal.id_barrio";

        //            StringConexion c = new StringConexion();
        //            cx.ConnectionString = c.getCadena();
        //            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        //            da.Fill(ds, "personal");

        //            return ds;
        //        }


        public DataSet Consultar(int id_deporte)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT * FROM Eventos WHERE id_deporte=" + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "eventos");

            return ds;
        }

        public DataSet ConsultarEvento(int evento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * FROM Eventos WHERE id_evento=" + evento;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "eventos");

            return ds;
        }

        public void Eliminar(int id_evento)
        {

            string sql = "";

            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "DELETE FROM Eventos WHERE id_evento=" + id_evento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "eventos");
        }

    }
}
