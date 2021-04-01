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
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Cond._Control
{
    public partial class Relatorio_de_Ponto : Form
    {
        conexao con = new conexao();

        private DataSet2 relDs2 = null;
        private DataSet2TableAdapters.PontoTableAdapter pontoTableAdapter = null;

        public Relatorio_de_Ponto()
        {
            InitializeComponent();

            con.conectar();

            relDs2 = new DataSet2();
            pontoTableAdapter = new DataSet2TableAdapters.PontoTableAdapter();
            pontoTableAdapter.Connection = con.conectar();
        }

        // inicio da função que permite movimentar a tela 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // fim da função que permite movimentar a tela
        public void FormatarGrid()
        {
            DtVisitas.DataSource = relDs2.Ponto;
            DtVisitas.Columns["Codigo Funcionario"].HeaderText = "Código funcionário";
            DtVisitas.Columns["Rg"].HeaderText = "RG";
            DtVisitas.Columns["Inicio do Expediente"].HeaderText = "Ínicio do Expediente";
            DtVisitas.Columns["Entrada pós refeição"].HeaderText = "Entrada pós-refeição";
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
                    pontoTableAdapter.Fill(relDs2.Ponto, Convert.ToInt32(TbPesquisa.Text), TbNome.Text);
                    con.desconctar();

                    FormatarGrid();
                    label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        pontoTableAdapter.Fill(relDs2.Ponto, null, "%" + TbNome.Text + "%");
                        con.desconctar();

                        FormatarGrid();
                        label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                    }

                }
            }
        }

        private void Relatorio_de_Ponto_Load(object sender, EventArgs e)
        {
            label1.Text = ("Digite o código do funcionário");
            comboBox1.SelectedIndex = 0;
            TbNome.Visible = false;
            TbPesquisa.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                TbNome.Visible = false;
                TbPesquisa.Visible = true;
                BtPesquizar.Location = new Point(393, 75);
                label1.Text = ("Digite o código do Funcionário");
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
                    BtPesquizar.Location = new Point(537, 75);
                    label1.Text = ("Digite o nome do Funcionário");
                    TbPesquisa.Clear();
                    TbNome.Clear();
                    label1.Visible = true;
                    BtPesquizar.Visible = true;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        pontoTableAdapter.Fill(relDs2.Ponto, null, "%");
                        con.desconctar();

                        FormatarGrid();
                        label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                        label1.Visible = false;
                        TbNome.Visible = false;
                        TbPesquisa.Visible = false;
                        BtPesquizar.Visible = false;
                    }

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorio_de_Ponto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
              
    }
}
