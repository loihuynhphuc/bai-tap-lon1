using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using THUVIEN;

namespace QL_VTXD
{
    public partial class frm_HDX : Form
    {
        SqlConnection kn = new SqlConnection(@"server=.;DataBase=QUANLYKHO;Integrated Security = true");
        public frm_HDX()
        {
            InitializeComponent();
        }
        public void buoc_cbo() {
            cbo_sHD.DataSource = Cls_HD.select_HD();
            cbo_sHD.DisplayMember = "SoHD";
            cbo_sHD.ValueMember = "SoHD";
        }

        private void frm_HDX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYKHODataSet8.pr_HDX' table. You can move, or remove it, as needed.
            buoc_cbo();
        }

        private void cbo_sHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pr_HDXTableAdapter.Fill(this.QUANLYKHODataSet8.pr_HDX,cbo_sHD.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
