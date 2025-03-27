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
    public partial class ListNCC : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public ListNCC()
        {
            InitializeComponent();
        }

        private void ListNCC_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void comboBoxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void thongTinChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string mancc = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTNcc tTNcc = new TTNcc(mancc);
            tTNcc.Show();

        }
        void loaddata()
        {
            string query = "SELECT * FROM NhaCungCap ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ A-Z")
            {
                string query = "SELECT * FROM NhaCungCap ORDER BY TenNhaCungCap ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ Z-A")
            {
                string query = "SELECT * FROM NhaCungCap ORDER BY TenNhaCungCap DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
        }

        private void comboBoxTim_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
