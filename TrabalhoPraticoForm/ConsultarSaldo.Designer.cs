namespace TrabalhoPraticoForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecuar
            // 
            this.buttonRecuar.Location = new System.Drawing.Point(185, 421);
            this.buttonRecuar.Name = "buttonRecuar";
            this.buttonRecuar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecuar.TabIndex = 2;
            this.buttonRecuar.Text = "Recuar";
            this.buttonRecuar.UseVisualStyleBackColor = true;
            this.buttonRecuar.Click += new System.EventHandler(this.buttonRecuar_Click);
            // 
            // dataGridViewSaldo
            // 
            this.dataGridViewSaldo.AllowUserToAddRows = false;
            this.dataGridViewSaldo.AllowUserToDeleteRows = false;
            this.dataGridViewSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaldo.Location = new System.Drawing.Point(75, 68);
            this.dataGridViewSaldo.Name = "dataGridViewSaldo";
            this.dataGridViewSaldo.ReadOnly = true;
            this.dataGridViewSaldo.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewSaldo.TabIndex = 3;
            // 
            // ConsultarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 483);
            this.Controls.Add(this.dataGridViewSaldo);
            this.Controls.Add(this.buttonRecuar);
            this.Name = "ConsultarSaldo";
            this.Text = "ConsultarSaldo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecuar;
        private System.Windows.Forms.DataGridView dataGridViewSaldo;
    }
}