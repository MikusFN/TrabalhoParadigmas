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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCodigoArtigo
            // 
            this.lbCodigoArtigo.AutoSize = true;
            this.lbCodigoArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArtigo.Location = new System.Drawing.Point(35, 80);
            this.lbCodigoArtigo.Name = "lbCodigoArtigo";
            this.lbCodigoArtigo.Size = new System.Drawing.Size(113, 17);
            this.lbCodigoArtigo.TabIndex = 0;
            this.lbCodigoArtigo.Text = "Codigo do Artigo";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(35, 230);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(98, 17);
            this.lbPreco.TabIndex = 1;
            this.lbPreco.Text = "Preço Unitario";
            // 
            // lbQuantidadeStock
            // 
            this.lbQuantidadeStock.AutoSize = true;
            this.lbQuantidadeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeStock.Location = new System.Drawing.Point(35, 180);
            this.lbQuantidadeStock.Name = "lbQuantidadeStock";
            this.lbQuantidadeStock.Size = new System.Drawing.Size(144, 17);
            this.lbQuantidadeStock.TabIndex = 2;
            this.lbQuantidadeStock.Text = "Quantidade em Stock";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(35, 280);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtBoxCodigoArtigo
            // 
            this.txtBoxCodigoArtigo.Location = new System.Drawing.Point(180, 80);
            this.txtBoxCodigoArtigo.Name = "txtBoxCodigoArtigo";
            this.txtBoxCodigoArtigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigoArtigo.TabIndex = 1;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(180, 230);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPreco.TabIndex = 4;
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Location = new System.Drawing.Point(180, 180);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantidade.TabIndex = 3;
            // 
            // richtxtDescricao
            // 
            this.richtxtDescricao.Location = new System.Drawing.Point(180, 280);
            this.richtxtDescricao.Name = "richtxtDescricao";
            this.richtxtDescricao.Size = new System.Drawing.Size(243, 153);
            this.richtxtDescricao.TabIndex = 5;
            this.richtxtDescricao.Text = "";
            // 
            // btnAdicionarArtigo
            // 
            this.btnAdicionarArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarArtigo.Location = new System.Drawing.Point(170, 450);
            this.btnAdicionarArtigo.Name = "btnAdicionarArtigo";
            this.btnAdicionarArtigo.Size = new System.Drawing.Size(150, 30);
            this.btnAdicionarArtigo.TabIndex = 6;
            this.btnAdicionarArtigo.Text = "Adicionar Artigo";
            this.btnAdicionarArtigo.UseVisualStyleBackColor = true;
            this.btnAdicionarArtigo.Click += new System.EventHandler(this.btnAdicionarArtigo_Click);
            // 
            // lbNomeArtigo
            // 
            this.lbNomeArtigo.AutoSize = true;
            this.lbNomeArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeArtigo.Location = new System.Drawing.Point(35, 130);
            this.lbNomeArtigo.Name = "lbNomeArtigo";
            this.lbNomeArtigo.Size = new System.Drawing.Size(106, 17);
            this.lbNomeArtigo.TabIndex = 9;
            this.lbNomeArtigo.Text = "Nome do Artigo";
            // 
            // txtBoxNomeArtigo
            // 
            this.txtBoxNomeArtigo.Location = new System.Drawing.Point(180, 130);
            this.txtBoxNomeArtigo.Name = "txtBoxNomeArtigo";
            this.txtBoxNomeArtigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeArtigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adicionar Artigo:";
            // 
            // FormAdicionarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdicionarArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
    }
}