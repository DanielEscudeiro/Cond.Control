using Cond._Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_2º_Semestre
{
    public partial class Liberar_Visitas : Form
    {
        public DataTable dt = new DataTable("tb_Visitas");

        conexao con = new conexao();
        public Liberar_Visitas()
        {
            InitializeComponent();

            try
            {
                con.conectar();

                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from tb_Visitas", con.conn))
                {
                    da.Fill(dt);

                    DtVisitas.DataSource = dt;
                }
                con.desconctar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar Cadastro" + ex);
            }

            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Data like '%{0}%'", DateTime.Now.Date.ToShortDateString());
            DtVisitas.DataSource = dv.ToTable();

            DtVisitas.Columns[0].Visible = false;
            DtVisitas.Columns[7].Visible = false;
            DtVisitas.Columns[8].Visible = false;
            DtVisitas.Columns[9].Visible = false;
            DtVisitas.Columns[10].Visible = false;
            DtVisitas.Columns[11].Visible = false;
            DtVisitas.Columns[6].HeaderText = "Hora De Entrada";
        }

        private void AtualizacaoAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (AtualizacaoAuto.Checked)
            {
                AtualizacaoTimer.Enabled = true;
            }
            else
            {
                AtualizacaoTimer.Enabled = false;
            }
        }

        private void BtPesquizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbNome.Text))
            {
                DataView dvi = dt.DefaultView;
                dvi.RowFilter = string.Format("Data like '%{0}%'", DateTime.Now.ToShortDateString());
                DtVisitas.DataSource = dvi.ToTable(Convert.ToString(dt));
            }
            else
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Nome like '%{0}%'", TbNome.Text);
                DtVisitas.DataSource = dv.ToTable(Convert.ToString(dt));
            }
        }

        private void AtualizacaoTimer_Tick(object sender, EventArgs e)
        {
            dt.Clear();
            con.conectar();
            using (MySqlDataAdapter da = new MySqlDataAdapter("select * from tb_Visitas", con.conn))
            {
                da.Fill(dt);

                DtVisitas.DataSource = dt;
            }
            con.desconctar();
        }

        private void DtVisitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visitantes.nome = DtVisitas.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            Visitantes.id = DtVisitas.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            Visitantes.codigo = DtVisitas.Rows[e.RowIndex].Cells["Codigo_de_Acesso"].Value.ToString();
            string propietario = DtVisitas.Rows[e.RowIndex].Cells["Propietario"].Value.ToString();
            string apartamento = DtVisitas.Rows[e.RowIndex].Cells["Apartamento"].Value.ToString();
            Visitantes.alteracao = DtVisitas.Rows[e.RowIndex].Cells["Alteracao"].Value.ToString();

            if (Visitantes.alteracao == "")
            {
                DialogResult result = MessageBox.Show("Deseja Liberar a Visita de: " + Visitantes.nome + "\nNa Casa/Apartamento do Morador: "
                    + propietario + " \nApartamento/Casa: " +
                apartamento, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Confirmação_de_Acesso_Entrada confirmar = new Confirmação_de_Acesso_Entrada();
                    confirmar.ShowDialog();  
                }
            }
            else
            {
                MessageBox.Show("Não é Possivel Alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
