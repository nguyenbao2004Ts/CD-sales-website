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
    public partial class QLThe : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public QLThe()
        {
            InitializeComponent();
        }

        private void QLThe_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT " +
                "KhachHang.MaKhachHang," +
                "KhachHang.HoTen,KhachHang.GioiTinh,KhachHang.DienThoai,KhachHang.DiaChi,KhachHang.NgaySinh,TheThanhVien.MaTheThanhVien,TheThanhVien.NgayDangKy," +
                "TheThanhVien.NgayHetHan FROM KhachHang INNER JOIN TheThanhVien ON KhachHang.MaKhachHang = TheThanhVien.MaKhachHang  ";
            dataGridView1.DataSource = ketnoi.Execute(query);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.Execute( "SELECT " +
               "KhachHang.MaKhachHang," +
               "KhachHang.HoTen,KhachHang.GioiTinh,KhachHang.DienThoai,KhachHang.DiaChi,KhachHang.NgaySinh,TheThanhVien.MaTheThanhVien,TheThanhVien.NgayDangKy," +
               "TheThanhVien.NgayHetHan FROM KhachHang INNER JOIN TheThanhVien ON KhachHang.MaKhachHang = TheThanhVien.MaKhachHang WHERE TheThanhVien.MaTheThanhVien =N'" + txtMaThe.Text + "'");
            TheTVrp the = new TheTVrp();
            the.SetDataSource(dt);
            InTheTv formthe = new InTheTv();
            formthe.crystalReportViewer1.ReportSource = the;
            formthe.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTim.Text;
            string query = "SELECT " +
               "KhachHang.MaKhachHang," +
               "KhachHang.HoTen,KhachHang.GioiTinh,KhachHang.DienThoai,KhachHang.DiaChi,KhachHang.NgaySinh,TheThanhVien.MaTheThanhVien,TheThanhVien.NgayDangKy," +
               "TheThanhVien.NgayHetHan FROM KhachHang INNER JOIN TheThanhVien ON KhachHang.MaKhachHang = TheThanhVien.MaKhachHang WHERE KhachHang.HoTen LIKE N'%" + ten + "%' ";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaThe.Text = row.Cells["MaTheThanhVien"].Value != DBNull.Value ? row.Cells["MaTheThanhVien"].Value.ToString() : string.Empty;
                txtMatv.Text = row.Cells["MaKhachHang"].Value != DBNull.Value ? row.Cells["MaKhachHang"].Value.ToString() : string.Empty;
                dateTimePickerDK.Value = row.Cells["NgayDangKy"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayDangKy"].Value) : DateTime.Now;
                dateTimePickerHH.Value = row.Cells["NgayHetHan"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayHetHan"].Value) : DateTime.Now;
            }
        }
    }
}
