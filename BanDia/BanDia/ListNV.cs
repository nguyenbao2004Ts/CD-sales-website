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
    public partial class ListNV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public ListNV()
        {
            InitializeComponent();
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

        private void ListNV_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ A-Z")
            {
                string query = "SELECT * FROM NhanVien ORDER BY TenNhanVien ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ Z-A")
            {
                string query = "SELECT * FROM NhanVien ORDER BY TenNhanVien DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê theo tuổi nhân viên tăng dần")
            {
                string query = "SELECT *, DATEDIFF(YEAR, NgaySinh, GETDATE()) - CASE " +
                    "WHEN DATEADD(YEAR, DATEDIFF(YEAR, NgaySinh, GETDATE()), NgaySinh) > GETDATE() THEN 1 ELSE 0 END AS Tuoi FROM NhanVien ORDER BY Tuoi ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê theo tuổi nhân viên giảm dần")
            {
                string query = "SELECT *, DATEDIFF(YEAR, NgaySinh, GETDATE()) - CASE " +
                    "WHEN DATEADD(YEAR, DATEDIFF(YEAR, NgaySinh, GETDATE()), NgaySinh) > GETDATE() THEN 1 ELSE 0 END AS Tuoi FROM NhanVien ORDER BY Tuoi DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            
        }
        void loaddata()
        {
            string query = "SELECT * FROM NhanVien ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
