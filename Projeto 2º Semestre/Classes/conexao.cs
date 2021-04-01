using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2º_Semestre
{
    public class conexao
    {
       public  MySqlConnection conn = new MySqlConnection();

        public conexao()
        {
            conn.ConnectionString = @"server=127.0.0.1;port=3306;User Id= condcontrol; database= Condominio; password= condcontrol2020";


        }
        public MySqlConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();

            }
            return conn;
        }
        public void  desconctar()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
