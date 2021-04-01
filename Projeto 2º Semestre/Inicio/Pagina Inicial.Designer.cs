namespace Projeto_2º_Semestre
{
    partial class Pagina_Inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Inicial));
            this.LbDados = new System.Windows.Forms.Label();
            this.PanelInformacoes = new System.Windows.Forms.Panel();
            this.LbDateTime = new System.Windows.Forms.Label();
            this.TempoDeAtualizacao = new System.Windows.Forms.Timer(this.components);
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.BtCadPagIni = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadastroDeMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadastroDePorteiro = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadastroDeTrabalhador = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAreaDoPorteiro = new System.Windows.Forms.ToolStripMenuItem();
            this.liberarVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosDeVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeMoradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeTrabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDePorteirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelInformacoes.SuspendLayout();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDados
            // 
            this.LbDados.AutoSize = true;
            this.LbDados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDados.Location = new System.Drawing.Point(4, 4);
            this.LbDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDados.Name = "LbDados";
            this.LbDados.Size = new System.Drawing.Size(471, 18);
            this.LbDados.TabIndex = 0;
            this.LbDados.Text = "Alysson Gabriel de Oliveira Paulino || Código de Usuario  2000";
            // 
            // PanelInformacoes
            // 
            this.PanelInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInformacoes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelInformacoes.Controls.Add(this.LbDateTime);
            this.PanelInformacoes.Controls.Add(this.LbDados);
            this.PanelInformacoes.Location = new System.Drawing.Point(0, 708);
            this.PanelInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.PanelInformacoes.Name = "PanelInformacoes";
            this.PanelInformacoes.Size = new System.Drawing.Size(1348, 28);
            this.PanelInformacoes.TabIndex = 2;
            this.PanelInformacoes.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInformacoes_Paint);
            // 
            // LbDateTime
            // 
            this.LbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbDateTime.AutoSize = true;
            this.LbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LbDateTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDateTime.Location = new System.Drawing.Point(1190, 4);
            this.LbDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDateTime.Name = "LbDateTime";
            this.LbDateTime.Size = new System.Drawing.Size(154, 18);
            this.LbDateTime.TabIndex = 1;
            this.LbDateTime.Text = "00/00/0000   00:00:00";
            this.LbDateTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TempoDeAtualizacao
            // 
            this.TempoDeAtualizacao.Enabled = true;
            this.TempoDeAtualizacao.Interval = 1000;
            this.TempoDeAtualizacao.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtCadPagIni,
            this.BtAreaDoPorteiro,
            this.BtRelatorios,
            this.BtConfiguracoes,
            this.BtSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuPrincipal.Size = new System.Drawing.Size(1348, 26);
            this.MenuPrincipal.TabIndex = 3;
            this.MenuPrincipal.Text = "Menu";
            // 
            // BtCadPagIni
            // 
            this.BtCadPagIni.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtCadPagIni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCadastroDeMorador,
            this.btCadastroDePorteiro,
            this.btCadastroDeTrabalhador});
            this.BtCadPagIni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCadPagIni.ForeColor = System.Drawing.Color.Black;
            this.BtCadPagIni.Name = "BtCadPagIni";
            this.BtCadPagIni.Size = new System.Drawing.Size(93, 22);
            this.BtCadPagIni.Text = "Cadastros";
            // 
            // btCadastroDeMorador
            // 
            this.btCadastroDeMorador.Name = "btCadastroDeMorador";
            this.btCadastroDeMorador.Size = new System.Drawing.Size(264, 22);
            this.btCadastroDeMorador.Text = "Cadastro de Moradores";
            this.btCadastroDeMorador.Click += new System.EventHandler(this.btCadastroDeMorador_Click);
            // 
            // btCadastroDePorteiro
            // 
            this.btCadastroDePorteiro.Name = "btCadastroDePorteiro";
            this.btCadastroDePorteiro.Size = new System.Drawing.Size(264, 22);
            this.btCadastroDePorteiro.Text = "Cadastro de Funcionários";
            this.btCadastroDePorteiro.Click += new System.EventHandler(this.btCadastroDePorteiro_Click);
            // 
            // btCadastroDeTrabalhador
            // 
            this.btCadastroDeTrabalhador.Name = "btCadastroDeTrabalhador";
            this.btCadastroDeTrabalhador.Size = new System.Drawing.Size(264, 22);
            this.btCadastroDeTrabalhador.Text = "Cadastro de Trabalhador";
            this.btCadastroDeTrabalhador.Click += new System.EventHandler(this.btCadastroDeTrabalhador_Click);
            // 
            // BtAreaDoPorteiro
            // 
            this.BtAreaDoPorteiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liberarVisitaToolStripMenuItem,
            this.encerrarVisitaToolStripMenuItem,
            this.trabalhadoresToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.BtAreaDoPorteiro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAreaDoPorteiro.Name = "BtAreaDoPorteiro";
            this.BtAreaDoPorteiro.Size = new System.Drawing.Size(140, 22);
            this.BtAreaDoPorteiro.Text = "Área do Porteiro";
            // 
            // liberarVisitaToolStripMenuItem
            // 
            this.liberarVisitaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liberarVisitaToolStripMenuItem.Name = "liberarVisitaToolStripMenuItem";
            this.liberarVisitaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.liberarVisitaToolStripMenuItem.Text = "Cadastrar Visitante";
            this.liberarVisitaToolStripMenuItem.Click += new System.EventHandler(this.liberarVisitaToolStripMenuItem_Click);
            // 
            // encerrarVisitaToolStripMenuItem
            // 
            this.encerrarVisitaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encerrarVisitaToolStripMenuItem.Name = "encerrarVisitaToolStripMenuItem";
            this.encerrarVisitaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.encerrarVisitaToolStripMenuItem.Text = "Encerrar Visita";
            this.encerrarVisitaToolStripMenuItem.Click += new System.EventHandler(this.encerrarVisitaToolStripMenuItem_Click);
            // 
            // trabalhadoresToolStripMenuItem
            // 
            this.trabalhadoresToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabalhadoresToolStripMenuItem.Name = "trabalhadoresToolStripMenuItem";
            this.trabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.trabalhadoresToolStripMenuItem.Text = "Acesso Trabalhadores";
            this.trabalhadoresToolStripMenuItem.Click += new System.EventHandler(this.trabalhadoresToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.funcionariosToolStripMenuItem.Text = "Acesso Funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // BtRelatorios
            // 
            this.BtRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosDeVisitasToolStripMenuItem,
            this.relatorioDeMoradoresToolStripMenuItem,
            this.relatorioDeFuncionariosToolStripMenuItem,
            this.relatorioDeTrabalhadoresToolStripMenuItem,
            this.relatorioDePorteirosToolStripMenuItem,
            this.usuariosDoSistemaToolStripMenuItem});
            this.BtRelatorios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRelatorios.Name = "BtRelatorios";
            this.BtRelatorios.Size = new System.Drawing.Size(92, 22);
            this.BtRelatorios.Text = "Relatórios";
            // 
            // relatoriosDeVisitasToolStripMenuItem
            // 
            this.relatoriosDeVisitasToolStripMenuItem.Name = "relatoriosDeVisitasToolStripMenuItem";
            this.relatoriosDeVisitasToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.relatoriosDeVisitasToolStripMenuItem.Text = "Relatórios de Visitas";
            this.relatoriosDeVisitasToolStripMenuItem.Click += new System.EventHandler(this.relatoriosDeVisitasToolStripMenuItem_Click);
            // 
            // relatorioDeMoradoresToolStripMenuItem
            // 
            this.relatorioDeMoradoresToolStripMenuItem.Name = "relatorioDeMoradoresToolStripMenuItem";
            this.relatorioDeMoradoresToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.relatorioDeMoradoresToolStripMenuItem.Text = "Relatório de Moradores";
            this.relatorioDeMoradoresToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeMoradoresToolStripMenuItem_Click);
            // 
            // relatorioDeFuncionariosToolStripMenuItem
            // 
            this.relatorioDeFuncionariosToolStripMenuItem.Name = "relatorioDeFuncionariosToolStripMenuItem";
            this.relatorioDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.relatorioDeFuncionariosToolStripMenuItem.Text = "Relatório de Funcionários";
            this.relatorioDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeFuncionariosToolStripMenuItem_Click);
            // 
            // relatorioDeTrabalhadoresToolStripMenuItem
            // 
            this.relatorioDeTrabalhadoresToolStripMenuItem.Name = "relatorioDeTrabalhadoresToolStripMenuItem";
            this.relatorioDeTrabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.relatorioDeTrabalhadoresToolStripMenuItem.Text = "Relatório de Trabalhadores ";
            this.relatorioDeTrabalhadoresToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeTrabalhadoresToolStripMenuItem_Click);
            // 
            // relatorioDePorteirosToolStripMenuItem
            // 
            this.relatorioDePorteirosToolStripMenuItem.Name = "relatorioDePorteirosToolStripMenuItem";
            this.relatorioDePorteirosToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.relatorioDePorteirosToolStripMenuItem.Text = "Relatório de Ponto dos Funcionários";
            this.relatorioDePorteirosToolStripMenuItem.Click += new System.EventHandler(this.relatorioDePorteirosToolStripMenuItem_Click);
            // 
            // usuariosDoSistemaToolStripMenuItem
            // 
            this.usuariosDoSistemaToolStripMenuItem.Name = "usuariosDoSistemaToolStripMenuItem";
            this.usuariosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.usuariosDoSistemaToolStripMenuItem.Text = "Usuários do Sistema";
            this.usuariosDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuariosDoSistemaToolStripMenuItem_Click);
            // 
            // BtConfiguracoes
            // 
            this.BtConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtAlterar});
            this.BtConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConfiguracoes.Name = "BtConfiguracoes";
            this.BtConfiguracoes.Size = new System.Drawing.Size(129, 22);
            this.BtConfiguracoes.Text = "Configurações";
            // 
            // BtAlterar
            // 
            this.BtAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(175, 22);
            this.BtAlterar.Text = "Alterar Senha";
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // BtSair
            // 
            this.BtSair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(47, 22);
            this.BtSair.Text = "Sair";
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-254, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 173);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(627, 474);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Pagina_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1348, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelInformacoes);
            this.Controls.Add(this.MenuPrincipal);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pagina_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pagina_Inicial_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pagina_Inicial_FormClosed);
            this.Load += new System.EventHandler(this.Pagina_Inicial_Load);
            this.PanelInformacoes.ResumeLayout(false);
            this.PanelInformacoes.PerformLayout();
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LbDados;
        private System.Windows.Forms.Panel PanelInformacoes;
        public System.Windows.Forms.Timer TempoDeAtualizacao;
        public System.Windows.Forms.Label LbDateTime;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem BtAlterar;
        private System.Windows.Forms.ToolStripMenuItem liberarVisitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarVisitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosDeVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeMoradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDePorteirosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem BtConfiguracoes;
        public System.Windows.Forms.ToolStripMenuItem BtCadPagIni;
        public System.Windows.Forms.ToolStripMenuItem BtAreaDoPorteiro;
        public System.Windows.Forms.ToolStripMenuItem BtRelatorios;
        public System.Windows.Forms.ToolStripMenuItem BtSair;
        public System.Windows.Forms.ToolStripMenuItem btCadastroDeMorador;
        public System.Windows.Forms.ToolStripMenuItem btCadastroDePorteiro;
        private System.Windows.Forms.ToolStripMenuItem trabalhadoresToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btCadastroDeTrabalhador;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeTrabalhadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}