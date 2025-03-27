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
    public partial class TimNCC : Form
    {

        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public TimNCC()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            string query = "SELECT * FROM NhaCungCap ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void thongTinChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string mancc = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTNcc tTNcc = new TTNcc(mancc);
            tTNcc.Show();
            
        }

        private void TimNCC_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";

            if (rbTimtheoid.Checked)
            {
                string id = txtTim.Text;
                query = $"SELECT * FROM NhaCungCap WHERE MaNhaCungCap LIKE '%{id}%'";
            }
            else if (rbTimtheoTen.Checked)
            {
                string name = txtTim.Text;
                query = "SELECT * FROM NhaCungCap WHERE TenNhaCungCap LIKE N'%" + name + "%'";
            }
            else if (rbTimtheomail.Checked)
            {
                string email = txtTim.Text;
                query = $"SELECT * FROM NhaCungCap WHERE Gmail LIKE '%{email}%'";
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

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
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
    }
}
