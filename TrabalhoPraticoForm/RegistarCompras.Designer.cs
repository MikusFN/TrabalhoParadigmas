namespace TrabalhoPraticoForm
{
    partial class RegistarCompras
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonConcluirRegistar = new System.Windows.Forms.Button();
            this.comboBoxArtigos = new System.Windows.Forms.ComboBox();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.listbxCompras = new System.Windows.Forms.ListBox();
            this.btAdicionarCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(175, 230);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(51, 20);
            this.textBoxValor.TabIndex = 4;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(35, 230);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(112, 17);
            this.labelValor.TabIndex = 15;
            this.labelValor.Text = "Valor de compra";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(35, 180);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(86, 17);
            this.labelQuantidade.TabIndex = 13;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(175, 130);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(35, 130);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(75, 17);
            this.labelDescricao.TabIndex = 11;
            this.labelDescricao.Text = "Descricao:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(35, 80);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(117, 17);
            this.labelCodigo.TabIndex = 9;
            this.labelCodigo.Text = "Codigo do Artigo:";
            // 
            // buttonConcluirRegistar
            // 
            this.buttonConcluirRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConcluirRegistar.Location = new System.Drawing.Point(135, 450);
            this.buttonConcluirRegistar.Name = "buttonConcluirRegistar";
            this.buttonConcluirRegistar.Size = new System.Drawing.Size(150, 30);
            this.buttonConcluirRegistar.TabIndex = 6;
            this.buttonConcluirRegistar.Text = "Concluir";
            this.buttonConcluirRegistar.UseVisualStyleBackColor = true;
            this.buttonConcluirRegistar.Click += new System.EventHandler(this.buttonConcluirRegistar_Click);
            // 
            // comboBoxArtigos
            // 
            this.comboBoxArtigos.FormattingEnabled = true;
            this.comboBoxArtigos.Location = new System.Drawing.Point(175, 80);
            this.comboBoxArtigos.Name = "comboBoxArtigos";
            this.comboBoxArtigos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArtigos.TabIndex = 1;
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(175, 180);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(34, 20);
            this.numericQuantidade.TabIndex = 3;
            this.numericQuantidade.ValueChanged += new System.EventHandler(this.numericQuantidade_ValueChanged);
            // 
            // listbxCompras
            // 
            this.listbxCompras.FormattingEnabled = true;
            this.listbxCompras.Location = new System.Drawing.Point(400, 25);
            this.listbxCompras.Name = "listbxCompras";
            this.listbxCompras.Size = new System.Drawing.Size(268, 498);
            this.listbxCompras.TabIndex = 20;
            // 
            // btAdicionarCompra
            // 
            this.btAdicionarCompra.Location = new System.Drawing.Point(50, 300);
            this.btAdicionarCompra.Name = "btAdicionarCompra";
            this.btAdicionarCompra.Size = new System.Drawing.Size(300, 30);
            this.btAdicionarCompra.TabIndex = 5;
            this.btAdicionarCompra.Text = "Adicionar Compra";
            this.btAdicionarCompra.UseVisualStyleBackColor = true;
            this.btAdicionarCompra.Click += new System.EventHandler(this.btAdicionarCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registar Compras:";
            // 
            // RegistarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdicionarCompra);
            this.Controls.Add(this.listbxCompras);
            this.Controls.Add(this.numericQuantidade);
            this.Controls.Add(this.comboBoxArtigos);
            this.Controls.Add(this.buttonConcluirRegistar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistarCompras";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonConcluirRegistar;
        private System.Windows.Forms.ComboBox comboBoxArtigos;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.ListBox listbxCompras;
        private System.Windows.Forms.Button btAdicionarCompra;
        private System.Windows.Forms.Label label1;
    }
}