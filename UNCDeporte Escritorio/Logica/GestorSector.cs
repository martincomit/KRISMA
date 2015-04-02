using Entidades;
using MapeoDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class GestorSector
    {

        MapeoSector ms = new MapeoSector();
        string guardado;
        public List<TipoSector> lista_tipo_sectores;
        public List<LugarPractica> lista_lugares;
        public List<Estado> lista_estados;
        public List<Deporte> lista_deportes;


        public List<Sector> lista_sector; //Para la consulta de Sectores por filtro

        Sector s = new Sector();
        public TipoSector tipo_sector;
        public LugarPractica lugar;
        public Estado estado;
        public Deporte deporte;

        public GestorSector()
        {
            this.ms = new MapeoSector();
            this.lista_tipo_sectores = null;
            this.lista_lugares = null;
            this.lista_estados = null;
            this.lista_deportes = null;
            this.tipo_sector = null;
            this.lugar = null;
            this.estado = null;
            this.deporte = null;

            this.lista_sector = null; //para la consulta de sectores

        }

        //Cargar Listas....Trabajar con objetos en vez de trabajar con datos
        public void cargar_lista_tipos_sector()
        {
            lista_tipo_sectores = ms.cargar_lista_tipos_sector();
        }
        public void cargar_lista_lugares()
        {
            lista_lugares = ms.cargar_lista_lugares();
        }
        public void cargar_lista_estados()
        {
            lista_estados = ms.cargar_lista_estados();
        }
        public void cargar_lista_deportes()
        {
            lista_deportes = ms.cargar_lista_deportes();
        }



        //metodos obtener

        public List<TipoSector> obtener_lista_TipoSector()
        {
            return lista_tipo_sectores;
        }
        public List<Estado> obtener_lista_Estado()
        {
            return lista_estados;
        }
        public List<LugarPractica> obtener_lista_Lugar()
        {
            return lista_lugares;
        }
        public List<Deporte> obtener_lista_Deporte()
        {
            return lista_deportes;
        }


        public string Registrar(string nombre, string descripcion, TipoSector ts, LugarPractica lp, Estado estado)
        {
            s.Nombre = nombre;
            s.Descipcion = descripcion;
            s.Tipo_sector = ts;
            s.Lugar = lp;
            s.Estado = estado;
            //s.Deporte = deporte;

            guardado = ms.Existe(s);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = ms.Registrar(s);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = ms.Consultar();
            return ds;
        }
        public void Eliminar(int id_sector)
        {
            ms.Eliminar(id_sector);
        }
        public string Modificar(string nombre, string descripcion, int id_tipo_Sector, int id_lugar, int id_estado, int id_sector)
        {
            tipo_sector = ms.obtenerTipoSector(id_tipo_Sector);
            lugar = ms.obtenerLugar(id_lugar);
            estado = ms.obtenerEstado(id_estado);
            //buscar la forma de encontrar los objetos para cargarlo acá.
            //tp.Id_tipo_sector = id_tipo_Sector;
            //lp.Id_lugar = id_lugar;
            //e.Id_estado = id_estado;

            s.Id_sector = id_sector;
            s.Nombre = nombre;
            s.Descipcion = descripcion;
            s.Tipo_sector = tipo_sector;
            s.Lugar = lugar;
            s.Estado = estado;
            guardado = ms.Modificar(s);
            return guardado;
        }
        public DataSet ConsultarPorFiltro(string nombre, int? id_lugar, int? id_estado, int? id_tipoSector)
        {
            DataSet ds = new DataSet();
            ds = ms.consultarPorFiltro(nombre, id_lugar, id_estado, id_tipoSector);
            return ds;
        }



    }
}
