using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDia
{

    public partial class TimNV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public TimNV()
        {
            InitializeComponent();
        }

        private void TimNV_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuQL menuQL = new MenuQL();
            menuQL.Show();
            this.Hide();
        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string manv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTNhanVien tTNhanVien = new TTNhanVien(manv);
            tTNhanVien.Show();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";

            if (rbTimtheoid.Checked)
            {
                string id = txtTim.Text;
                query = $"SELECT * FROM NhanVien WHERE MaNhanVien LIKE '%{id}%'";
            }
            else if (rbTimtheoTen.Checked)
            {
                string name = txtTim.Text;
                query = "SELECT * FROM NhanVien WHERE TenNhanVien LIKE N'%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(query))
            {
                DataTable result = ketnoi.Execute(query);
                if (result.Rows.Count > 0)
                {
                    dataGridView1.DataSource = result;
                    MessageBox.Show("Tìm thấy dữ liệu.");
                    txtTim.Clear();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Không tìm thấy dữ liệu.");
                    txtTim.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn tìm kiếm.");
            }
        }
        void loaddata()
        {
            string query = "SELECT * FROM NhanVien ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }
}
