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
    public partial class ListDia : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public ListDia()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ A-Z")
            {
                string query = "SELECT * FROM BangDia ORDER BY TenBangDia ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ Z-A")
            {
                string query = "SELECT * FROM BangDia ORDER BY TenBangDia DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê băng đĩa theo giá từ thấp – cao")
            {
                string query = "SELECT * FROM BangDia ORDER BY GiaThue ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê băng đĩa theo giá từ cao – thấp")
            {
                string query = "SELECT * FROM BangDia ORDER BY GiaThue DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
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

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string madia = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTDia tTDia = new TTDia(madia);
            tTDia.Show();
            
        }
        void loaddata()
        {

            string query = "SELECT * FROM BangDia ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void ListDia_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
