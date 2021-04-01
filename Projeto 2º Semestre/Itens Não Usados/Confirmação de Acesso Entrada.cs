using MySql.Data.MySqlClient;
using Projeto_2º_Semestre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cond._Control
{
    public partial class Confirmação_de_Acesso_Entrada : Form
    {
        public Confirmação_de_Acesso_Entrada()
        {
            InitializeComponent();
        }
        conexao con = new conexao();
        int count = 0;
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            con.conectar();

            if (tbCodigo.Text == "")
            {
                MessageBox.Show("Codigo de Acesso Não Pode Permanecer em Branco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("SELECT Nome, Telefone, Rg, Endereco, Apartamento, Propietario, Data, Alteracao, ID FROM tb_visitas WHERE Codigo_de_Acesso = ?", con.conn);
                    com.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = tbCodigo.Text;
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MySqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        count++;
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("Codigo de Acesso Invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        con.desconctar();
                    }

                    else
                    {
                        if (count == 1)
                        {
                            Visitantes.nome = dr.GetString("Nome");
                            Visitantes.telefone = dr.GetString("Telefone");
                            Visitantes.rg = dr.GetString("Rg");
                            Visitantes.endereco = dr.GetString("Endereco");
                            Visitantes.apartamento = dr.GetString("Apartamento");
                            Visitantes.propietario = dr.GetString("Propietario");
                            Visitantes.data = dr.GetString("Data");
                            Visitantes.alteracao = dr.GetString("Alteracao");
                            Visitantes.id = dr.GetString("ID");

                            if (Visitantes.alteracao == "1" || Visitantes.alteracao == "2")
                            {
                                MessageBox.Show("Visita já Liberada ou Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                count = 0;
                            }
                            else
                            {
                                if (Visitantes.data == DateTime.Now.ToShortDateString())
                                {
                                    Confirmacao_de_Dados conf = new Confirmacao_de_Dados();
                                    conf.ShowDialog();
                                    this.Close();

                                    count = 0;
                                    con.desconctar();
                                }

                                else
                                {
                                    MessageBox.Show("Não é Possivel Liberar, Visita já realizada ou \n não Agendada para Hoje", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    count = 0;
                                    con.desconctar();
                                }
                            }
                        }
                    }
                    con.desconctar();

                }
                catch (Exception es)
                {
                    MessageBox.Show(" " + es);
                }
            }

        }
    }
}