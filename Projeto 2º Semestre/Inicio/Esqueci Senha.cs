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
using Projeto_2º_Semestre;
using System.Net;
using System.Net.Mail;
using Cond._Control.Inicio;

namespace Cond._Control
{
    public partial class Esqueci_Senha : Form
    {
        Random rd = new Random();
        Random rd1 = new Random();
        int num1, num2, result;

        conexao con = new conexao();
        int count = 0;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public Esqueci_Senha()
        {
            InitializeComponent();
            num1 = rd.Next(0, 10);
            num2 = rd1.Next(1, 11);

            result = num1 + num2;

            label2.Text = "Responda o Desafio! " + num1 + " + " + num2 + " = ";
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbDesafio.Text == "")
            {
                MessageBox.Show("Os Campos não pode Permanecer em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                num1 = rd.Next(0, 10);
                num2 = rd1.Next(1, 11);

                result = num1 + num2;

                label2.Text = "Responda o Desafio! " + num1 + " + " + num2 + " = ";
            }

            else
            {
                Informacoes.Usuario = tbEmail.Text;
                if (Convert.ToInt32(tbDesafio.Text) == result)
                {
                    num1 = rd.Next(0, 10);
                    num2 = rd1.Next(1, 11);

                    result = num1 + num2;

                    label2.Text = "Responda o Desafio! " + num1 + " + " + num2 + " = ";

                    con.conectar();
                    try
                    {
                        MySqlCommand com = new MySqlCommand("SELECT Nome, Senha FROM tb_usuarios WHERE Usuario = ?", con.conn);
                        com.Parameters.Add("@Usuario", MySqlDbType.VarChar, 45).Value = tbEmail.Text;
                        com.CommandType = CommandType.Text;

                        com.ExecuteNonQuery();
                        MySqlDataReader dr = com.ExecuteReader();

                        while (dr.Read())
                        {
                            count++;
                        }

                        if (count == 0)
                        {
                            MessageBox.Show("E-mail não Cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.desconctar();

                            num1 = rd.Next(0, 10);
                            num2 = rd1.Next(1, 11);

                            result = num1 + num2;

                            label2.Text = "Responda o Desafio! " + num1 + " + " + num2 + " = ";
                            con.desconctar();
                        }

                        else
                        {

                            if (count == 1)
                            {
                                tbEmail.Clear();
                                tbDesafio.Clear();

                                Informacoes.Nome = dr.GetString("Nome");
                                Informacoes.Senha = dr.GetString("Senha");

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
                                mensagem.Subject = "Recuperação de Senha";
                                mensagem.Body = Informacoes.Nome + " Você Solicitou a recuperação de Senha! \n\n" + "Senha: " + Informacoes.Senha +
                                    "\n\n" + "Orientamos que faça a alteração da senha quando acessar o sistema!!!" + "\n\n\n" + "Atenciosamente! \nCondControl";
                                mensagem.To.Add(Informacoes.Usuario);

                                //envio da mensagem de email

                                cliente.Send(mensagem);
                                MessageBox.Show("Email Enviado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                count = 0;
                                con.desconctar();
                            }
                            con.desconctar();
                        }
                        con.desconctar();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(" " + es);
                        count = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Desafio Incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    num1 = rd.Next(0, 10);
                    num2 = rd1.Next(1, 11);

                    result = num1 + num2;

                    label2.Text = "Responda o Desafio! " + num1 + " + " + num2 + " = ";
                }
            }
        }
    }
}
