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

namespace BTL_nhom4_LaptrinhWindows.UCs
{
    public partial class ucThanhToan : UserControl
    {
        BindingSource thanhtoan = new BindingSource();
        public ucThanhToan()
        {
            InitializeComponent();
            dtgvHocPhi.DataSource = thanhtoan;
            load();
           
        }
      
        void load()
        {
            cboKhoasearch.DataSource = KhoaHocDAO.Instance.LayDanhSachKhoaHoc();
            cboKhoasearch.ValueMember = "id";
            cboKhoasearch.DisplayMember = "ten";
            cboKhoasearch.SelectedIndex = -1;
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgvLop.DataSource = HocvienDAO.Instance.LayDanhSachHocVien();
        }
        void HienDanhSach()
        {
            dtgvLop.DataSource = LopDAO.Instance.LayDanhSachSinhVienThuocLop((int)cboLop.SelectedValue);

        }


        private void cboKhoasearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboKhoasearch.SelectedIndex != -1)
                {
                    cboLop.DataSource = LopDAO.Instance.LayDanhSachLopTheoKhoa((int)cboKhoasearch.SelectedValue);
                    cboLop.ValueMember = "id";
                    cboLop.DisplayMember = "ten";
                    cboLop.SelectedIndex = -1;
                }
            }
            catch { }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboLop.SelectedIndex != -1)
                    HienDanhSach();
                else
                    dtgvLop.DataSource = HocvienDAO.Instance.LayDanhSachHocVien();
            }
            catch { }
        }

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idhocvien = (int)dtgvLop.SelectedCells[0].OwningRow.Cells["id"].Value;
                thanhtoan.DataSource = HocvienDAO.Instance.LayDanhSachHocPhi(idhocvien);
                txtConNo.Text = HocvienDAO.Instance.LaySoTienConNo(idhocvien).ToString();
                txtHoten.Text = dtgvLop.SelectedCells[0].OwningRow.Cells["hoten"].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idhocvien = (int)dtgvLop.SelectedCells[0].OwningRow.Cells["id"].Value;
                if (!HocvienDAO.Instance.ThemThanhToan(idhocvien, int.Parse(txtSoTien.Text)))
                {
                    MessageBox.Show("Thông tin không chính xác!");
                }
            ;
                txtConNo.Text = HocvienDAO.Instance.LaySoTienConNo(idhocvien).ToString();


                thanhtoan.DataSource = HocvienDAO.Instance.LayDanhSachHocPhi(idhocvien);
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int idhocvien = (int)dtgvLop.SelectedCells[0].OwningRow.Cells["id"].Value;
                int idthanhtoan = (int)dtgvHocPhi.SelectedCells[0].OwningRow.Cells["id2"].Value;
                if (!HocvienDAO.Instance.SuaThanhToan(idthanhtoan, int.Parse(txtSoTien.Text)))
                {
                    MessageBox.Show("Thông tin không chính xác!");
                }
            ;
                txtConNo.Text = HocvienDAO.Instance.LaySoTienConNo(idhocvien).ToString();
                thanhtoan.DataSource = HocvienDAO.Instance.LayDanhSachHocPhi(idhocvien);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idhocvien = (int)dtgvLop.SelectedCells[0].OwningRow.Cells["id"].Value;
                int idthanhtoan = (int)dtgvHocPhi.SelectedCells[0].OwningRow.Cells["id2"].Value;
                if (!HocvienDAO.Instance.XoaThanhToan(idthanhtoan))
                {
                    MessageBox.Show("Thông tin không chính xác!");
                }
            ;
                txtConNo.Text = HocvienDAO.Instance.LaySoTienConNo(idhocvien).ToString();
                thanhtoan.DataSource = HocvienDAO.Instance.LayDanhSachHocPhi(idhocvien);
            }
            catch { }
        }

        private void dtgvHocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvHocPhi.SelectedCells.Count > 0)
                    txtSoTien.Text = dtgvHocPhi.SelectedCells[0].OwningRow.Cells["tienthanhtoan"].Value.ToString();
                else
                    txtSoTien.Text = "";
            }
            catch { }
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
}
