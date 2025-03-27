namespace BanDia
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimNCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listNCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datHangBangDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.băngĐĩaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlydiaMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timdiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listdiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThueTraDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thueDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quanlytheThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem,
            this.băngĐĩaToolStripMenuItem,
            this.thànhViênToolStripMenuItem,
            this.baoCaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyNCCToolStripMenuItem,
            this.TimNCCToolStripMenuItem,
            this.listNCCToolStripMenuItem,
            this.datHangBangDiaToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // quanLyNCCToolStripMenuItem
            // 
            this.quanLyNCCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quanLyNCCToolStripMenuItem.Name = "quanLyNCCToolStripMenuItem";
            this.quanLyNCCToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.quanLyNCCToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            this.quanLyNCCToolStripMenuItem.Click += new System.EventHandler(this.thêmNhàCungCấpMớiToolStripMenuItem_Click);
            // 
            // TimNCCToolStripMenuItem
            // 
            this.TimNCCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimNCCToolStripMenuItem.Name = "TimNCCToolStripMenuItem";
            this.TimNCCToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.TimNCCToolStripMenuItem.Text = "Tìm kiếm nhà cung cấp";
            this.TimNCCToolStripMenuItem.Click += new System.EventHandler(this.TimNCCToolStripMenuItem_Click);
            // 
            // listNCCToolStripMenuItem
            // 
            this.listNCCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listNCCToolStripMenuItem.Name = "listNCCToolStripMenuItem";
            this.listNCCToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.listNCCToolStripMenuItem.Text = "Liệt kê nhà cung cấp";
            this.listNCCToolStripMenuItem.Click += new System.EventHandler(this.listNCCToolStripMenuItem_Click);
            // 
            // datHangBangDiaToolStripMenuItem
            // 
            this.datHangBangDiaToolStripMenuItem.Name = "datHangBangDiaToolStripMenuItem";
            this.datHangBangDiaToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.datHangBangDiaToolStripMenuItem.Text = "Đặt hàng băng đĩa";
            this.datHangBangDiaToolStripMenuItem.Click += new System.EventHandler(this.datHangBangDiaToolStripMenuItem_Click);
            // 
            // băngĐĩaToolStripMenuItem
            // 
            this.băngĐĩaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlydiaMớiToolStripMenuItem,
            this.timdiaToolStripMenuItem,
            this.listdiaToolStripMenuItem,
            this.ThueTraDiaToolStripMenuItem});
            this.băngĐĩaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.băngĐĩaToolStripMenuItem.Name = "băngĐĩaToolStripMenuItem";
            this.băngĐĩaToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.băngĐĩaToolStripMenuItem.Text = "Băng đĩa";
            // 
            // quanlydiaMớiToolStripMenuItem
            // 
            this.quanlydiaMớiToolStripMenuItem.Name = "quanlydiaMớiToolStripMenuItem";
            this.quanlydiaMớiToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.quanlydiaMớiToolStripMenuItem.Text = "Quản lý băng đĩa";
            this.quanlydiaMớiToolStripMenuItem.Click += new System.EventHandler(this.quanlydiaMớiToolStripMenuItem_Click);
            // 
            // timdiaToolStripMenuItem
            // 
            this.timdiaToolStripMenuItem.Name = "timdiaToolStripMenuItem";
            this.timdiaToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.timdiaToolStripMenuItem.Text = "Tìm kiếm băng đĩa";
            this.timdiaToolStripMenuItem.Click += new System.EventHandler(this.timdiaToolStripMenuItem_Click);
            // 
            // listdiaToolStripMenuItem
            // 
            this.listdiaToolStripMenuItem.Name = "listdiaToolStripMenuItem";
            this.listdiaToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.listdiaToolStripMenuItem.Text = "Liệt kê băng đĩa";
            this.listdiaToolStripMenuItem.Click += new System.EventHandler(this.listdiaToolStripMenuItem_Click);
            // 
            // ThueTraDiaToolStripMenuItem
            // 
            this.ThueTraDiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thueDiaToolStripMenuItem,
            this.TraDiaToolStripMenuItem});
            this.ThueTraDiaToolStripMenuItem.Name = "ThueTraDiaToolStripMenuItem";
            this.ThueTraDiaToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.ThueTraDiaToolStripMenuItem.Text = "Thuê,Trả băng đĩa";
            // 
            // thueDiaToolStripMenuItem
            // 
            this.thueDiaToolStripMenuItem.Name = "thueDiaToolStripMenuItem";
            this.thueDiaToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.thueDiaToolStripMenuItem.Text = "Thuê băng đĩa";
            this.thueDiaToolStripMenuItem.Click += new System.EventHandler(this.thueDiaToolStripMenuItem_Click);
            // 
            // TraDiaToolStripMenuItem
            // 
            this.TraDiaToolStripMenuItem.Name = "TraDiaToolStripMenuItem";
            this.TraDiaToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.TraDiaToolStripMenuItem.Text = "Trả băng đĩa";
            this.TraDiaToolStripMenuItem.Click += new System.EventHandler(this.TraDiaToolStripMenuItem_Click);
            // 
            // thànhViênToolStripMenuItem
            // 
            this.thànhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyThanhVienToolStripMenuItem,
            this.timThanhVienToolStripMenuItem,
            this.listThanhVienToolStripMenuItem,
            this.quanlytheThanhVienToolStripMenuItem});
            this.thànhViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            this.thànhViênToolStripMenuItem.Size = new System.Drawing.Size(130, 32);
            this.thànhViênToolStripMenuItem.Text = "Khách hàng";
            // 
            // quanLyThanhVienToolStripMenuItem
            // 
            this.quanLyThanhVienToolStripMenuItem.Name = "quanLyThanhVienToolStripMenuItem";
            this.quanLyThanhVienToolStripMenuItem.Size = new System.Drawing.Size(310, 36);
            this.quanLyThanhVienToolStripMenuItem.Text = "Quản lý thành viên";
            this.quanLyThanhVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyThanhVienToolStripMenuItem_Click);
            // 
            // timThanhVienToolStripMenuItem
            // 
            this.timThanhVienToolStripMenuItem.Name = "timThanhVienToolStripMenuItem";
            this.timThanhVienToolStripMenuItem.Size = new System.Drawing.Size(310, 36);
            this.timThanhVienToolStripMenuItem.Text = "Tìm kiếm thành viên";
            this.timThanhVienToolStripMenuItem.Click += new System.EventHandler(this.timThanhVienToolStripMenuItem_Click);
            // 
            // listThanhVienToolStripMenuItem
            // 
            this.listThanhVienToolStripMenuItem.Name = "listThanhVienToolStripMenuItem";
            this.listThanhVienToolStripMenuItem.Size = new System.Drawing.Size(310, 36);
            this.listThanhVienToolStripMenuItem.Text = "Liệt kê thành viên";
            this.listThanhVienToolStripMenuItem.Click += new System.EventHandler(this.listThanhVienToolStripMenuItem_Click);
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuatBaoCaoToolStripMenuItem});
            this.baoCaoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.baoCaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // xuatBaoCaoToolStripMenuItem
            // 
            this.xuatBaoCaoToolStripMenuItem.Name = "xuatBaoCaoToolStripMenuItem";
            this.xuatBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.xuatBaoCaoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuatBaoCaoToolStripMenuItem.Click += new System.EventHandler(this.xuatBaoCaoToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(1019, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(185, 44);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1204, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // quanlytheThanhVienToolStripMenuItem
            // 
            this.quanlytheThanhVienToolStripMenuItem.Name = "quanlytheThanhVienToolStripMenuItem";
            this.quanlytheThanhVienToolStripMenuItem.Size = new System.Drawing.Size(310, 36);
            this.quanlytheThanhVienToolStripMenuItem.Text = "Quản lý thẻ thành viên";
            this.quanlytheThanhVienToolStripMenuItem.Click += new System.EventHandler(this.quanlytheThanhVienToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 658);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu Nhân Viên";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimNCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listNCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem băngĐĩaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem quanlydiaMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timdiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listdiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThueTraDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thueDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TraDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyThanhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timThanhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listThanhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatBaoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datHangBangDiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem quanlytheThanhVienToolStripMenuItem;
    }
}