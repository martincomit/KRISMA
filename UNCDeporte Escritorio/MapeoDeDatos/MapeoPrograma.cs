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

        public Programa Cargar_Programa(int id_programa)
        {
            try
            {
                conexion.origen.Open();
                Programa p = new Programa();
                Estado e = new Estado();
                conexion.cmd = new SqlCommand("Cargar_Programa", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.cmd.Parameters.Add(new SqlParameter("@id_programa", id_programa));
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    conexion.dr1.Read();
                    p.Id_programa = Convert.ToInt32(conexion.dr1["id_programa"]);
                    p.Fecha_alta = Convert.ToDateTime(conexion.dr1["fecha_alta"]);
                    p.Anio = Convert.ToInt32(conexion.dr1["anio"]);
                    p.Descripcion = conexion.dr1["descripcion"].ToString();
                    p.Fecha_inicio = Convert.ToDateTime(conexion.dr1["fecha_inicio"]);
                    p.Fecha_fin = Convert.ToDateTime(conexion.dr1["fecha_fin"]);                    
                    e.Id_estado = Convert.ToInt32(conexion.dr1["id_estado"]);
                    e.Nombre = conexion.dr1["nombre"].ToString();
                    e.Descripcion = conexion.dr1["descripcion"].ToString();
                    e.Ambito = conexion.dr1["ambito"].ToString();        
                    p.Estado = e;
                }                

                conexion.cmd = new SqlCommand("Cargar_Detalle_Programa", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.cmd.Parameters.Add(new SqlParameter("@id_programa", id_programa));
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {                                                            
                    p.Nuevo_Detalle();
                    
                    while (conexion.dr1.Read())
                    {
                        DetallePrograma dp = new DetallePrograma();
                        Deporte dep = new Deporte();
                        Estado es = new Estado();
                        Diagramacion di = new Diagramacion();
                        //di.Nuevo_Detalle();

                        dp.Programa = p;
                        dep.Id_deporte = Convert.ToInt32(conexion.dr1["id_deporte"]);
                        dep.Nombre = conexion.dr1["nombre_deporte"].ToString();
                        dep.Descripcion = conexion.dr1["descripcion_deporte"].ToString();
                        dp.Deporte = dep;
                        dp.Item = Convert.ToInt32(conexion.dr1["item"]);
                        di.Id_diagramacion = Convert.ToInt32(conexion.dr1["id_diagramacion"]);
                        di.Deporte = dep;

                        conexion.cmd = new SqlCommand("Cargar_Detalle_Diagramacion", conexion.origen);
                        conexion.cmd.CommandType = CommandType.StoredProcedure;
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_diagramacion", di.Id_diagramacion));
                        conexion.dr2 = conexion.cmd.ExecuteReader();

                        if (conexion.dr2.HasRows)
                        {
                            di.Nuevo_Detalle();
                            //DetalleDiagramacion dd = new DetalleDiagramacion();

                            while (conexion.dr2.Read())
                            {
                                DetalleDiagramacion dd = new DetalleDiagramacion();
                                dd.Diagramacion = di;
                                
                                dd.Item = Convert.ToInt32(conexion.dr2["item"]);
                                Dia d = new Dia(1,conexion.dr2["dia_semana"].ToString(), conexion.dr2["dia_semana"].ToString().Substring(0,3),DateTime.Now);                                
                                dd.Dia_semana = d;                               
                                dd.Lugar_confirmado = Convert.ToBoolean(conexion.dr2["lugar_confirmado"]);
                                dd.Horario_confirmado = Convert.ToBoolean(conexion.dr2["horario_confirmado"]);
                                dd.Profesor_confirmado = Convert.ToBoolean(conexion.dr2["profesor_confirmado"]);

                                if (conexion.dr2["id_sector"] != DBNull.Value)
                                {
                                    Sector s = new Sector();
                                    TipoSector ts = new TipoSector();
                                    LugarPractica lp = new LugarPractica();

                                    conexion.cmd = new SqlCommand("Cargar_Sector", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", Convert.ToInt32(conexion.dr2["id_sector"])));
                                    conexion.dr3 = conexion.cmd.ExecuteReader();

                                    if (conexion.dr3.HasRows)
                                    {
                                        conexion.dr3.Read();
                                        s.Id_sector = Convert.ToInt32(conexion.dr2["id_sector"]);
                                        s.Nombre = conexion.dr3["nombre_sector"].ToString();
                                        s.Descipcion = conexion.dr3["descripcion_sector"].ToString();
                                        ts.Id_tipo_sector = Convert.ToInt32(conexion.dr3["id_tipo_sector"]);
                                        ts.Nombre = conexion.dr3["nombre_tipo"].ToString();
                                        ts.Descripcion = conexion.dr3["descripcion_tipo"].ToString();
                                        lp.Id_lugar = Convert.ToInt32(conexion.dr3["id_lugar"]);
                                        lp.Nombre = conexion.dr3["nombre_lugar"].ToString();
                                        lp.Descripcion = conexion.dr3["descripcion_lugar"].ToString();
                                        s.Tipo_sector = ts;
                                        s.Lugar = lp;

                                        dd.Sector = s;
                                    }
                                }
                                else
                                {
                                    dd.Sector = null;
                                }

                                if (conexion.dr2["id_hora_desde"] != DBNull.Value)
                                {
                                    Horario hd = new Horario();
                                    Horario hh = new Horario();

                                    conexion.cmd = new SqlCommand("Cargar_Horario", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@id_horario", Convert.ToInt32(conexion.dr2["id_hora_desde"])));
                                    conexion.dr3 = conexion.cmd.ExecuteReader();

                                    if (conexion.dr3.HasRows)
                                    {
                                        conexion.dr3.Read();
                                        hd.Id_horario = Convert.ToInt32(conexion.dr2["id_hora_desde"]);
                                        hd.Hora = conexion.dr3["hora"].ToString();
                                        hd.Minuto = conexion.dr3["minuto"].ToString();
                                        dd.Hora_desde = hd;
                                    }

                                    conexion.cmd = new SqlCommand("Cargar_Horario", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@id_horario", Convert.ToInt32(conexion.dr2["id_hora_hasta"])));
                                    conexion.dr3 = conexion.cmd.ExecuteReader();

                                    if (conexion.dr3.HasRows)
                                    {
                                        conexion.dr3.Read();
                                        hh.Id_horario = Convert.ToInt32(conexion.dr2["id_hora_hasta"]);
                                        hh.Hora = conexion.dr3["hora"].ToString();
                                        hh.Minuto = conexion.dr3["minuto"].ToString();
                                        dd.Hora_hasta = hh;
                                    }                                                                        
                                }
                                else
                                {
                                    dd.Hora_desde = null;
                                    dd.Hora_hasta = null;                                    
                                }
                                
                                if(conexion.dr2["documento"] != DBNull.Value)
                                {
                                    Personal prof = new Personal();
                                    conexion.cmd = new SqlCommand("Cargar_Profesor", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@documento", Convert.ToInt32(conexion.dr2["documento"])));
                                    conexion.dr3 = conexion.cmd.ExecuteReader();

                                    if (conexion.dr3.HasRows)
                                    {
                                        conexion.dr3.Read();
                                        prof.Documento = Convert.ToInt32(conexion.dr2["documento"]);
                                        prof.Apellido = conexion.dr3["apellido"].ToString();
                                        prof.Nombres = conexion.dr3["nombre"].ToString();
                                        prof.Fecha_nac = Convert.ToDateTime(conexion.dr3["fecha_nac"]);
                                        prof.Direccion = conexion.dr3["direccion"].ToString();
                                        prof.Tel_celular = conexion.dr3["tel_celular"].ToString();
                                        prof.Tel_fijo = conexion.dr3["tel_fijo"].ToString();
                                        prof.Email = conexion.dr3["email"].ToString();

                                        dd.Profesor = prof;
                                    }
                                }
                                else
                                {
                                    dd.Profesor = null;
                                }

                                di.Detalle.Add(dd);
                                
                              
                            }                                                
                        }
                        es.Id_estado = Convert.ToInt32(conexion.dr1["id_estado"]);
                        es.Nombre = conexion.dr1["nombre_estado"].ToString();
                        es.Descripcion = conexion.dr1["descripcion_estado"].ToString();
                        es.Ambito = conexion.dr1["ambito"].ToString();
                        dp.Estado = es;
                        dp.Diagramacion = di;


                        //---------------------- Reserva -----------------------------
                        /*
                        if (conexion.dr1["id_reserva"] != DBNull.Value)
                        {
                            Reserva r = new Reserva();
                            r.Id_reserva = Convert.ToInt32(conexion.dr1["id_reserva"]);

                            conexion.cmd = new SqlCommand("Cargar_Reserva", conexion.origen);
                            conexion.cmd.CommandType = CommandType.StoredProcedure;
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", r.Id_reserva));
                            conexion.dr3 = conexion.cmd.ExecuteReader();
                            conexion.dr3.Read();
                            r.Fecha_realizacion = Convert.ToDateTime(conexion.dr3["fecha_realizacion"]);
                            r.Descripcion = conexion.dr3["descripcion_reserva"].ToString();
                            TipoReserva tr = new TipoReserva();
                            tr.Id_tipo_reserva = Convert.ToInt32(conexion.dr3["id_tipo_reserva"]);
                            tr.Nombre = conexion.dr3["nombre"].ToString();
                            tr.Descripcion = conexion.dr3["descripcion_tipo"].ToString();
                            r.Tipo_reserva = tr;

                            conexion.cmd = new SqlCommand("Cargar_Detalle_Reserva", conexion.origen);
                            conexion.cmd.CommandType = CommandType.StoredProcedure;
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", r.Id_reserva));
                            conexion.dr4 = conexion.cmd.ExecuteReader();

                            
                            if (conexion.dr4.HasRows)
                            {
                                List<DetalleReserva> ldr = new List<DetalleReserva>();

                                while (conexion.dr4.Read())
                                {
                                    DetalleReserva detr = new DetalleReserva();
                                    detr.Reserva = r;
                                    detr.Item = Convert.ToInt32(conexion.dr4["item"]);
                                    
                                    Deporte d = new Deporte();
                                    d.Id_deporte = Convert.ToInt32(conexion.dr4["id_deporte"]);
                                    d.Nombre = conexion.dr4["nombre_deporte"].ToString();
                                    d.Descripcion = conexion.dr4["descripcion_deporte"].ToString();
                                    if (conexion.dr4["cod_sanaviron"] != DBNull.Value)
                                        d.Cod_sanaviron = Convert.ToInt32(conexion.dr4["cod_sanaviron"]);
                                    detr.Deporte = d;

                                    Persona per = new Persona();
                                    if (conexion.dr4["documento"] != DBNull.Value)
                                        per.Documento = Convert.ToInt32(conexion.dr4["documento"]);
                                    if (conexion.dr4["apellido"] != DBNull.Value)
                                        per.Apellido = conexion.dr4["apellido"].ToString();
                                    if (conexion.dr4["nombres"] != DBNull.Value)
                                        per.Nombres = conexion.dr4["nombres"].ToString();
                                    if (conexion.dr4["tel_fijo"] != DBNull.Value)
                                        per.Tel_fijo = conexion.dr4["tel_fijo"].ToString();
                                    if (conexion.dr4["tel_celular"] != DBNull.Value)
                                        per.Tel_celular = conexion.dr4["tel_celular"].ToString();
                                    if (conexion.dr4["email"] != DBNull.Value)
                                        per.Email = conexion.dr4["email"].ToString();
                                    
                                    detr.Persona = per;

                                    Sector s = new Sector();
                                    TipoSector ts = new TipoSector();
                                    LugarPractica lp = new LugarPractica();
                                    s.Id_sector = Convert.ToInt32(conexion.dr4["id_sector"]);
                                    
                                    conexion.cmd = new SqlCommand("Cargar_Sector", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", s.Id_sector));
                                    conexion.dr5 = conexion.cmd.ExecuteReader();
                                    conexion.dr5.Read();
                                    s.Nombre = conexion.dr5["nombre_sector"].ToString();
                                    s.Descripcion = conexion.dr5["descripcion_sector"].ToString();                                    
                                    ts.Id_tipo_sector = Convert.ToInt32(conexion.dr5["id_tipo_sector"]);
                                    ts.Nombre = conexion.dr5["nombre_tipo"].ToString();
                                    ts.Descripcion = conexion.dr5["descripcion_tipo"].ToString();
                                    s.Tipo_sector = ts;
                                    lp.Id_lugar = Convert.ToInt32(conexion.dr5["id_lugar"]);
                                    lp.Nombre = conexion.dr5["nombre_lugar"].ToString();
                                    lp.Descripcion = conexion.dr5["descripcion_lugar"].ToString();
                                    s.Lugar = lp;
                                    detr.Sector = s;
                                    detr.Fecha_reserva = Convert.ToDateTime(conexion.dr4["fecha_reserva"]);
                                    //-------------------
                                    Horario hd = new Horario();
                                    hd.Id_horario = Convert.ToInt32(conexion.dr4["id_hora_desde"]);
                                    Horario hh = new Horario();
                                    hh.Id_horario = Convert.ToInt32(conexion.dr4["id_hora_hasta"]);

                                    conexion.cmd = new SqlCommand("Cargar_Horario", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@id_horario", hd.Id_horario));
                                    conexion.dr5 = conexion.cmd.ExecuteReader();                                    
                                    conexion.dr5.Read();
                                    hd.Hora = conexion.dr5["hora"].ToString();
                                    hd.Minuto = conexion.dr5["minuto"].ToString();
                                    detr.Hora_desde = hd;
                                    
                                    conexion.cmd = new SqlCommand("Cargar_Horario", conexion.origen);
                                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                                    conexion.cmd.Parameters.Add(new SqlParameter("@id_horario", hh.Id_horario));
                                    conexion.dr5 = conexion.cmd.ExecuteReader();
                                    conexion.dr5.Read();                                    
                                    hh.Hora = conexion.dr5["hora"].ToString();
                                    hh.Minuto = conexion.dr5["minuto"].ToString();
                                    detr.Hora_hasta = hh;
                                    
                                    //------------------
                                    Estado est = new Estado();
                                    est.Id_estado = Convert.ToInt32(conexion.dr4["id_estado"]);
                                    est.Nombre = conexion.dr4["nombre_estado"].ToString();
                                    est.Descripcion = conexion.dr4["descripcion_estado"].ToString();
                                    est.Ambito = conexion.dr4["ambito"].ToString();
                                    detr.Estado = est;
                                    ldr.Add(detr);
                                }

                                r.Detalle = ldr;
                            }
                            
                            dp.Reserva = r;

                        }
                        */
                        //---------------------------------------------------

                        p.Detalle.Add(dp);                                        
                    }
                    
                }

                conexion.origen.Close();
                return p;
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
                            s.Descipcion= conexion.dr1["descripcion"].ToString();
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

        public List<Estado> Cargar_Lista_Estados(string ambito)
        {
            try
            {
                conexion.origen.Open();
                List<Estado> le = new List<Estado>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Estados", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.cmd.Parameters.Add(new SqlParameter("@ambito", ambito));
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        Estado e = new Estado();
                        if (conexion.dr1["id_estado"] != DBNull.Value)
                        {
                            e.Id_estado = Convert.ToInt32(conexion.dr1["id_estado"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            e.Nombre = conexion.dr1["nombre"].ToString();
                        }
                        if (conexion.dr1["descripcion"] != DBNull.Value)
                        {
                            e.Descripcion = conexion.dr1["descripcion"].ToString();
                        }
                        if (conexion.dr1["ambito"] != DBNull.Value)
                        {
                            e.Ambito = conexion.dr1["ambito"].ToString();
                        }
                        
                        le.Add(e);
                    }
                }
                conexion.origen.Close();

                return le;
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

        public bool Registrar_Programa(Programa programa)
        {            
            conexion.origen.Open();

            SqlTransaction transaccion;
            transaccion = conexion.origen.BeginTransaction();
 
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
                conexion.cmd.Parameters.Add(new SqlParameter("@id_estado", programa.Estado.Id_estado));
                conexion.cmd.ExecuteNonQuery();
                int id_programa = Convert.ToInt32(conexion.cmd.Parameters["@id_programa"].Value);

                if (programa.Estado.Nombre != "iniciada")
                {
                    //Detalle del Programa
                    for (int i = 0; i < programa.Detalle.Count; i++)
                    {

                        //Diagramacion
                        conexion.cmd = new SqlCommand("Registrar_Diagramacion", conexion.origen, transaccion);
                        conexion.cmd.CommandType = CommandType.StoredProcedure;
                        conexion.cmd.Parameters.Add("@id_diagramacion", SqlDbType.Int).Direction = ParameterDirection.Output;
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", programa.Detalle[i].Deporte.Id_deporte));
                        conexion.cmd.ExecuteNonQuery();
                        int id_diagramacion = Convert.ToInt32(conexion.cmd.Parameters["@id_diagramacion"].Value);


                        //Detalle Diagramacion
                        for (int j = 0; j < programa.Detalle[i].Diagramacion.Detalle.Count; j++)
                        {
                            conexion.cmd = new SqlCommand("Registrar_Detalle_Diagramacion", conexion.origen, transaccion);
                            conexion.cmd.CommandType = CommandType.StoredProcedure;
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_diagramacion", id_diagramacion));                            
                            conexion.cmd.Parameters.Add(new SqlParameter("@item", programa.Detalle[i].Diagramacion.Detalle[j].Item));
                            if (programa.Detalle[i].Diagramacion.Detalle[j].Sector != null)
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", programa.Detalle[i].Diagramacion.Detalle[j].Sector.Id_sector));
                            else
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", DBNull.Value));
                            conexion.cmd.Parameters.Add(new SqlParameter("@dia_semana", programa.Detalle[i].Diagramacion.Detalle[j].Dia_semana.Nombre));

                            if (programa.Detalle[i].Diagramacion.Detalle[j].Hora_desde != null)
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_desde", programa.Detalle[i].Diagramacion.Detalle[j].Hora_desde.Id_horario));
                            else
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_desde", DBNull.Value));

                            if (programa.Detalle[i].Diagramacion.Detalle[j].Hora_hasta != null)
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_hasta", programa.Detalle[i].Diagramacion.Detalle[j].Hora_hasta.Id_horario));
                            else
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_hasta", DBNull.Value));

                            if (programa.Detalle[i].Diagramacion.Detalle[j].Profesor != null)
                                conexion.cmd.Parameters.Add(new SqlParameter("@documento", programa.Detalle[i].Diagramacion.Detalle[j].Profesor.Documento));
                            else
                                conexion.cmd.Parameters.Add(new SqlParameter("@documento", DBNull.Value));

                            conexion.cmd.Parameters.Add(new SqlParameter("@lugar_confirmado", Convert.ToInt32(programa.Detalle[i].Diagramacion.Detalle[j].Lugar_confirmado)));
                            conexion.cmd.Parameters.Add(new SqlParameter("@horario_confirmado", Convert.ToInt32(programa.Detalle[i].Diagramacion.Detalle[j].Horario_confirmado)));
                            conexion.cmd.Parameters.Add(new SqlParameter("@profesor_confirmado", Convert.ToInt32(programa.Detalle[i].Diagramacion.Detalle[j].Profesor_confirmado)));
                            conexion.cmd.ExecuteNonQuery();
                        }

                        //Detalle Programa

                        conexion.cmd = new SqlCommand("Registrar_Detalle_Programa", conexion.origen, transaccion);
                        conexion.cmd.CommandType = CommandType.StoredProcedure;
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_programa", id_programa));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", programa.Detalle[i].Deporte.Id_deporte));
                        conexion.cmd.Parameters.Add(new SqlParameter("@item", programa.Detalle[i].Item));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_diagramacion", id_diagramacion));
                        if (programa.Detalle[i].Reserva != null)
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", programa.Detalle[i].Reserva.Id_reserva));
                        else
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", DBNull.Value));

                        conexion.cmd.Parameters.Add(new SqlParameter("@id_estado", programa.Detalle[i].Estado.Id_estado));
                        conexion.cmd.ExecuteNonQuery();

                    }
                }
                conexion.cmd.Transaction.Commit();                
                conexion.origen.Close();
                return true;
            }
            catch
            {
                conexion.cmd.Transaction.Rollback();
                //transaccion.Rollback();

                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return false;
            }
                        
        }


        public DataSet Consultar_Programas()
        {
            string sql = "";
            SqlConnection cx = new SqlConnection();
            DataSet ds = new DataSet();
            sql = "SELECT * from ProgramasActividad order by anio desc";

            StringConexion c = new StringConexion();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "ProgramasActividad");

            return ds;
        }

    }
}
