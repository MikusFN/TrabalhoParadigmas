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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuardarFicheiro
            // 
            this.GuardarFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarFicheiro.Location = new System.Drawing.Point(75, 300);
            this.GuardarFicheiro.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarFicheiro.Name = "GuardarFicheiro";
            this.GuardarFicheiro.Size = new System.Drawing.Size(150, 30);
            this.GuardarFicheiro.TabIndex = 4;
            this.GuardarFicheiro.Text = "Guardar Ficheiro";
            this.GuardarFicheiro.UseVisualStyleBackColor = true;
            this.GuardarFicheiro.Click += new System.EventHandler(this.GuardarFicheiro_Click);
            // 
            // CarregarFicheiro
            // 
            this.CarregarFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarregarFicheiro.Location = new System.Drawing.Point(75, 230);
            this.CarregarFicheiro.Margin = new System.Windows.Forms.Padding(2);
            this.CarregarFicheiro.Name = "CarregarFicheiro";
            this.CarregarFicheiro.Size = new System.Drawing.Size(150, 30);
            this.CarregarFicheiro.TabIndex = 3;
            this.CarregarFicheiro.Text = "Carregar Ficheiro";
            this.CarregarFicheiro.UseVisualStyleBackColor = true;
            this.CarregarFicheiro.Click += new System.EventHandler(this.CarregarFicheiro_Click);
            // 
            // btGerirCartoes
            // 
            this.btGerirCartoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerirCartoes.Location = new System.Drawing.Point(75, 160);
            this.btGerirCartoes.Name = "btGerirCartoes";
            this.btGerirCartoes.Size = new System.Drawing.Size(150, 30);
            this.btGerirCartoes.TabIndex = 2;
            this.btGerirCartoes.Text = "Gerir Cartões";
            this.btGerirCartoes.UseVisualStyleBackColor = true;
            this.btGerirCartoes.Click += new System.EventHandler(this.btGerirCartoes_Click);
            // 
            // btGerirArtigos
            // 
            this.btGerirArtigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerirArtigos.Location = new System.Drawing.Point(75, 90);
            this.btGerirArtigos.Name = "btGerirArtigos";
            this.btGerirArtigos.Size = new System.Drawing.Size(150, 30);
            this.btGerirArtigos.TabIndex = 1;
            this.btGerirArtigos.Text = "Gerir Artigos";
            this.btGerirArtigos.UseVisualStyleBackColor = true;
            this.btGerirArtigos.Click += new System.EventHandler(this.btGerirArtigos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "SuperDume";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuperDume
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGerirArtigos);
            this.Controls.Add(this.btGerirCartoes);
            this.Controls.Add(this.CarregarFicheiro);
            this.Controls.Add(this.GuardarFicheiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SuperDume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperDume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarFicheiro;
        private System.Windows.Forms.Button CarregarFicheiro;
        private System.Windows.Forms.Button btGerirCartoes;
        private System.Windows.Forms.Button btGerirArtigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}