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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRegistos
            // 
            this.dataGridRegistos.AllowUserToAddRows = false;
            this.dataGridRegistos.AllowUserToDeleteRows = false;
            this.dataGridRegistos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistos.Location = new System.Drawing.Point(31, 46);
            this.dataGridRegistos.Name = "dataGridRegistos";
            this.dataGridRegistos.ReadOnly = true;
            this.dataGridRegistos.Size = new System.Drawing.Size(467, 362);
            this.dataGridRegistos.TabIndex = 0;
            // 
            // buttonRecuar
            // 
            this.buttonRecuar.Location = new System.Drawing.Point(242, 470);
            this.buttonRecuar.Name = "buttonRecuar";
            this.buttonRecuar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecuar.TabIndex = 1;
            this.buttonRecuar.Text = "Recuar";
            this.buttonRecuar.UseVisualStyleBackColor = true;
            this.buttonRecuar.Click += new System.EventHandler(this.buttonRecuar_Click);
            // 
            // ConsultarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 550);
            this.Controls.Add(this.buttonRecuar);
            this.Controls.Add(this.dataGridRegistos);
            this.Name = "ConsultarCompras";
            this.Text = "ConsultarCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRegistos;
        private System.Windows.Forms.Button buttonRecuar;
    }
}