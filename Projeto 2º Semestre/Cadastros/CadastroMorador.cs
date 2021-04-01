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
    public partial class CadastroMorador : Form
    {
        conexao con = new conexao();
        public CadastroMorador()
        {
            InitializeComponent();
        }

        private void FormatarTela()
        {
            this.tbNome.Clear();
            this.tbTelefone.Clear();
            this.tbRg.Clear();
            this.tbCpf.Clear();
            this.tbEndereco.Clear();
            this.tbNum.Clear();
            this.tbEmail.Clear();

            this.tbNome.Focus();
        }

        bool validaCPF()
        {
            if(tbCpf.Text.Length.Equals(14))
            {
                int n1 = Convert.ToInt16(tbCpf.Text.Substring(0, 1));
                int n2 = Convert.ToInt16(tbCpf.Text.Substring(1, 1));
                int n3 = Convert.ToInt16(tbCpf.Text.Substring(2, 1));
                int n4 = Convert.ToInt16(tbCpf.Text.Substring(4, 1));
                int n5 = Convert.ToInt16(tbCpf.Text.Substring(5, 1));
                int n6 = Convert.ToInt16(tbCpf.Text.Substring(6, 1));
                int n7 = Convert.ToInt16(tbCpf.Text.Substring(8, 1));
                int n8 = Convert.ToInt16(tbCpf.Text.Substring(9, 1));
                int n9 = Convert.ToInt16(tbCpf.Text.Substring(10, 1));

                int n10 = Convert.ToInt16(tbCpf.Text.Substring(12, 1));
                int n11 = Convert.ToInt16(tbCpf.Text.Substring(13, 1));


                if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                {
                    return false;
                }

                else
                {
                    int Soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                    // Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador1 = Soma1 % 11;

                    // Verificar se o valor obtido é menor que dois ou maior
                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    // Soma todos os números multiplicados
                    int Soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

                    // Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador2 = Soma2 % 11;

                    // Verificar se o valor obtido é menor ou maior que 2
                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se os dois dígitos são iguais aos do CPF digitado na maskedTextBox
                    if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }                
            }
            else
            {
                return false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            con.conectar();

            int count = 0;

            //Verifica se o e-mail já está cadastrado na tb_morador.
            MySqlCommand repetidos = new MySqlCommand("SELECT Email, RG, CPF FROM tb_morador WHERE Email = ? or RG = ? or CPF = ?", con.conn); 
            repetidos.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = tbEmail.Text;
            repetidos.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRg.Text;
            repetidos.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = tbCpf.Text;

            repetidos.CommandType = CommandType.Text;
            repetidos.ExecuteNonQuery();
            MySqlDataReader Repetidos = repetidos.ExecuteReader();

            while (Repetidos.Read())
            {
                count++;
            }

            con.desconctar();

            try
            {
                if (String.IsNullOrEmpty(tbNome.Text))
                {
                    MessageBox.Show("O Nome é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                else if (tbCpf.MaskCompleted.Equals(false))
                {
                    MessageBox.Show("O Número do CPF é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCpf.Focus();
                }

                else if(validaCPF() == false)
                {
                    MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCpf.Focus();
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

                else if (String.IsNullOrEmpty(tbEmail.Text))
                {
                    MessageBox.Show("O E-mail é obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                }

                else if (count.Equals(1))
                {
                    MessageBox.Show("O E-mail, RG ou CPF já foi cadastrado no sistema, por favor tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.desconctar();
                }

                else if (!(tbEmail.Text.Contains("@") && tbEmail.Text.Contains(".com")))
                {
                    MessageBox.Show("O E-mail é inválido, por favor tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbEmail.Focus();
                }

                else
                {
                    con.conectar();

                    //Salvar na tabela: tb_morador
                    MySqlCommand dbcomand = new MySqlCommand("insert into tb_morador (Nome, RG, CPF, Telefone, Email, Endereco, NumeroCasa)" + 
                    " values(?, ?, ?, ?, ?, ?, ?)", con.conn);

                    dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = tbNome.Text;
                    dbcomand.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRg.Text;
                    dbcomand.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = tbCpf.Text;
                    dbcomand.Parameters.Add("@Telefone", MySqlDbType.VarChar, 45).Value = tbTelefone.Text;
                    dbcomand.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = tbEmail.Text;
                    dbcomand.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = tbEndereco.Text;
                    dbcomand.Parameters.Add("@NumeroCasa", MySqlDbType.VarChar, 45).Value = tbNum.Text;

                    dbcomand.ExecuteNonQuery();
                    con.desconctar();

                    MessageBox.Show("O Morador foi cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormatarTela();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.desconctar();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
