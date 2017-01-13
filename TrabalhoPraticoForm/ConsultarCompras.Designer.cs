namespace TrabalhoPraticoForm
{
    partial class ConsultarCompras
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
            this.dataGridRegistos = new System.Windows.Forms.DataGridView();
            this.buttonRecuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRegistos
            // 
            this.dataGridRegistos.AllowUserToAddRows = false;
            this.dataGridRegistos.AllowUserToDeleteRows = false;
            this.dataGridRegistos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistos.Location = new System.Drawing.Point(12, 62);
            this.dataGridRegistos.Name = "dataGridRegistos";
            this.dataGridRegistos.ReadOnly = true;
            this.dataGridRegistos.Size = new System.Drawing.Size(476, 283);
            this.dataGridRegistos.TabIndex = 0;
            // 
            // buttonRecuar
            // 
            this.buttonRecuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecuar.Location = new System.Drawing.Point(175, 385);
            this.buttonRecuar.Name = "buttonRecuar";
            this.buttonRecuar.Size = new System.Drawing.Size(150, 30);
            this.buttonRecuar.TabIndex = 1;
            this.buttonRecuar.Text = "Recuar";
            this.buttonRecuar.UseVisualStyleBackColor = true;
            this.buttonRecuar.Click += new System.EventHandler(this.buttonRecuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Consultar Compras:";
            // 
            // ConsultarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRecuar);
            this.Controls.Add(this.dataGridRegistos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRegistos;
        private System.Windows.Forms.Button buttonRecuar;
        private System.Windows.Forms.Label label1;
    }
}