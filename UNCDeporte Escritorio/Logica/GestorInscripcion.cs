using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapeoDeDatos;
using System.Data;

namespace Logica
{
    public class GestorInscripcion
    {
        string guardado;
        MapeoInscripcion mi = new MapeoInscripcion();


        public string Registrar(int documento, int []vector_id_deporte, int cantidad, string []vector_tipo)
        {

                
                guardado = mi.Registrar(documento, vector_id_deporte, cantidad, vector_tipo);
                return guardado;


        }



        public DataSet Consultar()
        {


           return mi.Consultar();


        }

        public DataSet ConsultarInscriptos()
        {


            return mi.ConsultarInscriptos();


        }

        public DataRow ContarInscripciones(int estado)
        {


            return mi.ContarInscripciones(estado);


        }

        public DataSet ConsultarInscriptos(int estado)
        {


            return mi.ConsultarInscriptos(estado);


        }

        public DataSet ConsultarDeportistas()
        {


            return mi.ConsultarDeportistas();


        }



        public DataSet Consultar(int id_deporte)
        {


            return mi.Consultar(id_deporte);


        }

        public DataSet Consultar(int documento, int id_deporte)
        {


            return mi.Consultar(documento, id_deporte);


        }

        public DataSet ConsultarDocumento(int documento)
        {


            return mi.ConsultarDocumento(documento);


        }

    }

   








}
