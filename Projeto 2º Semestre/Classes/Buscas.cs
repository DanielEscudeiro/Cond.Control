using MySql.Data.MySqlClient;
using Projeto_2º_Semestre;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond._Control.Inicio
{
  public class Buscas
    {
        #region Consultar
         conexao con = new conexao();
        public DataTable Buscarfuncionario(string Rg)
        {
            string mysql = @"select * from vw_join_ponto  where Rg = @Rg";

            MySqlCommand executar = new MySqlCommand(mysql, con.conn);
            executar.Parameters.AddWithValue("@Rg", Rg);

            con.conectar();
            executar.ExecuteNonQuery();

            DataTable tabelaponto = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(executar);

            da.Fill(tabelaponto);
            con.desconctar();
            return tabelaponto;
        }
        #endregion

        public DataTable BuscarTodosAcessos()
        {
            string mysql = @"select * from tb_usuarios";

            MySqlCommand executar = new MySqlCommand(mysql, con.conn);
            
            con.conectar();
            executar.ExecuteNonQuery();

            DataTable tabelaponto = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(executar);

            da.Fill(tabelaponto);
            con.desconctar();
            return tabelaponto;
        }

    }
}
