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
    public partial class Login : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public Login()
        {
            InitializeComponent();
            btnLogin.Cursor = Cursors.Hand;
                btnThoat.Cursor = Cursors.Hand;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBoxTaiKhoan.Text;
            string matKhau = textBoxMK.Text;

            
            string query = "EXEC USP_Form1 @TaiKhoan,@MatKhau";

            DataTable dt = ketnoi.getLogin(query, taiKhoan, matKhau);

            if (dt.Rows.Count > 0)
            {
                int maChucVu = Convert.ToInt32(dt.Rows[0]["MaChucVu"]);
                if (maChucVu == 1)
                {
                    QLThe.currentUserRole = 1;
                    QLNCC.currentUserRole = 1;
                    QLDia.currentUserRole = 1;
                    BaoCao.currentUserRole = 1;
                    DatHang.currentUserRole = 1;
                    ListDia.currentUserRole = 1;
                    ListNCC.currentUserRole = 1;
                    ListTV.currentUserRole = 1;
                    QLTV.currentUserRole = 1;
                    ThueDia.currentUserRole = 1;
                    TimDia.currentUserRole = 1;
                    TimNCC.currentUserRole = 1;
                    TimTV.currentUserRole = 1;
                    TraDia.currentUserRole = 1;
                    Menu menuNv = new Menu();
                    menuNv.Show();

                }
                else if (maChucVu == 2)
                {
                    QLThe.currentUserRole = 2;
                    QLNCC.currentUserRole = 2;
                    QLDia.currentUserRole = 2;
                    BaoCao.currentUserRole = 2;
                    DatHang.currentUserRole = 2;
                    ListDia.currentUserRole = 2;
                    ListNCC.currentUserRole = 2;
                    ListTV.currentUserRole = 2;
                    QLTV.currentUserRole = 2;
                    ThueDia.currentUserRole = 2;
                    TimDia.currentUserRole = 2;
                    TimNCC.currentUserRole = 2;
                    TraDia.currentUserRole = 2;

                    MenuQL menuql = new MenuQL();
                    menuql.Show();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMK.Clear();
                textBoxTaiKhoan.Clear();
                textBoxTaiKhoan.Focus();
            }
        }
    }
}
