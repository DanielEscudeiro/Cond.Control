namespace Projeto_2º_Semestre
{
    partial class login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.LbEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lbView = new System.Windows.Forms.Label();
            this.VisualizarSenha = new System.Windows.Forms.CheckBox();
            this.BtEntar = new System.Windows.Forms.Button();
            this.TbSenha = new System.Windows.Forms.TextBox();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.LbSenha = new System.Windows.Forms.Label();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbEsqueciSenha
            // 
            this.LbEsqueciSenha.ActiveLinkColor = System.Drawing.Color.Navy;
            this.LbEsqueciSenha.AutoSize = true;
            this.LbEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.LbEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbEsqueciSenha.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.LbEsqueciSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEsqueciSenha.LinkColor = System.Drawing.Color.White;
            this.LbEsqueciSenha.Location = new System.Drawing.Point(424, 270);
            this.LbEsqueciSenha.Name = "LbEsqueciSenha";
            this.LbEsqueciSenha.Size = new System.Drawing.Size(137, 21);
            this.LbEsqueciSenha.TabIndex = 8;
            this.LbEsqueciSenha.TabStop = true;
            this.LbEsqueciSenha.Text = "Esqueci a Senha";
            this.LbEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbEsqueciSenha_LinkClicked);
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView.Location = new System.Drawing.Point(595, 195);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(0, 15);
            this.lbView.TabIndex = 8;
            // 
            // VisualizarSenha
            // 
            this.VisualizarSenha.AutoSize = true;
            this.VisualizarSenha.Location = new System.Drawing.Point(679, 171);
            this.VisualizarSenha.Name = "VisualizarSenha";
            this.VisualizarSenha.Size = new System.Drawing.Size(15, 14);
            this.VisualizarSenha.TabIndex = 7;
            this.VisualizarSenha.UseVisualStyleBackColor = true;
            this.VisualizarSenha.CheckedChanged += new System.EventHandler(this.VisualizarSenha_CheckedChanged);
            this.VisualizarSenha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VisualizarSenha_MouseMove);
            // 
            // BtEntar
            // 
            this.BtEntar.BackColor = System.Drawing.Color.Transparent;
            this.BtEntar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtEntar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtEntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEntar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEntar.ForeColor = System.Drawing.Color.White;
            this.BtEntar.Location = new System.Drawing.Point(282, 216);
            this.BtEntar.Name = "BtEntar";
            this.BtEntar.Size = new System.Drawing.Size(415, 40);
            this.BtEntar.TabIndex = 5;
            this.BtEntar.Text = "ENTRAR";
            this.BtEntar.UseVisualStyleBackColor = false;
            this.BtEntar.Click += new System.EventHandler(this.BtEntar_Click);
            // 
            // TbSenha
            // 
            this.TbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenha.ForeColor = System.Drawing.Color.White;
            this.TbSenha.Location = new System.Drawing.Point(355, 166);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.Size = new System.Drawing.Size(346, 24);
            this.TbSenha.TabIndex = 4;
            this.TbSenha.UseSystemPasswordChar = true;
            this.TbSenha.TextChanged += new System.EventHandler(this.TbSenha_TextChanged);
            // 
            // TbUsuario
            // 
            this.TbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuario.ForeColor = System.Drawing.Color.White;
            this.TbUsuario.Location = new System.Drawing.Point(355, 115);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(346, 24);
            this.TbUsuario.TabIndex = 2;
            this.TbUsuario.TextChanged += new System.EventHandler(this.TbUsuario_TextChanged);
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.Location = new System.Drawing.Point(277, 171);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(76, 22);
            this.LbSenha.TabIndex = 3;
            this.LbSenha.Text = "Senha:";
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LbUsuario.Location = new System.Drawing.Point(266, 117);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(89, 22);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Usuário:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTROL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "COND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(735, 330);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 346;
            this.lineShape2.X2 = 691;
            this.lineShape2.Y1 = 192;
            this.lineShape2.Y2 = 192;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 355;
            this.lineShape1.X2 = 690;
            this.lineShape1.Y1 = 143;
            this.lineShape1.Y2 = 143;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(709, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(735, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbEsqueciSenha);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.VisualizarSenha);
            this.Controls.Add(this.BtEntar);
            this.Controls.Add(this.TbSenha);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LbEsqueciSenha;
        private System.Windows.Forms.Label lbView;
        private System.Windows.Forms.CheckBox VisualizarSenha;
        private System.Windows.Forms.Button BtEntar;
        public System.Windows.Forms.TextBox TbSenha;
        public System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

