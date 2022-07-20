using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace THUVIEN
{
    public class Cls_khachhang
    {
        public static DataTable select() {
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", Cls_ketnoi.kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool insert(string mkh,string tenkh,string dc,string std,string email) {
            bool rt = true;
            try
            {
                Cls_ketnoi.kn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("insert into KhachHang(MaKH,TenKH,DiaChi,SDT,Email) Values('{0}',N'{1}',N'{2}','{3}','{4}')", mkh, tenkh, dc, std, email), Cls_ketnoi.kn);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                rt = false;
            }
            finally
            {
                Cls_ketnoi.kn.Close();
            }
            return rt;
        
        }
    }
}
