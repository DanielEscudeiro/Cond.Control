namespace Projeto_2º_Semestre
{
    partial class Alterar_Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar_Senha));
            this.lbView = new System.Windows.Forms.Label();
            this.VisualizarSenha = new System.Windows.Forms.CheckBox();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.TbSenhaR = new System.Windows.Forms.TextBox();
            this.TbSenhaN = new System.Windows.Forms.TextBox();
            this.LbSenhaR = new System.Windows.Forms.Label();
            this.LbSenhaN = new System.Windows.Forms.Label();
            this.VisualizarSenha1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Location = new System.Drawing.Point(262, 81);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(0, 13);
            this.lbView.TabIndex = 15;
            // 
            // VisualizarSenha
            // 
            this.VisualizarSenha.AutoSize = true;
            this.VisualizarSenha.Location = new System.Drawing.Point(433, 192);
            this.VisualizarSenha.Name = "VisualizarSenha";
            this.VisualizarSenha.Size = new System.Drawing.Size(15, 14);
            this.VisualizarSenha.TabIndex = 105;
            this.VisualizarSenha.UseVisualStyleBackColor = true;
            this.VisualizarSenha.CheckedChanged += new System.EventHandler(this.VisualizarSenha_CheckedChanged);
            // 
            // BtAlterar
            // 
            this.BtAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.BtAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlterar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlterar.ForeColor = System.Drawing.Color.White;
            this.BtAlterar.Location = new System.Drawing.Point(237, 227);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(172, 31);
            this.BtAlterar.TabIndex = 2;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // TbSenhaR
            // 
            this.TbSenhaR.BackColor = System.Drawing.Color.White;
            this.TbSenhaR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbSenhaR.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenhaR.Location = new System.Drawing.Point(197, 185);
            this.TbSenhaR.Name = "TbSenhaR";
            this.TbSenhaR.Size = new System.Drawing.Size(253, 26);
            this.TbSenhaR.TabIndex = 1;
            this.TbSenhaR.UseSystemPasswordChar = true;
            // 
            // TbSenhaN
            // 
            this.TbSenhaN.BackColor = System.Drawing.Color.White;
            this.TbSenhaN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbSenhaN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenhaN.Location = new System.Drawing.Point(199, 100);
            this.TbSenhaN.Name = "TbSenhaN";
            this.TbSenhaN.Size = new System.Drawing.Size(251, 26);
            this.TbSenhaN.TabIndex = 0;
            this.TbSenhaN.UseSystemPasswordChar = true;
            // 
            // LbSenhaR
            // 
            this.LbSenhaR.AutoSize = true;
            this.LbSenhaR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSenhaR.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenhaR.ForeColor = System.Drawing.Color.White;
            this.LbSenhaR.Location = new System.Drawing.Point(194, 154);
            this.LbSenhaR.Name = "LbSenhaR";
            this.LbSenhaR.Size = new System.Drawing.Size(219, 28);
            this.LbSenhaR.TabIndex = 103;
            this.LbSenhaR.Text = "Repita sua Senha:";
            // 
            // LbSenhaN
            // 
            this.LbSenhaN.AutoSize = true;
            this.LbSenhaN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenhaN.ForeColor = System.Drawing.Color.White;
            this.LbSenhaN.Location = new System.Drawing.Point(194, 69);
            this.LbSenhaN.Name = "LbSenhaN";
            this.LbSenhaN.Size = new System.Drawing.Size(256, 28);
            this.LbSenhaN.TabIndex = 101;
            this.LbSenhaN.Text = "Digite a Nova Senha:";
            // 
            // VisualizarSenha1
            // 
            this.VisualizarSenha1.AutoSize = true;
            this.VisualizarSenha1.Location = new System.Drawing.Point(433, 107);
            this.VisualizarSenha1.Name = "VisualizarSenha1";
            this.VisualizarSenha1.Size = new System.Drawing.Size(15, 14);
            this.VisualizarSenha1.TabIndex = 102;
            this.VisualizarSenha1.UseVisualStyleBackColor = true;
            this.VisualizarSenha1.CheckedChanged += new System.EventHandler(this.VisualizarSenha1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 32);
            this.label7.TabIndex = 100;
            this.label7.Text = "Alterar Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(648, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VisualizarSenha1);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.VisualizarSenha);
            this.Controls.Add(this.BtAlterar);
            this.Controls.Add(this.TbSenhaR);
            this.Controls.Add(this.TbSenhaN);
            this.Controls.Add(this.LbSenhaR);
            this.Controls.Add(this.LbSenhaN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alterar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TbSenhaR;
        public System.Windows.Forms.TextBox TbSenhaN;
        public System.Windows.Forms.Label lbView;
        public System.Windows.Forms.CheckBox VisualizarSenha;
        public System.Windows.Forms.Button BtAlterar;
        public System.Windows.Forms.Label LbSenhaR;
        public System.Windows.Forms.Label LbSenhaN;
        public System.Windows.Forms.CheckBox VisualizarSenha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}