using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace THUVIEN
{
   public class Cls_hang
    {
       public static DataTable select(){
            SqlDataAdapter da = new SqlDataAdapter("select * from Hang",Cls_ketnoi.kn);
           DataTable dt  = new DataTable();
           da.Fill(dt);
           return dt;
       } 

    }
}
