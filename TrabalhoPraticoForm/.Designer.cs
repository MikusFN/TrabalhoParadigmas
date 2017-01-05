namespace TrabalhoPraticoForm
{
    partial class Form1
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
            this.buttonAdicionarArtigo = new System.Windows.Forms.Button();
            this.buttonActualizarStock = new System.Windows.Forms.Button();
            this.buttonEliminarArtigo = new System.Windows.Forms.Button();
            this.buttonConsultarArtigos = new System.Windows.Forms.Button();
            this.buttonVoltaramenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdicionarArtigo
            // 
            this.buttonAdicionarArtigo.Location = new System.Drawing.Point(313, 90);
            this.buttonAdicionarArtigo.Name = "buttonAdicionarArtigo";
            this.buttonAdicionarArtigo.Size = new System.Drawing.Size(100, 40);
            this.buttonAdicionarArtigo.TabIndex = 0;
            this.buttonAdicionarArtigo.Text = "Adicionar Artigo";
            this.buttonAdicionarArtigo.UseVisualStyleBackColor = true;
            // 
            // buttonActualizarStock
            // 
            this.buttonActualizarStock.Location = new System.Drawing.Point(313, 165);
            this.buttonActualizarStock.Name = "buttonActualizarStock";
            this.buttonActualizarStock.Size = new System.Drawing.Size(100, 40);
            this.buttonActualizarStock.TabIndex = 2;
            this.buttonActualizarStock.Text = "Actualizar";
            this.buttonActualizarStock.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarArtigo
            // 
            this.buttonEliminarArtigo.Location = new System.Drawing.Point(313, 245);
            this.buttonEliminarArtigo.Name = "buttonEliminarArtigo";
            this.buttonEliminarArtigo.Size = new System.Drawing.Size(100, 40);
            this.buttonEliminarArtigo.TabIndex = 3;
            this.buttonEliminarArtigo.Text = "Eliminar Artigo";
            this.buttonEliminarArtigo.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarArtigos
            // 
            this.buttonConsultarArtigos.Location = new System.Drawing.Point(313, 317);
            this.buttonConsultarArtigos.Name = "buttonConsultarArtigos";
            this.buttonConsultarArtigos.Size = new System.Drawing.Size(100, 40);
            this.buttonConsultarArtigos.TabIndex = 4;
            this.buttonConsultarArtigos.Text = "Consultar Artigos";
            this.buttonConsultarArtigos.UseVisualStyleBackColor = true;
            // 
            // buttonVoltaramenu
            // 
            this.buttonVoltaramenu.Location = new System.Drawing.Point(313, 408);
            this.buttonVoltaramenu.Name = "buttonVoltaramenu";
            this.buttonVoltaramenu.Size = new System.Drawing.Size(100, 40);
            this.buttonVoltaramenu.TabIndex = 5;
            this.buttonVoltaramenu.Text = "Sair";
            this.buttonVoltaramenu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonVoltaramenu);
            this.Controls.Add(this.buttonConsultarArtigos);
            this.Controls.Add(this.buttonEliminarArtigo);
            this.Controls.Add(this.buttonActualizarStock);
            this.Controls.Add(this.buttonAdicionarArtigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionarArtigo;
        private System.Windows.Forms.Button buttonActualizarStock;
        private System.Windows.Forms.Button buttonEliminarArtigo;
        private System.Windows.Forms.Button buttonConsultarArtigos;
        private System.Windows.Forms.Button buttonVoltaramenu;
    }
}

