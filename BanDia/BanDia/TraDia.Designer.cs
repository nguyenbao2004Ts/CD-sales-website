namespace BanDia
{
    partial class TraDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraDia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txMaPhieuThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenThanhVien = new System.Windows.Forms.TextBox();
            this.txtMaThanhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieuTra = new System.Windows.Forms.TextBox();
            this.txtTenBangDia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBTinhTrang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePickerNgayThueCT = new System.Windows.Forms.DateTimePicker();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaBangDia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 394);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã phiếu thuê";
            // 
            // txMaPhieuThue
            // 
            this.txMaPhieuThue.Location = new System.Drawing.Point(163, 456);
            this.txMaPhieuThue.Name = "txMaPhieuThue";
            this.txMaPhieuThue.Size = new System.Drawing.Size(174, 26);
            this.txMaPhieuThue.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên thành viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã thành viên";
            // 
            // txtTenThanhVien
            // 
            this.txtTenThanhVien.Location = new System.Drawing.Point(524, 518);
            this.txtTenThanhVien.Name = "txtTenThanhVien";
            this.txtTenThanhVien.Size = new System.Drawing.Size(174, 26);
            this.txtTenThanhVien.TabIndex = 22;
            // 
            // txtMaThanhVien
            // 
            this.txtMaThanhVien.Location = new System.Drawing.Point(524, 459);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.Size = new System.Drawing.Size(174, 26);
            this.txtMaThanhVien.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên băng đĩa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã phiếu trả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaPhieuTra
            // 
            this.txtMaPhieuTra.Location = new System.Drawing.Point(163, 515);
            this.txtMaPhieuTra.Name = "txtMaPhieuTra";
            this.txtMaPhieuTra.Size = new System.Drawing.Size(174, 26);
            this.txtMaPhieuTra.TabIndex = 26;
            this.txtMaPhieuTra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTenBangDia
            // 
            this.txtTenBangDia.Location = new System.Drawing.Point(163, 572);
            this.txtTenBangDia.Name = "txtTenBangDia";
            this.txtTenBangDia.Size = new System.Drawing.Size(174, 26);
            this.txtTenBangDia.TabIndex = 25;
            this.txtTenBangDia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Giá phạt";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(163, 631);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(174, 26);
            this.txtTienPhat.TabIndex = 29;
            this.txtTienPhat.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tình trạng";
            // 
            // cBTinhTrang
            // 
            this.cBTinhTrang.FormattingEnabled = true;
            this.cBTinhTrang.Items.AddRange(new object[] {
            "Hư hỏng",
            "Trả trễ hẹn",
            "Tốt",
            "Bị thiếu phụ kiện",
            "Bị mất"});
            this.cBTinhTrang.Location = new System.Drawing.Point(524, 575);
            this.cBTinhTrang.Name = "cBTinhTrang";
            this.cBTinhTrang.Size = new System.Drawing.Size(174, 28);
            this.cBTinhTrang.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 685);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ngày Thuê";
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(817, 504);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(131, 56);
            this.btnTra.TabIndex = 35;
            this.btnTra.Text = "Trả đĩa";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(985, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 54);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePickerNgayThueCT
            // 
            this.dateTimePickerNgayThueCT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayThueCT.Location = new System.Drawing.Point(400, 683);
            this.dateTimePickerNgayThueCT.Name = "dateTimePickerNgayThueCT";
            this.dateTimePickerNgayThueCT.Size = new System.Drawing.Size(173, 26);
            this.dateTimePickerNgayThueCT.TabIndex = 38;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Location = new System.Drawing.Point(905, 601);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(131, 56);
            this.btnInPhieu.TabIndex = 39;
            this.btnInPhieu.Text = "Xuất Phiếu Trả";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 631);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Mã băng đĩa";
            // 
            // txtMaBangDia
            // 
            this.txtMaBangDia.Location = new System.Drawing.Point(524, 631);
            this.txtMaBangDia.Name = "txtMaBangDia";
            this.txtMaBangDia.Size = new System.Drawing.Size(174, 26);
            this.txtMaBangDia.TabIndex = 40;
            // 
            // TraDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 753);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaBangDia);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.dateTimePickerNgayThueCT);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBTinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhieuTra);
            this.Controls.Add(this.txtTenBangDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenThanhVien);
            this.Controls.Add(this.txtMaThanhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txMaPhieuThue);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraDia";
            this.Text = "Trả Đĩa";
            this.Load += new System.EventHandler(this.TraDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txMaPhieuThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenThanhVien;
        private System.Windows.Forms.TextBox txtMaThanhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuTra;
        private System.Windows.Forms.TextBox txtTenBangDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThueCT;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaBangDia;
    }
}