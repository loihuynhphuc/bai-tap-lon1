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

namespace QL_VTXD
{
    public partial class frm_rphodon : Form
    {
        SqlConnection kn = new SqlConnection(@"server=.;DataBase=QUANLYKHO;Integrated Security = true");
        public frm_rphodon()
        {
            InitializeComponent();
        }
        public void buoc_cbo() {
            SqlDataAdapter da = new SqlDataAdapter("select * from Hang", kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cbo_mahang.DataSource = dt;
            this.cbo_mahang.DisplayMember = "MaHang";
            this.cbo_mahang.ValueMember = "MaHang";
        }

        private void frm_rphodon_Load(object sender, EventArgs e)
        {
            buoc_cbo();
            // TODO: This line of code loads data into the 'QUANLYKHODataSet4.rp_HODON' table. You can move, or remove it, as needed.
           
        }

        private void cbo_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rp_HODONTableAdapter.Fill(this.QUANLYKHODataSet4.rp_HODON, cbo_mahang.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
