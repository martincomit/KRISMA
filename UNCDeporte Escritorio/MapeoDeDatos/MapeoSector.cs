using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapeoDeDatos
{
    public class MapeoSector
    {
        Conexion conexion;

        public MapeoSector()
        {
            conexion = new Conexion();
        }

        public string Existe(Sector s)
        {
            try
            {
                conexion.origen.Open();
                conexion.ds = new DataSet();
                string nombre = s.Nombre;
                int id_tipo_sector = s.Tipo_sector.Id_tipo_sector;
                int id_lugar = s.Lugar.Id_lugar;
                conexion.str_sql = "Select * from sectores where nombre='" + nombre + "'" + " and id_tipo_sector=" + id_tipo_sector + " and id_lugar=" + id_lugar;
                conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(conexion.ds, "Sectores");
                string test = conexion.ds.Tables[0].Rows[0][0].ToString();


                return "Existe";

            }

            catch (Exception ex)
            {
                conexion.origen.Close();
                return "No existe";
            }

        }

        public List<TipoSector> cargar_lista_tipos_sector()
        {
            try
            {
                conexion.origen.Open();
                List<TipoSector> lts = new List<TipoSector>();

                conexion.cmd = new SqlCommand("SELECT * from TiposSector", conexion.origen);
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

        public List<Estado> cargar_lista_estados()
        {
            try
            {
                conexion.origen.Open();
                List<Estado> le = new List<Estado>();

                conexion.cmd = new SqlCommand("SELECT * from Estados where ambito='Sector'", conexion.origen);
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
                            e.Descripcion= conexion.dr1["descripcion"].ToString();
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

        public List<Deporte> cargar_lista_deportes()
        {
            try
            {
                conexion.origen.Open();
                List<Deporte> ld = new List<Deporte>();

                conexion.cmd = new SqlCommand("SELECT * from Deportes", conexion.origen);
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

        public List<LugarPractica> cargar_lista_lugares()
        {
            try
            {
                conexion.origen.Open();
                List<LugarPractica> listLP = new List<LugarPractica>();

                conexion.cmd = new SqlCommand("SELECT * from LugaresPractica", conexion.origen);
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
                        /*if (conexion.dr1["id_localidad"] != DBNull.Value)
                        {
                            lp.Localidad.Id_localidad = Convert.ToInt32(conexion.dr1["id_localidad"]);
                        }
                        if (conexion.dr1["id_barrio"] != DBNull.Value)
                        {
                            lp.Barrio.Id_barrio = Convert.ToInt32(conexion.dr1["id_barrio"]);
                        }*/
                        listLP.Add(lp);
                    }
                }
                conexion.origen.Close();
                return listLP;
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




        public string Registrar(Sector s)
        {
            conexion.origen.Open();
            SqlTransaction tran = conexion.origen.BeginTransaction();

            try
            {

                conexion.cmd = new SqlCommand("insert into Sectores (nombre, descripcion, id_tipo_sector, id_lugar, id_estado) values (@nombre, @descripcion, @tipoSector, @lugarPractica, @estado)", conexion.origen, tran);
                SqlParameter pr = new SqlParameter("@nombre", s.Nombre);
                SqlParameter pr2 = new SqlParameter("@descripcion", s.Descipcion);
                SqlParameter pr3 = new SqlParameter("@tipoSector", s.Tipo_sector.Id_tipo_sector);
                SqlParameter pr4 = new SqlParameter("@lugarPractica", s.Lugar.Id_lugar);
                SqlParameter pr5 = new SqlParameter("@estado", s.Estado.Id_estado);
                //SqlParameter pr6 = new SqlParameter("@deporte", s.Deporte.Id_deporte);

                conexion.cmd.Parameters.Add(pr);
                conexion.cmd.Parameters.Add(pr2);
                conexion.cmd.Parameters.Add(pr3);
                conexion.cmd.Parameters.Add(pr4);
                conexion.cmd.Parameters.Add(pr5);
                //conexion.cmd.Parameters.Add(pr6);

                conexion.cmd.ExecuteNonQuery();

                tran.Commit();
                conexion.origen.Close();
                return "Guardado";

            }
            catch (Exception ex)
            {
                tran.Rollback();
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return "Error al Guardar";

            }



        }

        public DataSet Consultar()
        {
            conexion.origen.Open();
            conexion.ds = new DataSet();
            conexion.str_sql = @"SELECT     dbo.Sectores.id_sector, dbo.Sectores.nombre AS Sector, dbo.Sectores.descripcion AS Descripción, dbo.LugaresPractica.nombre AS LugarDePráctica, dbo.TiposSector.nombre AS TipoDeSector, 
                      dbo.Estados.nombre AS Estado
FROM         dbo.Sectores INNER JOIN
                      dbo.LugaresPractica ON dbo.Sectores.id_lugar = dbo.LugaresPractica.id_lugar INNER JOIN
                      dbo.TiposSector ON dbo.Sectores.id_tipo_sector = dbo.TiposSector.id_tipo_sector INNER JOIN
                      dbo.Estados ON dbo.Sectores.id_estado = dbo.Estados.id_estado";


            conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
            conexion.da.Fill(conexion.ds, "Sectores");

            conexion.origen.Close();
            return conexion.ds;

        }

        public void Eliminar(int id_sector)
        {
            conexion.origen.Open();
            conexion.ds = new DataSet();

            conexion.str_sql = "Delete from Sectores where id_sector=" + id_sector;
            conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);

            conexion.da.Fill(conexion.ds, "Sectores");
            conexion.origen.Close();

        }
        public string Modificar(Sector s)
        {
            conexion.origen.Open();
            SqlTransaction tran = conexion.origen.BeginTransaction();
            try
            {

                conexion.cmd = new SqlCommand("Update Sectores set nombre=@nombre, descripcion=@descripcion, id_tipo_sector=@id_tipo, id_lugar=@id_lugar, id_estado=@id_estado where id_sector=@id_sector", conexion.origen, tran);
                SqlParameter pr = new SqlParameter("@nombre", s.Nombre);
                SqlParameter pr2 = new SqlParameter("@descripcion", s.Descipcion);
                SqlParameter pr3 = new SqlParameter("@id_tipo", s.Tipo_sector.Id_tipo_sector);
                SqlParameter pr4 = new SqlParameter("@id_lugar", s.Lugar.Id_lugar);
                SqlParameter pr5 = new SqlParameter("@id_estado", s.Estado.Id_estado);
                SqlParameter pr6 = new SqlParameter("@id_sector", s.Id_sector);

                conexion.cmd.Parameters.Add(pr);
                conexion.cmd.Parameters.Add(pr2);
                conexion.cmd.Parameters.Add(pr3);
                conexion.cmd.Parameters.Add(pr4);
                conexion.cmd.Parameters.Add(pr5);
                conexion.cmd.Parameters.Add(pr6);

                conexion.cmd.ExecuteNonQuery();

                tran.Commit();
                conexion.origen.Close();
                return "Modificado";
            }
            catch (Exception)
            {
                tran.Rollback();
                if (conexion.origen.State == ConnectionState.Open)
                {
                    conexion.origen.Close();
                }
                return "Error al Modificar";
            }
        }
        public LugarPractica obtenerLugar(int id_lugar)
        {

            conexion.origen.Open();
            conexion.str_sql = "Select * from LugaresPractica where id_lugar= " + id_lugar;
            conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
            conexion.dr1 = conexion.cmd.ExecuteReader();

            conexion.dr1.Read();
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

            conexion.origen.Close();
            return lp;

        }
        public TipoSector obtenerTipoSector(int id_tipo_sector)
        {

            conexion.origen.Open();
            conexion.str_sql = "Select * from TiposSector where id_tipo_sector= " + id_tipo_sector;
            conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
            conexion.dr1 = conexion.cmd.ExecuteReader();

            conexion.dr1.Read();
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
            conexion.origen.Close();
            return ts;



        }

        public Estado obtenerEstado(int id_estado)
        {

            conexion.origen.Open();
            conexion.str_sql = "Select * from Estados where id_estado= " + id_estado;
            conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
            conexion.dr1 = conexion.cmd.ExecuteReader();

            conexion.dr1.Read();
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

            conexion.origen.Close();
            return e;

        }
        public DataSet consultarPorFiltro(string nombre, int? id_lugar, int? id_estado, int? id_tipoSector)
        {
            try
            {
                conexion.origen.Open();
                conexion.ds = new DataSet();

                conexion.str_sql = @"select s.id_sector, s.nombre as Sector, s.descripcion as Descripción, lp.nombre as LugarDePráctica, ts.nombre as TipoSector,
			                        e.nombre as Estado
			
                                    from Sectores s, LugaresPractica lp, TiposSector ts, Estados e
                                    where 1=1 and s.id_lugar=lp.id_lugar and s.id_tipo_sector=ts.id_tipo_sector
                                    and s.id_estado=e.id_estado";

                if (!string.IsNullOrEmpty(nombre))
                {
                    conexion.str_sql += " and s.nombre like '%" + nombre + "%'";
                }
                if (id_lugar.HasValue)
                {
                    conexion.str_sql += " and s.id_lugar= " + id_lugar;
                }
                if (id_estado.HasValue)
                {
                    conexion.str_sql += " and s.id_estado= " + id_estado;
                }
                if (id_tipoSector.HasValue)
                {
                    conexion.str_sql += " and s.id_tipo_sector= " + id_tipoSector;
                }


                conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(conexion.ds, "consultaFiltro");
                conexion.origen.Close();
                return conexion.ds;

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

    }
}
