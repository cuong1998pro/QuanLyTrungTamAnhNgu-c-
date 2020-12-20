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
    public partial class ucDanhSachLop : UserControl
    {
        public ucDanhSachLop()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            cboKhoa.DataSource = KhoaHocDAO.Instance.LayDanhSachKhoaHoc();
            dtgvDanhsachsinhvien.DataSource = HocvienDAO.Instance.LayDanhSachHocVien();
            cboKhoa.ValueMember = "id";
            cboKhoa.DisplayMember = "ten";
           
        }

        private void comboBoxEx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

           
            int idkhoa = (int)cboKhoa.SelectedValue;

            cboThoiGian.DataSource = LopDAO.Instance.LayDanhSachThoiGianCuaMotKhoaHoc(idkhoa);
            cboThoiGian.ValueMember = "id";
            cboThoiGian.DisplayMember = "lich";
             }catch(Exception ex)
            {

            }
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLop.DataSource = LopDAO.Instance.LayDanhSachLopTheoKhoaVaThoiGian((int)cboKhoa.SelectedValue, (int)cboThoiGian.SelectedValue);
            cboLop.ValueMember = "id";
            cboLop.DisplayMember = "ten";
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvDanhsachsvcualop.DataSource = LopDAO.Instance.LayDanhSachSinhVienThuocLop((int)cboLop.SelectedValue);
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            //btnThem
            if (LopDAO.Instance.KiemTraHocVienTrongLop((int)dtgvDanhsachsinhvien.SelectedCells[0].OwningRow.Cells["id"].Value, (int)cboLop.SelectedValue))
            {
                if (!LopDAO.Instance.ThemHocVienVaoLop((int)dtgvDanhsachsinhvien.SelectedCells[0].OwningRow.Cells["id"].Value, (int)cboLop.SelectedValue))
                {
                    MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
                }
                dtgvDanhsachsvcualop.DataSource = LopDAO.Instance.LayDanhSachSinhVienThuocLop((int)cboLop.SelectedValue);
            }
            else
            {
                MessageBox.Show("Học viên đã thêm vào lớp từ trước!");
            }
        }
        void Tim()
        {
            dtgvDanhsachsinhvien.DataSource = HocvienDAO.Instance.TimThongTinHocVien(txtHoten.Text, txtSdt.Text);
        }
        private void textBoxX4_TextChanged(object sender, EventArgs e)
        {
            Tim();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            Tim();
        }

        #region empty
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

      
        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

        }

      

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

       

        

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        

        private void labelX10_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            //btnXoa
            if (!LopDAO.Instance.XoaHocVienVaoLop((int)dtgvDanhsachsvcualop.SelectedCells[0].OwningRow.Cells["id2"].Value, (int)cboLop.SelectedValue))
            {
                MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
            }
            dtgvDanhsachsvcualop.DataSource = LopDAO.Instance.LayDanhSachSinhVienThuocLop((int)cboLop.SelectedValue);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
