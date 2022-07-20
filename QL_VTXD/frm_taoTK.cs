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
    public partial class frm_taoTK : Form
    {
        public frm_taoTK()
        {
            InitializeComponent();
        }

        private void btn_taotk_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter(String.Format("select COUNT(*) from DangNhap where usename=N'{0}' or displayname=N'{1}'" ,this.txt_tendn.Text,txt_tentaikhoan.Text), Cls_ketnoi.kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                errorProvider1.SetError(txt_tentaikhoan, "Tài khoản đã có rồi!");
                //errorProvider1.SetError(txt_tendn, "Trùng tên đăng nhập!");
            }
            else {
                if (txt_taoMK.Text == txt_nhaplaimk.Text)
                {
                    if (txt_taoMK.Text.Length >= 6)
                    {
                        try
                        {
                            Cls_ketnoi.kn.Open();
                            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO DangNhap(displayname,usename, password) VALUES(N'{0}','{1}', '{2}')", this.txt_tentaikhoan.Text, this.txt_tendn.Text, this.txt_taoMK.Text), Cls_ketnoi.kn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tài khoản đã đăng ký thành công");

                        }
                        catch
                        {
                            MessageBox.Show("Tài khoản đã đăng ký thất bại");
                        }
                        finally
                        {
                            Cls_ketnoi.kn.Close();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txt_taoMK, "Mật khẩu phải có ít nhất 6 ký tự");
                    }
                }
                else {
                    errorProvider1.SetError(txt_nhaplaimk, "Mật khẩu nhập lại chưa đúng!");
                }
                   
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
