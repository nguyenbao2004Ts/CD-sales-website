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
    public partial class Menu : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public Menu()
        {
            InitializeComponent();
        }

        private void thêmNhàCungCấpMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNCC qLNCC = new QLNCC();
            qLNCC.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\430996147_2392243790960691_7301248806161264471_n.jpg");
        }

        private void TimNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimNCC timNCC = new TimNCC();
            timNCC.Show();
            this.Hide();
        }

        private void listNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListNCC listNCC = new ListNCC();
            listNCC.Show();
            this.Hide();
        }

        private void quanlydiaMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDia qLDia = new QLDia();
            qLDia.Show();
            this.Hide();
        }

        private void timdiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimDia timDia = new TimDia();
            timDia.Show();
            this.Hide();
        }

        private void listdiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDia listDia = new ListDia();
            listDia.Show();
            this.Hide();
        }

        private void quanLyThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTV qLTV = new QLTV();
            qLTV.Show();
            this.Hide();
        }

        private void timThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimTV timTV = new TimTV();
            timTV.Show();
            this.Hide();
        }

        private void listThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTV listTV = new ListTV();
            listTV.Show();
            this.Hide();
        }

        private void thueDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThueDia thueDia = new ThueDia();
            thueDia.Show();
            this.Hide();
        }

        private void TraDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraDia traDia = new TraDia();
            traDia.Show();
            this.Hide();
        }

        private void xuatBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.Show();
            this.Hide();
        }

        private void datHangBangDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatHang datHang = new DatHang();
            datHang.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void quanlytheThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLThe qLthe = new QLThe();
            qLthe.Show();
            this.Hide();
        }
    }
}
