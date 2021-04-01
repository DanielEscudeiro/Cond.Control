using System;
using System.Collections.Generic;
using Projeto_2º_Semestre;
using Cond._Control.Inicio;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using Cond._Control;
using System.Runtime.InteropServices;

namespace Projeto_2º_Semestre
{ 
    public partial class Relatorio_de_Visitas : Form
    {
        DataTable dt = new DataTable();
        conexao con = new conexao();

        private DataSet1 relDs = null;
        private Cond._Control.DataSet1TableAdapters.RelatorioTableAdapter relatorioTableAdapter = null;

        public Relatorio_de_Visitas()
        {
            InitializeComponent();

            con.conectar();
            relDs = new DataSet1();
            relatorioTableAdapter = new Cond._Control.DataSet1TableAdapters.RelatorioTableAdapter();
            relatorioTableAdapter.Connection = con.conectar();
        }

        // inicio da função que permite movimentar a tela 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // fim da função que permite movimentar a tela

        public void FormatarGrid()
        {
            DtVisitas.DataSource = relDs.Relatorio;
            DtVisitas.Columns[0].Visible = false;
            DtVisitas.Columns[7].Visible = false;
            DtVisitas.Columns[12].Visible = false;
            DtVisitas.Columns[13].Visible = false;
            DtVisitas.Columns["Rg"].HeaderText = "RG";
            DtVisitas.Columns["Endereco"].HeaderText = "Endereço";
            DtVisitas.Columns["Proprietario"].HeaderText = "Proprietário";
            DtVisitas.Columns[8].HeaderText = "Hora de entrada";
            DtVisitas.Columns[9].HeaderText = "Hora de saída";
            DtVisitas.Columns[10].HeaderText = "Porteiro responsável pela entrada";
            DtVisitas.Columns[11].HeaderText = "Porteiro responsável pela saída";
        }

        private void BtPesquizar_Click(object sender, EventArgs e)
        {
            if (TbNome.Text == "" && comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Digite um nome para buscar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                relatorioTableAdapter.Fill(relDs.Relatorio, "%" + TbNome.Text + "%", "%" + TbNome.Text + "%");
                FormatarGrid();
                con.desconctar();

            }

            label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                relatorioTableAdapter.Fill(relDs.Relatorio, "%", "%");
                FormatarGrid();
                con.desconctar();
                label1.Visible = false;
                TbNome.Visible = false;
                BtPesquizar.Visible = false;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                   
                    label1.Visible = true;
                    TbNome.Visible = true;
                    BtPesquizar.Visible = true;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {

                        label1.Visible = true;
                        TbNome.Visible = true;
                        BtPesquizar.Visible = true;
                    }
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorio_de_Visitas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Relatorio_de_Visitas_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }

}