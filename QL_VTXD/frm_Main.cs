using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THUVIEN;

namespace QL_VTXD
{
    public partial class frm_Main : Form
    {
        public frm_Main(bool vb,string username)
        {
            InitializeComponent();

            //thongkeToolStripMenuItem.Visible = true;
            thongkeToolStripMenuItem.Visible = vb;
            taikhoanToolStripMenuItem.Visible = vb;
            HanghoaToolStripMenuItem.Visible = vb;
            lb_hienthi.Text = username;
            
        }
        
        private void frm_Main_Load(object sender, EventArgs e)
        {
           
        }

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Dangnhap f_dn = new frm_Dangnhap();
            f_dn.Show();
            this.Hide();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void doimatkhauToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frm_DoiMK f_Mk = new frm_DoiMK();
            f_Mk.Show();
           
        }

        private void taotaikhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_taoTK f_tao = new frm_taoTK();
            f_tao.Show();
           

        }

        private void hethongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phieunhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_phieunhap f_phieunhap = new frm_phieunhap();
            f_phieunhap.Show();
        }

        private void hoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Hoadon f_hd = new frm_Hoadon();
            f_hd.Show();
        }

        private void rpphieunhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rp_phieunhap fr_phieunhap = new frm_rp_phieunhap();
            fr_phieunhap.Show();
        }

        private void rphoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rphodon fr_hoadon = new frm_rphodon();
            fr_hoadon.Show();
        }

        private void taikhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hoadonXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HDX f_hdx = new frm_HDX();
            f_hdx.Show();
        }
    }
}
