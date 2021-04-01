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
    public partial class Relatorio_de_Usuarios : Form
    {
        conexao con = new conexao();

        private DataSet6 relDs6 = null;
        private DataSet6TableAdapters.UsuariosTableAdapter usuarioTableAdapter = null;

        public Relatorio_de_Usuarios()
        {
            InitializeComponent();

            relDs6 = new DataSet6();
            con.conectar();
            usuarioTableAdapter = new DataSet6TableAdapters.UsuariosTableAdapter();
            usuarioTableAdapter.Connection = con.conectar();
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
            DtVisitas.Columns[4].Visible = false;
            DtVisitas.Columns[7].Visible = false;
            DtVisitas.Columns[5].HeaderText = "Nível de acesso";
            DtVisitas.Columns[1].HeaderText = "Código de funcionário";
            DtVisitas.Columns[3].HeaderText = "Usuário";
        }
        private void BtPesquizar_Click(object sender, EventArgs e)
        {
            if (TbNome.Text == "" && comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Digite um nome para buscar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(TbPesquisa.Text == "" && comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Digite um código para buscar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    usuarioTableAdapter.Fill(relDs6.Usuarios, Convert.ToInt32(TbPesquisa.Text), TbNome.Text);
                    con.desconctar();

                    DtVisitas.DataSource = relDs6.Usuarios;
                    label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                    FormatarGrid();
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        usuarioTableAdapter.Fill(relDs6.Usuarios, null, "%" + TbNome.Text + "%");
                        con.desconctar();

                        DtVisitas.DataSource = relDs6.Usuarios;
                        label3.Text = DtVisitas.Rows.Count.ToString() + " Cadastros foram encontrados!";
                        FormatarGrid();
                    }
                    else
                    {
                        Buscas bu = new Buscas();
                        DtVisitas.DataSource = bu.BuscarTodosAcessos();
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
                BtPesquizar.Location = new Point(394, 75);
                label1.Text = ("Digite o código do funcionário");
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
                    BtPesquizar.Location = new Point(538, 75);
                    label1.Text = ("Digite o nome do funcionário");
                    TbPesquisa.Clear();
                    TbNome.Clear();
                    label1.Visible = true;
                    BtPesquizar.Visible = true;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        Buscas bu = new Buscas();
                        DtVisitas.DataSource = bu.BuscarTodosAcessos();
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
        private void Relatorio_de_Usuarios_Load(object sender, EventArgs e)
        {
            label1.Text = ("Digite o código do funcionário");
            comboBox1.SelectedIndex = 0;
            TbNome.Visible = false;
            TbPesquisa.Visible = true;
        }

        private void DtVisitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroUsuario cad = new CadastroUsuario();

            cad.tbNome.Text = DtVisitas.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            cad.tbCod.Text = DtVisitas.Rows[e.RowIndex].Cells["Cod_Funcionario"].Value.ToString();
            cad.tbUsuario.Text = DtVisitas.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            cad.cmbAcesso.Text = DtVisitas.Rows[e.RowIndex].Cells["Acesso"].Value.ToString();
            cad.cmbNivelAcesso.Text = DtVisitas.Rows[e.RowIndex].Cells["Nivel_Acesso"].Value.ToString();
            cad.id = DtVisitas.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            cad.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorio_de_Usuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
