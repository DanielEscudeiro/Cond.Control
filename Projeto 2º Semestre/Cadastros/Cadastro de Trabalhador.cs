using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cond._Control.Inicio;
using MySql.Data.MySqlClient;
using Projeto_2º_Semestre;

namespace Cond._Control
{
    public partial class Cadastro_de_Trabalhador : Form
    {
        conexao con = new conexao();
        public Cadastro_de_Trabalhador()
        {
            InitializeComponent();

            btEncerrar.Visible = false;
            btLiberar.Visible = false;
        }
        int TamanhoDaSenha = 8;
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
        private void BtConfirmar_Click(object sender, EventArgs e)
        {

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

            try
            {
                TimeSpan dias = dtFinal.Value - dtInicio.Value;

                con.conectar();

                MySqlCommand dbcomand = new MySqlCommand("insert into tb_trabalhador (Nome, Telefone, RG, Tipo_de_Servico, Porteiro_Responsavel_Cadastro, Data_Inicio, Data_Fim, Acesso, Endereco, Casa, Propietario, Codigo_de_Acesso)" +
                    " values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con.conn);

                dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = TbNome.Text;
                dbcomand.Parameters.Add("@Telefone", MySqlDbType.VarChar, 45).Value = TbTelefone.Text;
                dbcomand.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRg.Text;
                dbcomand.Parameters.Add("@Tipo_de_Servico", MySqlDbType.VarChar, 45).Value = cbServico.Text;
                dbcomand.Parameters.Add("@Porteiro_Responsavel_Cadastro", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                dbcomand.Parameters.Add("@Data_Inicio", MySqlDbType.VarChar, 45).Value = dtInicio.Value.ToShortDateString();
                dbcomand.Parameters.Add("@Data_Fim", MySqlDbType.VarChar, 45).Value = dtFinal.Value.ToShortDateString();
                dbcomand.Parameters.Add("@Acesso", MySqlDbType.VarChar, 45).Value = cbAcesso.Text;
                dbcomand.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = TbEndereco.Text;
                dbcomand.Parameters.Add("@Casa", MySqlDbType.VarChar, 45).Value = TbNum.Text;
                dbcomand.Parameters.Add("@Propietario", MySqlDbType.VarChar, 45).Value = TbPropietario.Text;
                dbcomand.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = codigoTra;


                dbcomand.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Código do trabalhador: " + codigoTra, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            con.desconctar();
        }

        private void btLiberar_Click(object sender, EventArgs e)
        {
            con.conectar();
            try
            {

                MySqlCommand dbcomand = new MySqlCommand("insert into tb_trabalhadores (Nome, Telefone, RG, Placa_do_Veiculo, Tipo_de_Servico," +
                    " Endereco, Bloco, Casa, Propietario, Data, Hora_Entrada, Porteiro_Responsavel_Entrada, Codigo_de_Acesso)" +
                    " values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con.conn);
                dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = Trabalhador.Nome;
                dbcomand.Parameters.Add("@Telefone", MySqlDbType.VarChar, 45).Value = Trabalhador.Telefone;
                dbcomand.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = Trabalhador.Rg;
                dbcomand.Parameters.Add("@Placa_do_Veiculo", MySqlDbType.VarChar, 45).Value = Trabalhador.Veiculo;
                dbcomand.Parameters.Add("@Tipo_de_Servico", MySqlDbType.VarChar, 45).Value = Trabalhador.Veiculo;
                dbcomand.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = Trabalhador.Endereco;
                dbcomand.Parameters.Add("@Bloco", MySqlDbType.VarChar, 45).Value = Trabalhador.Bloco;
                dbcomand.Parameters.Add("@Casa", MySqlDbType.VarChar, 45).Value = Trabalhador.Casa;
                dbcomand.Parameters.Add("@Propietario", MySqlDbType.VarChar, 45).Value = Trabalhador.Propietario;
                dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();
                dbcomand.Parameters.Add("@Hora_Entrada", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToLongTimeString();
                dbcomand.Parameters.Add("@Porteiro_Responsavel_Entrada", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                dbcomand.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = Trabalhador.Codigo;

                dbcomand.ExecuteNonQuery();

                MessageBox.Show("Trabalhador liberado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.desconctar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            con.desconctar();
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {
            con.conectar();
            try
            {
                MySqlCommand dbcomand = new MySqlCommand("Update tb_trabalhadores set Hora_Saida = ?, Porteiro_Responsavel_Saida = ? where Codigo_de_Acesso = ? And Data = ?", con.conn);

                dbcomand.Parameters.Add("@Hora_Saida", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToLongTimeString();
                dbcomand.Parameters.Add("@Porteiro_Responsavel_Saida", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                dbcomand.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = Trabalhador.Codigo;
                dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                dbcomand.CommandType = CommandType.Text;
                dbcomand.ExecuteNonQuery();

                if (DialogResult.OK == MessageBox.Show("Saída do trabalhador finalizada com sucesso", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    con.desconctar();
                    this.Close();
                }
                con.desconctar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                con.desconctar();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
