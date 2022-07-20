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
    public partial class frm_themkh : Form
    {
        public frm_themkh()
        {
            InitializeComponent();
        }
        public void makh()
        {
            txt_makh.Text = "KH" + Convert.ToInt32(Cls_khachhang.select().Rows.Count + 1);
        }
        public void them_kh() {
            if (txt_tenkh.Text.Length == 0 && txt_dc.Text.Length == 0 && txt_sdt.Text.Length == 0 && txt_dc.Text.Length == 0 && txt_email.Text.Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin!");
            }
            else {
                Cls_khachhang.insert(txt_makh.Text, txt_tenkh.Text, txt_dc.Text, txt_sdt.Text, txt_email.Text);
                MessageBox.Show("Đã thêm khách hàng thành công");
            }
           
        }
        public void load_dl()
        {
            this.dgv_dl.DataSource = Cls_khachhang.select();
        }

        private void frm_themkh_Load(object sender, EventArgs e)
        {
            makh();
            load_dl();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them_kh();
            load_dl();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
