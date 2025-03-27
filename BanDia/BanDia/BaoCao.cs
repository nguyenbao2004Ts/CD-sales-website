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

    public partial class BaoCao : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public BaoCao()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void comboBox1_TextChanged(object sender, EventArgs e)
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

        private void BaoCao_Load(object sender, EventArgs e)
        {
            string queryLop = "SELECT MaNhanVien FROM NhanVien";
            DataTable dt = ketnoi.Execute(queryLop);

            cBNguoiBaoCao.DataSource = dt;
            cBNguoiBaoCao.DisplayMember = "MaNhanVien";
            cBNguoiBaoCao.ValueMember = "MaNhanVien";
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                cBNguoiBaoCao.Text = row.Cells["MaNhanVien"].Value != DBNull.Value ? row.Cells["MaNhanVien"].Value.ToString() : string.Empty;
                txtTenBaoCao.Text = row.Cells["TenBaoCao"].Value != DBNull.Value ? row.Cells["TenBaoCao"].Value.ToString() : string.Empty;
                txtMaBaoCao.Text = row.Cells["MaBaoCao"].Value != DBNull.Value ? row.Cells["MaBaoCao"].Value.ToString() : string.Empty;
                txtDoanhThu.Text = row.Cells["DoanhThu"].Value != DBNull.Value ? row.Cells["DoanhThu"].Value.ToString() : string.Empty;
                dateTimePickerNgayLap.Value = row.Cells["NgayBaoCao"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayBaoCao"].Value) : DateTime.Now;
                dateTimePickerStart.Value = row.Cells["NgayBatDau"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayBatDau"].Value) : DateTime.Now;
                dateTimePickerEnd.Value = row.Cells["NgayKetThuc"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayKetThuc"].Value) : DateTime.Now;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maBaoCao = txtMaBaoCao.Text;
            string tenBaoCao = txtTenBaoCao.Text;
            string maNhanVien = cBNguoiBaoCao.SelectedValue.ToString();
            string doanhThu = txtDoanhThu.Text;
            string ngayBaoCao = dateTimePickerNgayLap.Value.ToString("yyyy-MM-dd");
            string ngayBatDau = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");

            string query = "INSERT INTO BaoCao (MaBaoCao,TenBaoCao, MaNhanVien, DoanhThu, NgayBaoCao, NgayBatDau, NgayKetThuc) " +
                                     "VALUES (N'" + maBaoCao + "',N'" + tenBaoCao+ "',N'" + maNhanVien + "',N'" + doanhThu + "',N'" + ngayBaoCao + "',N'" + ngayBatDau + "',N'" + ngayKetThuc + "')";

                ketnoi.ExecuteNonQuery(query);
                MessageBox.Show("Đã lưu báo cáo thành công!");
            loaddata();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.Execute("SELECT * From BaoCao Where MaBaoCao =N'" + txtMaBaoCao.Text + "'");
            BaoCaorp baocao1 = new BaoCaorp();
            baocao1.SetDataSource(dt);
            formBaocao formBaoCao = new formBaocao();
            formBaoCao.crystalReportViewer1.ReportSource = baocao1;
            formBaoCao.ShowDialog();
        }
        void loaddata()
        {
            string query = "SELECT * FROM BaoCao ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }

}
