using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLiSach
{
    public class CheckThem
    {
       public static string checkThem(string MaKH, string HoTen, string DiaChi, string DienThoai, string Email)
        {
            if(MaKH.Length > 5)
            {
                return "Mã KH quá dài";
            }
            else if(HoTen.Length > 30)
            { return "Họ Tên quá dài"; }
            else if(DiaChi.Length > 30)
            { return "Địa Chỉ quá dài"; }
            else if(DienThoai.Length >7)
            { return "SDT quá dài"; }
            else if(Email.Length > 12)
            { return "Email quá dài"; }
            return "0";
        }
        
    }
}
