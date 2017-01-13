namespace TrabalhoPraticoForm
{
    partial class GerirPontos
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
            this.buttonAtribuirCartão = new System.Windows.Forms.Button();
            this.buttonRegistarCompras = new System.Windows.Forms.Button();
            this.buttonConsultarCompras = new System.Windows.Forms.Button();
            this.buttonConsultarSaldo = new System.Windows.Forms.Button();
            this.buttonRecuar = new System.Windows.Forms.Button();
            this.dtGridGerirCartoes = new System.Windows.Forms.DataGridView();
            this.btAlterarCartao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGerirCartoes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtribuirCartão
            // 
            this.buttonAtribuirCartão.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtribuirCartão.Location = new System.Drawing.Point(50, 80);
            this.buttonAtribuirCartão.Name = "buttonAtribuirCartão";
            this.buttonAtribuirCartão.Size = new System.Drawing.Size(200, 30);
            this.buttonAtribuirCartão.TabIndex = 1;
            this.buttonAtribuirCartão.Text = "Adicionar um Cartão";
            this.buttonAtribuirCartão.UseMnemonic = false;
            this.buttonAtribuirCartão.UseVisualStyleBackColor = true;
            this.buttonAtribuirCartão.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRegistarCompras
            // 
            this.buttonRegistarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistarCompras.Location = new System.Drawing.Point(50, 220);
            this.buttonRegistarCompras.Name = "buttonRegistarCompras";
            this.buttonRegistarCompras.Size = new System.Drawing.Size(200, 30);
            this.buttonRegistarCompras.TabIndex = 3;
            this.buttonRegistarCompras.Text = "Registar Compras";
            this.buttonRegistarCompras.UseMnemonic = false;
            this.buttonRegistarCompras.UseVisualStyleBackColor = true;
            this.buttonRegistarCompras.Click += new System.EventHandler(this.buttonRegistarCompras_Click);
            // 
            // buttonConsultarCompras
            // 
            this.buttonConsultarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarCompras.Location = new System.Drawing.Point(50, 290);
            this.buttonConsultarCompras.Name = "buttonConsultarCompras";
            this.buttonConsultarCompras.Size = new System.Drawing.Size(200, 30);
            this.buttonConsultarCompras.TabIndex = 4;
            this.buttonConsultarCompras.Text = "Consultar Compras";
            this.buttonConsultarCompras.UseMnemonic = false;
            this.buttonConsultarCompras.UseVisualStyleBackColor = true;
            this.buttonConsultarCompras.Click += new System.EventHandler(this.buttonConsultarCompras_Click);
            // 
            // buttonConsultarSaldo
            // 
            this.buttonConsultarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarSaldo.Location = new System.Drawing.Point(50, 360);
            this.buttonConsultarSaldo.Name = "buttonConsultarSaldo";
            this.buttonConsultarSaldo.Size = new System.Drawing.Size(200, 30);
            this.buttonConsultarSaldo.TabIndex = 5;
            this.buttonConsultarSaldo.Text = "Consultar Saldo";
            this.buttonConsultarSaldo.UseMnemonic = false;
            this.buttonConsultarSaldo.UseVisualStyleBackColor = true;
            this.buttonConsultarSaldo.Click += new System.EventHandler(this.buttonConsultarSaldo_Click);
            // 
            // buttonRecuar
            // 
            this.buttonRecuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecuar.Location = new System.Drawing.Point(75, 450);
            this.buttonRecuar.Name = "buttonRecuar";
            this.buttonRecuar.Size = new System.Drawing.Size(150, 30);
            this.buttonRecuar.TabIndex = 6;
            this.buttonRecuar.Text = "Recuar";
            this.buttonRecuar.UseMnemonic = false;
            this.buttonRecuar.UseVisualStyleBackColor = true;
            this.buttonRecuar.Click += new System.EventHandler(this.buttonRecuar_Click);
            // 
            // dtGridGerirCartoes
            // 
            this.dtGridGerirCartoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGerirCartoes.Location = new System.Drawing.Point(300, 25);
            this.dtGridGerirCartoes.Name = "dtGridGerirCartoes";
            this.dtGridGerirCartoes.ReadOnly = true;
            this.dtGridGerirCartoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridGerirCartoes.Size = new System.Drawing.Size(375, 500);
            this.dtGridGerirCartoes.TabIndex = 5;
            // 
            // btAlterarCartao
            // 
            this.btAlterarCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarCartao.Location = new System.Drawing.Point(50, 150);
            this.btAlterarCartao.Name = "btAlterarCartao";
            this.btAlterarCartao.Size = new System.Drawing.Size(200, 30);
            this.btAlterarCartao.TabIndex = 2;
            this.btAlterarCartao.Text = "Alterar Informações";
            this.btAlterarCartao.UseVisualStyleBackColor = true;
            this.btAlterarCartao.Click += new System.EventHandler(this.btAlterarCartao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gerir Pontos:";
            // 
            // GerirPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAlterarCartao);
            this.Controls.Add(this.dtGridGerirCartoes);
            this.Controls.Add(this.buttonRecuar);
            this.Controls.Add(this.buttonConsultarSaldo);
            this.Controls.Add(this.buttonConsultarCompras);
            this.Controls.Add(this.buttonRegistarCompras);
            this.Controls.Add(this.buttonAtribuirCartão);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerirPontos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerirPontos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGerirCartoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtribuirCartão;
        private System.Windows.Forms.Button buttonRegistarCompras;
        private System.Windows.Forms.Button buttonConsultarCompras;
        private System.Windows.Forms.Button buttonConsultarSaldo;
        private System.Windows.Forms.Button buttonRecuar;
        private System.Windows.Forms.DataGridView dtGridGerirCartoes;
        private System.Windows.Forms.Button btAlterarCartao;
        private System.Windows.Forms.Label label1;
    }
}