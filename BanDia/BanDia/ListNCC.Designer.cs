namespace BanDia
{
    partial class ListNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListNCC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripNCC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thongTinChiTietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTim = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripNCC;
            this.dataGridView1.Location = new System.Drawing.Point(30, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 296);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // comboBoxTim
            // 
            this.comboBoxTim.FormattingEnabled = true;
            this.comboBoxTim.Items.AddRange(new object[] {
            "Liệt kê từ A-Z",
            "Liệt kê từ Z-A"});
            this.comboBoxTim.Location = new System.Drawing.Point(44, 442);
            this.comboBoxTim.Name = "comboBoxTim";
            this.comboBoxTim.Size = new System.Drawing.Size(235, 28);
            this.comboBoxTim.TabIndex = 27;
            this.comboBoxTim.SelectedIndexChanged += new System.EventHandler(this.comboBoxTim_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(440, 428);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 55);
            this.btnTim.TabIndex = 28;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(612, 429);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(120, 54);
            this.buttonLamMoi.TabIndex = 29;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(785, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 54);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Liệt Kê Nhà Cung Cấp";
            // 
            // ListNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.comboBoxTim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListNCC";
            this.Text = "Liệt Kê Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.ListNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripNCC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNCC;
        private System.Windows.Forms.ToolStripMenuItem thongTinChiTietToolStripMenuItem;
    }
}