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
    public partial class TimDia : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public TimDia()
        {
            InitializeComponent();
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string madia = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTDia tTDia = new TTDia(madia);
            tTDia.Show();

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";
            if (rbTimtheoid.Checked)
            {
                string id = txtTim.Text;
                query = $"SELECT * FROM BangDia WHERE MaBangDia LIKE '%{id}%'";
            }
            else if (rbTimtheoTen.Checked)
            {
                string name = txtTim.Text;
                query = "SELECT * FROM BangDia WHERE TenBangDia LIKE N'%" + name + "%'";
            }
            else if (rbTimtheogia.Checked)
            {
                string gia = txtTim.Text;
                query = $"SELECT * FROM BangDia WHERE GiaThue LIKE '%{gia}%'";
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

        private void TimDia_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM BangDia ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }
}
