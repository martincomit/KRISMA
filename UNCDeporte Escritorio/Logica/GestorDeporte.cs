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

        public DataSet ConsultarDeportesInscriptos(int documento)
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarDeportesInscriptos(documento);
            return ds;
        }

        public DataSet ConsultarProfesXDeporte()
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarProfesXDeporte();
            return ds;
        }

        public DataSet ConsultarProfesXDeporte(string documento, string id_deporte, string id_programa)
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarProfesXDeporte(documento, id_deporte, id_programa);
            return ds;
        }

        public DataSet EliminarProfeXDeporteXPrograma(int documento, int id_deporte, int programa)
        {
            DataSet ds = new DataSet();
            ds = md.EliminarProfeXDeporteXPrograma(documento, id_deporte, programa);
            return ds;
        }

        public DataSet Consultar(string tipo)
        {
            DataSet ds = new DataSet();
            ds = md.Consultar(tipo);
            return ds;
        }


        public DataSet Consultar(Boolean torneo, string tipo)
        {
            DataSet ds = new DataSet();
            ds = md.Consultar(torneo, tipo);
            return ds;
        }

        public DataSet Consultar(Boolean torneo)
        {
            DataSet ds = new DataSet();
            ds = md.Consultar(true);
            return ds;
        }

        public DataSet Consultar(int id_deporte)
        {
            return md.Consultar(id_deporte);
        }

        //tabla tipodeportes hasta ahora = 0 -recreativo, 1-federado, puede existir en futuro infantil, mamis, etc
        public DataSet ConsultarTipoDeportes()
        {
            return md.ConsultarTipoDeportes();
        }

        public DataSet ConsultarTipo(int id_tipo)
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarTipo(id_tipo);
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

        public DataSet ConsultarPorTipoFederado()
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarPorTipoFederado();
            return ds;
        }

        public DataSet ConsultarPorTipoRecreativo()
        {
            DataSet ds = new DataSet();
            ds = md.ConsultarPorTipoRecreativo();
            return ds;
        }

    }
    

}
