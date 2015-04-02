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

        public string cadena = "workstation id=krismadb.mssql.somee.com;packet size=4096;user id=nkdiablo_SQLLogin_1;pwd=k2f4wfiebq;data source=krismadb.mssql.somee.com;persist security info=False;initial catalog=krismadb";
        public string cadena2 = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=bd_proyecto;Integrated Security=True";

        public String getCadena()
        {
            return cadena;
        }

    }
}
