using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLiSach
{
    public class CheckDangNhap
    {
        public static string ktdangnhap(string ten, string pass)
        {
            if ((ten == "admin") && (pass == "")) { return ("Vui lòng điền mật khẩu"); }
            else
            if (ten == "") { return (" Sai tên đăng nhập hoặc sai mật khẩu"); }
           

            else return "0";
        }
    }
}
