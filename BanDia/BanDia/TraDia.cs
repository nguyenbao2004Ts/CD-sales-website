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
    public partial class TraDia : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public TraDia()
        {
            InitializeComponent();
        }

        private void TraDia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            string query = "SELECT pt.MaPhieuTra, pt.MaPhieuThue,pt.MaKhachHang, pt.NgayThue, ctp.MaBangDia, ctp.TenBangDia, ctp.HoTen, ctp.NgayThue AS NgayThueCT,  ctp.TienPhat, ctp.TinhTrang FROM PhieuTra pt INNER JOIN ChiTietPhieuTra ctp ON pt.MaPhieuTra = ctp.MaPhieuTra ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaBangDia.Text = row.Cells["MaBangDia"].Value != DBNull.Value ? row.Cells["MaBangDia"].Value.ToString() : string.Empty;
                txtMaThanhVien.Text = row.Cells["MaKhachHang"].Value != DBNull.Value ? row.Cells["MaKhachHang"].Value.ToString() : string.Empty;
                txtMaPhieuTra.Text = row.Cells["MaPhieuTra"].Value != DBNull.Value ? row.Cells["MaPhieuTra"].Value.ToString() : string.Empty;
                txMaPhieuThue.Text = row.Cells["MaPhieuThue"].Value != DBNull.Value ? row.Cells["MaPhieuThue"].Value.ToString() : string.Empty;
                dateTimePickerNgayThueCT.Value = row.Cells["NgayThue"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayThue"].Value) : DateTime.Now;
                txtTenBangDia.Text = row.Cells["TenBangDia"].Value != DBNull.Value ? row.Cells["TenBangDia"].Value.ToString() : string.Empty;
                txtTenThanhVien.Text = row.Cells["HoTen"].Value != DBNull.Value ? row.Cells["HoTen"].Value.ToString() : string.Empty;
                txtTienPhat.Text = row.Cells["TienPhat"].Value != DBNull.Value ? row.Cells["TienPhat"].Value.ToString() : string.Empty;
                cBTinhTrang.Text = row.Cells["TinhTrang"].Value != DBNull.Value ? row.Cells["TinhTrang"].Value.ToString() : string.Empty;
            }

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            string mabangdia = txtMaBangDia.Text;
            string matv = txtMaThanhVien.Text;
            string mapt = txtMaPhieuTra.Text;
            string mapth = txMaPhieuThue.Text;
            string tenbd = txtTenBangDia.Text;
            string tentv = txtTenThanhVien.Text;
            string tien = txtTienPhat.Text;
            string tinhtrang = cBTinhTrang.Text;
            string ngaythue = dateTimePickerNgayThueCT.Value.ToString();
            string queryPhieuTra = "INSERT INTO PhieuTra (MaPhieuTra, MaPhieuThue, MaKhachHang, NgayThue) " +
                       "VALUES ('" + mapt + "','" + mapth + "','" + matv + "','" + ngaythue + "')";
            string queryChiTietPhieuTra = "INSERT INTO ChiTietPhieuTra (MaPhieuTra, MaBangDia, TenBangDia, HoTen, NgayThue, TienPhat, TinhTrang) " +
                              "VALUES ('" + mapt + "','" + mabangdia + "','" + tenbd + "','" + tentv + "','" + ngaythue + "','" + tien + "','" + tinhtrang + "')";
            ketnoi.ExecuteNonQuery(queryPhieuTra);
            ketnoi.ExecuteNonQuery(queryChiTietPhieuTra);
            loaddata();
            txtMaBangDia.Clear();
            txtMaThanhVien.Clear();
            txtMaPhieuTra.Clear();
            txMaPhieuThue.Clear();
            txtTenBangDia.Clear();
            txtTenThanhVien.Clear();
            txtTienPhat.Clear();
            cBTinhTrang.Items.Clear();
            dateTimePickerNgayThueCT.Value = DateTime.Now;

        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.Execute("SELECT pt.MaPhieuTra, pt.MaPhieuThue, pt.MaKhachHang, pt.NgayThue, ctp.MaBangDia, ctp.TenBangDia, ctp.HoTen, ctp.NgayThue AS NgayThueCT, ctp.TienPhat, ctp.TinhTrang FROM PhieuTra pt INNER JOIN ChiTietPhieuTra ctp ON pt.MaPhieuTra = ctp.MaPhieuTra WHERE pt.MaPhieuTra = N'" + txtMaPhieuTra.Text + "'");
            PhieuTrarp baocao2 = new PhieuTrarp();
            baocao2.SetDataSource(dt);
            InPhieuTra formPhieuTra = new InPhieuTra();
            formPhieuTra.crystalReportViewer1.ReportSource = baocao2;
            formPhieuTra.ShowDialog();
        }
    }
}
