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
    public partial class TTDia : Form
    {
        private string _madia;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public TTDia()
        {
            InitializeComponent();
        }
        public TTDia(string madia) : this()
        {
            _madia = madia;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TTDia_Load(object sender, EventArgs e)
        {
            string query = " SELECT * FROM BangDia WHERE MaBangDia = N'" + _madia + "'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtMaBangDia.Text = _madia;
                txtTenBangDia.Text = dt.Rows[0][1].ToString();
                txtTheLoai.Text = dt.Rows[0][2].ToString();
                txtTinhTrang.Text = dt.Rows[0][3].ToString();
                txtHangSX.Text = dt.Rows[0][4].ToString();
                txtGhiChu.Text = dt.Rows[0][5].ToString();
                txtGiaThue.Text = dt.Rows[0][6].ToString();
            }
        }
    }
}
