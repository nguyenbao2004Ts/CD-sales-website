namespace BanDia
{
    partial class TimNCC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimNCC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTimtheomail = new System.Windows.Forms.RadioButton();
            this.rbTimtheoTen = new System.Windows.Forms.RadioButton();
            this.rbTimtheoid = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripNCC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thongTinChiTietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTimtheomail);
            this.groupBox1.Controls.Add(this.rbTimtheoTen);
            this.groupBox1.Controls.Add(this.rbTimtheoid);
            this.groupBox1.Location = new System.Drawing.Point(77, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbTimtheomail
            // 
            this.rbTimtheomail.AutoSize = true;
            this.rbTimtheomail.Location = new System.Drawing.Point(16, 120);
            this.rbTimtheomail.Name = "rbTimtheomail";
            this.rbTimtheomail.Size = new System.Drawing.Size(127, 24);
            this.rbTimtheomail.TabIndex = 2;
            this.rbTimtheomail.TabStop = true;
            this.rbTimtheomail.Text = "Tìm theo Mail";
            this.rbTimtheomail.UseVisualStyleBackColor = true;
            // 
            // rbTimtheoTen
            // 
            this.rbTimtheoTen.AutoSize = true;
            this.rbTimtheoTen.Location = new System.Drawing.Point(16, 77);
            this.rbTimtheoTen.Name = "rbTimtheoTen";
            this.rbTimtheoTen.Size = new System.Drawing.Size(122, 24);
            this.rbTimtheoTen.TabIndex = 1;
            this.rbTimtheoTen.TabStop = true;
            this.rbTimtheoTen.Text = "Tìm theo tên";
            this.rbTimtheoTen.UseVisualStyleBackColor = true;
            // 
            // rbTimtheoid
            // 
            this.rbTimtheoid.AutoSize = true;
            this.rbTimtheoid.Location = new System.Drawing.Point(16, 37);
            this.rbTimtheoid.Name = "rbTimtheoid";
            this.rbTimtheoid.Size = new System.Drawing.Size(158, 24);
            this.rbTimtheoid.TabIndex = 0;
            this.rbTimtheoid.TabStop = true;
            this.rbTimtheoid.Text = "Tìm theo mã NCC";
            this.rbTimtheoid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripNCC;
            this.dataGridView1.Location = new System.Drawing.Point(45, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 414);
            this.dataGridView1.TabIndex = 12;
            // 
            // contextMenuStripNCC
            // 
            this.contextMenuStripNCC.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripNCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinChiTietToolStripMenuItem});
            this.contextMenuStripNCC.Name = "contextMenuStripNCC";
            this.contextMenuStripNCC.Size = new System.Drawing.Size(218, 36);
            // 
            // thongTinChiTietToolStripMenuItem
            // 
            this.thongTinChiTietToolStripMenuItem.Name = "thongTinChiTietToolStripMenuItem";
            this.thongTinChiTietToolStripMenuItem.Size = new System.Drawing.Size(217, 32);
            this.thongTinChiTietToolStripMenuItem.Text = "Thông tin chi tiết";
            this.thongTinChiTietToolStripMenuItem.Click += new System.EventHandler(this.thongTinChiTietToolStripMenuItem_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(947, 650);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(120, 54);
            this.buttonLamMoi.TabIndex = 16;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(947, 559);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 55);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(501, 573);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(342, 26);
            this.txtTim.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1091, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 54);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tìm nhà cung cấp";
            // 
            // TimNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimNCC";
            this.Text = "Tìm Kiếm Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.TimNCC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripNCC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTimtheomail;
        private System.Windows.Forms.RadioButton rbTimtheoTen;
        private System.Windows.Forms.RadioButton rbTimtheoid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNCC;
        private System.Windows.Forms.ToolStripMenuItem thongTinChiTietToolStripMenuItem;
    }
}