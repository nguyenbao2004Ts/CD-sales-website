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
    public partial class ThueDia : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public ThueDia()
        {
            InitializeComponent();
        }

        private void ThueDia_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM ChiTietPhieuThue ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDia_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maBangDia = txtMaBangDia.Text;
            string maThanhVien = txtMaThanhVien.Text;
            string maPhieuThue = txtMaPhieuThue.Text;
            string ngayThue = dateTimePicker1.Text;
            string tenBangDia = txtTenBangDia.Text;
            string tenThanhVien = txtTenThanhVien.Text;
            string hangSX = txtHangSX.Text;
            string tienthue = txtGiaThue.Text;
            string insertPhieuThueQuery = "INSERT INTO PhieuThue (MaPhieuThue, MaKhachHang, NgayThue)" +
                "VALUES ('" + maPhieuThue + "','" + maThanhVien + "','" + ngayThue + "')";
            string insertChiTietPhieuThueQuery = "INSERT INTO ChiTietPhieuThue (MaPhieuThue, MaBangDia, TenBangDia, GiaThue, MaKhachHang, Hang, HoTen, NgayThue)" +
                "VALUES ('" + maPhieuThue + "','" + maBangDia + "','" + tenBangDia + "','" + tienthue + "''" + maThanhVien + "','" + hangSX + "','" + tenThanhVien + "','" + ngayThue + "')";
            ketnoi.ExecuteNonQuery(insertPhieuThueQuery);
            ketnoi.ExecuteNonQuery(insertChiTietPhieuThueQuery);
            loaddata();
            txtMaBangDia.Clear();
            txtMaThanhVien.Clear();
            txtMaPhieuThue.Clear();
            dateTimePicker1.Value = DateTime.Now; 
            txtTenBangDia.Clear();
            txtTenThanhVien.Clear();
            txtHangSX.Clear();
            txtGiaThue.Clear();

        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.Execute("SELECT * FROM ChiTietPhieuThue WHERE MaPhieuThue = N'" + txtMaPhieuThue.Text + "'");
            PhieuThuerp baocao3 = new PhieuThuerp();
            baocao3.SetDataSource(dt);
            Form2 formPhieuThue = new Form2();
            formPhieuThue.crystalReportViewer1.ReportSource = baocao3;
            formPhieuThue.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaBangDia.Text = row.Cells["MaBangDia"].Value != DBNull.Value ? row.Cells["MaBangDia"].Value.ToString() : string.Empty;
                txtMaThanhVien.Text = row.Cells["MaKhachHang"].Value != DBNull.Value ? row.Cells["MaKhachHang"].Value.ToString() : string.Empty;
                txtMaPhieuThue.Text = row.Cells["MaPhieuThue"].Value != DBNull.Value ? row.Cells["MaPhieuThue"].Value.ToString() : string.Empty;
                dateTimePicker1.Value = row.Cells["NgayThue"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayThue"].Value) : DateTime.Now;
                txtTenBangDia.Text = row.Cells["TenBangDia"].Value != DBNull.Value ? row.Cells["TenBangDia"].Value.ToString() : string.Empty;
                txtTenThanhVien.Text = row.Cells["HoTen"].Value != DBNull.Value ? row.Cells["HoTen"].Value.ToString() : string.Empty;
                txtHangSX.Text = row.Cells["Hang"].Value != DBNull.Value ? row.Cells["Hang"].Value.ToString() : string.Empty;
                txtGiaThue.Text = row.Cells["GiaThue"].Value != DBNull.Value ? row.Cells["GiaThue"].Value.ToString() : string.Empty;
            }
        }
    }
}
