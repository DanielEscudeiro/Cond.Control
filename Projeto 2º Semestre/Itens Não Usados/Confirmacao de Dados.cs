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
    public partial class Confirmacao_de_Dados : Form
    {
        public Confirmacao_de_Dados()
        {
            InitializeComponent();

            TbNome.Text = Visitantes.nome;
            TbTelefone.Text = Visitantes.telefone;
            TbRg.Text = Visitantes.rg;
            TbEndereco.Text = Visitantes.endereco;
            TbNum.Text = Visitantes.apartamento;
            TbPropietario.Text = Visitantes.propietario;
            TbData.Text = Visitantes.data;
        }
        conexao con = new conexao();

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (Visitantes.alteracao == "0")
            {

                con.conectar();

                MySqlCommand dbcomand = new MySqlCommand("Update tb_visitas set Hora_de_Entrada = ?, Porteiro_Responsavel_Entrada = ?, Alteracao = ? where ID = ?", con.conn);
                dbcomand.Parameters.Add("@Hora_de_Entrada", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToString();
                dbcomand.Parameters.Add("@Porteiro_Responsavel_Entrada", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                dbcomand.Parameters.Add("@Alteracao", MySqlDbType.VarChar, 45).Value = 1;
                dbcomand.Parameters.Add("@ID", MySqlDbType.Int32).Value = Visitantes.id;

                dbcomand.CommandType = CommandType.Text;
                dbcomand.ExecuteNonQuery();

                if (DialogResult.OK == MessageBox.Show("Visita Liberada Com Sucesso", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    con.desconctar();
                    this.Close();
                }
                con.desconctar();

            }
            else
            {
                if (Visitantes.alteracao == "1")
                {
                    con.conectar();

                    MySqlCommand dbcomand = new MySqlCommand("Update tb_visitas set Hora_de_Saida = ?, Porteiro_Responsavel_Saida = ?, Alteracao = ?,  Codigo_de_Acesso = ? where ID = ?", con.conn);
                    dbcomand.Parameters.Add("@Hora_de_Saida", MySqlDbType.VarChar, 45).Value = DateTime.Now.ToString();
                    dbcomand.Parameters.Add("@Porteiro_Responsavel_Saida", MySqlDbType.VarChar, 45).Value = Informacoes.Nome;
                    dbcomand.Parameters.Add("@Alteracao", MySqlDbType.VarChar, 45).Value = 2;
                    dbcomand.Parameters.Add("@Codigo_de_Acesso", MySqlDbType.VarChar, 45).Value = "00000";
                    dbcomand.Parameters.Add("@ID", MySqlDbType.Int32).Value = Visitantes.id;

                    dbcomand.CommandType = CommandType.Text;
                    dbcomand.ExecuteNonQuery();


                    if (DialogResult.OK == MessageBox.Show("Visita Encerrada Com Sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        con.desconctar();
                        this.Close();
                    }
                    con.desconctar();
                }
            }

        }
    }
}