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
    public partial class frmDanhSachHocVien : Form
    {
        public frmDanhSachHocVien()
        {
            InitializeComponent();
        }

        private void frmDanhSachHocVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BTL_N04DataSet1.thongkesinhvien' table. You can move, or remove it, as needed.
          
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.thongkesinhvienTableAdapter.Fill(this.BTL_N04DataSet1.thongkesinhvien,int.Parse(textBoxX1.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
