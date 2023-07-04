namespace CatatanKeuangan
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListTransaksi = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJumlahTrx = new System.Windows.Forms.TextBox();
            this.rbUangMasuk = new System.Windows.Forms.RadioButton();
            this.rbUangKeluar = new System.Windows.Forms.RadioButton();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnLaporan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Transaksi";
            // 
            // dgvListTransaksi
            // 
            this.dgvListTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTransaksi.Location = new System.Drawing.Point(12, 56);
            this.dgvListTransaksi.Name = "dgvListTransaksi";
            this.dgvListTransaksi.RowTemplate.Height = 25;
            this.dgvListTransaksi.Size = new System.Drawing.Size(506, 631);
            this.dgvListTransaksi.TabIndex = 1;
            this.dgvListTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTransaksi_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(541, 281);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(273, 73);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Tambah Baru";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(541, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(273, 73);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(273, 73);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(541, 565);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(273, 73);
            this.btnBaru.TabIndex = 5;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(614, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jumlah Trx";
            // 
            // txtJumlahTrx
            // 
            this.txtJumlahTrx.Location = new System.Drawing.Point(614, 136);
            this.txtJumlahTrx.Name = "txtJumlahTrx";
            this.txtJumlahTrx.Size = new System.Drawing.Size(200, 23);
            this.txtJumlahTrx.TabIndex = 10;
            // 
            // rbUangMasuk
            // 
            this.rbUangMasuk.AutoSize = true;
            this.rbUangMasuk.Location = new System.Drawing.Point(541, 242);
            this.rbUangMasuk.Name = "rbUangMasuk";
            this.rbUangMasuk.Size = new System.Drawing.Size(91, 19);
            this.rbUangMasuk.TabIndex = 12;
            this.rbUangMasuk.TabStop = true;
            this.rbUangMasuk.Text = "Uang Masuk";
            this.rbUangMasuk.UseVisualStyleBackColor = true;
            // 
            // rbUangKeluar
            // 
            this.rbUangKeluar.AutoSize = true;
            this.rbUangKeluar.Location = new System.Drawing.Point(659, 242);
            this.rbUangKeluar.Name = "rbUangKeluar";
            this.rbUangKeluar.Size = new System.Drawing.Size(89, 19);
            this.rbUangKeluar.TabIndex = 13;
            this.rbUangKeluar.TabStop = true;
            this.rbUangKeluar.Text = "Uang Keluar";
            this.rbUangKeluar.UseVisualStyleBackColor = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(614, 95);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 23);
            this.dtpTanggal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tanggal";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(539, 657);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(273, 50);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 708);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Saldo :";
            // 
            // lbTotalSaldo
            // 
            this.lbTotalSaldo.AutoSize = true;
            this.lbTotalSaldo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalSaldo.Location = new System.Drawing.Point(150, 708);
            this.lbTotalSaldo.Name = "lbTotalSaldo";
            this.lbTotalSaldo.Size = new System.Drawing.Size(57, 25);
            this.lbTotalSaldo.TabIndex = 18;
            this.lbTotalSaldo.Text = "Rp. 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(614, 176);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(200, 60);
            this.txtDeskripsi.TabIndex = 19;
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(539, 741);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(273, 50);
            this.btnLaporan.TabIndex = 21;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 803);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lbTotalSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.rbUangKeluar);
            this.Controls.Add(this.rbUangMasuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJumlahTrx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBaru);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvListTransaksi);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvListTransaksi;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBaru;
        private TextBox txtId;
        private Label label2;
        private Label label4;
        private TextBox txtJumlahTrx;
        private RadioButton rbUangMasuk;
        private RadioButton rbUangKeluar;
        private DateTimePicker dtpTanggal;
        private Label label3;
        private Button btnClear;
        private Label label5;
        private Label lbTotalSaldo;
        private Label label6;
        private TextBox txtDeskripsi;
        private Button btnLaporan;
    }
}