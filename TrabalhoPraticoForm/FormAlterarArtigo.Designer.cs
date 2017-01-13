namespace TrabalhoPraticoForm
{
    partial class FormAlterarArtigo
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
            this.txtBoxNomeArtigo2 = new System.Windows.Forms.TextBox();
            this.lbNomeArtigo = new System.Windows.Forms.Label();
            this.btnAlterarArtigo = new System.Windows.Forms.Button();
            this.richtxtDescricao2 = new System.Windows.Forms.RichTextBox();
            this.txtBoxQuantidade2 = new System.Windows.Forms.TextBox();
            this.txtBoxPreco2 = new System.Windows.Forms.TextBox();
            this.txtBoxCodigoArtigo2 = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbQuantidadeStock = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbCodigoArtigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNomeArtigo2
            // 
            this.txtBoxNomeArtigo2.Location = new System.Drawing.Point(180, 130);
            this.txtBoxNomeArtigo2.Name = "txtBoxNomeArtigo2";
            this.txtBoxNomeArtigo2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeArtigo2.TabIndex = 2;
            // 
            // lbNomeArtigo
            // 
            this.lbNomeArtigo.AutoSize = true;
            this.lbNomeArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeArtigo.Location = new System.Drawing.Point(35, 130);
            this.lbNomeArtigo.Name = "lbNomeArtigo";
            this.lbNomeArtigo.Size = new System.Drawing.Size(110, 17);
            this.lbNomeArtigo.TabIndex = 20;
            this.lbNomeArtigo.Text = "Nome do Artigo:";
            // 
            // btnAlterarArtigo
            // 
            this.btnAlterarArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarArtigo.Location = new System.Drawing.Point(170, 450);
            this.btnAlterarArtigo.Name = "btnAlterarArtigo";
            this.btnAlterarArtigo.Size = new System.Drawing.Size(150, 30);
            this.btnAlterarArtigo.TabIndex = 6;
            this.btnAlterarArtigo.Text = "Alterar Artigo";
            this.btnAlterarArtigo.UseVisualStyleBackColor = true;
            this.btnAlterarArtigo.Click += new System.EventHandler(this.btnAlterarArtigo_Click);
            // 
            // richtxtDescricao2
            // 
            this.richtxtDescricao2.Location = new System.Drawing.Point(180, 280);
            this.richtxtDescricao2.Name = "richtxtDescricao2";
            this.richtxtDescricao2.Size = new System.Drawing.Size(243, 153);
            this.richtxtDescricao2.TabIndex = 5;
            this.richtxtDescricao2.Text = "";
            // 
            // txtBoxQuantidade2
            // 
            this.txtBoxQuantidade2.Location = new System.Drawing.Point(180, 180);
            this.txtBoxQuantidade2.Name = "txtBoxQuantidade2";
            this.txtBoxQuantidade2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantidade2.TabIndex = 3;
            // 
            // txtBoxPreco2
            // 
            this.txtBoxPreco2.Location = new System.Drawing.Point(180, 230);
            this.txtBoxPreco2.Name = "txtBoxPreco2";
            this.txtBoxPreco2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPreco2.TabIndex = 4;
            // 
            // txtBoxCodigoArtigo2
            // 
            this.txtBoxCodigoArtigo2.Location = new System.Drawing.Point(180, 80);
            this.txtBoxCodigoArtigo2.Name = "txtBoxCodigoArtigo2";
            this.txtBoxCodigoArtigo2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigoArtigo2.TabIndex = 1;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(35, 280);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(75, 17);
            this.lbDescricao.TabIndex = 14;
            this.lbDescricao.Text = "Descrição:";
            // 
            // lbQuantidadeStock
            // 
            this.lbQuantidadeStock.AutoSize = true;
            this.lbQuantidadeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeStock.Location = new System.Drawing.Point(35, 180);
            this.lbQuantidadeStock.Name = "lbQuantidadeStock";
            this.lbQuantidadeStock.Size = new System.Drawing.Size(148, 17);
            this.lbQuantidadeStock.TabIndex = 13;
            this.lbQuantidadeStock.Text = "Quantidade em Stock:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(35, 230);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(102, 17);
            this.lbPreco.TabIndex = 12;
            this.lbPreco.Text = "Preço Unitario:";
            // 
            // lbCodigoArtigo
            // 
            this.lbCodigoArtigo.AutoSize = true;
            this.lbCodigoArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArtigo.Location = new System.Drawing.Point(35, 80);
            this.lbCodigoArtigo.Name = "lbCodigoArtigo";
            this.lbCodigoArtigo.Size = new System.Drawing.Size(117, 17);
            this.lbCodigoArtigo.TabIndex = 11;
            this.lbCodigoArtigo.Text = "Codigo do Artigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Alterar Artigo:";
            // 
            // FormAlterarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNomeArtigo2);
            this.Controls.Add(this.lbNomeArtigo);
            this.Controls.Add(this.btnAlterarArtigo);
            this.Controls.Add(this.richtxtDescricao2);
            this.Controls.Add(this.txtBoxQuantidade2);
            this.Controls.Add(this.txtBoxPreco2);
            this.Controls.Add(this.txtBoxCodigoArtigo2);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbQuantidadeStock);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbCodigoArtigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlterarArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlterarArtigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNomeArtigo2;
        private System.Windows.Forms.Label lbNomeArtigo;
        private System.Windows.Forms.Button btnAlterarArtigo;
        private System.Windows.Forms.RichTextBox richtxtDescricao2;
        private System.Windows.Forms.TextBox txtBoxQuantidade2;
        private System.Windows.Forms.TextBox txtBoxPreco2;
        private System.Windows.Forms.TextBox txtBoxCodigoArtigo2;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbQuantidadeStock;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbCodigoArtigo;
        private System.Windows.Forms.Label label1;
    }
}