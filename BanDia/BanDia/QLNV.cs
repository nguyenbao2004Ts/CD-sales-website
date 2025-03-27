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
    public partial class QLNV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public QLNV()
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

        private void contextMenuStripNV_Opening(object sender, CancelEventArgs e)
        {

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM NhanVien ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                cBChucVu.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string chucvu = cBChucVu.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string ngaysinh = dateTimePicker1.Text;
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, ChucVu, SDT, DiaChi, NgaySinh)" + "VALUES(N'" + ma + "',N'" + ten + "',N'" + chucvu + "',N'" + sdt + "',N'" + diachi + "',N'" + ngaysinh + "')";
            ketnoi.ExecuteNonQuery(query);
            loaddata();
            txtMa.Clear();
            txtTen.Clear();
            cBChucVu.SelectedIndex = -1;
            txtSDT.Clear();
            txtDiaChi.Clear();
            dateTimePicker1.Value = DateTime.Now; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
              
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = N'" + ma + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Nhân Viên Thành Công");
                txtMa.Clear();
                txtTen.Clear();
                cBChucVu.SelectedIndex = -1;
                txtSDT.Clear();
                txtDiaChi.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                
                MessageBox.Show("Vui lòng chọn nhân viên để được xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string ten = txtTen.Text;
                string chucvu = cBChucVu.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string ngaysinh = dateTimePicker1.Text;


                string query = "UPDATE NhanVien SET TenNhanVien = N'" + ten + "', ChucVu = N'" + chucvu + "', SDT = N'" + sdt + "' , DiaChi = N'" + diachi + "', NgaySinh = N'" + ngaysinh + "' WHERE MaNhanVien = N'" + ma + "'";


                ketnoi.ExecuteNonQuery(query);

                loaddata();
                MessageBox.Show("Đã Cập Nhật Nhân Viên Thành Công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để được cập nhật!");
            }
        }
    }
}
