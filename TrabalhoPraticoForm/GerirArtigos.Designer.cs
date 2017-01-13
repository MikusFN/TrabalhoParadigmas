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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridArtigos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridArtigos
            // 
            this.dtGridArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridArtigos.Location = new System.Drawing.Point(300, 25);
            this.dtGridArtigos.Name = "dtGridArtigos";
            this.dtGridArtigos.ReadOnly = true;
            this.dtGridArtigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridArtigos.Size = new System.Drawing.Size(375, 500);
            this.dtGridArtigos.TabIndex = 0;
            // 
            // btAdicionarArt
            // 
            this.btAdicionarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarArt.Location = new System.Drawing.Point(50, 80);
            this.btAdicionarArt.Name = "btAdicionarArt";
            this.btAdicionarArt.Size = new System.Drawing.Size(200, 30);
            this.btAdicionarArt.TabIndex = 1;
            this.btAdicionarArt.Text = "Adicionar Artigo";
            this.btAdicionarArt.UseVisualStyleBackColor = true;
            this.btAdicionarArt.Click += new System.EventHandler(this.btAdicionarArt_Click);
            // 
            // btRemoverArt
            // 
            this.btRemoverArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverArt.Location = new System.Drawing.Point(50, 150);
            this.btRemoverArt.Name = "btRemoverArt";
            this.btRemoverArt.Size = new System.Drawing.Size(200, 30);
            this.btRemoverArt.TabIndex = 2;
            this.btRemoverArt.Text = "Remover Artigo";
            this.btRemoverArt.UseVisualStyleBackColor = true;
            this.btRemoverArt.Click += new System.EventHandler(this.btRemoverArt_Click);
            // 
            // btAlterarArtigo
            // 
            this.btAlterarArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarArtigo.Location = new System.Drawing.Point(50, 220);
            this.btAlterarArtigo.Name = "btAlterarArtigo";
            this.btAlterarArtigo.Size = new System.Drawing.Size(200, 30);
            this.btAlterarArtigo.TabIndex = 3;
            this.btAlterarArtigo.Text = "Alterar Artigo";
            this.btAlterarArtigo.UseVisualStyleBackColor = true;
            this.btAlterarArtigo.Click += new System.EventHandler(this.btAlterarArtigo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Recuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Gerir Artigos:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(50, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = "Atualizar Artigo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GerirArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAlterarArtigo);
            this.Controls.Add(this.btRemoverArt);
            this.Controls.Add(this.btAdicionarArt);
            this.Controls.Add(this.dtGridArtigos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirArtigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}