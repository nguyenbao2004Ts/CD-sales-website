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
    public partial class TimTV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public TimTV()
        {
            InitializeComponent();
        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string matv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTthanhVien tthanhVien = new TTthanhVien(matv);
            tthanhVien.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentUserRole == 1)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else if (currentUserRole == 2)
            {
                MenuQL menuQL = new MenuQL();
                menuQL.Show();
            }
            this.Hide();
        }

        private void TimTV_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rbTimtheoid.Checked)
            {
                int id = Convert.ToInt32(txtTim.Text);
                string query = $"SELECT * FROM KhachHang WHERE MaKhachHang LIKE '%{id}%'";
                DataTable dt = ketnoi.Execute(query);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("TÌm thấy dữ liệu thành viên");
                    txtTim.Clear();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu thành viên");
                    txtTim.Clear();

                }
            }
            if (rbTimtheoTen.Checked)
            {
                string ten = txtTim.Text;
                string query = "SELECT* FROM KhachHang WHERE HoTen LIKE N'%" + ten + "%'";
                DataTable dt = ketnoi.Execute(query);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("TÌm thấy dữ liệu thành viên");
                    txtTim.Clear();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu thành viên");
                    txtTim.Clear();

                }
            }
            if (rbTimtheoSdt.Checked)
            {
                string sdt = txtTim.Text.Trim();
                string query = "SELECT * FROM KhachHang WHERE DienThoai LIKE N'%" + sdt + "%'";
                DataTable dt = ketnoi.Execute(query);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("TÌm thấy dữ liệu khách hàng");
                    txtTim.Clear();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu khách hàng");
                    txtTim.Clear();

                }
            }
        }
        void loaddata()
        {
            string query = "SELECT * FROM KhachHang ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }
}
