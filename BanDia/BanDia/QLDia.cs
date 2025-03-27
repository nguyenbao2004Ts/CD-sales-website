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
    public partial class QLDia : Form
    {
        public static int currentUserRole;
        ketnoicsdl ketnoi = new ketnoicsdl();
        public QLDia()
        {
            InitializeComponent();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void QLDia_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM BangDia ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string matl = txtMaloai.Text;
            string mtt = txtTinhTrang.Text;
            string ghichu = txtNote.Text;
            string mahang = txtHangSX.Text;
            string gia = txtGia.Text;
            string query = "INSERT INTO BangDia (MaBangDia, TenBangDia, MaTheLoai,MaTinhTrang,MaHang,GhiChu,GiaThue)" + "VALUES(N'" + ma + "',N'" + ten + "',N'" + matl + "',N'" + mtt + "',N'" + mahang + "',N'" + ghichu + "',N'" + gia + "')";
            ketnoi.ExecuteNonQuery(query);
            loaddata();
            txtGia.Clear();
            txtMa.Clear();
            txtTen.Clear();
            txtMaloai.Clear();
            txtTinhTrang.Clear();
            txtNote.Clear();
            txtHangSX.Clear();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM BangDia WHERE MaBangDia = N'" + ma + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Băng Đĩa Thành Công");
                txtGia.Clear();
                txtMa.Clear();
                txtTen.Clear();
                txtMaloai.Clear();
                txtTinhTrang.Clear();
                txtNote.Clear();
                txtHangSX.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn băng đĩa để được xóa!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtMaloai.Text = row.Cells[2].Value.ToString();
                txtTinhTrang.Text = row.Cells[3].Value.ToString();
                txtHangSX.Text = row.Cells[4].Value.ToString();
                txtNote.Text = row.Cells[5].Value.ToString();
                txtGia.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string ten = txtTen.Text;
                string matl = txtMaloai.Text;
                string mtt = txtTinhTrang.Text;
                string ghichu = txtNote.Text;
                string mahang = txtHangSX.Text;
                string gia = txtGia.Text;

                string query = "UPDATE BangDia SET " +
                               "TenBangDia = N'" + ten + "', " +
                               "MaTheLoai = N'" + matl + "', " +
                               "MaTinhTrang = N'" + mtt + "', " +
                               "MaHang = N'" + mahang + "', " +
                               "GhiChu = N'" + ghichu + "', " +
                               "GiaThue = N'" + gia + "' " +
                               "WHERE MaBangDia = N'" + ma + "'";

                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Sửa Băng Đĩa Thành Công");

                txtGia.Clear();
                txtMa.Clear();
                txtTen.Clear();
                txtMaloai.Clear();
                txtTinhTrang.Clear();
                txtNote.Clear();
                txtHangSX.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn băng đĩa để được sửa!");
            }
        }
    }
}
