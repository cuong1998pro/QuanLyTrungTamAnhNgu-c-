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
    public partial class ucThoiGianHoc : UserControl
    {
        BindingSource thoigian = new BindingSource();
       

        public ucThoiGianHoc()
        {
            InitializeComponent();
            dtgvLichhoc.DataSource = thoigian;
            load();
            Addbinding();
        }
        void Addbinding()
        { 
            txtBuoitrongtuan.DataBindings.Add(new Binding("text", dtgvLichhoc.DataSource, "thu", true, DataSourceUpdateMode.Never));
            txtCahoc.DataBindings.Add(new Binding("text", dtgvLichhoc.DataSource, "ca", true, DataSourceUpdateMode.Never));
        }
        void load()
        {
            thoigian.DataSource = ThoigianDAO.Instance.LayDanhSachThoiGian();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //bool ThoigianhocDao = false;
            if (!ThoigianDAO.Instance.ThemThoiGian(txtBuoitrongtuan.Text, txtCahoc.Text))
            {
                MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id =(int) dtgvLichhoc.SelectedCells[0].OwningRow.Cells["id"].Value;
            if (!ThoigianDAO.Instance.SuaLich(txtBuoitrongtuan.Text, txtCahoc.Text,id))
            {
                MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
            }
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)dtgvLichhoc.SelectedCells[0].OwningRow.Cells["id"].Value;
            if (!ThoigianDAO.Instance.XoaLich( id))
            {
                MessageBox.Show("Thông tin chưa chính xác, bạn vui lòng kiểm tra lại thông tin");
            }
            load();
        }
    }
}
