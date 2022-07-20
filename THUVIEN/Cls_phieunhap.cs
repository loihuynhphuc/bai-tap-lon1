using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace THUVIEN
{
    public class Cls_phieunhap
    {
        public static DataTable select()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PhieuNhap", Cls_ketnoi.kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool insert(string soPN,string Mah,string MaNCC,string Makh,string MaNV,string NN,int GN,int sl,int stdatra) {
            bool rt = true;
            try
            {
                Cls_ketnoi.kn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("insert into PhieuNhap(MaPN,MaHang,MaNCC,MaKho,MaNV,NgayNhap,GiaNhap,SoLuongNhap,SoTienDaTra) Values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},{8})", soPN, Mah, MaNCC, Makh, MaNV, NN, GN, sl, stdatra), Cls_ketnoi.kn);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                rt = false;
            }
            finally {
                Cls_ketnoi.kn.Close();
            }
            return rt;
        }
        public static bool update(string soPN, string Mah, string MaNCC, string Makh, string MaNV, string NN, int GN, int sl, int stdatra)
        {
            bool rt = true;
            try
            {
                Cls_ketnoi.kn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("update PhieuNhap set MaHang='{0}',MaNCC='{1}',MaKho='{2}',MaNV='{3}',NgayNhap='{4}',GiaNhap={5},SoLuongNhap={6},SoTienDaTra={7} where MaPN='{8}'", Mah, MaNCC, Makh, MaNV, NN, GN, sl, stdatra,soPN), Cls_ketnoi.kn);
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
        public static bool delete(string soPN)
        {
            bool rt = true;
            try
            {
                Cls_ketnoi.kn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("delete PhieuNhap where MaPN='{0}'",soPN), Cls_ketnoi.kn);
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
