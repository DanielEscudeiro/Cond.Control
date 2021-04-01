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
using MySql.Data.MySqlClient;
using Cond._Control.Inicio;
using System.Linq.Expressions;

namespace Cond._Control
{
    public partial class Acesso_de_Trabalhador : Form
    {
        public Acesso_de_Trabalhador()
        {
            InitializeComponent();
        }

        conexao con = new conexao();
        int count = 0;

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            Cadastro_de_Trabalhador cadTra = new Cadastro_de_Trabalhador();
            cadTra.btLiberar.Visible = false;
            cadTra.btEncerrar.Visible = false;

            con.conectar();

            if (tbCodigo.Text == "")
            {
                MessageBox.Show("O código de acesso não pode permanecer em branco", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Trabalhador.Codigo = tbCodigo.Text;

                    MySqlCommand com = new MySqlCommand("SELECT Nome, Telefone, Rg, Endereco, Casa, Propietario, Data_Inicio, Data_Fim, Acesso, " +
                        "Tipo_de_Servico, ID FROM tb_trabalhador WHERE Codigo_de_Acesso = ?", con.conn);
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
                        MessageBox.Show("Código de acesso inválido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        con.desconctar();
                    }

                    else
                    {
                        if (count == 1)
                        {
                            Trabalhador.Nome = dr.GetString("Nome");
                            Trabalhador.Telefone = dr.GetString("Telefone");
                            Trabalhador.Rg = dr.GetString("Rg");
                            Trabalhador.Endereco = dr.GetString("Endereco");
                            Trabalhador.Casa = dr.GetString("Casa");
                            Trabalhador.Propietario = dr.GetString("Propietario");
                            Trabalhador.DataInicio = dr.GetString("Data_Inicio");
                            Trabalhador.DataFim = dr.GetString("Data_Fim");
                            Trabalhador.Acesso = dr.GetString("Acesso");
                            Trabalhador.Bloco = dr.GetString("Bloco");
                            Trabalhador.Veiculo = dr.GetString("Placa_do_Veiculo");
                            Trabalhador.TipoServico = dr.GetString("Tipo_de_Servico");
                            Trabalhador.ID = dr.GetString("ID");

                            if (rbEntrada.Checked)
                            {
                                cadTra.BtConfirmar.Visible = false;
                                cadTra.btLiberar.Visible = true;
                                cadTra.btEncerrar.Visible = false;
                                cadTra.Text = "Entrada do trabalhador";

                                cadTra.TbNome.Text = Trabalhador.Nome;
                                cadTra.TbTelefone.Text = Trabalhador.Telefone;
                                cadTra.tbRg.Text = Trabalhador.Rg;
                                cadTra.cbServico.Text = Trabalhador.TipoServico;
                                cadTra.dtInicio.Text = Trabalhador.DataInicio;
                                cadTra.dtFinal.Text = Trabalhador.DataFim;
                                cadTra.cbAcesso.Text = Trabalhador.Acesso;
                                cadTra.TbEndereco.Text = Trabalhador.Endereco;
                                cadTra.TbNum.Text = Trabalhador.Casa;
                                cadTra.TbPropietario.Text = Trabalhador.Propietario;

                                cadTra.TbNome.Enabled = false;
                                cadTra.TbTelefone.Enabled = false;
                                cadTra.tbRg.Enabled = false;
                                cadTra.TbEndereco.Enabled = false;
                                cadTra.TbPropietario.Enabled = false;

                                cadTra.TbNum.Enabled = false;
                                cadTra.cbServico.Enabled = false;
                                cadTra.cbAcesso.Enabled = false;
                                cadTra.dtInicio.Enabled = false;
                                cadTra.dtFinal.Enabled = false;

                                cadTra.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                if (rbSaida.Checked)
                                {
                                    cadTra.BtConfirmar.Visible = false;
                                    cadTra.btLiberar.Visible = false;
                                    cadTra.btEncerrar.Visible = true;
                                    cadTra.Text = "Saída de trabalhador";

                                    cadTra.TbNome.Text = Trabalhador.Nome;
                                    cadTra.TbTelefone.Text = Trabalhador.Telefone;
                                    cadTra.tbRg.Text = Trabalhador.Rg;
                                    cadTra.cbServico.Text = Trabalhador.TipoServico;
                                    cadTra.dtInicio.Text = Trabalhador.DataInicio;
                                    cadTra.dtFinal.Text = Trabalhador.DataFim;
                                    cadTra.TbEndereco.Text = Trabalhador.Endereco;
                                    cadTra.TbNum.Text = Trabalhador.Casa;
                                    cadTra.TbPropietario.Text = Trabalhador.Propietario;

                                    cadTra.TbNome.Enabled = false;
                                    cadTra.TbTelefone.Enabled = false;
                                    cadTra.tbRg.Enabled = false;
                                    cadTra.TbEndereco.Enabled = false;
                                    cadTra.TbPropietario.Enabled = false;

                                    cadTra.TbNum.Enabled = false;                         
                                    cadTra.cbServico.Enabled = false;
                                    cadTra.cbAcesso.Enabled = false;
                                    cadTra.dtInicio.Enabled = false;
                                    cadTra.dtFinal.Enabled = false;

                                    cadTra.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Selecione um evento", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    con.desconctar();
                                }
                            }

                            con.desconctar();

                        }
                        count = 0;
                    }
                    con.desconctar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com banco de dados, " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.desconctar();
                }
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
