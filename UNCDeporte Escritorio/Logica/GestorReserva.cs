using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;

namespace Logica
{
    public class GestorReserva
    {
        public MapeoReserva mr;
        public Reserva reserva;
        public List<Reserva> lista_reserva;

        public List<LugarPractica> lista_lugares;
        public List<TipoSector> lista_tipo_sectores;
        public List<Sector> lista_sectores;
        public List<Horario> lista_horarios;
        public List<Deporte> lista_deportes;
        public List<Personal> lista_profesores;
        public List<Deportista> lista_deportistas;
        public List<TipoReserva> lista_tipos_reserva;
        public List<Estado> lista_estados_detalle_reserva;


        public GestorReserva()
        {
            mr = new MapeoReserva();
            reserva = null;
            lista_lugares = null;
            lista_tipo_sectores = null;
            lista_sectores = null;
            lista_horarios = null;
            lista_deportes = null;
            lista_profesores = null;
            lista_deportistas = null;
            lista_tipos_reserva = null;
            lista_estados_detalle_reserva = null;
        }

        public void Nueva_Reserva()
        {
            reserva = new Reserva();
        }

        public void Nueva_Lista_Reserva()
        {
            lista_reserva = new List<Reserva>();
        }
    


        //Métodos ABM's
        public bool Registrar_Reserva(List<DetallePrograma> detalle)
        {
            return mr.Registrar_Reserva(lista_reserva, detalle);
        }

        public bool Registrar_Reserva(Reserva reserva)
        {
            return mr.Registrar_Reserva(reserva);
        }


        //-------------------------------

        public void Cargar_Lista_Lugares()
        {
            lista_tipo_sectores = mr.Cargar_Lista_Tipo_Sectores();
            lista_sectores = mr.Cargar_Lista_Sectores();
            lista_lugares = mr.Cargar_Lista_Lugares();

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

        public void Cargar_Lista_Horarios()
        {
            lista_horarios = mr.Cargar_Lista_Horarios();
        }

        public void Cargar_Lista_Deportes()
        {
            lista_deportes = mr.Cargar_Lista_Deportes();
        }

        public void Cargar_Lista_Profesores()
        {
            lista_profesores = mr.Cargar_Lista_Profesores();
        }

        public void Cargar_Lista_Deportistas()
        {

        }

        public void Cargar_Lista_Tipos_Reserva()
        {
            lista_tipos_reserva = mr.Cargar_Lista_Tipos_Reserva();
        }

        public void Cargar_Lista_Estados_Detalle_Reserva()
        {
            lista_estados_detalle_reserva = mr.Cargar_Lista_Estados("detallereserva");
        }

        public void Cargar_Lista_Reservas(Sector sector)
        {
            lista_reserva = mr.Cargar_Lista_Reservas(sector.Id_sector);            
        }


        //---------------------------------------------------------        
        public List<LugarPractica> Obtener_Lista_Lugares()
        {
            return lista_lugares;
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

        public List<Horario> Obtener_Lista_Horarios()
        {
            return lista_horarios;
        }

        public Horario Obtener_Horario(string horario)
        {
            int i = 0;
            while ((horario != lista_horarios[i].Hora + ":" + lista_horarios[i].Minuto))
            {
                i = i + 1;
            }
            return lista_horarios[i];
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

        /*
        public Deportista Obtener_Lista_Deportistas()
        {
            
        }
        public Deportista Obtener_Deportista(int Documento)
        {

        }
        */
        
    }
}
