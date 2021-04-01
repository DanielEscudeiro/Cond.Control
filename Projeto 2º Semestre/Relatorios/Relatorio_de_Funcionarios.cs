using Cond._Control.Inicio;
using Projeto_2º_Semestre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cond._Control
{
    public partial class Relatorio_de_Funcionarios : Form
    {
        conexao con = new conexao();

        private DataSet4 relDs4 = null;
        private DataSet4TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter = null;

        public Relatorio_de_Funcionarios()
        {
            InitializeComponent();

            relDs4 = new DataSet4();
            funcionarioTableAdapter = new DataSet4TableAdapters.FuncionarioTableAdapter();
            funcionarioTableAdapter.Connection = con.conectar();
        }

        // inicio da função que permite movimentar a tela 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // fim da função que permite movimentar a tela

        public void FormatarGrid()
        {
            DtFuncionarios.DataSource = relDs4.Funcionario;
            DtFuncionarios.Columns["NumeroCasa"].HeaderText = "Número";
            DtFuncionarios.Columns["Id"].HeaderText = "Código de funcionário";
            DtFuncionarios.Columns["Funcao"].HeaderText = "Função";
            DtFuncionarios.Columns["Endereco"].HeaderText = "Endereço";
            DtFuncionarios.Columns["Funcao"].HeaderText = "Função";
            DtFuncionarios.Columns["Email"].HeaderText = "E-mail";
        }

        private void BtPesquizar_Click(object sender, EventArgs e)
        {
            if (TbNome.Text == "" && comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Digite um nome para buscar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TbPesquisa.Text == "" && comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Digite um código para buscar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {
                if (comboBox1.SelectedIndex == 0)
                {
                    funcionarioTableAdapter.Fill(relDs4.Funcionario, Convert.ToInt32(TbPesquisa.Text), TbNome.Text);
                    con.desconctar();

                    FormatarGrid();
                    label3.Text = DtFuncionarios.Rows.Count.ToString() + " Cadastros foram encontrados!";
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        funcionarioTableAdapter.Fill(relDs4.Funcionario, null, "%" + TbNome.Text + "%");
                        con.desconctar();

                        FormatarGrid();
                        label3.Text = DtFuncionarios.Rows.Count.ToString() + " Cadastros foram encontrados!";
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                TbNome.Visible = false;
                TbPesquisa.Visible = true;
                BtPesquizar.Location = new Point(392, 75);
                label1.Text = ("Digite o código do Funcionário:");
                TbPesquisa.Clear();
                TbNome.Clear();
                label1.Visible = true;
                BtPesquizar.Visible = true;
            }
            else
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    TbNome.Visible = true;
                    TbPesquisa.Visible = false;
                    BtPesquizar.Location = new Point(536, 75);
                    label1.Text = ("Digite o nome do Funcionário:");
                    TbPesquisa.Clear();
                    TbNome.Clear();
                    label1.Visible = true;
                    BtPesquizar.Visible = true;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {

                        funcionarioTableAdapter.Fill(relDs4.Funcionario, null, "%");
                        con.desconctar();

                        FormatarGrid();
                        label3.Text = DtFuncionarios.Rows.Count.ToString() + " Cadastros foram encontrados!";
                        label1.Visible = false;
                        TbNome.Visible = false;
                        TbPesquisa.Visible = false;
                        BtPesquizar.Visible = false;
                    }
                }
            }
        }

        private void Relatorio_de_Funcionarios_Load(object sender, EventArgs e)
        {
            label1.Text = ("Digite o código do funcionário");
            comboBox1.SelectedIndex = 0;
            TbNome.Visible = false;
            TbPesquisa.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtVisitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroFuncionarioInterno cad = new CadastroFuncionarioInterno();

            cad.tbNome.Text = DtFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            cad.tbEmail.Text = DtFuncionarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            cad.tbRg.Text = DtFuncionarios.Rows[e.RowIndex].Cells["RG"].Value.ToString();
            cad.tbCpf.Text = DtFuncionarios.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
            cad.tbNum.Text = DtFuncionarios.Rows[e.RowIndex].Cells["NumeroCasa"].Value.ToString();
            cad.tbTelefone.Text = DtFuncionarios.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            cad.cmbFuncao.Text = DtFuncionarios.Rows[e.RowIndex].Cells["Funcao"].Value.ToString();
            cad.tbEndereco.Text = DtFuncionarios.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
            FuncionarioInterno.ID = DtFuncionarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            cad.tbNome.Enabled = true;
            cad.tbCpf.Enabled = true;
            cad.tbEmail.Enabled = true;
            cad.tbEndereco.Enabled = true;
            cad.tbRg.Enabled = true;
            cad.tbTelefone.Enabled = true;
            cad.tbNum.Enabled = true;
            cad.cmbFuncao.Enabled = true;
            cad.btCadastrar.Visible = false;
            cad.btEncerrarManha.Visible = false;
            cad.btEncerrarTarde.Visible = false;
            cad.btLiberarManha.Visible = false;
            cad.btLiberarTarde.Visible = false;
            cad.btAtualizar.Visible = true;

            cad.ShowDialog();
        }

        private void Relatorio_de_Funcionarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
