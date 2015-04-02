using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorPrograma
    {
        public MapeoPrograma mp;

        public List<Programa> lista_programas;
        public List<Deporte> lista_deportes;
        public List<LugarPractica> lista_lugares;
        public List<TipoSector> lista_tipo_sectores;
        public List<Sector> lista_sectores;
        public List<Personal> lista_profesores;
        public List<Diagramacion> lista_diagranaciones;

        public Programa programa;
        public Deporte deporte;
        public LugarPractica lugar;     
        public TipoSector tipo_sector;        
        public Sector sector;        
        public Personal profesor;
        public Diagramacion diagramacion;



        public GestorPrograma()
        {
            this.mp = new MapeoPrograma();
            this.lista_programas = null;
            this.programa = null;
            this.lista_deportes = null; 
            this.deporte = null;
            this.lista_lugares = null;
            this.lugar = null;
            this.lista_tipo_sectores = null;
            this.tipo_sector = null;
            this.lista_sectores = null;
            this.sector = null;
            this.lista_profesores = null;
            this.profesor = null;
        }

        
        public bool Hay_Programas()
        {
            if ((lista_programas != null) && (lista_programas.Count != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Hay_Diagramacion(Deporte d)
        {
            if (d.Id_deporte == 0)//Cambiar
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Nuevo_Programa()
        {
            programa = new Programa();
        }

        public void Registrar_Programa()
        {
            
        }

        public void Modificar_Programa()
        {
            
        }

        public void Eliminar_Programa()
        {
            
        }

        public DataSet Consulatar_Programa()
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar_Programas();
            return ds;
        }


        //Cargas iniciales despues se trabaja con OBJETOS
        public void Cargar_Lista_Programas()
        {            
            lista_programas = mp.Cargar_Lista_Programas();
        }

        public void Cargar_Lista_Deportes()
        {            
            lista_deportes = mp.Cargar_Lista_Deportes();
        }

        public void Cargar_Lista_Lugares()
        {
            lista_lugares = mp.Cargar_Lista_Lugares();
        }

        public void Cargar_Lista_Profesores()
        {
            lista_profesores = mp.Cargar_Lista_Profesores();
        }
        

        //-----------------------------------------------


        public List<Programa> Obtener_Lista_Programas()
        {
            return lista_programas;
        }

        public List<Deporte> Obtener_Lista_Deportes()
        {
            return lista_deportes;
        }

        public List<LugarPractica> Obtener_Lista_Lugares()
        {
            return lista_lugares;
        }

        public List<TipoSector> Obtener_Lista_Tipos_Sectores(LugarPractica lp)
        {
            List<TipoSector> lts = new List<TipoSector>();

            foreach (Sector s in lp.Lista_sector)
            {
                lts.Add(s.Tipo_sector);
            }

            lista_tipo_sectores = new List<TipoSector>();
            
            for (int i = 0; i < lts.Count; i++)
            {
                if (i == 0)
                {
                    lista_tipo_sectores.Add(lts[i]);                    
                }
                else
                {
                    if (lts[i].Id_tipo_sector != lts[i - 1].Id_tipo_sector)
                    {
                        lista_tipo_sectores.Add(lts[i]);
                    }
                }
            }
                
            return lista_tipo_sectores;            
        }
        
        public List<Sector> Obtener_Lista_Sectores(LugarPractica lp, TipoSector ts)
        {
            List<Sector> ls = new List<Sector>();
            foreach (Sector s in lp.Lista_sector)
            {
                if (s.Tipo_sector.Id_tipo_sector == ts.Id_tipo_sector)
                    ls.Add(s);
            }
            return ls;
        }

        public List<Personal> Obtener_Lista_Profesores()
        {
            return lista_profesores;
        }
    }
}
