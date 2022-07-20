using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace THUVIEN
{
   public class Cls_HD
    {
        public static DataTable select_HD() { 
           string tv = String.Format("select SoHD,MaCH,Hang.MaHang,MaKho,MaNV,NgayXuat,SoluongXuat,TenHang,SoLuong,ThanhTien,TenKH,DiaChi  from Hang,HoaDon where  Hang.MaHang= HoaDon.MaHang");
           SqlDataAdapter da = new SqlDataAdapter(tv, Cls_ketnoi.kn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           return dt;
        }

        public static DataTable select_gia(string mah)
        {
            string tv = String.Format("select DonGia  from Hang,HoaDon where  Hang.MaHang= HoaDon.MaHang and Hang.MaHang='{0}'", mah);
            SqlDataAdapter da = new SqlDataAdapter(tv, Cls_ketnoi.kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool insert(string SoHD,string mh,string MaCH,string MaKH,string MaNV,string NX,int soluong,int thanhtien,string mkh,string tenkh,string dc) {
            bool rt = true;
            try
            {
                Cls_ketnoi.kn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("insert HoaDon Values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}',N'{9}','{10}')",SoHD,mh,MaCH,MaKH,MaNV,NX,soluong,thanhtien,mkh,tenkh,dc), Cls_ketnoi.kn);
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

