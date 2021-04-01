namespace Cond._Control
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAcesso = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nível de acesso";
            // 
            // cmbNivelAcesso
            // 
            this.cmbNivelAcesso.BackColor = System.Drawing.Color.White;
            this.cmbNivelAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNivelAcesso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivelAcesso.ForeColor = System.Drawing.Color.Black;
            this.cmbNivelAcesso.FormattingEnabled = true;
            this.cmbNivelAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Porteiro"});
            this.cmbNivelAcesso.Location = new System.Drawing.Point(381, 249);
            this.cmbNivelAcesso.Name = "cmbNivelAcesso";
            this.cmbNivelAcesso.Size = new System.Drawing.Size(300, 31);
            this.cmbNivelAcesso.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "Código de funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Acesso";
            // 
            // cmbAcesso
            // 
            this.cmbAcesso.BackColor = System.Drawing.Color.White;
            this.cmbAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcesso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcesso.ForeColor = System.Drawing.Color.Black;
            this.cmbAcesso.FormattingEnabled = true;
            this.cmbAcesso.Items.AddRange(new object[] {
            "Liberado",
            "Bloqueado"});
            this.cmbAcesso.Location = new System.Drawing.Point(38, 317);
            this.cmbAcesso.Name = "cmbAcesso";
            this.cmbAcesso.Size = new System.Drawing.Size(310, 31);
            this.cmbAcesso.TabIndex = 4;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(381, 309);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(300, 38);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(257, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 32);
            this.label7.TabIndex = 105;
            this.label7.Text = "Alterar Usuário";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(38, 96);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(643, 31);
            this.tbNome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 120;
            this.label6.Text = "Nome";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(38, 173);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(643, 31);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbCod
            // 
            this.tbCod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCod.Location = new System.Drawing.Point(38, 249);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(310, 31);
            this.tbCod.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(722, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAcesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNivelAcesso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btSalvar;
        public System.Windows.Forms.ComboBox cmbNivelAcesso;
        public System.Windows.Forms.ComboBox cmbAcesso;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbUsuario;
        public System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}