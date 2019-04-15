using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace QLiSach
{
    public class CheckXoa
    {
        public static string checkXoa(string maKH)
        {
            if (maKH.Length < 4)
            {
                return "Xóa thành công";
            }

            return "0";

        }

    }
}
