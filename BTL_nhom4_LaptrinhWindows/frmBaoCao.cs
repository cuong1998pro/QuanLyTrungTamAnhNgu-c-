using BTL_nhom4_LaptrinhWindows.DAO;
using BTL_nhom4_LaptrinhWindows.DTO;
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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            List < HocVien >ds= HocvienDAO.Instance.LayDanhSachIDHocVien();
            foreach(HocVien x in ds)
            {
                HocvienDAO.Instance.LaySoTienConNo(x.id);
            }
             this.thongkehocphiTableAdapter.Fill(this.BTL_N04DataSet.thongkehocphi, 1);

            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
