using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace MapeoDeDatos
{
    public class MapeoPrograma
    {
        Conexion conexion;

        public MapeoPrograma()
        {
            conexion = new Conexion();                        
        }

        public DataSet ConsultarHorariosPrograma(int id_deporte)
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();

            sql = @"select d.dia, h.hora, h.minuto, s.nombre, l.nombre as lugarpractica, l.direccion
            from DetallesDiagramacion dd, Horarios h, Dias d, Sectores s, LugaresPractica l
            where
            (dd.id_hora_desde = h.id_horario or dd.id_hora_hasta = h.id_horario)
            and dd.dia_semana = d.id_dia
            and dd.id_sector = s.id_sector
            and l.id_lugar = s.id_lugar
            and dd.id_deporte = " + id_deporte;

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "DetallesDiagramacion");
            return ds;
       
        }

        

        public List<Programa> Cargar_Lista_Programas()
        {            
            try
            {
                conexion.origen.Open();
                List<Programa> lp = new List<Programa>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Programas", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;                
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {                    
                    while (conexion.dr1.Read())
                    {
                        Programa p = new Programa();
                        p.Id_programa = Convert.ToInt32(conexion.dr1["id_programa"]);
                        p.Fecha_alta = Convert.ToDateTime(conexion.dr1["fecha_alta"]);
                        p.Anio = Convert.ToInt32(conexion.dr1["anio"]);
                        p.Descripcion = conexion.dr1["descripcion"].ToString();
                        p.Fecha_inicio = Convert.ToDateTime(conexion.dr1["fecha_inicio"]);
                        p.Fecha_fin = Convert.ToDateTime(conexion.dr1["fecha_fin"]);

                        //Estado e = new Estado();
                        //p.estado = Convert.ToInt32(conexion.dr["estado"]);
                        //Hay que cambiar el select para traer los estados

                        lp.Add(p);
                    }
                }
                conexion.origen.Close();
               
                return lp;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
        }

        public List<Deporte> Cargar_Lista_Deportes()
        {
            try
            {
                conexion.origen.Open();                
                List<Deporte> ld = new List<Deporte>();
                                
                conexion.cmd = new SqlCommand("Cargar_Lista_Deportes", conexion.origen);                
                conexion.cmd.CommandType = CommandType.StoredProcedure;                                             
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        Deporte d = new Deporte();
                        
                        if (conexion.dr1["id_deporte"] != DBNull.Value)
                        {
                            d.Id_deporte = Convert.ToInt32(conexion.dr1["id_deporte"]);                        
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            d.Nombre = conexion.dr1["nombre"].ToString();
                        }                        
                        if (conexion.dr1["descripcion"] != DBNull.Value)
                        {
                            d.Descripcion = conexion.dr1["descripcion"].ToString();
                        }
                        if (conexion.dr1["cod_sanaviron"] != DBNull.Value)
                        {
                            d.Cod_sanaviron = Convert.ToInt32(conexion.dr1["cod_sanaviron"]);
                        }
                        

                        ld.Add(d);
                    }
                }
                conexion.origen.Close();
                return ld;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;                                         
            }
            
        }

        public List<Horario> Cargar_Lista_Horarios()
        {
            try
            {
                conexion.origen.Open();
                List<Horario> lh = new List<Horario>();

                conexion.cmd = new SqlCommand("Cargar_Lista_Horarios", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        Horario h = new Horario();

                        if (conexion.dr1["id_horario"] != DBNull.Value)
                        {
                            h.Id_horario = Convert.ToInt32(conexion.dr1["id_horario"]);
                        }
                        if (conexion.dr1["hora"] != DBNull.Value)
                        {
                            h.Hora = conexion.dr1["hora"].ToString();
                        }
                        if (conexion.dr1["minuto"] != DBNull.Value)
                        {
                            h.Minuto = conexion.dr1["minuto"].ToString();
                        }
                        
                        lh.Add(h);
                    }
                }
                conexion.origen.Close();
                return lh;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
        }
                  
        public List<LugarPractica> Cargar_Lista_Lugares()
        {
            try
            {
                conexion.origen.Open();
                List<LugarPractica> llp = new List<LugarPractica>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Lugares", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        LugarPractica lp = new LugarPractica();
                        if (conexion.dr1["id_lugar"] != DBNull.Value)
                        {
                            lp.Id_lugar = Convert.ToInt32(conexion.dr1["id_lugar"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            lp.Nombre = conexion.dr1["nombre"].ToString();
                        }
                        if (conexion.dr1["descripcion"] != DBNull.Value)
                        {
                            lp.Descripcion = conexion.dr1["descripcion"].ToString();
                        }
                        if (conexion.dr1["direccion"] != DBNull.Value)
                        {
                            lp.Direccion = conexion.dr1["direccion"].ToString();
                        }
                        if (conexion.dr1["id_barrio"] != DBNull.Value)
                        {
                            Barrio b = new Barrio();
                            b.Id_barrio = Convert.ToInt32(conexion.dr1["id_barrio"]);
                            lp.Barrio = b;
                        }

                        llp.Add(lp);
                    }
                }
                conexion.origen.Close();

                return llp;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }    
        }

        public List<TipoSector> Cargar_Lista_Tipo_Sectores()
        {
            try
            {
                conexion.origen.Open();
                List<TipoSector> lts = new List<TipoSector>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Tipo_Sectores", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        TipoSector ts = new TipoSector();
                        if (conexion.dr1["id_tipo_sector"] != DBNull.Value)
                        {
                            ts.Id_tipo_sector = Convert.ToInt32(conexion.dr1["id_tipo_sector"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            ts.Nombre = conexion.dr1["nombre"].ToString();
                        }
                        if (conexion.dr1["descripcion"] != DBNull.Value)
                        {
                            ts.Descripcion = conexion.dr1["descripcion"].ToString();
                        }
                        
                        lts.Add(ts);
                    }
                }
                conexion.origen.Close();

                return lts;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
        }

        public List<Sector> Cargar_Lista_Sectores()
        {
            try
            {
                conexion.origen.Open();
                List<Sector> ls = new List<Sector>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Sectores", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        Sector s = new Sector();
                        if (conexion.dr1["id_sector"] != DBNull.Value)
                        {
                            s.Id_sector = Convert.ToInt32(conexion.dr1["id_sector"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            s.Nombre = conexion.dr1["nombre"].ToString();
                        }
                        if (conexion.dr1["descripcion"] != DBNull.Value)
                        {
                            s.Descripcion = conexion.dr1["descripcion"].ToString();
                        }
                        if (conexion.dr1["id_tipo_sector"] != DBNull.Value)
                        {
                            TipoSector ts = new TipoSector();
                            ts.Id_tipo_sector = Convert.ToInt32(conexion.dr1["id_tipo_sector"]);
                            s.Tipo_sector = ts;
                        }
                        if (conexion.dr1["id_lugar"] != DBNull.Value)
                        {
                            LugarPractica lp = new LugarPractica();
                            lp.Id_lugar = Convert.ToInt32(conexion.dr1["id_lugar"]);
                            s.Lugar = lp;
                        }

                        ls.Add(s);
                    }
                }
                conexion.origen.Close();

                return ls;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
        }

        public List<Personal> Cargar_Lista_Profesores()
        {
            try
            {
                conexion.origen.Open();
                List<Personal> lp = new List<Personal>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Profesores", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        Personal p = new Personal();
                        //Usuario u = new Usuario();
                        //Perfil pe = new Perfil();                        
                        p.Documento = Convert.ToInt32(conexion.dr1["documento"]);
                        p.Apellido = conexion.dr1["apellido"].ToString();
                        p.Nombres = conexion.dr1["nombre"].ToString();
                        //u.Id_usuario = Convert.ToInt32(conexion.dr1["id_usuario"]);
                        //p.usuario = u;
                                                
                        lp.Add(p);
                    }
                }
                conexion.origen.Close();

                return lp;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
        }

        public void Registrar_Programa(Programa programa)
        {            
            conexion.origen.Open();

            SqlTransaction transaccion;
            transaccion = conexion.origen.BeginTransaction();
            
          
            //conexion.cmd.Connection = conexion.origen;
            //conexion.cmd.Transaction = transaccion;
            try
            {
                //Programa
                conexion.cmd = new SqlCommand("Registrar_Programa", conexion.origen, transaccion);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.cmd.Parameters.Add("@id_programa", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.cmd.Parameters.Add(new SqlParameter("@anio", programa.Anio));
                conexion.cmd.Parameters.Add(new SqlParameter("@fecha_alta", programa.Fecha_alta));
                conexion.cmd.Parameters.Add(new SqlParameter("@descripcion", programa.Descripcion));
                conexion.cmd.Parameters.Add(new SqlParameter("@fecha_inicio", programa.Fecha_inicio));
                conexion.cmd.Parameters.Add(new SqlParameter("@fecha_fin", programa.Fecha_fin));
                //conexion.cmd.Parameters.Add(new SqlParameter("@id_estado", programa.estado.id_estado));
                conexion.cmd.ExecuteNonQuery();
                int id_programa = Convert.ToInt32(conexion.cmd.Parameters["@id_programa"].Value);                
                

                //Detalle del Programa
                for (int i = 0; i < programa.Detalle.Count; i++)
                {
                    
                    //Diagramacion
                    conexion.cmd = new SqlCommand("Registrar_Diagramacion", conexion.origen, transaccion);
                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                    conexion.cmd.Parameters.Add("@id_diagramacion", SqlDbType.Int).Direction = ParameterDirection.Output;
                    conexion.cmd.Parameters.Add(new SqlParameter("@descripcion", "PROGRAMA "+programa.Anio.ToString()+", DEPORTE "+programa.Detalle[i].Deporte.Nombre));                
                    conexion.cmd.ExecuteNonQuery();
                    int id_diagramacion = Convert.ToInt32(conexion.cmd.Parameters["@id_diagramacion"].Value);


                    //Detalle Diagramacion
                    for (int j = 0; j < programa.Detalle[i].Diagramacion.Detalle.Count; j++)
                    {                        
                        conexion.cmd = new SqlCommand("Registrar_Detalle_Diagramacion", conexion.origen, transaccion);
                        conexion.cmd.CommandType = CommandType.StoredProcedure;
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_diagramacion", id_diagramacion));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", programa.Detalle[i].Deporte.Id_deporte));
                        conexion.cmd.Parameters.Add(new SqlParameter("@item", programa.Detalle[i].Diagramacion.Detalle[j].Item));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", programa.Detalle[i].Diagramacion.Detalle[j].Sector.Id_sector));
                        conexion.cmd.Parameters.Add(new SqlParameter("@dia_semana", programa.Detalle[i].Diagramacion.Detalle[j].Dia_semana));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_desde", programa.Detalle[i].Diagramacion.Detalle[j].Hora_desde.Id_horario));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_hasta", programa.Detalle[i].Diagramacion.Detalle[j].Hora_hasta.Id_horario));
                        conexion.cmd.Parameters.Add(new SqlParameter("@documento", programa.Detalle[i].Diagramacion.Detalle[j].Profesor.Documento));
                        conexion.cmd.ExecuteNonQuery();
                    }

                    //Detalle Programa
                    
                    conexion.cmd = new SqlCommand("Registrar_Detalle_Programa", conexion.origen, transaccion);
                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_programa", id_programa));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", programa.Detalle[i].Deporte.Id_deporte));
                    conexion.cmd.Parameters.Add(new SqlParameter("@item", programa.Detalle[i].Item));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_diagramacion", id_diagramacion));
                    conexion.cmd.Parameters.Add(new SqlParameter("@cupo", programa.Detalle[i].Cupo));
                    conexion.cmd.ExecuteNonQuery();
                    
                }
                conexion.cmd.Transaction.Commit();
                //transaccion.Commit();

                conexion.origen.Close();
            }
            catch
            {
                conexion.cmd.Transaction.Rollback();
                //transaccion.Rollback();

                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
            }
                        
        }

    }
}
