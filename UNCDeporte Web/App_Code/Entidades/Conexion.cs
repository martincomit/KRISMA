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
        public DataRow drow;

        //public string bd = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\cambios\\Base de Datos\\bd_proyecto.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True";
        public string str_sql;
        public string str_sql2;
        public string str_sql3;
        public string str_sql4;

        public SqlDataAdapter da;
        public SqlDataReader dr1;
        public SqlDataReader dr2;
        public SqlDataReader dr3;
        public SqlCommand cmd;
        public SqlCommand cmd2;
        public SqlCommand cmd3;
        public SqlCommand cmd4;





        public Conexion()
        {
            //this.origen = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\cambios\\Base de Datos\\bd_proyecto.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True;MultipleActiveResultSets=True");            
            this.origen = new SqlConnection("workstation id=krismadb.mssql.somee.com;packet size=4096;user id=nkdiablo_SQLLogin_1;pwd=k2f4wfiebq;data source=krismadb.mssql.somee.com;persist security info=False;initial catalog=krismadb");
            this.origen = new SqlConnection("Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=bd_proyecto;Integrated Security=True");
            this.ds = null;
            this.dt = null;
            this.str_sql = "";
            this.str_sql2 = "";
            this.str_sql3 = "";
            this.str_sql4 = "";
            this.da = null;
            this.dr1 = null;
            this.dr2 = null;
            this.dr3 = null;
            this.cmd = null;
            this.cmd2 = null;
            this.cmd3 = null;
            this.cmd4 = null;
            this.drow = null;

        }

    }
}
