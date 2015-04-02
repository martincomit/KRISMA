using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    
    public class GestorEstado
    {
        string guardado;
        Estado e = new Estado();
        MapeoEstado me = new MapeoEstado();
        

        public string Registrar(string nombre, int id_loc)
        {

            e.Nombre = nombre;
         

            guardado = me.Existe(e);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = me.Registrar(e);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = me.Consultar();
            return ds;
        }

        public DataSet Consultar(int id_estado)
        {
            DataSet ds = new DataSet();
            ds = me.Consultar(id_estado);
            return ds;
        }

        public DataSet ConsultarEstadoDetalle(int id_estado)
        {
            DataSet ds = new DataSet();
            ds = me.ConsultarEstadoDetalle(id_estado);
            return ds;
        }

        public DataSet Consultar(string ambito)
        {
            DataSet ds = new DataSet();
            ds = me.Consultar(ambito);
            return ds;
        }

        public DataSet ConsultarAprobados(string ambito)
        {
            DataSet ds = new DataSet();
            ds = me.ConsultarAprobados(ambito);
            return ds;
        }

        public DataSet ConsultarSoloInscripciones(string ambito)
        {
            DataSet ds = new DataSet();
            ds = me.ConsultarSoloInscripciones(ambito);
            return ds;
        }

        public void Eliminar(int id)
        {

            me.Eliminar(id);

        }




    }
}
