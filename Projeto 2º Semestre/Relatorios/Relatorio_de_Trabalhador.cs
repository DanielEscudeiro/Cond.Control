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
    public partial class Relatorio_de_Trabalhador : Form
    {
        conexao con = new conexao();

        private DataSet5 relDs5 = null;
        private DataSet5TableAdapters.TrabalhadorTableAdapter trabalhadorTableAdapter = null;

        public Relatorio_de_Trabalhador()
        {
            InitializeComponent();

            relDs5 = new DataSet5();
            con.conectar();
            trabalhadorTableAdapter = new DataSet5TableAdapters.TrabalhadorTableAdapter();
            trabalhadorTableAdapter.Connection = con.conectar();
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
            DtVisitas.Columns[5].Visible = false;
            DtVisitas.Columns[6].Visible = false;
            DtVisitas.Columns[7].Visible = false;
            DtVisitas.Columns[13].Visible = false;
            DtVisitas.Columns[12].HeaderText = "Porteiro responsável pelo cadastro";
            DtVisitas.Columns[4].HeaderText = "Tipo de serviço";
            DtVisitas.Columns[8].HeaderText = "Endereço";
            DtVisitas.Columns[11].HeaderText = "Proprietário";
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
                    trabalhadorTableAdapter.Fill(relDs5.Trabalhador, TbPesquisa.Text, TbPesquisa.Text);
                    con.desconctar();

                    DtVisitas.DataSource = relDs5.Trabalhador;
                    label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                    FormatarGrid();
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        trabalhadorTableAdapter.Fill(relDs5.Trabalhador, "%" + TbNome.Text + "%", "%" + TbNome.Text + "%");
                        con.desconctar();

                        DtVisitas.DataSource = relDs5.Trabalhador;
                        label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                        FormatarGrid();
                    }
                    else
                    {
                        trabalhadorTableAdapter.Fill(relDs5.Trabalhador, "%", "%");
                        con.desconctar();

                        DtVisitas.DataSource = relDs5.Trabalhador;
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
                label1.Text = ("Digite o RG do Trabalhador:");
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
                    BtPesquizar.Location = new Point(508, 75);
                    label1.Text = ("Digite o nome do Trabalhador:");
                    TbPesquisa.Clear();
                    TbNome.Clear();
                    label1.Visible = true;
                    BtPesquizar.Visible = true;
                }
                else
                {
                    trabalhadorTableAdapter.Fill(relDs5.Trabalhador, "%", "%");
                    con.desconctar();

                    DtVisitas.DataSource = relDs5.Trabalhador;
                    label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                    FormatarGrid();
                    label1.Visible = false;
                    TbNome.Visible = false;
                    TbPesquisa.Visible = false;
                    BtPesquizar.Visible = false;
                }
            }
        }

        private void Relatorio_de_Tabalhador_Load(object sender, EventArgs e)
        {
            label1.Text = ("Digite o RG do morador:");
            comboBox1.SelectedIndex = 0;
            TbNome.Visible = false;
            TbPesquisa.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorio_de_Trabalhador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
