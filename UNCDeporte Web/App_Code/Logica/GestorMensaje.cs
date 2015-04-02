using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MapeoDeDatos;
using System.Data;
/// <summary>
/// Descripción breve de GestorMensaje
namespace Logica
{
    public class GestorMensaje
    {
        MapeoMensaje mm = new MapeoMensaje();

        public void EnviarMensaje(int id_deporte, string mensaje)
        {

            mm.EnviarMensaje(id_deporte, mensaje);

        }

        public void EnviarMensajeTorneo(int id_torneo, string mensaje)
        {

            mm.EnviarMensajeTorneo(id_torneo, mensaje);

        }

        public DataSet ConsultarMensajes(int id_deporte)
        {

            DataSet ds = new DataSet();
            ds = mm.ConsultarMensajes(id_deporte);
            return ds;

        }

        public void EliminarMensaje(int id_mensaje)
        {

            mm.EliminarMensaje(id_mensaje);

        }
    }
}