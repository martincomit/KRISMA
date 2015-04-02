using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapeoDeDatos;
using Entidades;
using System.Data;

namespace Logica
{

    public class GestorLugarPractica
    {

       
        MapeoLugarPractica mlp = new MapeoLugarPractica();
        string guardado;
        LugarPractica lp = new LugarPractica();
        public Localidad l;
        public Barrio b;

        public string Registrar(string nombre, string descripcion, string direccion, Localidad localidad, Barrio barrio)
        {  
            lp.Nombre = nombre;
            lp.Descripcion = descripcion;
            lp.Direccion = direccion;
            lp.Localidad = localidad;
            lp.Barrio = barrio;

            guardado = mlp.Existe(lp);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mlp.Registrar(lp);
                return guardado;
            }
        }


        public string Registrar(string nombre)
        {
            lp.Nombre = nombre;
            guardado = mlp.Existe(lp);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mlp.Registrar(lp);
                return guardado;
            }
        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mlp.Consultar();
            return ds;
        }

        public DataSet Consultar2(int id_dep)
        {
            return mlp.Consultar2(id_dep);
        }

        public DataSet ConsultarPorFiltro(string nombre, int id_localidad)
        {
            DataSet ds = new DataSet();
            ds = mlp.ConsultarPorFiltro(nombre, id_localidad);
            return ds;
        }

        public DataSet ConsultarPorFiltro(string nombre)
        {
            DataSet ds = new DataSet();
            ds = mlp.ConsultarPorFiltro(nombre);
            return ds;
        }
        
        public void Eliminar(int id_lugar)
        {
            mlp.Eliminar(id_lugar);
        }

        public string Modificar(int id_lugar, string nombre, string descripcion, string direccion, int id_localidad, int id_barrio)
        {
            l = mlp.obtenerLocalidad(id_localidad);
            b = mlp.obtenerBarrio(id_barrio);

            lp.Id_lugar = id_lugar;
            lp.Nombre = nombre;
            lp.Descripcion = descripcion;
            lp.Direccion = direccion;
            lp.Localidad = l;
            lp.Barrio = b;

            guardado = mlp.Existe(lp);


            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mlp.Modificar(lp);
                return guardado;
            }
        }


    }
    

}
