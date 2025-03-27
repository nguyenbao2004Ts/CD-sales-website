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
    public partial class DatHang : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public DatHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM PhieuNhap ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
        private void thongTinChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string madon = txtMaPhieuNhap.Text;
            string mancc = txtMaNCC.Text;
            string gia = txtGia.Text;
            string manv = txtMaNV.Text;
            string ngay = dateTimePicker1.Text;
            string query = "INSERT INTO PhieuNhap (MaPhieuNhap, MaNhaCungCap, Gia, MaNhanVien,NgayNhap)" + "VALUES(N'" + madon + "',N'" + mancc + "',N'" + gia + "',N'" + manv + "',N'" + ngay + "')";

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.Execute("SELECT pn.MaPhieuNhap, pn.MaNhaCungCap, pn.NgayNhap, pn.Gia, pn.MaNhanVien,ctpn.MaBangDia, ctpn.HangSanXuat, ctpn.SoLuong, ctpn.GhiChu FROM PhieuNhap pn INNER JOIN ChiTietPhieuNhap ctpn ON pn.MaPhieuNhap=ctpn.MaPhieuNhap Where pn.MaPhieuNhap =N'"+txtMaPhieuNhap.Text+"'");
            DatHangrp baocao = new DatHangrp();
            baocao.SetDataSource(dt);
            InHDDatHang formdathang = new InHDDatHang();
            formdathang.crystalReportViewer1.ReportSource = baocao;
            formdathang.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaPhieuNhap.Text = row.Cells["MaPhieuNhap"].Value != DBNull.Value ? row.Cells["MaPhieuNhap"].Value.ToString() : string.Empty;
                txtMaNCC.Text = row.Cells["MaNhaCungCap"].Value != DBNull.Value ? row.Cells["MaNhaCungCap"].Value.ToString() : string.Empty;
                txtGia.Text = row.Cells["Gia"].Value != DBNull.Value ? row.Cells["Gia"].Value.ToString() : string.Empty;
                txtMaNV.Text = row.Cells["MaNhanVien"].Value != DBNull.Value ? row.Cells["MaNhanVien"].Value.ToString() : string.Empty;
                dateTimePicker1.Value = row.Cells["NgayNhap"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayNhap"].Value) : DateTime.Now;
            }
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
