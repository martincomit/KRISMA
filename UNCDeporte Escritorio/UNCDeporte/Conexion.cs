using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MapeoDeDatos
{
    public class Conexion
    {        
        public SqlConnection origen;
        public DataSet ds;
        public DataTable dt;

        //public string bd = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\cambios\\Base de Datos\\bd_proyecto.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True";
        public string str_sql;

        public SqlDataAdapter da;
        public SqlDataReader dr1;
        public SqlDataReader dr2;
        public SqlDataReader dr3;
        public SqlCommand cmd;
        //public SqlCommand cmd2;



        public Conexion()
        {
         
            this.origen = new SqlConnection("workstation id=krismadb.mssql.somee.com;packet size=4096;user id=nkdiablo_SQLLogin_1;pwd=k2f4wfiebq;data source=krismadb.mssql.somee.com;persist security info=False;initial catalog=krismadb;Connect Timeout=60");
            this.ds = null;
            this.dt = null;
            this.str_sql = "";
            this.da = null;
            this.dr1 = null;
            this.dr2 = null;
            this.dr3 = null;
            this.cmd = null;
            //this.cmd2 = null;
        }

    }
}
