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
    public partial class QLTV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public QLTV()
        {
            InitializeComponent();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QLTV_Load(object sender, EventArgs e)
        {
            loaddata();
           
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cBSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string matv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTthanhVien tthanhVien = new TTthanhVien(matv);
            tthanhVien.Show();
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

        private void checkBoxTV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            string query = "SELECT " +
                "KhachHang.MaKhachHang," +
                "KhachHang.HoTen,KhachHang.GioiTinh,KhachHang.DienThoai,KhachHang.DiaChi,KhachHang.NgaySinh,TheThanhVien.MaTheThanhVien,TheThanhVien.NgayDangKy," +
                "TheThanhVien.NgayHetHan FROM KhachHang INNER JOIN TheThanhVien ON KhachHang.MaKhachHang = TheThanhVien.MaKhachHang; "; 
            dataGridView1.DataSource = ketnoi.Execute(query);
            dateTimePickerDK.Enabled = false;
            dateTimePickerHH.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMa.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTen.Text = row.Cells["HoTen"].Value.ToString();
                cBSex.Text = row.Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                dateTimePickerDK.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);
                dateTimePickerHH.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked) 
                    { 
                string maKhachHang = txtMa.Text;
                string hoTen = txtTen.Text;
                string gioiTinh = cBSex.Text;
                string dienThoai = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
 
                DateTime ngayDK = dateTimePickerDK.Value;
                DateTime ngayHH = dateTimePickerHH.Value;

                string querykh = "INSERT INTO KhachHang (MaKhachHang, HoTen, GioiTinh, DienThoai, DiaChi, NgaySinh)" + " VALUES (N'" + maKhachHang + "',N'" + hoTen + "',N'" + gioiTinh + "',N'" + dienThoai + "',N'" + diaChi + "',N'" + ngaySinh + "')";
                ketnoi.Execute(querykh);
                string querytv = "INSERT INTO TheThanhVien (MaKhachHang,NgayDangKy,NgayHetHan)" + " VALUES (N'" + maKhachHang + "',N'" + ngayDK + "',N'" + ngayHH + "')";
                    ketnoi.Execute(querytv);
                    MessageBox.Show("Thêm thành viên thành công!");
                loaddata();
                txtMa.Clear();
                txtTen.Clear();
                cBSex.SelectedIndex = -1;
                txtSDT.Clear();
                txtDiaChi.Clear();
                dateTimePicker1.Value = DateTime.Now;
                checkBox1.Checked = false;
                }
                else
                {
                    string maKhachHang = txtMa.Text;
                    string hoTen = txtTen.Text;
                    string gioiTinh = cBSex.Text;
                    string dienThoai = txtSDT.Text;
                    string diaChi = txtDiaChi.Text;
                    DateTime ngaySinh = dateTimePicker1.Value;

                    string query = "INSERT INTO KhachHang (MaKhachHang, HoTen, GioiTinh, DienThoai, DiaChi, NgaySinh)" + " VALUES (N'" + maKhachHang + "',N'" + hoTen + "',N'" + gioiTinh + "',N'" + dienThoai + "',N'" + diaChi + "',N'" + ngaySinh + "')";

                    ketnoi.Execute(query);

                    MessageBox.Show("Thêm thành viên thành công!");
                    loaddata();
                    txtMa.Clear();
                    txtTen.Clear();
                    cBSex.SelectedIndex = -1;
                    txtSDT.Clear();
                    txtDiaChi.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    checkBox1.Checked = false;
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string maKhachHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string querytv = "DELETE FROM TheThanhVien WHERE MaKhachHang = N'" + maKhachHang + "'";
                ketnoi.Execute(querytv);
                string query = "DELETE FROM KhachHang WHERE MaKhachHang = N'" + maKhachHang + "'";
                ketnoi.ExecuteNonQuery(query);
                
                loaddata();
                MessageBox.Show("Đã Xóa Khách Hàng Thành Công");
                txtMa.Clear();
                txtTen.Clear();
                cBSex.SelectedIndex = -1;
                txtSDT.Clear();
                txtDiaChi.Clear();
                dateTimePicker1.Value = DateTime.Now;
                checkBox1.Checked = false;
            }
            else
            {

                MessageBox.Show("Vui lòng chọn khách hàng để được xóa!");
                checkBox1.Checked = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maKhachHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string hoTen = txtTen.Text;
                string gioiTinh = cBSex.Text;
                string dienThoai = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                DateTime ngayDK = dateTimePickerDK.Value;
                DateTime ngayHH = dateTimePickerHH.Value;

                string query = "UPDATE KhachHang SET HoTen = N'" + hoTen + "', GioiTinh = N'" + gioiTinh + "', DienThoai = N'" + dienThoai + "', DiaChi = N'" + diaChi + "', NgaySinh = N'" + ngaySinh + "' WHERE MaKhachHang = N'" + maKhachHang + "'";
                string querytv = "UPDATE TheThanhVien SET  NgayDangKy = N'" + ngayDK + "', NgayHetHan = N'" + ngayHH + "' WHERE MaKhachHang = N'" + maKhachHang + "'";
                ketnoi.Execute(query);

                MessageBox.Show("Cập nhật khách hàng thành công!");
                loaddata();
                txtMa.Clear();
                txtTen.Clear();
                cBSex.SelectedIndex = -1;
                txtSDT.Clear();
                txtDiaChi.Clear();
                dateTimePicker1.Value = DateTime.Now;
                checkBox1.Checked = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên để được cập nhật!");
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePickerDK.Enabled = true;
                dateTimePickerHH.Enabled = true;
            }
            else
            {
                dateTimePickerDK.Enabled = false;
                dateTimePickerHH.Enabled = false;
            }
        }
    }
}
