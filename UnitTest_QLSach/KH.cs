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
    }
}
