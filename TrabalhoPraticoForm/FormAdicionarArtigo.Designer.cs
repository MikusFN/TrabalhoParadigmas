namespace TrabalhoPraticoForm
{
    partial class FormAdicionarArtigo
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
            this.lbCodigoArtigo = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQuantidadeStock = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtBoxCodigoArtigo = new System.Windows.Forms.TextBox();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.txtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.richtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnAdicionarArtigo = new System.Windows.Forms.Button();
            this.lbNomeArtigo = new System.Windows.Forms.Label();
            this.txtBoxNomeArtigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCodigoArtigo
            // 
            this.lbCodigoArtigo.AutoSize = true;
            this.lbCodigoArtigo.Location = new System.Drawing.Point(65, 75);
            this.lbCodigoArtigo.Name = "lbCodigoArtigo";
            this.lbCodigoArtigo.Size = new System.Drawing.Size(85, 13);
            this.lbCodigoArtigo.TabIndex = 0;
            this.lbCodigoArtigo.Text = "Codigo do Artigo";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(65, 130);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(74, 13);
            this.lbPreco.TabIndex = 1;
            this.lbPreco.Text = "Preço Unitario";
            // 
            // lbQuantidadeStock
            // 
            this.lbQuantidadeStock.AutoSize = true;
            this.lbQuantidadeStock.Location = new System.Drawing.Point(65, 185);
            this.lbQuantidadeStock.Name = "lbQuantidadeStock";
            this.lbQuantidadeStock.Size = new System.Drawing.Size(110, 13);
            this.lbQuantidadeStock.TabIndex = 2;
            this.lbQuantidadeStock.Text = "Quantidade em Stock";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(65, 240);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtBoxCodigoArtigo
            // 
            this.txtBoxCodigoArtigo.Location = new System.Drawing.Point(156, 75);
            this.txtBoxCodigoArtigo.Name = "txtBoxCodigoArtigo";
            this.txtBoxCodigoArtigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigoArtigo.TabIndex = 4;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(145, 130);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPreco.TabIndex = 5;
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Location = new System.Drawing.Point(181, 185);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantidade.TabIndex = 6;
            // 
            // richtxtDescricao
            // 
            this.richtxtDescricao.Location = new System.Drawing.Point(145, 240);
            this.richtxtDescricao.Name = "richtxtDescricao";
            this.richtxtDescricao.Size = new System.Drawing.Size(243, 153);
            this.richtxtDescricao.TabIndex = 7;
            this.richtxtDescricao.Text = "";
            // 
            // btnAdicionarArtigo
            // 
            this.btnAdicionarArtigo.Location = new System.Drawing.Point(181, 412);
            this.btnAdicionarArtigo.Name = "btnAdicionarArtigo";
            this.btnAdicionarArtigo.Size = new System.Drawing.Size(153, 23);
            this.btnAdicionarArtigo.TabIndex = 8;
            this.btnAdicionarArtigo.Text = "Adicionar Artigo";
            this.btnAdicionarArtigo.UseVisualStyleBackColor = true;
            this.btnAdicionarArtigo.Click += new System.EventHandler(this.btnAdicionarArtigo_Click);
            // 
            // lbNomeArtigo
            // 
            this.lbNomeArtigo.AutoSize = true;
            this.lbNomeArtigo.Location = new System.Drawing.Point(298, 75);
            this.lbNomeArtigo.Name = "lbNomeArtigo";
            this.lbNomeArtigo.Size = new System.Drawing.Size(80, 13);
            this.lbNomeArtigo.TabIndex = 9;
            this.lbNomeArtigo.Text = "Nome do Artigo";
            // 
            // txtBoxNomeArtigo
            // 
            this.txtBoxNomeArtigo.Location = new System.Drawing.Point(384, 72);
            this.txtBoxNomeArtigo.Name = "txtBoxNomeArtigo";
            this.txtBoxNomeArtigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeArtigo.TabIndex = 10;
            // 
            // FormAdicionarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 447);
            this.Controls.Add(this.txtBoxNomeArtigo);
            this.Controls.Add(this.lbNomeArtigo);
            this.Controls.Add(this.btnAdicionarArtigo);
            this.Controls.Add(this.richtxtDescricao);
            this.Controls.Add(this.txtBoxQuantidade);
            this.Controls.Add(this.txtBoxPreco);
            this.Controls.Add(this.txtBoxCodigoArtigo);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbQuantidadeStock);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbCodigoArtigo);
            this.Name = "FormAdicionarArtigo";
            this.Text = "FormAdicionarArtigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoArtigo;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbQuantidadeStock;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox txtBoxCodigoArtigo;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.TextBox txtBoxQuantidade;
        private System.Windows.Forms.RichTextBox richtxtDescricao;
        private System.Windows.Forms.Button btnAdicionarArtigo;
        private System.Windows.Forms.Label lbNomeArtigo;
        private System.Windows.Forms.TextBox txtBoxNomeArtigo;
    }
}