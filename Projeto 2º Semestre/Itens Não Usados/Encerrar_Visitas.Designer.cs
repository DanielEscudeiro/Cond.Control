namespace Projeto_2º_Semestre
{
    partial class Encerrar_Visitas
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
            this.AtualizacaoAuto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.DtVisitas = new System.Windows.Forms.DataGridView();
            this.AtualizacaoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // AtualizacaoAuto
            // 
            this.AtualizacaoAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AtualizacaoAuto.AutoSize = true;
            this.AtualizacaoAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizacaoAuto.Location = new System.Drawing.Point(1060, 20);
            this.AtualizacaoAuto.Name = "AtualizacaoAuto";
            this.AtualizacaoAuto.Size = new System.Drawing.Size(265, 20);
            this.AtualizacaoAuto.TabIndex = 9;
            this.AtualizacaoAuto.Text = "Atualização da Tabela Automatica";
            this.AtualizacaoAuto.UseVisualStyleBackColor = true;
            this.AtualizacaoAuto.CheckedChanged += new System.EventHandler(this.AtualizacaoAuto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite Um Nome Para Pesquizar:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(12, 22);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(220, 20);
            this.TbNome.TabIndex = 7;
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.Location = new System.Drawing.Point(249, 13);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(83, 32);
            this.BtPesquisar.TabIndex = 6;
            this.BtPesquisar.Text = "Pesquizar";
            this.BtPesquisar.UseVisualStyleBackColor = true;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquizar_Click);
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
            this.DtVisitas.Location = new System.Drawing.Point(2, 49);
            this.DtVisitas.Name = "DtVisitas";
            this.DtVisitas.ReadOnly = true;
            this.DtVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVisitas.Size = new System.Drawing.Size(1333, 440);
            this.DtVisitas.TabIndex = 5;
            this.DtVisitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVisitas_CellDoubleClick);
            // 
            // AtualizacaoTimer
            // 
            this.AtualizacaoTimer.Interval = 1000;
            this.AtualizacaoTimer.Tick += new System.EventHandler(this.AtualizacaoTimer_Tick);
            // 
            // Encerrar_Visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 492);
            this.Controls.Add(this.AtualizacaoAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.BtPesquisar);
            this.Controls.Add(this.DtVisitas);
            this.Name = "Encerrar_Visitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encerrar_Visitas";
            ((System.ComponentModel.ISupportInitialize)(this.DtVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AtualizacaoAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.DataGridView DtVisitas;
        private System.Windows.Forms.Timer AtualizacaoTimer;
    }
}