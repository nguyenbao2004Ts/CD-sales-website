namespace BanDia
{
    partial class QLThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLThe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.txtMatv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDK = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHH = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thông tin thẻ thành viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(338, 486);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(316, 26);
            this.txtTim.TabIndex = 3;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(776, 606);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(180, 43);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "Xuất thẻ thành viên";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập tên thành viên cần tìm";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(990, 606);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 43);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(115, 555);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(182, 26);
            this.txtMaThe.TabIndex = 7;
            // 
            // txtMatv
            // 
            this.txtMatv.Location = new System.Drawing.Point(115, 606);
            this.txtMatv.Name = "txtMatv";
            this.txtMatv.Size = new System.Drawing.Size(182, 26);
            this.txtMatv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã thẻ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã thành viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày đăng ký";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hết hạn";
            // 
            // dateTimePickerDK
            // 
            this.dateTimePickerDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDK.Location = new System.Drawing.Point(551, 556);
            this.dateTimePickerDK.Name = "dateTimePickerDK";
            this.dateTimePickerDK.Size = new System.Drawing.Size(201, 26);
            this.dateTimePickerDK.TabIndex = 15;
            // 
            // dateTimePickerHH
            // 
            this.dateTimePickerHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHH.Location = new System.Drawing.Point(551, 604);
            this.dateTimePickerHH.Name = "dateTimePickerHH";
            this.dateTimePickerHH.Size = new System.Drawing.Size(201, 26);
            this.dateTimePickerHH.TabIndex = 16;
            // 
            // QLThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 693);
            this.Controls.Add(this.dateTimePickerHH);
            this.Controls.Add(this.dateTimePickerDK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatv);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLThe";
            this.Text = "Quản lý thẻ thành viên";
            this.Load += new System.EventHandler(this.QLThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.TextBox txtMatv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDK;
        private System.Windows.Forms.DateTimePicker dateTimePickerHH;
    }
}