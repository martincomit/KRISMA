using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using MapeoDeDatos;

namespace Logica
{
    public class GestorUnidadAcademica
    {
        UnidadAcademica u = new UnidadAcademica();
        MapeoUnidadAcademica mu = new MapeoUnidadAcademica();
        string guardado;

        public string Registrar(string nombre, string descripcion)
        {

            u.Nombre = nombre;
            u.Descripcion = descripcion;

            guardado = mu.Existe(u);

            if (guardado == "Existe")
                return "Existe";
            else
            {
                guardado = mu.Registrar(u);
                return guardado;
            }

        }

        public DataSet Consultar()
        {
            DataSet ds = new DataSet();
            ds = mu.Consultar();
            return ds;
        }

        public void Eliminar(int id)
        {

            mu.Eliminar(id);

        }




    }
}
