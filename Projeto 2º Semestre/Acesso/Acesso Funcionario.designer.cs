namespace Cond._Control
{
    partial class Acesso_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso_Funcionario));
            this.gpbEvento = new System.Windows.Forms.GroupBox();
            this.rbEntradaTarde = new System.Windows.Forms.RadioButton();
            this.rbSaidaRefeicao = new System.Windows.Forms.RadioButton();
            this.rbSaidaTarde = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbRG = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEvento
            // 
            this.gpbEvento.Controls.Add(this.rbEntradaTarde);
            this.gpbEvento.Controls.Add(this.rbSaidaRefeicao);
            this.gpbEvento.Controls.Add(this.rbSaidaTarde);
            this.gpbEvento.Controls.Add(this.rbEntrada);
            this.gpbEvento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEvento.ForeColor = System.Drawing.Color.White;
            this.gpbEvento.Location = new System.Drawing.Point(12, 100);
            this.gpbEvento.Name = "gpbEvento";
            this.gpbEvento.Size = new System.Drawing.Size(422, 107);
            this.gpbEvento.TabIndex = 0;
            this.gpbEvento.TabStop = false;
            this.gpbEvento.Text = "Evento";
            // 
            // rbEntradaTarde
            // 
            this.rbEntradaTarde.AutoSize = true;
            this.rbEntradaTarde.Location = new System.Drawing.Point(122, 35);
            this.rbEntradaTarde.Name = "rbEntradaTarde";
            this.rbEntradaTarde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbEntradaTarde.Size = new System.Drawing.Size(289, 29);
            this.rbEntradaTarde.TabIndex = 2;
            this.rbEntradaTarde.TabStop = true;
            this.rbEntradaTarde.Text = "Entrada volta da refeição";
            this.rbEntradaTarde.UseVisualStyleBackColor = true;
            // 
            // rbSaidaRefeicao
            // 
            this.rbSaidaRefeicao.AutoSize = true;
            this.rbSaidaRefeicao.Location = new System.Drawing.Point(122, 70);
            this.rbSaidaRefeicao.Name = "rbSaidaRefeicao";
            this.rbSaidaRefeicao.Size = new System.Drawing.Size(233, 29);
            this.rbSaidaRefeicao.TabIndex = 3;
            this.rbSaidaRefeicao.TabStop = true;
            this.rbSaidaRefeicao.Text = "Saída para refeição";
            this.rbSaidaRefeicao.UseVisualStyleBackColor = true;
            // 
            // rbSaidaTarde
            // 
            this.rbSaidaTarde.AutoSize = true;
            this.rbSaidaTarde.Location = new System.Drawing.Point(7, 69);
            this.rbSaidaTarde.Name = "rbSaidaTarde";
            this.rbSaidaTarde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbSaidaTarde.Size = new System.Drawing.Size(88, 29);
            this.rbSaidaTarde.TabIndex = 1;
            this.rbSaidaTarde.TabStop = true;
            this.rbSaidaTarde.Text = "Saída";
            this.rbSaidaTarde.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(7, 35);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(109, 29);
            this.rbEntrada.TabIndex = 0;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.White;
            this.btConfirmar.Location = new System.Drawing.Point(442, 170);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(158, 37);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbRG
            // 
            this.tbRG.BackColor = System.Drawing.Color.White;
            this.tbRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRG.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRG.ForeColor = System.Drawing.Color.Black;
            this.tbRG.Location = new System.Drawing.Point(443, 138);
            this.tbRG.Mask = "00,000,000-a";
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(157, 26);
            this.tbRG.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(195, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 32);
            this.label7.TabIndex = 106;
            this.label7.Text = "Acesso Funcionário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(440, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 121;
            this.label6.Text = "Digite o RG ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Acesso_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(648, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.gpbEvento);
            this.Controls.Add(this.btConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acesso_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Funcionario";
            this.gpbEvento.ResumeLayout(false);
            this.gpbEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEvento;
        private System.Windows.Forms.RadioButton rbSaidaTarde;
        private System.Windows.Forms.RadioButton rbEntrada;
        public System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.RadioButton rbEntradaTarde;
        private System.Windows.Forms.RadioButton rbSaidaRefeicao;
        private System.Windows.Forms.MaskedTextBox tbRG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}