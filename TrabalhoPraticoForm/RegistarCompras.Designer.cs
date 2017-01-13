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
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(460, 335);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(51, 20);
            this.textBoxValor.TabIndex = 16;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(370, 335);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(84, 13);
            this.labelValor.TabIndex = 15;
            this.labelValor.Text = "Valor de compra";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(41, 156);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(65, 13);
            this.labelQuantidade.TabIndex = 13;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(124, 99);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricao.TabIndex = 12;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(41, 99);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.TabIndex = 11;
            this.labelDescricao.Text = "Descricao:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(41, 42);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(88, 13);
            this.labelCodigo.TabIndex = 9;
            this.labelCodigo.Text = "Codigo do Artigo:";
            // 
            // buttonConcluirRegistar
            // 
            this.buttonConcluirRegistar.Location = new System.Drawing.Point(313, 445);
            this.buttonConcluirRegistar.Name = "buttonConcluirRegistar";
            this.buttonConcluirRegistar.Size = new System.Drawing.Size(75, 23);
            this.buttonConcluirRegistar.TabIndex = 17;
            this.buttonConcluirRegistar.Text = "Concluir";
            this.buttonConcluirRegistar.UseVisualStyleBackColor = true;
            this.buttonConcluirRegistar.Click += new System.EventHandler(this.buttonConcluirRegistar_Click);
            // 
            // comboBoxArtigos
            // 
            this.comboBoxArtigos.FormattingEnabled = true;
            this.comboBoxArtigos.Location = new System.Drawing.Point(136, 42);
            this.comboBoxArtigos.Name = "comboBoxArtigos";
            this.comboBoxArtigos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArtigos.TabIndex = 18;
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(124, 156);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(34, 20);
            this.numericQuantidade.TabIndex = 19;
            this.numericQuantidade.ValueChanged += new System.EventHandler(this.numericQuantidade_ValueChanged);
            // 
            // listbxCompras
            // 
            this.listbxCompras.FormattingEnabled = true;
            this.listbxCompras.Location = new System.Drawing.Point(373, 42);
            this.listbxCompras.Name = "listbxCompras";
            this.listbxCompras.Size = new System.Drawing.Size(268, 290);
            this.listbxCompras.TabIndex = 20;
            // 
            // btAdicionarCompra
            // 
            this.btAdicionarCompra.Location = new System.Drawing.Point(194, 239);
            this.btAdicionarCompra.Name = "btAdicionarCompra";
            this.btAdicionarCompra.Size = new System.Drawing.Size(139, 23);
            this.btAdicionarCompra.TabIndex = 21;
            this.btAdicionarCompra.Text = "Adicionar Compra";
            this.btAdicionarCompra.UseVisualStyleBackColor = true;
            this.btAdicionarCompra.Click += new System.EventHandler(this.btAdicionarCompra_Click);
            // 
            // RegistarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 544);
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
            this.Name = "RegistarCompras";
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
    }
}