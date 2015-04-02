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
        public Deportista de = new Deportista(); //ver de hacerlo privado y usar el constructor
        MapeoDeportista mde = new MapeoDeportista();
        string guardado;

        public string Registrar(int documento, DateTime fecha_Nac,string apellido, string nombres,char sexo,int caract_fijo, long tel_fijo,int caract_cel, long tel_cel,string email, Boolean becado, string direccion, int id_localidad, int id_barrio, int id_condicion, int id_deporte, int id_unidad, int id_escuela)
        {

            de.Documento = documento;
            de.Fec_nac = fecha_Nac;
            de.Apellido = apellido;
            de.Nombres = nombres;
            de.Sexo = sexo;
            de.Caract_fijo = caract_fijo;
            de.Tel_fijo = tel_fijo;
            de.Caract_cel = caract_cel;
            de.Tel_cel = tel_cel;
            de.Email = email;
            de.Direccion = direccion;
            de.Becado = becado;
            de.Id_localidad = id_localidad;
            de.Id_barrio = id_barrio;
            de.Id_condicion = id_condicion;
            de.Id_deporte = id_deporte;
            de.Id_unidadAcademica = id_unidad;
            de.Id_escuela = id_escuela;

            //le asigno el estado de alta al deportista, también se debería cambiar el estado de la inscripción a creada. 

            guardado = mde.Existe(de);
            //comprobar si existe inscripcion y detalle

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


        public DataSet ConsultarDeportistasPorDeporte(int id_deporte)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarDeportistasPorDeporte(id_deporte);
            return ds;
        }

        public DataSet ConsultarInscripciones(int id_deporte)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripciones(id_deporte);
            return ds;
        }

        //ConsultarDeportista
        public Deportista ConsultarDeportista(int documento)
        {
            Deportista dep = new Deportista();
            dep = mde.ConsultarDeportista(documento);

            return dep;
        }


        public DataSet ConsultarDeportista(int documento, int id_deporte)
        {
            
            return mde.ConsultarDeportista(documento, id_deporte);

        }


        public DataSet ConsultarDeportes(string documento_deportista)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarDeportes(documento_deportista);
            return ds;
        }


     

        public DataSet ConsultarDeportesProfe(string documento_profe)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarDeportesProfe(documento_profe);
            return ds;
        }


        public DataSet ConsultarInscripcion(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.ConsultarInscripciones(documento);
            return ds;
        }

        public DataSet Consultar(int documento)
        {
            DataSet ds = new DataSet();
            ds = mde.Consultar(documento);
            return ds;
        }


        public void Eliminar(int dni)
        {

            mde.Eliminar(dni);

        }




    }
}
