namespace Cond._Control
{
    partial class Relatorio_de_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_de_Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtVisitas = new System.Windows.Forms.DataGridView();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.BtPesquizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Código do Funcionário",
            "Nome do Funcionário",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(15, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 27);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "0 Cadastros foram encontrados!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(531, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 32);
            this.label4.TabIndex = 67;
            this.label4.Text = "Relatório de Usuários";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1295, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TbPesquisa
            // 
            this.TbPesquisa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPesquisa.Location = new System.Drawing.Point(262, 78);
            this.TbPesquisa.Name = "TbPesquisa";
            this.TbPesquisa.Size = new System.Drawing.Size(126, 28);
            this.TbPesquisa.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Selecione um Item:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Digite um Nome Para Buscar:";
            // 
            // DtVisitas
            // 
            this.DtVisitas.AllowUserToAddRows = false;
            this.DtVisitas.AllowUserToDeleteRows = false;
            this.DtVisitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtVisitas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtVisitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVisitas.GridColor = System.Drawing.Color.White;
            this.DtVisitas.Location = new System.Drawing.Point(7, 112);
            this.DtVisitas.Name = "DtVisitas";
            this.DtVisitas.ReadOnly = true;
            this.DtVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVisitas.Size = new System.Drawing.Size(1321, 475);
            this.DtVisitas.TabIndex = 62;
            this.DtVisitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVisitas_CellDoubleClick);
            // 
            // TbNome
            // 
            this.TbNome.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNome.Location = new System.Drawing.Point(262, 78);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(270, 28);
            this.TbNome.TabIndex = 64;
            // 
            // BtPesquizar
            // 
            this.BtPesquizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtPesquizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtPesquizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtPesquizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPesquizar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquizar.ForeColor = System.Drawing.Color.White;
            this.BtPesquizar.Location = new System.Drawing.Point(538, 75);
            this.BtPesquizar.Name = "BtPesquizar";
            this.BtPesquizar.Size = new System.Drawing.Size(121, 30);
            this.BtPesquizar.TabIndex = 70;
            this.BtPesquizar.Text = "Pesquisar";
            this.BtPesquizar.UseVisualStyleBackColor = false;
            this.BtPesquizar.Click += new System.EventHandler(this.BtPesquizar_Click);
            // 
            // Relatorio_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1337, 616);
            this.Controls.Add(this.BtPesquizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtVisitas);
            this.Controls.Add(this.TbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio_de_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_de_Usuarios";
            this.Load += new System.EventHandler(this.Relatorio_de_Usuarios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Relatorio_de_Usuarios_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox TbPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtVisitas;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Button BtPesquizar;
    }
}