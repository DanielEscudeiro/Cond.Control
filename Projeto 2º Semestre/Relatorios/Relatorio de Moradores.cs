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
    public partial class Relatorio_de_Moradores : Form
    {
        conexao con = new conexao();

        private DataSet3 relDs3 = null;
        private DataSet3TableAdapters.CadMoradorTableAdapter moradorTableAdapter = null;

        public Relatorio_de_Moradores()
        {
            InitializeComponent();

            con.conectar();

            relDs3 = new DataSet3();
            moradorTableAdapter = new DataSet3TableAdapters.CadMoradorTableAdapter();
            moradorTableAdapter.Connection = con.conectar();
        }

        // inicio da função que permite movimentar a tela 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // fim da função que permite movimentar a tela

        public void FormatarGrid()
        {
            DtVisitas.Columns[0].Visible = false;
            DtVisitas.Columns[5].HeaderText = "E-mail";
            DtVisitas.Columns[6].HeaderText = "Endereço";
            DtVisitas.Columns[7].HeaderText = "Número";
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
                    moradorTableAdapter.Fill(relDs3.CadMorador, TbPesquisa.Text, TbPesquisa.Text);
                    con.desconctar();

                    DtVisitas.DataSource = relDs3.CadMorador;
                    DtVisitas.Columns["NumeroCasa"].HeaderText = "Numero da Casa";
                    label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                    FormatarGrid();
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        moradorTableAdapter.Fill(relDs3.CadMorador, "%" + TbNome.Text + "%", "%" + TbNome.Text + "%");
                        con.desconctar();

                        DtVisitas.DataSource = relDs3.CadMorador;
                        DtVisitas.Columns["NumeroCasa"].HeaderText = "Numero da Casa";
                        label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                        FormatarGrid();
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
                BtPesquizar.Location = new Point(365, 75);
                label1.Text = ("Digite o RG do Morador:");
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
                    BtPesquizar.Location = new Point(509, 75);
                    label1.Text = ("Digite o nome do Morador:");
                    TbPesquisa.Clear();
                    TbNome.Clear();
                    label1.Visible = true;
                    BtPesquizar.Visible = true;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        moradorTableAdapter.Fill(relDs3.CadMorador, "%", "%");
                        con.desconctar();

                        DtVisitas.DataSource = relDs3.CadMorador;
                        label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                        FormatarGrid();
                        label1.Visible = false;
                        TbNome.Visible = false;
                        TbPesquisa.Visible = false;
                        BtPesquizar.Visible = false;
                    }
                }

            }
        }

        private void Relatorio_de_MOradores_Load(object sender, EventArgs e)
        {

            label1.Text = ("Digite o RG do morador:");
            comboBox1.SelectedIndex = 0;
            TbNome.Visible = false;
            TbPesquisa.Visible = true;
        }

        private void DtVisitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroMorador cad = new CadastroMorador();

            cad.tbNome.Text = DtVisitas.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            cad.tbEmail.Text = DtVisitas.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            cad.tbRg.Text = DtVisitas.Rows[e.RowIndex].Cells["RG"].Value.ToString();
            cad.tbCpf.Text = DtVisitas.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
            cad.tbNum.Text = DtVisitas.Rows[e.RowIndex].Cells["NumeroCasa"].Value.ToString();
            cad.tbTelefone.Text = DtVisitas.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            cad.tbEndereco.Text = DtVisitas.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();

            cad.tbNome.Enabled = false;
            cad.tbCpf.Enabled = false;
            cad.tbEmail.Enabled = false;
            cad.tbEndereco.Enabled = false;
            cad.tbRg.Enabled = false;
            cad.tbTelefone.Enabled = false;
            cad.tbNum.Enabled = false;


            cad.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorio_de_Moradores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
