using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNCDeporte
{
    public static class global
    {
        public static string cadena = "workstation id=krismadb.mssql.somee.com;packet size=4096;user id=nkdiablo_SQLLogin_1;pwd=k2f4wfiebq;data source=krismadb.mssql.somee.com;persist security info=False;initial catalog=krismadb;Connect Timeout=60"; //cadena de hosting, time out 60 segundos. somee.com
        //public static string cadena = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bd_proyecto;Data Source=ADMIN\\SQLEXPRESS"; //cadena de base local martin y anibal
        public static int dni = 0;
        public static string mail = "";
        public static int id_permiso = 0;
        public static int id_perfil = 0;
        public static string nombre = "";
        public static string descripcion = "";
        public static string nombre_perfil = "";
        public static int id_usuario = 0;
        public static string usuario = "";
        public static Boolean guardoLocalidad = false;
        public static Boolean asignarMasPerfiles = false;
        public static int id_localidad = 0;
        public static Boolean eliminar = false;
        public static int documento = 0;
        public static int documentoDeportista = 0;
        public static int id_estado = 0;
        public static int cantidad_participantes = 0;
        public static int id_torneo = 0;
        public static int cantidad_participantes_torneo = 0;
        public static int documentoProfe = 0;
        public static string p1 = "";
        public static string p2 = "";
        public static string p3 = "";
        public static string p4 = "";
        public static string p5 = "";
        public static string p6 = "";
        public static string p7 = "";
        public static string p8 = "";

        public static int docp1 = 0;
        public static int docp2 = 0;
        public static int docp3 = 0;
        public static int docp4 = 0;
        public static int docp5 = 0;
        public static int docp6 = 0;
        public static int docp7 = 0;
        public static int docp8 = 0;

        public static int id_deporte_torneo = 0;

    }
}
