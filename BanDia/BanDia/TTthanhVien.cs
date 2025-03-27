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
    public partial class TTthanhVien : Form
    {
        private string _matv;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public TTthanhVien()
        {
            InitializeComponent();
        }
        public TTthanhVien(string matv) : this()
        {
            _matv = matv;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TTthanhVien_Load(object sender, EventArgs e)
        {
            string query = " SELECT * FROM KhachHang WHERE MaKhachHang = N'" + _matv + "'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtMaKH.Text = _matv;
                txtHoTen.Text = dt.Rows[0][1].ToString();
                txtSex.Text = dt.Rows[0][2].ToString();
                txtSdt.Text = dt.Rows[0][3].ToString();
                txtDiaChi.Text = dt.Rows[0][4].ToString();
                dateTimePicker1.Text = dt.Rows[0][5].ToString();
            }
        }
    }
}
