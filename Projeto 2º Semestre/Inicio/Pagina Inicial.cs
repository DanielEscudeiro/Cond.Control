using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using Cond._Control;

namespace Projeto_2º_Semestre
{
    public partial class Pagina_Inicial : Form
    {
        public Pagina_Inicial()
        {
            InitializeComponent();

            LbDados.Text = Informacoes.Nome + " || Código de Funcionário: " + Informacoes.Cod_Funcionario;
        }

        private void Pagina_Inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pagina_Inicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbDateTime.Text = DateTime.Now.ToString();
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            Alterar_Senha alterar = new Alterar_Senha();
            alterar.ShowDialog();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            /*Pagina_Inicial PAG = new Pagina_Inicial();
            login Log = new login();
            Log.Show();
            this.Hide();*/
            Application.Exit();
        }

        private void liberarVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVisitante conf = new CadastroVisitante();
            conf.ShowDialog();
        }

        private void encerrarVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmacao_de_Acesso_Saida enc = new Confirmacao_de_Acesso_Saida();
            enc.ShowDialog();
        }

        private void relatoriosDeVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_de_Visitas relVisi = new Relatorio_de_Visitas();
            relVisi.Show();
        }


        private void btCadastroDeTrabalhador_Click(object sender, EventArgs e)
        {
            Cadastro_de_Trabalhador cad = new Cadastro_de_Trabalhador();
            cad.ShowDialog();
        }

        private void trabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso_de_Trabalhador acesTra = new Acesso_de_Trabalhador();
            acesTra.ShowDialog();
        }

        private void btCadastroDePorteiro_Click(object sender, EventArgs e)
        {
            CadastroFuncionarioInterno cad = new CadastroFuncionarioInterno();
            cad.btLiberarTarde.Visible = false;
            cad.btLiberarManha.Visible = false;
            cad.btEncerrarTarde.Visible = false;
            cad.btEncerrarManha.Visible = false;
            cad.tbNome.Enabled = true;
            cad.tbRg.Enabled = true;
            cad.tbCpf.Enabled = true;
            cad.tbEmail.Enabled = true;
            cad.tbTelefone.Enabled = true;
            cad.tbRg.Enabled = true;
            cad.tbEndereco.Enabled = true;
            cad.tbNum.Enabled = true;
            cad.cmbFuncao.Enabled = true;

            cad.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso_Funcionario fun = new Acesso_Funcionario();
            fun.ShowDialog();
        }

        private void btCadastroDeMorador_Click(object sender, EventArgs e)
        {
            CadastroMorador cadMor = new CadastroMorador();
            cadMor.ShowDialog();
        }

        private void relatorioDePorteirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_de_Ponto rel = new Relatorio_de_Ponto();
            rel.Show();
        }

        private void relatorioDeMoradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_de_Moradores relMor = new Relatorio_de_Moradores();
            relMor.Show();
        }

        private void relatorioDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_de_Funcionarios relFun = new Relatorio_de_Funcionarios();
            relFun.Show();
        }

        private void relatorioDeTrabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_de_Trabalhador relTra = new Relatorio_de_Trabalhador();
            relTra.Show();
        }

        private void usuariosDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_de_Usuarios relUser = new Relatorio_de_Usuarios();
            relUser.Show();
        }

        private void PanelInformacoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pagina_Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}

