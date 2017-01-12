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
            this.SuspendLayout();
            // 
            // GuardarFicheiro
            // 
            this.GuardarFicheiro.Location = new System.Drawing.Point(607, 455);
            this.GuardarFicheiro.Name = "GuardarFicheiro";
            this.GuardarFicheiro.Size = new System.Drawing.Size(196, 46);
            this.GuardarFicheiro.TabIndex = 0;
            this.GuardarFicheiro.Text = "Guardar Ficheiro";
            this.GuardarFicheiro.UseVisualStyleBackColor = true;
            this.GuardarFicheiro.Click += new System.EventHandler(this.GuardarFicheiro_Click);
            // 
            // CarregarFicheiro
            // 
            this.CarregarFicheiro.Location = new System.Drawing.Point(607, 383);
            this.CarregarFicheiro.Name = "CarregarFicheiro";
            this.CarregarFicheiro.Size = new System.Drawing.Size(197, 50);
            this.CarregarFicheiro.TabIndex = 1;
            this.CarregarFicheiro.Text = "Carregar Ficheiro";
            this.CarregarFicheiro.UseVisualStyleBackColor = true;
            this.CarregarFicheiro.Click += new System.EventHandler(this.CarregarFicheiro_Click);
            // 
            // SuperDume
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.CarregarFicheiro);
            this.Controls.Add(this.GuardarFicheiro);
            this.Name = "SuperDume";
            this.Text = "SuperDume";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuardarFicheiro;
        private System.Windows.Forms.Button CarregarFicheiro;
    }
}