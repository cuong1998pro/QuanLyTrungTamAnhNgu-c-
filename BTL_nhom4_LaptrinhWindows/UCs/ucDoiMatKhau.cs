using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_nhom4_LaptrinhWindows.DAO;

namespace BTL_nhom4_LaptrinhWindows
{
    public partial class ucThongtinTaiKhoan : UserControl
    {
        public ucThongtinTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAO.Instance.KetquaDangnhap(txtTenTaiKhoan.Text, txtMatKhau.Text))
                if (txtNhapLai.Text == txtMatKhauMoi.Text)
                {
                    try
                    {
                        if (!TaiKhoanDAO.Instance.Thaydoimatkhau(txtTenTaiKhoan.Text, txtMatKhauMoi.Text))
                            MessageBox.Show("Thất bại");
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Mật khẩu nhập lại không chính xác");
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }
    }
}
