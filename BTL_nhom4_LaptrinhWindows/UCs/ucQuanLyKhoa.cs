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
    public partial class ucQuanLyKhoa : UserControl
    {
        BindingSource khoa = new BindingSource();
        public ucQuanLyKhoa()
        {
         
            InitializeComponent();
            dtgvKhoa.DataSource = khoa;
            Load();
            Addbinding();
            
            
        }
        private void Addbinding()
        {
           txtTenKhoaHoc.DataBindings.Add(new Binding("text", dtgvKhoa.DataSource, "ten", true, DataSourceUpdateMode.Never));
            txtHocPhi.DataBindings.Add(new Binding("text", dtgvKhoa.DataSource, "hocphi", true, DataSourceUpdateMode.Never));
            dtpNgaybatdau.DataBindings.Add(new Binding("value", dtgvKhoa.DataSource, "ngaybatdau", true, DataSourceUpdateMode.Never));
            dtpNgayKetThuc.DataBindings.Add(new Binding("value", dtgvKhoa.DataSource, "ngayketthuc", true, DataSourceUpdateMode.Never));
        }
        void Load()
        {
            khoa.DataSource = KhoaHocDAO.Instance.LayDanhSachKhoaHoc();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KhoaHocDAO.Instance.ThemKhoaHoc(txtTenKhoaHoc.Text, dtpNgaybatdau.Value.ToString("MM/dd/yyyy"), dtpNgayKetThuc.Value.ToString("MM/dd/yyyy"), int.Parse(txtHocPhi.Text)))
                {
                    MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dtgvKhoa.SelectedCells[0].OwningRow.Cells["id"].Value;

                if (!KhoaHocDAO.Instance.SuaKhoahoc(id, txtTenKhoaHoc.Text, dtpNgaybatdau.Value.ToString("MM/dd/yyyy"), dtpNgayKetThuc.Value.ToString("MM/dd/yyyy"), int.Parse(txtHocPhi.Text)))
                {
                    MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
                }
            
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dtgvKhoa.SelectedCells[0].OwningRow.Cells["id"].Value;
                if (!KhoaHocDAO.Instance.XoaKhoaHoc(id))
                {
                    MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load();
        }
    }
}
