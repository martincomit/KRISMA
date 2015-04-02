using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Horario
    {
        private int id_horario;
        private string hora;
        private string minuto;

        public int Id_horario
        {
            get { return id_horario; }
            set { id_horario = value; }
        }
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public string Minuto
        {
            get { return minuto; }
            set { minuto = value; }
        }
        public Horario()
        {
            this.id_horario = 1;
            this.hora = "";
            this.minuto = "";
        }

        public Horario(int id_horario, string hora, string minuto)
        {
            this.id_horario = id_horario;
            this.hora = hora;
            this.minuto = minuto;
        }

    }
}
