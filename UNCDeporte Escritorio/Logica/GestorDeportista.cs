using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorDeportista
    {
        Deportista de = new Deportista();
        MapeoDeportista mde = new MapeoDeportista();
        string guardado;

        public string Registrar(int DNI, string Apellido)
        {

            de.Documento= DNI;
            de.Apellido = Apellido;

            guardado = mde.Existe(de);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mde.Registrar(de);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mde.Consultar();
            return ds;
        }

        public DataSet deportePreinscripto(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.deportePreinscripto(documento);
            return ds;
        }

        public DataSet ConsultarSinAsignar()
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarSinAsignar();
            return ds;
        }

        public DataSet ConsultarInscripciones()
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripciones();
            return ds;
        }


        public DataSet ConsultarInscripciones(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripciones(documento);
            return ds;
        }

        public DataSet ConsultarInscripciones(string ambito)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripciones(ambito);
            return ds;
        }

        public DataSet ConsultarInscripcionesEstado(int id_estado)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripcionesEstado(id_estado);
            return ds;
        }

        public DataSet ConsultarInscripcionesEstadoDocumento(int id_estado, int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripcionesEstadoDocumento(id_estado, documento);
            return ds;
        }


        

        public DataSet Consultar(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.Consultar(documento);
            return ds;
        }

        public DataSet Consultar(int documento, int id_estado)
        {
            DataSet ds = new DataSet();
            ds = mde.Consultar(documento, id_estado);
            return ds;
        }

        public DataSet ConsultarDeportes(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarDeportes(documento);
            return ds;
        }

        public DataSet ConsultarInscripciones(int estadoaprobado, int estadosolorecreativas)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripciones(estadoaprobado, estadosolorecreativas);
            return ds;
        }

        public void Eliminar(int dni)
        {

            mde.Eliminar(dni);

        }

        public string Modificar(int documento, int id_estado)
        {

            string guardado= mde.Modificar(documento, id_estado);
            return guardado;
        }

        public string Modificar(int documento, int id_estadoErgo, int id_estadoLabo)
        {

            string guardado = mde.Modificar(documento, id_estadoErgo, id_estadoLabo);
            return guardado;
        }


        public DataSet ConsultarPorDocumento(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarPorDocumento(documento);
            return ds;
        }

        public string DarBaja(int documento)
        {

            string guardado = mde.DarBaja(documento);
            return guardado;
        }

        public DataSet ConsultarDeportistasDeAlta()
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarDeportistasDeAlta();
            return ds;
        }

        public DataSet DarBajaDeportistasPorAñoInscripcion(int año)
        {
            DataSet ds = new DataSet();
            ds = mde.DarBajaDeportistasPorAñoInscripcion(año);
            return ds;
        }

    }
}

