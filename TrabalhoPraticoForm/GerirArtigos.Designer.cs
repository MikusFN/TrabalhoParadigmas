namespace TrabalhoPraticoForm
{
    partial class GerirArtigos
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
            this.dtGridArtigos = new System.Windows.Forms.DataGridView();
            this.btAdicionarArt = new System.Windows.Forms.Button();
            this.btRemoverArt = new System.Windows.Forms.Button();
            this.btAlterarArtigo = new System.Windows.Forms.Button();
            this.lbGerirArtigos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridArtigos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridArtigos
            // 
            this.dtGridArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridArtigos.Location = new System.Drawing.Point(12, 36);
            this.dtGridArtigos.Name = "dtGridArtigos";
            this.dtGridArtigos.Size = new System.Drawing.Size(393, 467);
            this.dtGridArtigos.TabIndex = 0;
            // 
            // btAdicionarArt
            // 
            this.btAdicionarArt.Location = new System.Drawing.Point(459, 128);
            this.btAdicionarArt.Name = "btAdicionarArt";
            this.btAdicionarArt.Size = new System.Drawing.Size(115, 23);
            this.btAdicionarArt.TabIndex = 1;
            this.btAdicionarArt.Text = "Adicionar Artigo";
            this.btAdicionarArt.UseVisualStyleBackColor = true;
            this.btAdicionarArt.Click += new System.EventHandler(this.btAdicionarArt_Click);
            // 
            // btRemoverArt
            // 
            this.btRemoverArt.Location = new System.Drawing.Point(459, 187);
            this.btRemoverArt.Name = "btRemoverArt";
            this.btRemoverArt.Size = new System.Drawing.Size(115, 23);
            this.btRemoverArt.TabIndex = 2;
            this.btRemoverArt.Text = "Remover Artigo";
            this.btRemoverArt.UseVisualStyleBackColor = true;
            this.btRemoverArt.Click += new System.EventHandler(this.btRemoverArt_Click);
            // 
            // btAlterarArtigo
            // 
            this.btAlterarArtigo.Location = new System.Drawing.Point(459, 243);
            this.btAlterarArtigo.Name = "btAlterarArtigo";
            this.btAlterarArtigo.Size = new System.Drawing.Size(115, 23);
            this.btAlterarArtigo.TabIndex = 3;
            this.btAlterarArtigo.Text = "Alterar Artigo";
            this.btAlterarArtigo.UseVisualStyleBackColor = true;
            // 
            // lbGerirArtigos
            // 
            this.lbGerirArtigos.AutoSize = true;
            this.lbGerirArtigos.Location = new System.Drawing.Point(23, 13);
            this.lbGerirArtigos.Name = "lbGerirArtigos";
            this.lbGerirArtigos.Size = new System.Drawing.Size(39, 13);
            this.lbGerirArtigos.TabIndex = 4;
            this.lbGerirArtigos.Text = "Artigos";
            // 
            // GerirArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 530);
            this.Controls.Add(this.lbGerirArtigos);
            this.Controls.Add(this.btAlterarArtigo);
            this.Controls.Add(this.btRemoverArt);
            this.Controls.Add(this.btAdicionarArt);
            this.Controls.Add(this.dtGridArtigos);
            this.Name = "GerirArtigos";
            this.Text = "GerirArtigos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridArtigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridArtigos;
        private System.Windows.Forms.Button btAdicionarArt;
        private System.Windows.Forms.Button btRemoverArt;
        private System.Windows.Forms.Button btAlterarArtigo;
        private System.Windows.Forms.Label lbGerirArtigos;
    }
}