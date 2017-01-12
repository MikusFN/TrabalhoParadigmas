namespace TrabalhoPraticoForm
{
    partial class SuperDume
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
            this.GuardarFicheiro = new System.Windows.Forms.Button();
            this.CarregarFicheiro = new System.Windows.Forms.Button();
            this.btGerirCartoes = new System.Windows.Forms.Button();
            this.btGerirArtigos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuardarFicheiro
            // 
            this.GuardarFicheiro.Location = new System.Drawing.Point(455, 370);
            this.GuardarFicheiro.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarFicheiro.Name = "GuardarFicheiro";
            this.GuardarFicheiro.Size = new System.Drawing.Size(147, 37);
            this.GuardarFicheiro.TabIndex = 0;
            this.GuardarFicheiro.Text = "Guardar Ficheiro";
            this.GuardarFicheiro.UseVisualStyleBackColor = true;
            this.GuardarFicheiro.Click += new System.EventHandler(this.GuardarFicheiro_Click);
            // 
            // CarregarFicheiro
            // 
            this.CarregarFicheiro.Location = new System.Drawing.Point(455, 311);
            this.CarregarFicheiro.Margin = new System.Windows.Forms.Padding(2);
            this.CarregarFicheiro.Name = "CarregarFicheiro";
            this.CarregarFicheiro.Size = new System.Drawing.Size(148, 41);
            this.CarregarFicheiro.TabIndex = 1;
            this.CarregarFicheiro.Text = "Carregar Ficheiro";
            this.CarregarFicheiro.UseVisualStyleBackColor = true;
            this.CarregarFicheiro.Click += new System.EventHandler(this.CarregarFicheiro_Click);
            // 
            // btGerirCartoes
            // 
            this.btGerirCartoes.Location = new System.Drawing.Point(455, 256);
            this.btGerirCartoes.Name = "btGerirCartoes";
            this.btGerirCartoes.Size = new System.Drawing.Size(147, 41);
            this.btGerirCartoes.TabIndex = 2;
            this.btGerirCartoes.Text = "Gerir Cartões";
            this.btGerirCartoes.UseVisualStyleBackColor = true;
            this.btGerirCartoes.Click += new System.EventHandler(this.btGerirCartoes_Click);
            // 
            // btGerirArtigos
            // 
            this.btGerirArtigos.Location = new System.Drawing.Point(455, 192);
            this.btGerirArtigos.Name = "btGerirArtigos";
            this.btGerirArtigos.Size = new System.Drawing.Size(147, 46);
            this.btGerirArtigos.TabIndex = 3;
            this.btGerirArtigos.Text = "Gerir Artigos";
            this.btGerirArtigos.UseVisualStyleBackColor = true;
            this.btGerirArtigos.Click += new System.EventHandler(this.btGerirArtigos_Click);
            // 
            // SuperDume
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(620, 426);
            this.Controls.Add(this.btGerirArtigos);
            this.Controls.Add(this.btGerirCartoes);
            this.Controls.Add(this.CarregarFicheiro);
            this.Controls.Add(this.GuardarFicheiro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SuperDume";
            this.Text = "SuperDume";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuardarFicheiro;
        private System.Windows.Forms.Button CarregarFicheiro;
        private System.Windows.Forms.Button btGerirCartoes;
        private System.Windows.Forms.Button btGerirArtigos;
    }
}