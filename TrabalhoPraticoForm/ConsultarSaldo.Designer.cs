﻿namespace TrabalhoPraticoForm
{
    partial class ConsultarSaldo
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
            this.buttonRecuar = new System.Windows.Forms.Button();
            this.dataGridViewSaldo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecuar
            // 
            this.buttonRecuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecuar.Location = new System.Drawing.Point(185, 150);
            this.buttonRecuar.Name = "buttonRecuar";
            this.buttonRecuar.Size = new System.Drawing.Size(150, 30);
            this.buttonRecuar.TabIndex = 1;
            this.buttonRecuar.Text = "Recuar";
            this.buttonRecuar.UseVisualStyleBackColor = true;
            this.buttonRecuar.Click += new System.EventHandler(this.buttonRecuar_Click);
            // 
            // dataGridViewSaldo
            // 
            this.dataGridViewSaldo.AllowUserToAddRows = false;
            this.dataGridViewSaldo.AllowUserToDeleteRows = false;
            this.dataGridViewSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaldo.Location = new System.Drawing.Point(100, 75);
            this.dataGridViewSaldo.Name = "dataGridViewSaldo";
            this.dataGridViewSaldo.ReadOnly = true;
            this.dataGridViewSaldo.Size = new System.Drawing.Size(300, 50);
            this.dataGridViewSaldo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Consultar Saldo:";
            // 
            // ConsultarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSaldo);
            this.Controls.Add(this.buttonRecuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarSaldo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecuar;
        private System.Windows.Forms.DataGridView dataGridViewSaldo;
        private System.Windows.Forms.Label label1;
    }
}