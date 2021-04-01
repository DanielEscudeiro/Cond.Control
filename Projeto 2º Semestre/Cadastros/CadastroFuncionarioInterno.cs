using Cond._Control.Inicio;
using MySql.Data.MySqlClient;
using Projeto_2º_Semestre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cond._Control
{
    public partial class CadastroFuncionarioInterno : Form
    {
        conexao con = new conexao();
        public CadastroFuncionarioInterno()
        {
            InitializeComponent();
        }
        int TamanhoDaSenha = 8;
        string senhaPorteiro;
        private DataSet4 relDs4 = null;
        private DataSet4TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter = null;

        private void FormatarTela()
        {
            this.tbNome.Clear();
            this.tbTelefone.Clear();
            this.tbRg.Clear();
            this.tbCpf.Clear();
            this.tbEndereco.Clear();
            this.tbNum.Clear();
            this.tbEmail.Clear();
            this.cmbFuncao.Text = "";
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

        bool validaCPF()
        {
            if (tbCpf.Text.Length.Equals(14))
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

        //Realiza Cadastro de Funcionario e (Usuario -> Porteiro)
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            con.conectar();
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

                else if (validaCPF() == false)
                {
                    MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCpf.Focus();
                }

                else if (String.IsNullOrEmpty(cmbFuncao.Text))
                {
                    MessageBox.Show("A Função é obrigatória", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbFuncao.Focus();
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

                else if (!(tbEmail.Text.Contains("@") && tbEmail.Text.Contains(".com") || tbEmail.Text.Contains(".")))
                {
                    MessageBox.Show("O E-mail é inválido, por favor tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    //Verifica se já Existe um Cadastro com o Email informado

                    int count = 0;

                    MySqlCommand com = new MySqlCommand("SELECT Email, RG, CPF FROM tb_funcionariointerno WHERE Email = ? And Rg = ? And CPF = ?", con.conn);
                    com.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = tbEmail.Text;
                    com.Parameters.Add("@Rg", MySqlDbType.VarChar, 45).Value = tbRg.Text;
                    com.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = tbCpf.Text;

                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MySqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("Email já cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbEmail.Focus();
                        con.desconctar();
                        return;
                    }
                    if (count == 0)
                    {
                        try
                        {
                            con.desconctar();
                            con.conectar();

                            MySqlCommand dbcomand = new MySqlCommand("insert into tb_funcionariointerno (Nome, RG, CPF, Endereco, Funcao, NumeroCasa, Telefone, Email)" +
                                    " values(?, ?, ?, ?, ?, ?, ?, ?)", con.conn);
                            dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = tbNome.Text;
                            dbcomand.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRg.Text;
                            dbcomand.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = tbCpf.Text;
                            dbcomand.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = tbEndereco.Text;
                            dbcomand.Parameters.Add("@Funcao", MySqlDbType.VarChar, 45).Value = cmbFuncao.Text;
                            dbcomand.Parameters.Add("@NumeroCasa", MySqlDbType.VarChar, 45).Value = tbNum.Text;
                            dbcomand.Parameters.Add("@Telefone", MySqlDbType.VarChar, 45).Value = tbTelefone.Text;
                            dbcomand.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = tbEmail.Text;

                            dbcomand.ExecuteNonQuery();
                            MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            con.desconctar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao cadastrar o funcionário! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    count = 0;
                }

                // Verifica Se ele sera Cadastrado Como Porteiro no Sistema (Se Sim Realiza o Cadastro de Usuario Dele)

                if (cmbFuncao.Text == "Porteiro")
                {
                    //Gera a Senha de Acesso do Sistema Para O Porteiro
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

                        senhaPorteiro = strbld.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gerar a Senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Cadastra o Funcionario Interno Como Porteiro Na Tabela tb_Usuarios para Acesso ao Sistema
                    con.desconctar();
                    con.conectar();
                    int count = 0;

                    MySqlCommand com = new MySqlCommand("SELECT Id FROM tb_funcionariointerno WHERE CPF = ?", con.conn);

                    com.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = tbCpf.Text;

                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MySqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        FuncionarioInterno.ID = dr.GetString("Id");
                        con.desconctar();

                        con.conectar();

                        MySqlCommand dbcomand2 = new MySqlCommand("insert into tb_usuarios (Nome, Cod_Funcionario, Usuario, Senha, Nivel_Acesso, Acesso)" +
                            " values(?, ?, ?, ?, ?, ?)", con.conn);

                        dbcomand2.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = tbNome.Text;
                        dbcomand2.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                        dbcomand2.Parameters.Add("@Usuario", MySqlDbType.VarChar, 45).Value = tbEmail.Text;
                        dbcomand2.Parameters.Add("@Senha", MySqlDbType.VarChar, 45).Value = senhaPorteiro;
                        dbcomand2.Parameters.Add("@Nivel_Acesso", MySqlDbType.VarChar, 45).Value = "Porteiro";
                        dbcomand2.Parameters.Add("@Acesso", MySqlDbType.VarChar, 45).Value = "Liberado";

                        dbcomand2.CommandType = CommandType.Text;
                        dbcomand2.ExecuteNonQuery();

                        //Envio de Email com as Credenciais de acesso ao Sistema

                        SmtpClient cliente = new SmtpClient();
                        NetworkCredential credenciais = new NetworkCredential();

                        //definir as configurações do cliente

                        cliente.Host = "smtp.gmail.com";
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                        cliente.UseDefaultCredentials = false;

                        //definir credenciais de acesso ao email

                        credenciais.UserName = "noreply.condcontrol@gmail.com";
                        credenciais.Password = "UniToledo";

                        //define as credenciais do cliente

                        cliente.Credentials = credenciais;

                        //preparar a mensagem enviar

                        MailMessage mensagem = new MailMessage();
                        mensagem.From = new MailAddress("noreply.condcontrol@gmail.com", "Não responda essa mensagem. (Sistema CondControl)");
                        mensagem.Subject = "Cadastro CondControl";
                        mensagem.Body = "Olá, " + tbNome.Text + " Seja bem-vindo ao sistema CondControl! \n" + "segue seu usuário e senha para acesso ao sistema!" + "\n\n" + "Usuário: " + tbEmail.Text +
                            "\n" + "Senha: " + senhaPorteiro + "\n\n" + "Orientamos que faça a alteração da senha quando acessar o sistema!" + "\n\n\n" + "Atenciosamente! \nCondControl";
                        mensagem.To.Add(tbEmail.Text);

                        //envio da mensagem de email

                        cliente.Send(mensagem);
                        MessageBox.Show("Usuario cadastrado com sucesso, foi enviado um E-mail contendo a senha e seu usuário para acesso ao sistema", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormatarTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.desconctar();
        }


        /*__________________________________________________________________________*/

        // Realiza a Entrada no Inicio do Expediente
        private void btEntradaManha_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;

                con.conectar();

                MySqlCommand com = new MySqlCommand("SELECT Cod_Funcionario, Data FROM tb_pontofuncionario WHERE Cod_Funcionario = ? And Data = ?", con.conn);
                com.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                com.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    try
                    {
                        con.desconctar();
                        con.conectar();

                        MySqlCommand dbcomand = new MySqlCommand("insert into tb_pontofuncionario (Cod_Funcionario, Data, Hora_de_Entrada_Manha, Controle)" +
                           " values(?, ?, ?, ?)", con.conn);

                        dbcomand.Parameters.Add("@Cod_Funcionario", MySqlDbType.Int32).Value = FuncionarioInterno.ID;
                        dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();
                        dbcomand.Parameters.Add("@Hora_de_Entrada_Manha", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToLongTimeString();
                        dbcomand.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 1;

                        dbcomand.ExecuteNonQuery();

                        if (DialogResult.OK == MessageBox.Show("Entrada de funcionário realizada com sucesso", "Sucesso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            con.desconctar();
                            FormatarTela();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao realizar a entrada: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.desconctar();
                    }
                }
                if (count == 1)
                {
                    MessageBox.Show("O funcionário já possui entrada para hoje", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.desconctar();
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a entrada: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Realiza a Saida para o Horario de Refeição
        private void btEncerrarManha_Click(object sender, EventArgs e)
        {
            con.conectar();
            try
            {
                int count = 0;

                MySqlCommand com = new MySqlCommand("SELECT Cod_Funcionario, Controle, Data FROM tb_pontofuncionario WHERE Cod_Funcionario = ? And Controle = ? And Data = ?", con.conn);
                com.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                com.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 1;
                com.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    try
                    {
                        con.desconctar();
                        con.conectar();

                        MySqlCommand dbcomand = new MySqlCommand("Update tb_pontofuncionario set Hora_de_Saida_Manha = ?, Controle = ? where Cod_Funcionario = ? And Data = ?", con.conn);

                        dbcomand.Parameters.Add("@Hora_de_Saida_Manha", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToLongTimeString();
                        dbcomand.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 2;
                        dbcomand.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                        dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                        dbcomand.CommandType = CommandType.Text;
                        dbcomand.ExecuteNonQuery();

                        if (DialogResult.OK == MessageBox.Show("Saída de funcionário realizada com sucesso", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            con.desconctar();
                            FormatarTela();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao realizar a atualização no banco de dados " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.desconctar();
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("O funcionário já saiu para refeição hoje", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.desconctar();
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a saída da refeição " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Realiza a Entrada depois do Horario de Refeição
        private void btLiberarTarde_Click(object sender, EventArgs e)
        {
            con.conectar();
            try
            {
                int count = 0;

                MySqlCommand com = new MySqlCommand("SELECT Cod_Funcionario, Controle, Data FROM tb_pontofuncionario WHERE Cod_Funcionario = ? And Controle = ? And Data = ?", con.conn);
                com.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                com.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 2;
                com.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    try
                    {
                        con.desconctar();
                        con.conectar();

                        MySqlCommand dbcomand = new MySqlCommand("Update tb_pontofuncionario set Hora_de_Entrada_Tarde = ?,Controle = ? where Cod_Funcionario = ? And Data = ?", con.conn);

                        dbcomand.Parameters.Add("@Hora_de_Entrada_Tarde", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToLongTimeString();
                        dbcomand.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 3;
                        dbcomand.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                        dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                        dbcomand.CommandType = CommandType.Text;
                        dbcomand.ExecuteNonQuery();

                        if (DialogResult.OK == MessageBox.Show("Entrada de funcionário realizada com sucesso", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            con.desconctar();
                            FormatarTela();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao realizar a atualização no banco de dados " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.desconctar();
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("O funcionário já possui entrada após a refeição para hoje", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.desconctar();
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a atualização no banco de dados " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.desconctar();
            }
        }

        // Realiza a Saida Fim do Expediente
        private void btEncerrarTarde_Click(object sender, EventArgs e)
        {
            con.conectar();

            try
            {
                int count = 0;

                MySqlCommand com = new MySqlCommand("SELECT Cod_Funcionario, Controle, Data FROM tb_pontofuncionario WHERE Cod_Funcionario = ? And Controle = ? And Data = ?", con.conn);
                com.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                com.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 3;
                com.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString(); ;

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    con.desconctar();
                    con.conectar();

                    try
                    {
                        MySqlCommand dbcomand = new MySqlCommand("Update tb_pontofuncionario set Hora_de_Saida_Tarde = ?, Controle = ? where Cod_Funcionario = ? And Data = ?", con.conn);

                        dbcomand.Parameters.Add("@Hora_de_Saida_Tarde", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToLongTimeString();
                        dbcomand.Parameters.Add("@Controle", MySqlDbType.VarChar, 45).Value = 4;
                        dbcomand.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;
                        dbcomand.Parameters.Add("@Data", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToShortDateString();

                        dbcomand.CommandType = CommandType.Text;
                        dbcomand.ExecuteNonQuery();

                        if (DialogResult.OK == MessageBox.Show("Saída de funcionário realizada com sucesso", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            con.desconctar();
                            FormatarTela();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao realizar a atualização no banco de dados " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.desconctar();
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("O funcionário já encerrou o expediente para o dia de hoje", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.desconctar();
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a atualização no banco de dados " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.desconctar();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            con.desconctar();
            con.conectar();

            try
            {
                MySqlCommand dbcomand = new MySqlCommand("Update tb_funcionariointerno set Nome = ?, RG = ?, CPF = ?, Endereco = ?, Funcao = ?, NumeroCasa = ?, Telefone = ?, Email = ? Where Id = ?", con.conn);

                dbcomand.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = tbNome.Text;
                dbcomand.Parameters.Add("@RG", MySqlDbType.VarChar, 45).Value = tbRg.Text;
                dbcomand.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = tbCpf.Text;
                dbcomand.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = tbEndereco.Text;
                dbcomand.Parameters.Add("@Funcao", MySqlDbType.VarChar, 45).Value = cmbFuncao.Text;
                dbcomand.Parameters.Add("@NumeroCasa", MySqlDbType.VarChar, 45).Value = tbNum.Text;
                dbcomand.Parameters.Add("@Telefone", MySqlDbType.VarChar, 45).Value = tbTelefone.Text;
                dbcomand.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = tbEmail.Text;
                dbcomand.Parameters.Add("@Id", MySqlDbType.VarChar, 45).Value = FuncionarioInterno.ID;

                dbcomand.CommandType = CommandType.Text;
                dbcomand.ExecuteNonQuery();

                if (DialogResult.OK == MessageBox.Show("Cadastro de funcionário atualizado com sucesso", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    con.desconctar();
                    FormatarTela();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a atualização no banco de dados " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.desconctar();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
