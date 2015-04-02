using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public static class global
    {
        public static int dni=0;
        public static string mail = "";
        public static int id_permiso = 0;
        public static int id_perfil = 0;
        public static string nombre = "";
        public static string descripcion = "";
        public static string nombre_perfil = "";
        public static int id_usuario = 0;
        public static string usuario = "";
        public static int id_unidad = 0;
        public static int id_localidad = 0;
        public static int id_condicion = 0;
        public static int documento_deportista = 0;
        public static Boolean sesion = false; //si vene con sesion o no. para el consultar estado
        public static int master = 1;
        //autogestion 1 consultar estado 2 eventos 3 torneos 4 cet 5

    }

}
