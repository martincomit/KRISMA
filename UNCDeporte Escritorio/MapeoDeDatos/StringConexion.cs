using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace MapeoDeDatos
{
    public class StringConexion
    {

        public string cadena = "workstation id=krismadb.mssql.somee.com;packet size=4096;user id=nkdiablo_SQLLogin_1;pwd=k2f4wfiebq;data source=krismadb.mssql.somee.com;persist security info=False;initial catalog=krismadb;Connect Timeout=60";
        //public string cadena = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bd_proyecto;Data Source=ADMIN\\SQLEXPRESS";

       

        public String getCadena()
        {
            return cadena;
        }

    }
}
