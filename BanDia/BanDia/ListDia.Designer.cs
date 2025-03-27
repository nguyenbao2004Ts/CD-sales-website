namespace BanDia
{
    partial class ListDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDia));
            this.btnBack = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.comboBoxTim = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDia = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(784, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 54);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(614, 429);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(120, 54);
            this.buttonLamMoi.TabIndex = 34;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(442, 428);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 55);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // comboBoxTim
            // 
            this.comboBoxTim.FormattingEnabled = true;
            this.comboBoxTim.Items.AddRange(new object[] {
            "Liệt kê từ A-Z",
            "Liệt kê từ Z-A",
            "Liệt kê băng đĩa theo giá từ thấp – cao",
            "Liệt kê băng đĩa theo giá từ cao – thấp"});
            this.comboBoxTim.Location = new System.Drawing.Point(46, 442);
            this.comboBoxTim.Name = "comboBoxTim";
            this.comboBoxTim.Size = new System.Drawing.Size(311, 28);
            this.comboBoxTim.TabIndex = 32;
            this.comboBoxTim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripDia;
            this.dataGridView1.Location = new System.Drawing.Point(32, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 296);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStripDia
            // 
            this.contextMenuStripDia.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripDia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThongTinToolStripMenuItem});
            this.contextMenuStripDia.Name = "contextMenuStripDia";
            this.contextMenuStripDia.Size = new System.Drawing.Size(199, 36);
            // 
            // xemThongTinToolStripMenuItem
            // 
            this.xemThongTinToolStripMenuItem.Name = "xemThongTinToolStripMenuItem";
            this.xemThongTinToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.xemThongTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThongTinToolStripMenuItem.Click += new System.EventHandler(this.xemThongTinToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "Liệt Kê Băng Đĩa";
            // 
            // ListDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.comboBoxTim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListDia";
            this.Text = "Liệt Kê Băng Đĩa ";
            this.Load += new System.EventHandler(this.ListDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripDia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox comboBoxTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDia;
        private System.Windows.Forms.ToolStripMenuItem xemThongTinToolStripMenuItem;
    }
}