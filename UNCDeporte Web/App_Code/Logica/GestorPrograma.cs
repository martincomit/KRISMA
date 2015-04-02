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
        public Programa programa;
        public Diagramacion diagramacion;

        public List<Programa> lista_programas;
        public List<Deporte> lista_deportes;
        public List<LugarPractica> lista_lugares;
        public List<TipoSector> lista_tipo_sectores;
        public List<Sector> lista_sectores;
        public List<Personal> lista_profesores;
        public List<Horario> lista_Horarios;        
                

        public GestorPrograma()
        {
            this.mp = new MapeoPrograma();
            this.lista_programas = null;
            this.programa = null;
            this.lista_deportes = null;             
            this.lista_lugares = null;            
            this.lista_tipo_sectores = null;            
            this.lista_sectores = null;            
            this.lista_profesores = null;            
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


        //Métodos ABM's  -------------------
        public void Registrar_Programa()
        {            
            mp.Registrar_Programa(programa);
        }

        public void Modificar_Programa()
        {
            
        }

        public void Eliminar_Programa()
        {
            
        }

        public void Consulatar_Programa()
        {
         
        }


        public DataSet ConsultarHorariosPrograma(int id_deporte)
        {
           
            DataSet ds = new DataSet();
            ds = mp.ConsultarHorariosPrograma(id_deporte);
            return ds;

        }

       

        //----------------------------------

        
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
            lista_tipo_sectores = mp.Cargar_Lista_Tipo_Sectores();
            lista_sectores = mp.Cargar_Lista_Sectores();
            lista_lugares = mp.Cargar_Lista_Lugares();

            for (int i = 0; i < lista_sectores.Count; i++)
            {
                int j = 0;
                while (lista_sectores[i].Tipo_sector.Id_tipo_sector != lista_tipo_sectores[j].Id_tipo_sector)
                {
                    j = j + 1;
                }
                lista_sectores[i].Tipo_sector = lista_tipo_sectores[j];

                j = 0;
                while (lista_sectores[i].Lugar.Id_lugar != lista_lugares[j].Id_lugar)
                {
                    j = j + 1;
                }
                lista_sectores[i].Lugar = lista_lugares[j];
            }

            
            for (int i = 0; i < lista_lugares.Count; i++)
            {
                lista_lugares[i].Lista_sector = new List<Sector>();
                for (int j = 0; j < lista_sectores.Count; j++)
                {
                    if (lista_lugares[i].Id_lugar == lista_sectores[j].Lugar.Id_lugar)
                    {                        
                        lista_lugares[i].Lista_sector.Add(lista_sectores[j]);
                    }
                }
            }
        }         

        public void Cargar_Lista_Profesores()
        {
            lista_profesores = mp.Cargar_Lista_Profesores();
        }
        public void Cargar_Lista_Horarios()
        {
            lista_Horarios = mp.Cargar_Lista_Horarios();
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
        public Deporte Obtener_Deporte(int id_deporte)
        {
            int i = 0;
            while (id_deporte != lista_deportes[i].Id_deporte)
            {
                i = i + 1;
            }
            return lista_deportes[i];
        }

        public List<TipoSector> Obtener_Lista_Tipo_Sectores()
        {
            return lista_tipo_sectores;
        }
        public List<TipoSector> Obtener_Tipo_Sectores(LugarPractica lp)
        {
            List<TipoSector> auxlts = new List<TipoSector>();
            List<TipoSector> lts = new List<TipoSector>();

            foreach (Sector s in lp.Lista_sector)
            {                
                auxlts.Add(s.Tipo_sector);
            }

            for (int i = 0; i < auxlts.Count; i++)
            {
                if (i == 0)
                {
                    lts.Add(auxlts[i]);
                }
                else
                {
                    if (auxlts[i].Id_tipo_sector != auxlts[i - 1].Id_tipo_sector)
                    {
                        lts.Add(auxlts[i]);
                    }
                }
            }            

            return lts; 
        }

        public List<Sector> Obtener_Lista_Sectores()
        {                    
            return lista_sectores;
        }

        public List<Sector> Obtener_Sectores(LugarPractica lp, TipoSector ts)
        {
            List<Sector> ls = new List<Sector>();

            foreach (Sector s in lp.Lista_sector)
            {
                if (s.Tipo_sector.Id_tipo_sector == ts.Id_tipo_sector)
                    ls.Add(s);
            }

            return ls;
        }
        
        public List<LugarPractica> Obtener_Lista_Lugares()
        {            
            return lista_lugares;
        }
        
        public List<Personal> Obtener_Lista_Profesores()
        {
            return lista_profesores;
        }

        public Personal Obtener_Profesor(int documento)
        {
            int i = 0;
            while (documento != lista_profesores[i].Documento)
            {
                i = i + 1;
            }
            return lista_profesores[i];
        }

        public List<Horario> Obtener_Lista_Horarios()
        {
            return lista_Horarios;
        }

        public Horario Obtener_Horario(string horario)
        {
            int i = 0;
            while ((horario != lista_Horarios[i].Hora+":"+lista_Horarios[i].Minuto))
            {
                i = i + 1;
            }
            return lista_Horarios[i];
        }
    }
}
