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
    public partial class CadastroVisitante : Form
    {
        conexao con = new conexao();
        public CadastroVisitante()
        {
            InitializeComponent();
        }

        int TamanhoDaSenha = 8;

        private void FormatarTela()
        {
            this.tbNome.Clear();
            this.tbRg.Clear();
            this.tbTelefone.Clear();
            this.tbEndereco.Clear();
            this.tbNum.Clear();
            this.tbNomeProprietario.Clear();
            this.tbNome.Focus();
        }

        private void ValidaTamanhoSenha()
        {
            if (!string.IsNullOrWhiteSpace("6"))
            {
                TamanhoDaSenha = 6;
                if (TamanhoDaSenha > 99)
                {
                    TamanhoDaSenha = 99;
                }
                if (TamanhoDaSenha < 8)
                {
                    TamanhoDaSenha = 6;
                }
            }
        }
        string codigoTra;
        private void btCadastroPortaria_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(tbNome.Text))
                {
                    MessageBox.Show("O Nome do visitante é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNome.Focus();
                }

                else if (tbTelefone.MaskCompleted.Equals(false))
                {
                    MessageBox.Show("O Número do celular é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbTelefone.Focus();
                }

                else if (tbRg.MaskCompleted.Equals(false))
                {
                    MessageBox.Show("O Número do RG é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRg.Focus();
                }

                else if (String.IsNullOrEmpty(tbEndereco.Text))
                {
                    MessageBox.Show("O Endereço é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEndereco.Focus();
                }

                else if (String.IsNullOrEmpty(tbNum.Text))
                {
                    MessageBox.Show("O Número do endereço é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNum.Focus();
                }


                if (String.IsNullOrEmpty(tbNomeProprietario.Text))
                {
                    MessageBox.Show("O Nome do proprietário é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNomeProprietario.Focus();
                }

                else
                {
                    con.conectar();

                    ValidaTamanhoSenha();
                    string validar = "abcd1234567890";
                    try
                    {
                        StringBuilder strbld = new StringBuilder(100);
                        Random random = new Random();
                        while (0 < TamanhoDaSenha--)
                        {
                            strbld.Append(validar[random.Next(validar.Length)]);
                        }
                        codigoTra = strbld.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Salvar na tabela: tb_controleacesso
                    MySqlCommand dbcomand = new MySqlCommand("insert into tb_controleacesso (Nome, Data, Telefone, Rg, Endereco, Apartamento, Proprietario, " +
                        "Hora_de_Entrada, Porteiro_Responsavel_Entrada, Alteracao, Codigo_de_Acesso)" +
                    " values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con.conn);

                    dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = tbNome.Text;
                    dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();
                    dbcomand.Parameters.Add("@Telefone", MySqlDbType.VarChar, 45).Value = tbTelefone.Text;
                    dbcomand.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRg.Text;
                    dbcomand.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = tbEndereco.Text;
                    dbcomand.Parameters.Add("@Apartamento", MySqlDbType.VarChar, 45).Value = tbNum.Text;
                    dbcomand.Parameters.Add("@Proprietario", MySqlDbType.VarChar, 45).Value = tbNomeProprietario.Text;
                    dbcomand.Parameters.Add("@Hora_de_Entrada", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToString();
                    dbcomand.Parameters.Add("@Porteiro_Responsavel_Entrada", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                    dbcomand.Parameters.Add("@Alteracao", MySqlDbType.VarChar, 45).Value = 1; //1 = significa que entrou e o 2 significa que ele saiu
                    dbcomand.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = codigoTra;

                    dbcomand.ExecuteNonQuery();

                    con.desconctar();
                   
                    MessageBox.Show("O Visitante foi cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Codigo do Visitante: " + codigoTra, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormatarTela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com o banco de dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.desconctar();
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {

            if (Visitantes.alteracao == "1")
            {
                con.conectar();

                MySqlCommand dbcomand = new MySqlCommand("Update tb_controleacesso set Hora_de_Saida = ?, Porteiro_Responsavel_Saida = ?, Alteracao = ?,  Codigo_de_Acesso = ? where ID = ?", con.conn);
                dbcomand.Parameters.Add("@Hora_de_Saida", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToString();
                dbcomand.Parameters.Add("@Porteiro_Responsavel_Saida", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                dbcomand.Parameters.Add("@Alteracao", MySqlDbType.VarChar, 45).Value = 2;
                dbcomand.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = "00000";
                dbcomand.Parameters.Add("@ID", MySqlDbType.Int32).Value = Visitantes.id;

                dbcomand.CommandType = CommandType.Text;
                dbcomand.ExecuteNonQuery();


                if (DialogResult.OK == MessageBox.Show("Visita encerrada com sucesso", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    con.desconctar();
                    this.Close();
                }
                con.desconctar();
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
