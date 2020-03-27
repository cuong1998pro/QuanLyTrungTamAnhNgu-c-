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
    public partial class frmDiemThi : Form
    {
        public frmDiemThi()
        {
            InitializeComponent();
        }

        private void frmDiemThi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
