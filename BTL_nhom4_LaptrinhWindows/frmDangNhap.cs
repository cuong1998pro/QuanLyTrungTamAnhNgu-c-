using BTL_nhom4_LaptrinhWindows.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_nhom4_LaptrinhWindows
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAO.Instance.KetquaDangnhap(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                frmMain f = new frmMain();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
