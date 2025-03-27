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
    public partial class TTNcc : Form
    {
        private string _mancc;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public TTNcc()
        {
            InitializeComponent();
        }
        public TTNcc(string mancc) : this()
        {
            _mancc = mancc;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TTNcc_Load(object sender, EventArgs e)
        {
            string query = " SELECT * FROM NhaCungCap WHERE MaNhaCungCap = N'"+_mancc+"'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtMa.Text = _mancc;
                txtTen.Text = dt.Rows[0][1].ToString();
                txtDiachi.Text = dt.Rows[0][2].ToString();
                txtGmail.Text = dt.Rows[0][3].ToString();
            }
        }
    }
}
