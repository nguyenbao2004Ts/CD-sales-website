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
    public partial class QLNCC : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
         public static int currentUserRole;

        public QLNCC()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void thongTinChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string mancc = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTNcc tTNcc = new TTNcc(mancc);
            tTNcc.Show();
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMa.Text;
            string tenNCC = txtTen.Text;
            string DCNCC = txtDiaChi.Text;
            string mailNCC = txtMail.Text;
            string query = "INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi, Gmail)" + "VALUES(N'"+ maNCC + "',N'" + tenNCC + "',N'" + DCNCC + "',N'" + mailNCC + "')";
            ketnoi.ExecuteNonQuery(query);
            loaddata();
            txtMail.Clear();
            txtMa.Clear();
            txtDiaChi.Clear();
            txtTen.Clear();
        }
        void loaddata()
        {
            string query = "SELECT * FROM NhaCungCap ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void QLNCC_Load(object sender, EventArgs e)
        {
            loaddata();
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
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtMail.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maNCC = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM NhaCungcap WHERE MaNhaCungCap = N'" + maNCC + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Nhà Cung Cấp Thành Công");
                txtMail.Clear();
                txtMa.Clear();
                txtDiaChi.Clear();
                txtTen.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để được xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maNCC = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string tenNCC = txtTen.Text;
                string diaChiNCC = txtDiaChi.Text;
                string mailNCC = txtMail.Text;

               
                string query = "UPDATE NhaCungCap SET TenNhaCungCap = N'" + tenNCC + "', DiaChi = N'" + diaChiNCC + "', Gmail = N'" + mailNCC + "' WHERE MaNhaCungCap = N'" + maNCC + "'";

                
                ketnoi.ExecuteNonQuery(query);

                loaddata();
                MessageBox.Show("Đã Cập Nhật Nhà Cung Cấp Thành Công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để được cập nhật!");
            }
        }
    }
}
