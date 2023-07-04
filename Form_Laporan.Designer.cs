namespace CatatanKeuangan
{
    partial class Form_Laporan
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
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUangKeluar = new System.Windows.Forms.Label();
            this.lbUangMasuk = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(12, 12);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowTemplate.Height = 25;
            this.dgvLaporan.Size = new System.Drawing.Size(546, 634);
            this.dgvLaporan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(575, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uang Keluar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(575, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uang Masuk :";
            // 
            // lbUangKeluar
            // 
            this.lbUangKeluar.AutoSize = true;
            this.lbUangKeluar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUangKeluar.Location = new System.Drawing.Point(705, 12);
            this.lbUangKeluar.Name = "lbUangKeluar";
            this.lbUangKeluar.Size = new System.Drawing.Size(109, 21);
            this.lbUangKeluar.TabIndex = 3;
            this.lbUangKeluar.Text = "Rp. 2.000.000";
            // 
            // lbUangMasuk
            // 
            this.lbUangMasuk.AutoSize = true;
            this.lbUangMasuk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUangMasuk.Location = new System.Drawing.Point(705, 50);
            this.lbUangMasuk.Name = "lbUangMasuk";
            this.lbUangMasuk.Size = new System.Drawing.Size(109, 21);
            this.lbUangMasuk.TabIndex = 4;
            this.lbUangMasuk.Text = "Rp. 2.000.000";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(575, 597);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(265, 49);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form_Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 658);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lbUangMasuk);
            this.Controls.Add(this.lbUangKeluar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLaporan);
            this.Name = "Form_Laporan";
            this.Text = "Form_Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvLaporan;
        private Label label1;
        private Label label2;
        private Label lbUangKeluar;
        private Label lbUangMasuk;
        private Button btnHome;
    }
}