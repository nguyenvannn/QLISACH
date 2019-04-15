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
    public class KH
    {
        
        [TestMethod]
        public void Themthanhcong()
        {
            //string actual = kh ("KH12","Anh","BC","43543","45335");
            //string expected = "0";
            //Assert.AreEqual(expected, actual);
            //KhachHang kh1 = new KhachHang("PH2", "Phan", "Go Vap", "Nam", "08389283882");
            //string actual = kh.Inser
            //Assert.IsTrue(actual);
            string actual = CheckThem.checkThem("KH12", "Anh", "BC", "64765","64745");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BotrongMaKH()
        {
            string actual = CheckThem.checkThem("", "Anh", "BC", "64765", "64745");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CotheBoTrong()
        {
            string actual = CheckThem.checkThem("KH13", "", "", "", "");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void XoaThanhCong()
        {
            string actual = CheckXoa.checkXoa("KH01");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void XoaKhongThanhCong()
        {
            string actual = CheckXoa.checkXoa("");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TimThanhCong()
        {
            string actual = CheckTim.checkTim("KH01");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TimKhongThanhCong()
        {
            string actual = CheckTim.checkTim("");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SuaThanhCong()
        {
            string actual = CheckSua.checkSua("KH01","Anh","BC","4535","43543");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
    }
}
