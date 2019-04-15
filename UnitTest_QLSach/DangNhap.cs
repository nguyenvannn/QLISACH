using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLiSach;
using System.Windows.Forms;

namespace UnitTest_QLSach
{
    [TestClass]
    public class DangNhap
    {
        [TestMethod]
        public void Test_Nhap_Dung_Tai_Khoan()
        {
            string actual = CheckDangNhap.ktdangnhap("admin", "12345");
         
            string expected = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Khongnhapmatkhau()
        {
            string actual = CheckDangNhap.ktdangnhap("admin", "");

            string expected = "1";
            Assert.AreEqual(expected, actual);

        }
    }
}
