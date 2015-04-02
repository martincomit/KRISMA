using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapeoDeDatos;
using Entidades;
using System.Data;

namespace Logica
{
    public class GestorEvento
    {

        MapeoEvento mp = new MapeoEvento();
        string guardado;
        Evento e = new Evento();

        public string Registrar(Evento e)
        {

            guardado = mp.Existe(e);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mp.Registrar(e);
                return guardado;
            }
           
           
        }

        public string Modificar(Evento e)
        {
                guardado = mp.Modificar(e);
                return guardado;
        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar();
            return ds;
        }


        //public DataSet ConsultarJOIN()
        //{
        //    DataSet ds = new DataSet();
        //    ds = mp.ConsultarJOIN();
        //    return ds;
        //}

        public DataSet Consultar(int id_deporte)
        {
            DataSet ds = new DataSet();
            ds = mp.Consultar(id_deporte);
            return ds;
        }

        public DataSet ConsultarEvento(int id_evento)
        {
            DataSet ds = new DataSet();
            ds = mp.ConsultarEvento(id_evento);
            return ds;
        }

        public void Eliminar(int id_evento)
        {
            mp.Eliminar(id_evento);
        }

     

    }
    
}
