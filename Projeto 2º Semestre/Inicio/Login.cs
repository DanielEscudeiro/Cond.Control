using Cond._Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

namespace Projeto_2º_Semestre
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            TbUsuario.Focus();
        }
        // inicio da função que permite movimentar a tela 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // fim da função que permite movimentar a tela

        conexao con = new conexao();
        int count = 0;
        int acess = 0;


        private void BtEntar_Click(object sender, EventArgs e)
        {
            con.conectar();

            if (TbSenha.Text == "" || TbUsuario.Text == "")
            {
                MessageBox.Show("O usuário ou a senha não podem permanecer em branco", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Seleciona todos os dados do banco e verifica se o login e valido 

                try
                {
                    string query = "SELECT Nivel_Acesso, ID, Cod_Funcionario, Acesso, Nome, Usuario, Senha FROM tb_usuarios WHERE Usuario= '" +
                    TbUsuario.Text + "'AND Senha= '" + TbSenha.Text + "' ";

                    MySqlCommand com = new MySqlCommand(query, con.conn);
                    com.ExecuteNonQuery();
                    MySqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        count++;
                    }

                    if (count < 1)
                    {
                        acess++;
                        con.desconctar();

                        //Bloqueia o usuario após digitado a senha incorreta 3 vezes

                        if (acess >= 3)
                        {
                            con.conectar();

                            MySqlCommand dbcomand = new MySqlCommand("Update tb_usuarios set Acesso = ? where Usuario = ?", con.conn);
                            dbcomand.Parameters.Add("@Acesso", MySqlDbType.VarChar, 45).Value = "Bloqueado";
                            dbcomand.Parameters.Add("@Usuario", MySqlDbType.VarChar, 45).Value = TbUsuario.Text;

                            dbcomand.CommandType = CommandType.Text;
                            dbcomand.ExecuteNonQuery();
                            con.desconctar();

                            Informacoes.Usuario = TbUsuario.Text;

                            MessageBox.Show("Acesso bloqueado, procure o administrador", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //configura  envio de email  

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
                            mensagem.Subject = "Acesso Bloqueado";
                            mensagem.Body = "\n\n" + Informacoes.Nome + " Seu acesso foi bloqueado, procure o administrador e solicite o desbloqueio \n\n" + "\n\n\n" + "Atenciosamente! \nCondControl";
                            mensagem.To.Add(Informacoes.Usuario);

                            //envio da mensagem de email

                            cliente.Send(mensagem);
                            count = 0;
                            acess = 0;
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.desconctar();
                        }
                    }

                    else
                    {
                        //Dados recuperados e armazenados em variaveis de classes estaticas   

                        if (count == 1)
                        {
                            string acesso = dr.GetString("Acesso");
                            string nivel = dr.GetString("Nivel_Acesso");
                            string codigo = dr.GetString("Cod_Funcionario");
                            string id = dr.GetString("ID");
                            string nome = dr.GetString("Nome");
                            string usuario = dr.GetString("Usuario");
                            string senha = dr.GetString("Senha");

                            if (acesso.Equals("Liberado"))
                            {
                                Informacoes.ID = id;
                                Informacoes.Cod_Funcionario = codigo;
                                Informacoes.Nome = nome;
                                Informacoes.Usuario = usuario;
                                Informacoes.Senha = senha;
                                Pagina_Inicial PAG = new Pagina_Inicial();

                                if (nivel.Equals("Administrador"))
                                {
                                    this.Hide();
                                    PAG.Show();
                                }

                                else
                                {
                                    if ((nivel.Equals("Porteiro")))
                                    {
                                        PAG.btCadastroDeMorador.Visible = false;
                                        PAG.btCadastroDePorteiro.Visible = false;
                                        PAG.BtRelatorios.Visible = false;
                                        this.Hide();
                                        PAG.Show();
                                    }
                                }
                            }
                            else
                            {
                                if (acesso.Equals("Bloqueado"))
                                {
                                    MessageBox.Show("Acesso bloqueado, procure o administrador", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    count = 0;
                                }
                            }
                        }
                    }

                    con.desconctar();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro com o banco de dados " + Ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.desconctar();
                }
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VisualizarSenha_MouseMove(object sender, MouseEventArgs e)
        {
            lbView.Text = "Visualizar senha";
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            lbView.Text = "";
        }

        private void VisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (VisualizarSenha.Checked)
            {
                TbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TbSenha.UseSystemPasswordChar = true;
            }
        }

        private void LbEsqueciSenha_Click(object sender, EventArgs e)
        {
            Esqueci_Senha esq = new Esqueci_Senha();
            esq.ShowDialog();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void LbEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esqueci_Senha esq = new Esqueci_Senha();
            esq.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void TbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
