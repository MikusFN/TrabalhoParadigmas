﻿namespace TrabalhoPraticoForm
{
    partial class GerirPontos
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
            this.buttonAtribuirCartão = new System.Windows.Forms.Button();
            this.buttonRegistarCompras = new System.Windows.Forms.Button();
            this.buttonConsultarCompras = new System.Windows.Forms.Button();
            this.buttonConsultarSaldo = new System.Windows.Forms.Button();
            this.buttonRecuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAtribuirCartão
            // 
            this.buttonAtribuirCartão.Location = new System.Drawing.Point(78, 65);
            this.buttonAtribuirCartão.Name = "buttonAtribuirCartão";
            this.buttonAtribuirCartão.Size = new System.Drawing.Size(124, 23);
            this.buttonAtribuirCartão.TabIndex = 0;
            this.buttonAtribuirCartão.Text = "Atribuir Cartão";
            this.buttonAtribuirCartão.UseMnemonic = false;
            this.buttonAtribuirCartão.UseVisualStyleBackColor = true;
            this.buttonAtribuirCartão.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRegistarCompras
            // 
            this.buttonRegistarCompras.Location = new System.Drawing.Point(78, 174);
            this.buttonRegistarCompras.Name = "buttonRegistarCompras";
            this.buttonRegistarCompras.Size = new System.Drawing.Size(124, 23);
            this.buttonRegistarCompras.TabIndex = 1;
            this.buttonRegistarCompras.Text = "Registar Compras";
            this.buttonRegistarCompras.UseMnemonic = false;
            this.buttonRegistarCompras.UseVisualStyleBackColor = true;
            this.buttonRegistarCompras.Click += new System.EventHandler(this.buttonRegistarCompras_Click);
            // 
            // buttonConsultarCompras
            // 
            this.buttonConsultarCompras.Location = new System.Drawing.Point(78, 280);
            this.buttonConsultarCompras.Name = "buttonConsultarCompras";
            this.buttonConsultarCompras.Size = new System.Drawing.Size(124, 23);
            this.buttonConsultarCompras.TabIndex = 2;
            this.buttonConsultarCompras.Text = "Consultar Compras";
            this.buttonConsultarCompras.UseMnemonic = false;
            this.buttonConsultarCompras.UseVisualStyleBackColor = true;
            this.buttonConsultarCompras.Click += new System.EventHandler(this.buttonConsultarCompras_Click);
            // 
            // buttonConsultarSaldo
            // 
            this.buttonConsultarSaldo.Location = new System.Drawing.Point(78, 375);
            this.buttonConsultarSaldo.Name = "buttonConsultarSaldo";
            this.buttonConsultarSaldo.Size = new System.Drawing.Size(124, 23);
            this.buttonConsultarSaldo.TabIndex = 3;
            this.buttonConsultarSaldo.Text = "Consultar Saldo";
            this.buttonConsultarSaldo.UseMnemonic = false;
            this.buttonConsultarSaldo.UseVisualStyleBackColor = true;
            this.buttonConsultarSaldo.Click += new System.EventHandler(this.buttonConsultarSaldo_Click);
            // 
            // buttonRecuar
            // 
            this.buttonRecuar.Location = new System.Drawing.Point(78, 482);
            this.buttonRecuar.Name = "buttonRecuar";
            this.buttonRecuar.Size = new System.Drawing.Size(124, 23);
            this.buttonRecuar.TabIndex = 4;
            this.buttonRecuar.Text = "Recuar";
            this.buttonRecuar.UseMnemonic = false;
            this.buttonRecuar.UseVisualStyleBackColor = true;
            this.buttonRecuar.Click += new System.EventHandler(this.buttonRecuar_Click);
            // 
            // GerirPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.buttonRecuar);
            this.Controls.Add(this.buttonConsultarSaldo);
            this.Controls.Add(this.buttonConsultarCompras);
            this.Controls.Add(this.buttonRegistarCompras);
            this.Controls.Add(this.buttonAtribuirCartão);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerirPontos";
            this.ShowIcon = false;
            this.Text = "GerirPontos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAtribuirCartão;
        private System.Windows.Forms.Button buttonRegistarCompras;
        private System.Windows.Forms.Button buttonConsultarCompras;
        private System.Windows.Forms.Button buttonConsultarSaldo;
        private System.Windows.Forms.Button buttonRecuar;
    }
}