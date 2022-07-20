using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VTXD
{
    public partial class frm_rp_phieunhap : Form
    {
        public frm_rp_phieunhap()
        {
            InitializeComponent();
        }

        private void frm_rp_phieunhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYKHODataSet3.rp_phieuthu' table. You can move, or remove it, as needed.
            this.rp_phieuthuTableAdapter.Fill(this.QUANLYKHODataSet3.rp_phieuthu);

            this.reportViewer1.RefreshReport();
        }
    }
}
