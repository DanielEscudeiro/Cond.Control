using MySql.Data.MySqlClient;
using Projeto_2º_Semestre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cond._Control
{
    public partial class Confirmacao_de_Acesso_Saida : Form
    {
        public Confirmacao_de_Acesso_Saida()
        {
            InitializeComponent();
        }

        int count = 0;
        conexao con = new conexao();

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            con.conectar();

            if (tbCodigo.Text == "")
            {
                MessageBox.Show("O código de acesso não pode permanecer em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("SELECT Nome,Telefone, Rg, Endereco, Apartamento, Proprietario, Data, Alteracao, ID FROM tb_controleacesso WHERE Codigo_de_Acesso = ?", con.conn);
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
                        MessageBox.Show("Código de acesso inválido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            Visitantes.propietario = dr.GetString("Proprietario");
                            Visitantes.data = dr.GetString("Data");
                            Visitantes.alteracao = dr.GetString("Alteracao");
                            Visitantes.id = dr.GetString("ID");

                            
                            if (Visitantes.alteracao == "0" || Visitantes.alteracao == "2")
                            {
                                MessageBox.Show("Visita não liberada, ou já realizada", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                count = 0;
                            }
                            else
                            {
                                CadastroVisitante conf = new CadastroVisitante();
                                conf.tbNome.Text = Visitantes.nome;
                                conf.tbRg.Text = Visitantes.rg;
                                conf.tbTelefone.Text = Visitantes.telefone;
                                conf.tbEndereco.Text = Visitantes.endereco;
                                conf.tbNum.Text = Visitantes.apartamento;
                                conf.tbNomeProprietario.Text = Visitantes.propietario;

                                conf.tbNome.Enabled = false;
                                conf.tbRg.Enabled = false;
                                conf.tbTelefone.Enabled = false;
                                conf.tbEndereco.Enabled = false;
                                conf.tbNum.Enabled = false; 
                                conf.tbNomeProprietario.Enabled = false;
                                conf.btCadastrarPortaria.Visible = false;
                                conf.btEncerrar.Visible = true;

                                conf.ShowDialog();
                                this.Close();

                                count = 0;
                                con.desconctar();
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
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

