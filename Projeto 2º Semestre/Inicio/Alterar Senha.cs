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
using MySql.Data.MySqlClient;

namespace Projeto_2º_Semestre
{
    public partial class Alterar_Senha : Form
    {
        public Alterar_Senha()
        {
            InitializeComponent();
            TbSenhaN.Focus();
        }


        conexao con = new conexao();

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbSenhaN.Text == "" && TbSenhaR.Text == "")
                {
                    MessageBox.Show("As senhas não podem ficar em branco ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (TbSenhaN.Text == TbSenhaR.Text)
                    {
                        con.conectar();

                        //Atualiza a senha no banco de dados, de acordo com ID recuperado apartir do login

                        MySqlCommand dbcomand = new MySqlCommand("Update tb_usuarios set Senha = ? where ID = ?", con.conn);
                        dbcomand.Parameters.Add("@Senha", MySqlDbType.VarChar, 45).Value = TbSenhaR.Text;
                        dbcomand.Parameters.Add("@ID", MySqlDbType.Int32).Value = Informacoes.ID;

                        dbcomand.CommandType = CommandType.Text;
                        dbcomand.ExecuteNonQuery();

                        MessageBox.Show("Senha atualizada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TbSenhaN.Clear();
                        TbSenhaR.Clear();

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
                        mensagem.From = new MailAddress("noreply.condcontrol@gmail.com");
                        mensagem.Subject = "Alteração de Senha";
                        mensagem.Body = "\n\n" + Informacoes.Nome + " Sua senha foi alterada com sucesso! \n\n" + "\n\n\n" + "Atenciosamente! \nCondControl";
                        mensagem.To.Add(Informacoes.Usuario);

                        //envio da mensagem de email

                        cliente.Send(mensagem);

                        con.desconctar();
                        //dbcon.Close();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não conferem ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //dbcon.Close();
                        con.desconctar();
                        TbSenhaR.Clear();
                        TbSenhaR.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dbcon.Close();
                con.desconctar();
            }
        }

        private void VisualizarSenha1_CheckedChanged(object sender, EventArgs e)
        {
            if (VisualizarSenha1.Checked)
            {
                TbSenhaN.UseSystemPasswordChar = false;
            }
            else
            {
                TbSenhaN.UseSystemPasswordChar = true;
            }
        }

        private void VisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (VisualizarSenha.Checked)
            {
                TbSenhaR.UseSystemPasswordChar = false;
            }
            else
            {
                TbSenhaR.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
