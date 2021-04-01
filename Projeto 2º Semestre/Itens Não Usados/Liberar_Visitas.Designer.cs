namespace Projeto_2º_Semestre
{
    partial class Liberar_Visitas
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
            this.DtVisitas = new System.Windows.Forms.DataGridView();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AtualizacaoAuto = new System.Windows.Forms.CheckBox();
            this.AtualizacaoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // DtVisitas
            // 
            this.DtVisitas.AllowUserToAddRows = false;
            this.DtVisitas.AllowUserToDeleteRows = false;
            this.DtVisitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVisitas.Location = new System.Drawing.Point(3, 53);
            this.DtVisitas.Name = "DtVisitas";
            this.DtVisitas.ReadOnly = true;
            this.DtVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVisitas.Size = new System.Drawing.Size(1331, 436);
            this.DtVisitas.TabIndex = 0;
            this.DtVisitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVisitas_CellDoubleClick);
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.Location = new System.Drawing.Point(249, 17);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(83, 32);
            this.BtPesquisar.TabIndex = 1;
            this.BtPesquisar.Text = "Pesquizar";
            this.BtPesquisar.UseVisualStyleBackColor = true;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquizar_Click);
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(12, 26);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(220, 20);
            this.TbNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite Um Nome Para Pesquizar:";
            // 
            // AtualizacaoAuto
            // 
            this.AtualizacaoAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AtualizacaoAuto.AutoSize = true;
            this.AtualizacaoAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizacaoAuto.Location = new System.Drawing.Point(1060, 24);
            this.AtualizacaoAuto.Name = "AtualizacaoAuto";
            this.AtualizacaoAuto.Size = new System.Drawing.Size(265, 20);
            this.AtualizacaoAuto.TabIndex = 4;
            this.AtualizacaoAuto.Text = "Atualização da Tabela Automatica";
            this.AtualizacaoAuto.UseVisualStyleBackColor = true;
            this.AtualizacaoAuto.CheckedChanged += new System.EventHandler(this.AtualizacaoAuto_CheckedChanged);
            // 
            // AtualizacaoTimer
            // 
            this.AtualizacaoTimer.Interval = 1000;
            this.AtualizacaoTimer.Tick += new System.EventHandler(this.AtualizacaoTimer_Tick);
            // 
            // Liberar_Visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 492);
            this.Controls.Add(this.AtualizacaoAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.BtPesquisar);
            this.Controls.Add(this.DtVisitas);
            this.Name = "Liberar_Visitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberar Visitas";
            ((System.ComponentModel.ISupportInitialize)(this.DtVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AtualizacaoAuto;
        private System.Windows.Forms.Timer AtualizacaoTimer;
        public System.Windows.Forms.DataGridView DtVisitas;
    }
}