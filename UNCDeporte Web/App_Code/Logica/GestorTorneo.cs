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

        public DataSet Consultar(int id_deporte)
        {
            DataSet ds = new DataSet();
            ds = mt.Consultar(id_deporte);
            return ds;
        }

        public DataSet ConsultarCupo(int id_torneo)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarCupo(id_torneo);
            return ds;
        }
   

        public DataSet ConsultarInscriptos(int id_torneo)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarInscriptos(id_torneo);
            return ds;
        }


        public DataSet ConsultarDatos(int id_deporte)
        {
            DataSet ds = new DataSet();
            ds = mt.ConsultarDatos(id_deporte);
            return ds;
        }
        public string registrarParticipante(int documento, int id_torneo)
        {

            guardado = mt.Existe(documento, id_torneo);

            if (guardado == "Existe")
                return "Ya esta Inscripto";
            else
            {
                guardado = mt.registrarParticipante(documento, id_torneo);
                return guardado;
            }
        }

           

        
    }
}