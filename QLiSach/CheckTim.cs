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
    public class CheckTim
    {
        public static string checkTim(string maKH)
        {
            if (maKH.Length < 4)
            {
                return "Tìm thành công";
            }

            return "0";

        }
    }
}
