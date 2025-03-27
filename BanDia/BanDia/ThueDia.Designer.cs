namespace BanDia
{
    partial class ThueDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThueDia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTenBangDia = new System.Windows.Forms.TextBox();
            this.btnXuatPhieu = new System.Windows.Forms.Button();
            this.txtMaBangDia = new System.Windows.Forms.TextBox();
            this.txtMaThanhVien = new System.Windows.Forms.TextBox();
            this.txtTenThanhVien = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.txtMaPhieuThue = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDia_CellContentClick);
            // 
            // txtTenBangDia
            // 
            this.txtTenBangDia.Location = new System.Drawing.Point(130, 510);
            this.txtTenBangDia.Name = "txtTenBangDia";
            this.txtTenBangDia.Size = new System.Drawing.Size(216, 26);
            this.txtTenBangDia.TabIndex = 5;
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.Location = new System.Drawing.Point(758, 543);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(141, 48);
            this.btnXuatPhieu.TabIndex = 6;
            this.btnXuatPhieu.Text = "Xuất phiếu";
            this.btnXuatPhieu.UseVisualStyleBackColor = true;
            this.btnXuatPhieu.Click += new System.EventHandler(this.btnXuatPhieu_Click);
            // 
            // txtMaBangDia
            // 
            this.txtMaBangDia.Location = new System.Drawing.Point(130, 453);
            this.txtMaBangDia.Name = "txtMaBangDia";
            this.txtMaBangDia.Size = new System.Drawing.Size(216, 26);
            this.txtMaBangDia.TabIndex = 7;
            // 
            // txtMaThanhVien
            // 
            this.txtMaThanhVien.Location = new System.Drawing.Point(130, 571);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.Size = new System.Drawing.Size(216, 26);
            this.txtMaThanhVien.TabIndex = 8;
            // 
            // txtTenThanhVien
            // 
            this.txtTenThanhVien.Location = new System.Drawing.Point(130, 630);
            this.txtTenThanhVien.Name = "txtTenThanhVien";
            this.txtTenThanhVien.Size = new System.Drawing.Size(216, 26);
            this.txtTenThanhVien.TabIndex = 9;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(502, 571);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(174, 26);
            this.txtHangSX.TabIndex = 12;
            // 
            // txtMaPhieuThue
            // 
            this.txtMaPhieuThue.Location = new System.Drawing.Point(502, 453);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.Size = new System.Drawing.Size(174, 26);
            this.txtMaPhieuThue.TabIndex = 11;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(502, 510);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(174, 26);
            this.txtGiaThue.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã băng đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên băng đĩa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã thành viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên thành viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã phiếu thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Giá thuê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hãng sản xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ngày Thuê";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(959, 543);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 48);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(860, 616);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 54);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(502, 629);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // ThueDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 739);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHangSX);
            this.Controls.Add(this.txtMaPhieuThue);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.txtTenThanhVien);
            this.Controls.Add(this.txtMaThanhVien);
            this.Controls.Add(this.txtMaBangDia);
            this.Controls.Add(this.btnXuatPhieu);
            this.Controls.Add(this.txtTenBangDia);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThueDia";
            this.Text = "Thuê Đĩa";
            this.Load += new System.EventHandler(this.ThueDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTenBangDia;
        private System.Windows.Forms.Button btnXuatPhieu;
        private System.Windows.Forms.TextBox txtMaBangDia;
        private System.Windows.Forms.TextBox txtMaThanhVien;
        private System.Windows.Forms.TextBox txtTenThanhVien;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.TextBox txtMaPhieuThue;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}