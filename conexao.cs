using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVoluntariado
{
    internal class conexao
    {
        private static string server = @"BOT0713142W11-1";
        private static string database = "Voluntariado";
        private static string user = "sa";
        private static string password = "sasenac";

        public static string IniciarCon
        {
            get 
            {
            return "Data Source=" + server + ";Integrated Security = false ; Initial Catalog="
            + database + ";" + "User ID=" + user + "; Password=" + password;
            }
        }
    }
}
