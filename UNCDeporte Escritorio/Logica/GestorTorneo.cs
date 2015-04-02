using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorTorneo
    {
        Torneo t = new Torneo();
        MapeoTorneo mt = new MapeoTorneo();
        string guardado;


        public string Registrar(string nombre, string descripcion, Deporte deporte, DateTime inicioTorneo, DateTime cierreTorneo, TipoTorneo tipoTorneo, int cantidadParticipantes, Estado estado, int puntajePrimerPuesto, int puntajeSegundoPuesto, Deporte tipoDeporte)
        {
            t.Nombre = nombre;
            t.Descripcion = descripcion;
            t.Deporte = deporte;
            t.Inicio_Torneo = inicioTorneo;
            t.Cierre_Torneo = cierreTorneo;
            t.Tipo_Torneo = tipoTorneo;
            t.Cantidad_participantes = cantidadParticipantes;
            t.Estado = estado;
            t.Puntaje_primer_puesto = puntajePrimerPuesto;
            t.Puntaje_segundo_puesto = puntajeSegundoPuesto;
            t.Deporte = tipoDeporte;

            guardado = mt.Existe(t);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mt.Registrar(t);
                return guardado;
            }
        }

        public string RegistrarClasificatorio(string nombre, string descripcion, Deporte deporte, DateTime inicioTorneo, DateTime cierreTorneo, TipoTorneo tipoTorneo, int cantidadParticipantes, Estado estado, int cantidadGrupos, int cantidadParticipantesPorGrupo, int clasificadosPorGrupo, int puntajePrimerPuesto, int puntajeSegundoPuesto, Deporte tipoDeporte)
        {
            t.Nombre = nombre;
            t.Descripcion = descripcion;
            t.Deporte = deporte;
            t.Inicio_Torneo = inicioTorneo;
            t.Cierre_Torneo = cierreTorneo;
            t.Tipo_Torneo = tipoTorneo;
            t.Cantidad_participantes = cantidadParticipantes;
            t.Estado = estado;
            t.Cantidad_grupos = cantidadGrupos;
            t.Cantidad_participantes_grupo = cantidadParticipantesPorGrupo;
            t.Cantidad_clasificados_grupo = clasificadosPorGrupo;
            t.Puntaje_primer_puesto = puntajePrimerPuesto;
            t.Puntaje_segundo_puesto = puntajeSegundoPuesto;
            t.Deporte = tipoDeporte;

            guardado = mt.Existe(t);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mt.RegistrarClasificatorio(t);
                return guardado;
            }
        }


        public void registrarEnCurso(int id_torneo, int id_estado)
        {


            mt.registrarEnCurso(id_torneo, id_estado);
             
 
        }

        public void registrarResultado(int id_torneo, int id_estado, int doc_primero, int doc_segundo)
        {


            mt.registrarResultado(id_torneo, id_estado, doc_primero, doc_segundo);


        }


        public DataSet ConsultarPorFiltro(string nombre)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarPorFiltro(nombre);
            return ds;
        }

        public DataSet ConsultarRanking(int id_deporte)
        {
            return mt.ConsultarRanking(id_deporte);
        }


        public DataSet Consultar(int id_deporte)
        {
            DataSet ds = new DataSet();
            ds = mt.Consultar(id_deporte);
            return ds;
        }


        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mt.Consultar();
            return ds;
        }

        public DataSet ConsultarDatos(int id_torneo)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarDatos(id_torneo);
            return ds;
        }

        public DataSet ConsultarDescripcion(int id_torneo)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarDescripcion(id_torneo);
            return ds;
        }

        public DataSet ConsultarEstado(int id_torneo)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarEstado(id_torneo);
            return ds;
        }


        public void Eliminar(int documento)
        {

            mt.Eliminar(documento);

        }

        //public void registrarRanking(int id_deporte, int doc_primero, int doc_segundo)
        //{

        //    mt.registrarRanking(id_deporte, doc_primero, doc_segundo);

        //}

        public DataSet ConsultarEstadosTorneo()
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarEstadosTorneo();
            return ds;
        }

    }
}