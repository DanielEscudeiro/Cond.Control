using Cond._Control.Inicio;
using MySql.Data.MySqlClient;
using Projeto_2º_Semestre;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cond._Control
{
    public partial class Acesso_Funcionario : Form
    {
        public Acesso_Funcionario()
        {
            InitializeComponent();
        }

        int count = 0;
        conexao con = new conexao();
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                con.conectar();

                MySqlCommand com = new MySqlCommand("SELECT Nome, RG, Id, CPF, Funcao, Endereco, NumeroCasa, Telefone, Email FROM tb_funcionariointerno WHERE RG = ?", con.conn);
                com.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRG.Text;

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    MessageBox.Show("RG inválido ou não cadastrado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.desconctar();
                }

                else
                {
                    if (count == 1)
                    {
                        FuncionarioInterno.Nome = dr.GetString("Nome");
                        FuncionarioInterno.RG = dr.GetString("Rg");
                        FuncionarioInterno.CPF = dr.GetString("CPF");
                        FuncionarioInterno.ID = dr.GetString("Id");
                        FuncionarioInterno.Funcao = dr.GetString("Funcao");
                        FuncionarioInterno.Telefone = dr.GetString("Telefone");
                        FuncionarioInterno.Endereco = dr.GetString("Endereco");
                        FuncionarioInterno.Numero = dr.GetString("NumeroCasa");
                        FuncionarioInterno.Email = dr.GetString("Email");

                       CadastroFuncionarioInterno acesso = new CadastroFuncionarioInterno();

                        acesso.tbNome.Text = FuncionarioInterno.Nome;
                        acesso.tbTelefone.Text = FuncionarioInterno.Telefone;
                        acesso.tbRg.Text = FuncionarioInterno.RG;
                        acesso.tbCpf.Text = FuncionarioInterno.CPF;
                        acesso.tbEndereco.Text = FuncionarioInterno.Endereco;
                        acesso.tbNum.Text = FuncionarioInterno.Numero;
                        acesso.tbEmail.Text = FuncionarioInterno.Email;
                        acesso.cmbFuncao.Text = FuncionarioInterno.Funcao;


                        if (rbEntrada.Checked)
                        {
                            acesso.btCadastrar.Visible = false;
                            acesso.btLiberarTarde.Visible = false;
                            acesso.btEncerrarTarde.Visible = false;
                            acesso.btEncerrarManha.Visible = false;

                            acesso.Text = "Entrada de funcionário";

                            acesso.ShowDialog();
                            tbRG.Clear();
                            con.desconctar();
                        }
                        else
                        {
                            if (rbSaidaRefeicao.Checked)
                            {
                                acesso.btCadastrar.Visible = false;
                                acesso.btLiberarTarde.Visible = false;
                                acesso.btEncerrarTarde.Visible = false;
                                acesso.btLiberarManha.Visible = false;

                                acesso.Text = "Saída de funcionário";

                                acesso.ShowDialog();
                                tbRG.Clear();

                                con.desconctar();
                            }
                            else
                            {
                                if (rbEntradaTarde.Checked)
                                {
                                    acesso.btCadastrar.Visible = false;
                                    acesso.btEncerrarManha.Visible = false;
                                    acesso.btEncerrarTarde.Visible = false;
                                    acesso.btLiberarManha.Visible = false;

                                    acesso.Text = "Entrada de funcionário";

                                    acesso.ShowDialog();
                                    tbRG.Clear();

                                    con.desconctar();
                                }
                                else
                                {
                                    if (rbSaidaTarde.Checked)
                                    {
                                        acesso.btCadastrar.Visible = false;
                                        acesso.btEncerrarManha.Visible = false;
                                        acesso.btLiberarTarde.Visible = false;
                                        acesso.btLiberarManha.Visible = false;

                                        acesso.Text = "Saída de funcionário";

                                        acesso.ShowDialog();
                                        tbRG.Clear();

                                        con.desconctar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Um evento deve ser selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con.desconctar();
                                    }
                                    con.desconctar();
                                }
                            }
                        }
                    }
                }
                count = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com banco de dados, " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.desconctar();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

