using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapeoDeDatos;
using Entidades;
using System.Data;

namespace Logica
{


    public class GestorDeporte
    {

        MapeoDeporte md = new MapeoDeporte();
        string guardado;
        Deporte d = new Deporte();

        public string Registrar(string nombre, string descripcion, int cod_sanaviron)
        {
            d.Nombre = nombre;
            d.Descripcion = descripcion;
            d.Cod_sanaviron = cod_sanaviron;

            guardado = md.Existe(d);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = md.Registrar(d);
                return guardado;
            }
            return "";
        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = md.Consultar();
            return ds;
        }

        public DataSet Consultar(Boolean torneo, string tipo)
        {
            DataSet ds = new DataSet();
            ds = md.Consultar(torneo, tipo);
            return ds;
        }

        public DataSet Consultar(string tipo)
        {
            DataSet ds = new DataSet();
            ds = md.Consultar(tipo);
            return ds;
        }


        public DataSet Consultar(Boolean torneo)
        {
            DataSet ds = new DataSet();
            ds = md.Consultar(torneo);
            return ds;
        }


        public DataSet ConsultarMasSolicitados()
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarMasSolicitados();
            return ds;
        }

        public void Eliminar(int id_deporte)
        {

            md.Eliminar(id_deporte);

        }



    }
    

}
