using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace THUVIEN
{
    public class Cls_ketnoi
    {
        public static SqlConnection kn = new SqlConnection(@"server=LAPTOP-FDOO31K1;DataBase=QUANLYKHO;Integrated Security = true");

    }
}
