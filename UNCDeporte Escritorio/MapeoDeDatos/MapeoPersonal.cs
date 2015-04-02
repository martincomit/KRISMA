using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace MapeoDeDatos
{
    public class MapeoPersonal
    {
        public string Existe(Personal p)
        {
            try
            {
                string sql = "";
                SqlConnection cx = new SqlConnection();
                int documento = 0;
        
                DataSet ds = new DataSet();

                documento = p.Documento;

                sql = "Select * from Personal where documento=" + documento;

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.Fill(ds, "Personal");


                string test = ds.Tables[0].Rows[0][0].ToString();
                return "Existe";
            }

            catch (Exception ex)
            {
                return "No existe";
            }

        }





        public string Registrar(Personal p)
        {
            try
            {
                string sql = "";
       
                int documento;
                DateTime fec_nac;
                string apellido;
                string nombres;
                string calleynum;
                int id_barrio;
                int id_usuario;
                byte[] foto;
                int id_localidad;
                string email;
                string tel_fijo;
                string tel_cel;
                char sexo;
       
               
                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();

                documento = p.Documento;
                id_usuario = p.Id_usuario;
                fec_nac = p.Fecha_nac;
                apellido = p.Apellido;
                nombres = p.Nombres;
                calleynum = p.Calleynum;
                id_barrio = p.Id_barrio;
             
                foto = p.foto;
                id_localidad = p.Id_localidad;
                email = p.Email;
                tel_fijo = p.Tel_fijo;
                tel_cel = p.Tel_cel;
                sexo = p.Sexo;
         

                sql = "Insert into Personal (documento, fec_nac, apellido, nombres, calleynum, id_barrio, id_usuario, foto, id_localidad, email, tel_fijo, tel_cel, sexo) Values (@documento, @fec_nac, @apellido, @nombres, @calleynum, @id_barrio, @id_usuario, @foto, @id_localidad, @email, @tel_fijo, @tel_cel, @sexo)";
              //  sql2 = "Insert into Usuarios (id_usuario, pass, id_perfil) Values (@id_usuario, @id_usuario, @id_perfil)"; //guardo en id_usuario y pass el docu. todo lo mismo.
                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql,cx);
                

                SqlParameter pr1 = new SqlParameter("@documento", documento);
                SqlParameter pr2 = new SqlParameter("@fec_nac", fec_nac);
                SqlParameter pr3 = new SqlParameter("@apellido", apellido);
                SqlParameter pr4 = new SqlParameter("@nombres", nombres);
                SqlParameter pr5 = new SqlParameter("@calleynum", calleynum);
                SqlParameter pr6 = new SqlParameter("@id_barrio", id_barrio);
                SqlParameter pr7 = new SqlParameter("@id_usuario", id_usuario);
                SqlParameter pr8= new SqlParameter("@foto", foto);
                SqlParameter pr9 = new SqlParameter("@id_localidad", id_localidad);
                SqlParameter pr10= new SqlParameter("@email", email);
                SqlParameter pr11 = new SqlParameter("@tel_fijo", tel_fijo);
                SqlParameter pr12 = new SqlParameter("@tel_cel", tel_cel);
                SqlParameter pr13 = new SqlParameter("@sexo", sexo);
             


                //SqlParameter pr15 = new SqlParameter("@id_usuario", id_usuario);
                //SqlParameter pr16 = new SqlParameter("@id_perfil", id_perfil);
                //cm2.Parameters.Add(pr15);
                //cm2.Parameters.Add(pr16);

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


        public string Modificar(Personal p)
        {
            try
            {
                string sql = "";
                int documento;
                DateTime fec_nac;
                string apellido;
                string nombres;
                string calleynum;
                int id_barrio;
                int id_usuario;
                byte[] foto;
                int id_localidad;
                string email;
                string tel_fijo;
                string tel_cel;
                char sexo;
 

                SqlConnection cx = new SqlConnection();
                DataSet ds = new DataSet();

                documento = p.Documento;
                fec_nac = p.Fecha_nac;
                apellido = p.Apellido;
                nombres = p.Nombres;
                calleynum = p.Calleynum;
                id_barrio = p.Id_barrio;
                id_usuario = p.Id_usuario;
                foto = p.foto;
                id_localidad = p.Id_localidad;
                email = p.Email;
                tel_fijo = p.Tel_fijo;
                tel_cel = p.Tel_cel;
                sexo = p.Sexo;
              
                sql = "Update Personal set fec_nac = @fec_nac, apellido=@apellido, nombres = @nombres, calleynum =@calleynum , id_barrio = @id_barrio, id_usuario = @id_usuario,foto = @foto ,id_localidad=@id_localidad , email = @email, tel_fijo =@tel_fijo, tel_cel =@tel_cel, sexo = @sexo where documento=@documento ";

                StringConexion c = new StringConexion();

                cx.ConnectionString = c.getCadena();
                cx.Open();
                SqlCommand cm = new SqlCommand(sql, cx);
                SqlParameter pr1 = new SqlParameter("@documento", documento);
                SqlParameter pr2 = new SqlParameter("@fec_nac", fec_nac);
                SqlParameter pr3 = new SqlParameter("@apellido", apellido);
                SqlParameter pr4 = new SqlParameter("@nombres", nombres);
                SqlParameter pr5 = new SqlParameter("@calleynum", calleynum);
                SqlParameter pr6 = new SqlParameter("@id_barrio", id_barrio);
                SqlParameter pr7 = new SqlParameter("@id_usuario", id_usuario);
                SqlParameter pr8 = new SqlParameter("@foto", foto);
                SqlParameter pr9 = new SqlParameter("@id_localidad", id_localidad);
                SqlParameter pr10 = new SqlParameter("@email", email);
                SqlParameter pr11 = new SqlParameter("@tel_fijo", tel_fijo);
                SqlParameter pr12 = new SqlParameter("@tel_cel", tel_cel);
                SqlParameter pr13 = new SqlParameter("@sexo", sexo);
              
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
            sql = "SELECT * from personal";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "personal");

            return ds;
        }

        public DataSet ConsultarProfes(int id_perfil)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT up.documento, up.pass, up.estado 
                    from UsuariosXPerfiles up
                    where up.id_perfil=6
                    and up.estado =1";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "UsuariosXPerfiles");

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


        public DataSet Consultar(int id_localidad)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = @"SELECT * from personal where id_localidad=" + id_localidad;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "personal");

            return ds;
        }

        public DataSet ConsultarDNI(int documento)
        {

            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Select * from personal where documento=" + documento;
            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "personal");

            return ds;
        }

        public void Eliminar(int documento)
        {

            string sql = "";
            string sql2 = "";

            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "Delete from personal where documento=" + documento;
            sql2 = "Delete from usuarios where id_usuario=" + documento;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cx);
            da.Fill(ds, "personal");
            da2.Fill(ds, "usuarios");
        }
    }
}
