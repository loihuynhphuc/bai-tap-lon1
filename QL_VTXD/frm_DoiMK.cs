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
using System.Data.SqlClient;

namespace QL_VTXD
{
    public partial class frm_DoiMK : Form
    {
        public frm_DoiMK()
        {
            InitializeComponent();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(String.Format("select COUNT(*) from DangNhap where usename=N'{0}' and password='{1}'",this.txt_tentaikhoan.Text,this.txt_matkhaucu.Text),Cls_ketnoi.kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txt_matkhaumoi.Text == txt_nhaplaimatkhau.Text)
                {
                    if (txt_matkhaumoi.Text.Length >= 6)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter(String.Format("update DangNhap set password='{0}' where usename=N'{1}' and password='{2}'", this.txt_matkhaumoi.Text, this.txt_tentaikhoan.Text, this.txt_matkhaucu.Text), Cls_ketnoi.kn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        errorProvider1.SetError(txt_matkhaumoi, "Mật khẩu ít nhất phải có 6 ký tự");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_matkhaumoi, "Bạn chưa điền mật khẩu!");
                    errorProvider1.SetError(txt_nhaplaimatkhau, "Mật khẩu nhập lại chưa đúng!");
                }
            }
            else {
                errorProvider1.SetError(txt_tentaikhoan, "Tên người dùng chưa đúng!");
                errorProvider1.SetError(txt_matkhaucu, "Mật khẩu hiện tại chưa đúng!");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
