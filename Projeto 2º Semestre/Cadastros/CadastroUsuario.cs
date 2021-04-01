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
    public partial class CadastroUsuario : Form
    {
        conexao con = new conexao();
        public string id;
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void FormatarTela()
        {
            this.tbNome.Clear();
            this.tbCod.Clear();
            this.tbUsuario.Clear();
            this.cmbNivelAcesso.SelectedIndex = -1;
            this.cmbAcesso.SelectedIndex = -1;

            this.cmbNivelAcesso.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                con.conectar();

                MySqlCommand dbcomand = new MySqlCommand("Update tb_usuarios set Nivel_Acesso = ?, Acesso = ? where ID = ?", con.conn);
                dbcomand.Parameters.Add("@Nivel_Acesso", MySqlDbType.VarChar, 45).Value = cmbNivelAcesso.SelectedItem;
                dbcomand.Parameters.Add("@Acesso", MySqlDbType.VarChar, 45).Value = cmbAcesso.SelectedItem;
                dbcomand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

                dbcomand.CommandType = CommandType.Text;
                dbcomand.ExecuteNonQuery();

                MessageBox.Show("Alteração feita com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.desconctar();
                FormatarTela();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.desconctar();
                FormatarTela();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
