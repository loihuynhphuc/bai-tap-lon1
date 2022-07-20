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
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = "Người đăng nhập:" +" "+ txt_tendangnhap.Text;
                Cls_ketnoi.kn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("select * from DangNhap WHERE usename=N'{0}' and password= '{1}'", this.txt_tendangnhap.Text, this.txt_password.Text), Cls_ketnoi.kn);
                SqlDataReader dta = cmd.ExecuteReader();
               
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frm_Main f_main = new frm_Main(true,userName);
                    f_main.Show();
                    this.Hide();
                    
                   
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
            finally {
                Cls_ketnoi.kn.Close();
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "XÁC NHẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
          
        }

        private void frm_Dangnhap_Load(object sender, EventArgs e)
        {
        }
    }
}
