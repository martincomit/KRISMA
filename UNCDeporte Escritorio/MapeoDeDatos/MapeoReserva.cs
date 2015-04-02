using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace MapeoDeDatos
{
    public class MapeoReserva
    {
        Conexion conexion;

        public MapeoReserva()
        {
            conexion = new Conexion();                        
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
                            s.Descipcion = conexion.dr1["descripcion"].ToString();
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
            catch (Exception e)
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

        public List<TipoReserva> Cargar_Lista_Tipos_Reserva()
        {
            try
            {
                conexion.origen.Open();
                List<TipoReserva> ltr = new List<TipoReserva>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Tipos_Reserva", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        TipoReserva tr = new TipoReserva();
                        if (conexion.dr1["id_tipo_reserva"] != DBNull.Value)
                        {
                            tr.Id_tipo_reserva = Convert.ToInt32(conexion.dr1["id_tipo_reserva"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            tr.Nombre = conexion.dr1["nombre"].ToString();
                        }
                        if (conexion.dr1["descripcion"] != DBNull.Value)
                        {
                            tr.Descripcion = conexion.dr1["descripcion"].ToString();
                        }

                        ltr.Add(tr);
                    }
                }
                conexion.origen.Close();

                return ltr;
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

        public List<Reserva> Cargar_Lista_Reservas(int id_sector)
        {
            try
            {
                conexion.origen.Open();
                List<Reserva> lr = new List<Reserva>();
                conexion.cmd = new SqlCommand("Cargar_Lista_Reservas", conexion.origen);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", id_sector));
                conexion.dr1 = conexion.cmd.ExecuteReader();

                if (conexion.dr1.HasRows)
                {
                    //Reserva r = new Reserva();

                    while (conexion.dr1.Read())
                    {
                        Reserva r = new Reserva();
                        /*
                        if (lr.Count > 1)
                        {
                            if (lr[lr.Count - 2].Id_reserva == r.Id_reserva)
                            {
                            }
                            else
                            {

                            }
                        }
                        else
                        { */                           
                            r.Id_reserva = Convert.ToInt32(conexion.dr1["id_reserva"]);
                            r.Descripcion = conexion.dr1["descripcion"].ToString();
                            TipoReserva tr = new TipoReserva();
                            tr.Id_tipo_reserva = Convert.ToInt32(conexion.dr1["id_tipo_reserva"]);
                            r.Tipo_reserva = tr;
                            DetalleReserva dr = new DetalleReserva();
                            dr.Item = Convert.ToInt32(conexion.dr1["item"]);

                            if (conexion.dr1["id_deporte"] != DBNull.Value)
                            {
                                conexion.cmd = new SqlCommand("Cargar_Deporte", conexion.origen);
                                conexion.cmd.CommandType = CommandType.StoredProcedure;
                                conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", Convert.ToInt32(conexion.dr1["id_deporte"])));
                                conexion.dr2 = conexion.cmd.ExecuteReader();
                                Deporte d = new Deporte();
                                conexion.dr2.Read();
                                d.Id_deporte = Convert.ToInt32(conexion.dr2["id_deporte"]);
                                d.Nombre = conexion.dr2["nombre"].ToString();
                                d.Descripcion = conexion.dr2["descripcion"].ToString();

                                dr.Deporte = d;
                            }                            
                            
                            Persona p = new Persona();
                            if (conexion.dr1["documento"] != DBNull.Value)
                                p.Documento = Convert.ToInt32(conexion.dr1["documento"]);
                            if (conexion.dr1["apellido"] != DBNull.Value)
                                p.Apellido = conexion.dr1["apellido"].ToString();
                            if (conexion.dr1["nombres"] != DBNull.Value)
                                p.Nombres = conexion.dr1["nombres"].ToString();

                            dr.Persona = p;

                            Sector s = new Sector();
                            TipoSector ts = new TipoSector();
                            LugarPractica lp = new LugarPractica();

                            conexion.cmd = new SqlCommand("Cargar_Sector", conexion.origen);
                            conexion.cmd.CommandType = CommandType.StoredProcedure;
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", Convert.ToInt32(conexion.dr1["id_sector"])));
                            conexion.dr2 = conexion.cmd.ExecuteReader();

                            conexion.dr2.Read();
                            ts.Id_tipo_sector = Convert.ToInt32(conexion.dr2["id_tipo_sector"]);
                            ts.Nombre = conexion.dr2["nombre_tipo"].ToString();
                            ts.Descripcion = conexion.dr2["descripcion_tipo"].ToString();
                            lp.Id_lugar = Convert.ToInt32(conexion.dr2["id_lugar"]);
                            lp.Nombre = conexion.dr2["nombre_lugar"].ToString();
                            lp.Descripcion = conexion.dr2["descripcion_lugar"].ToString();
                            s.Id_sector = Convert.ToInt32(conexion.dr1["id_sector"]);
                            s.Nombre = conexion.dr2["nombre_sector"].ToString();
                            s.Descipcion = conexion.dr2["descripcion_sector"].ToString();
                            s.Tipo_sector = ts;
                            s.Lugar = lp;

                            dr.Fecha_reserva = Convert.ToDateTime(conexion.dr1["fecha_reserva"]);

                            Horario hd = new Horario();
                            Horario hh = new Horario();

                            conexion.cmd = new SqlCommand("Cargar_Horario", conexion.origen);
                            conexion.cmd.CommandType = CommandType.StoredProcedure;
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_horario", Convert.ToInt32(conexion.dr1["id_hora_desde"])));
                            conexion.dr2 = conexion.cmd.ExecuteReader();
                            conexion.dr2.Read();

                            hd.Id_horario = Convert.ToInt32(conexion.dr1["id_hora_desde"]);
                            hd.Hora = conexion.dr2["hora"].ToString();
                            hd.Minuto = conexion.dr2["minuto"].ToString();

                            conexion.cmd = new SqlCommand("Cargar_Horario", conexion.origen);
                            conexion.cmd.CommandType = CommandType.StoredProcedure;
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_horario", Convert.ToInt32(conexion.dr1["id_hora_hasta"])));
                            conexion.dr2 = conexion.cmd.ExecuteReader();
                            conexion.dr2.Read();

                            hh.Id_horario = Convert.ToInt32(conexion.dr1["id_hora_hasta"]);
                            hh.Hora = conexion.dr2["hora"].ToString();
                            hh.Minuto = conexion.dr2["minuto"].ToString();

                            dr.Hora_desde = hd;
                            dr.Hora_hasta = hh;

                            Estado e = new Estado();
                            e.Id_estado = Convert.ToInt32(conexion.dr1["id_estado"]);
                            e.Nombre = conexion.dr1["nombre_estado"].ToString();
                            e.Descripcion = conexion.dr1["descripcion_estado"].ToString();
                            e.Ambito = conexion.dr1["ambito"].ToString();

                            dr.Estado = e;

                            r.Detalle.Add(dr);
                            lr.Add(r);
                        //}
                    }
                }


                return lr;
            }
            catch (Exception e)
            {
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return null;
            }
        }

        public bool Registrar_Reserva(List<Reserva> reservas, List<DetallePrograma> detalle)
        {
            conexion.origen.Open();

            SqlTransaction transaccion;
            transaccion = conexion.origen.BeginTransaction();


            try
            {
                for (int i = 0; i < reservas.Count; i++)
                {
                    conexion.cmd = new SqlCommand("Registrar_Reserva", conexion.origen, transaccion);
                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                    conexion.cmd.Parameters.Add("@id_reserva", SqlDbType.Int).Direction = ParameterDirection.Output;
                    conexion.cmd.Parameters.Add(new SqlParameter("@fecha_realizacion", reservas[i].Fecha_realizacion));
                    conexion.cmd.Parameters.Add(new SqlParameter("@descripcion", reservas[i].Descripcion));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_tipo_reserva", reservas[i].Tipo_reserva.Id_tipo_reserva));
                    conexion.cmd.ExecuteNonQuery();
                    int id_reserva = Convert.ToInt32(conexion.cmd.Parameters["@id_reserva"].Value);

                    for (int j = 0; j < reservas[i].Detalle.Count; j++)
                    {
                        conexion.cmd = new SqlCommand("Registrar_Detalle_Reserva", conexion.origen, transaccion);
                        conexion.cmd.CommandType = CommandType.StoredProcedure;
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", id_reserva));
                        conexion.cmd.Parameters.Add(new SqlParameter("@item", reservas[i].Detalle[j].Item));
                        if (reservas[i].Detalle[j].Deporte != null)
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", reservas[i].Detalle[j].Deporte.Id_deporte));
                        else
                            conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", DBNull.Value));

                        if (reservas[i].Detalle[j].Persona != null)
                        {
                            conexion.cmd.Parameters.Add(new SqlParameter("@documento", reservas[i].Detalle[j].Persona.Documento));
                            conexion.cmd.Parameters.Add(new SqlParameter("@apellido", reservas[i].Detalle[j].Persona.Apellido));
                            conexion.cmd.Parameters.Add(new SqlParameter("@nombres", reservas[i].Detalle[j].Persona.Nombres));
                            conexion.cmd.Parameters.Add(new SqlParameter("@tel_fijo", reservas[i].Detalle[j].Persona.Tel_fijo));
                            conexion.cmd.Parameters.Add(new SqlParameter("@tel_celular", reservas[i].Detalle[j].Persona.Tel_celular));
                            conexion.cmd.Parameters.Add(new SqlParameter("@email", reservas[i].Detalle[j].Persona.Email));
                        }
                        else
                        {
                            conexion.cmd.Parameters.Add(new SqlParameter("@documento", DBNull.Value));
                            conexion.cmd.Parameters.Add(new SqlParameter("@apellido", DBNull.Value));
                            conexion.cmd.Parameters.Add(new SqlParameter("@nombres", DBNull.Value));
                            conexion.cmd.Parameters.Add(new SqlParameter("@tel_fijo", DBNull.Value));
                            conexion.cmd.Parameters.Add(new SqlParameter("@tel_celular", DBNull.Value));
                            conexion.cmd.Parameters.Add(new SqlParameter("@email", DBNull.Value));
                        }                                                    

                        conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", reservas[i].Detalle[j].Sector.Id_sector));
                        conexion.cmd.Parameters.Add(new SqlParameter("@fecha_reserva", reservas[i].Detalle[j].Fecha_reserva));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_desde", reservas[i].Detalle[j].Hora_desde.Id_horario));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_hasta", reservas[i].Detalle[j].Hora_hasta.Id_horario));
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_estado", reservas[i].Detalle[j].Estado.Id_estado));

                        conexion.cmd.ExecuteNonQuery();
                    }

                    conexion.cmd = new SqlCommand("Actualizar_Estado_Detalle_programa", conexion.origen, transaccion);
                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_programa", detalle[i].Programa.Id_programa));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", detalle[i].Deporte.Id_deporte));
                    conexion.cmd.Parameters.Add(new SqlParameter("@item", detalle[i].Item));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", id_reserva));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_estado", 15));

                    conexion.cmd.ExecuteNonQuery();

                }
                conexion.cmd.Transaction.Commit();
                conexion.origen.Close();
                return true;
            }
            catch(Exception e)
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


        //--------------------------------------------------------------
        public bool Registrar_Reserva(Reserva reserva)
        {
            conexion.origen.Open();

            SqlTransaction transaccion;
            transaccion = conexion.origen.BeginTransaction();


            try
            {                
                conexion.cmd = new SqlCommand("Registrar_Reserva", conexion.origen, transaccion);
                conexion.cmd.CommandType = CommandType.StoredProcedure;
                conexion.cmd.Parameters.Add("@id_reserva", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.cmd.Parameters.Add(new SqlParameter("@fecha_realizacion", reserva.Fecha_realizacion));
                conexion.cmd.Parameters.Add(new SqlParameter("@descripcion", reserva.Descripcion));
                conexion.cmd.Parameters.Add(new SqlParameter("@id_tipo_reserva", reserva.Tipo_reserva.Id_tipo_reserva));
                conexion.cmd.ExecuteNonQuery();
                int id_reserva = Convert.ToInt32(conexion.cmd.Parameters["@id_reserva"].Value);

                for (int j = 0; j < reserva.Detalle.Count; j++)
                {
                    conexion.cmd = new SqlCommand("Registrar_Detalle_Reserva", conexion.origen, transaccion);
                    conexion.cmd.CommandType = CommandType.StoredProcedure;
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_reserva", id_reserva));
                    conexion.cmd.Parameters.Add(new SqlParameter("@item", reserva.Detalle[j].Item));
                    if ((reserva.Detalle[j].Deporte != null) && (reserva.Detalle[j].Deporte.Id_deporte != 0))
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", reserva.Detalle[j].Deporte.Id_deporte));
                    else
                        conexion.cmd.Parameters.Add(new SqlParameter("@id_deporte", DBNull.Value));

                    if (reserva.Detalle[j].Persona != null)
                    {
                        conexion.cmd.Parameters.Add(new SqlParameter("@documento", reserva.Detalle[j].Persona.Documento));
                        conexion.cmd.Parameters.Add(new SqlParameter("@apellido", reserva.Detalle[j].Persona.Apellido));
                        conexion.cmd.Parameters.Add(new SqlParameter("@nombres", reserva.Detalle[j].Persona.Nombres));
                        conexion.cmd.Parameters.Add(new SqlParameter("@tel_fijo", reserva.Detalle[j].Persona.Tel_fijo));
                        conexion.cmd.Parameters.Add(new SqlParameter("@tel_celular", reserva.Detalle[j].Persona.Tel_celular));
                        conexion.cmd.Parameters.Add(new SqlParameter("@email", reserva.Detalle[j].Persona.Email));
                    }
                    else
                    {
                        conexion.cmd.Parameters.Add(new SqlParameter("@documento", DBNull.Value));
                        conexion.cmd.Parameters.Add(new SqlParameter("@apellido", DBNull.Value));
                        conexion.cmd.Parameters.Add(new SqlParameter("@nombres", DBNull.Value));
                        conexion.cmd.Parameters.Add(new SqlParameter("@tel_fijo", DBNull.Value));
                        conexion.cmd.Parameters.Add(new SqlParameter("@tel_celular", DBNull.Value));
                        conexion.cmd.Parameters.Add(new SqlParameter("@email", DBNull.Value));
                    }

                    conexion.cmd.Parameters.Add(new SqlParameter("@id_sector", reserva.Detalle[j].Sector.Id_sector));
                    conexion.cmd.Parameters.Add(new SqlParameter("@fecha_reserva", reserva.Detalle[j].Fecha_reserva));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_desde", reserva.Detalle[j].Hora_desde.Id_horario));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_hora_hasta", reserva.Detalle[j].Hora_hasta.Id_horario));
                    conexion.cmd.Parameters.Add(new SqlParameter("@id_estado", reserva.Detalle[j].Estado.Id_estado));

                    conexion.cmd.ExecuteNonQuery();
                }                    

                
                conexion.cmd.Transaction.Commit();
                conexion.origen.Close();
                return true;
            }
            catch (Exception e)
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
        //--------------------------------------------------------------



    }
}
