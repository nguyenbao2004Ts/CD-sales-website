namespace BanDia
{
    partial class TimTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimTV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTimtheoSdt = new System.Windows.Forms.RadioButton();
            this.rbTimtheoTen = new System.Windows.Forms.RadioButton();
            this.rbTimtheoid = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripTV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTimtheoSdt);
            this.groupBox1.Controls.Add(this.rbTimtheoTen);
            this.groupBox1.Controls.Add(this.rbTimtheoid);
            this.groupBox1.Location = new System.Drawing.Point(70, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 154);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbTimtheoSdt
            // 
            this.rbTimtheoSdt.AutoSize = true;
            this.rbTimtheoSdt.Location = new System.Drawing.Point(16, 120);
            this.rbTimtheoSdt.Name = "rbTimtheoSdt";
            this.rbTimtheoSdt.Size = new System.Drawing.Size(131, 24);
            this.rbTimtheoSdt.TabIndex = 2;
            this.rbTimtheoSdt.TabStop = true;
            this.rbTimtheoSdt.Text = "Tìm theo SDT";
            this.rbTimtheoSdt.UseVisualStyleBackColor = true;
            // 
            // rbTimtheoTen
            // 
            this.rbTimtheoTen.AutoSize = true;
            this.rbTimtheoTen.Location = new System.Drawing.Point(16, 77);
            this.rbTimtheoTen.Name = "rbTimtheoTen";
            this.rbTimtheoTen.Size = new System.Drawing.Size(199, 24);
            this.rbTimtheoTen.TabIndex = 1;
            this.rbTimtheoTen.TabStop = true;
            this.rbTimtheoTen.Text = "Tìm theo tên thành viên";
            this.rbTimtheoTen.UseVisualStyleBackColor = true;
            // 
            // rbTimtheoid
            // 
            this.rbTimtheoid.AutoSize = true;
            this.rbTimtheoid.Location = new System.Drawing.Point(16, 37);
            this.rbTimtheoid.Name = "rbTimtheoid";
            this.rbTimtheoid.Size = new System.Drawing.Size(225, 24);
            this.rbTimtheoid.TabIndex = 0;
            this.rbTimtheoid.TabStop = true;
            this.rbTimtheoid.Text = "Tìm theo mã thẻ thành viên";
            this.rbTimtheoid.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1084, 591);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 54);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripTV;
            this.dataGridView1.Location = new System.Drawing.Point(38, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 414);
            this.dataGridView1.TabIndex = 32;
            // 
            // contextMenuStripTV
            // 
            this.contextMenuStripTV.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThongTinToolStripMenuItem});
            this.contextMenuStripTV.Name = "contextMenuStripTV";
            this.contextMenuStripTV.Size = new System.Drawing.Size(199, 36);
            // 
            // xemThongTinToolStripMenuItem
            // 
            this.xemThongTinToolStripMenuItem.Name = "xemThongTinToolStripMenuItem";
            this.xemThongTinToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.xemThongTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThongTinToolStripMenuItem.Click += new System.EventHandler(this.xemThongTinToolStripMenuItem_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(940, 644);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(120, 54);
            this.buttonLamMoi.TabIndex = 36;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(940, 553);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 55);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(494, 567);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(342, 26);
            this.txtTim.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 46);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tìm thành viên";
            // 
            // TimTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimTV";
            this.Text = "Tìm Thành Viên";
            this.Load += new System.EventHandler(this.TimTV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripTV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTimtheoSdt;
        private System.Windows.Forms.RadioButton rbTimtheoTen;
        private System.Windows.Forms.RadioButton rbTimtheoid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTV;
        private System.Windows.Forms.ToolStripMenuItem xemThongTinToolStripMenuItem;
    }
}