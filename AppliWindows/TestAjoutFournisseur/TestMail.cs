using System;
using ApliCommercial.Ajout;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestAjoutFournisseur
{
    [TestClass]
    public class TestMailTrue
    {
        [TestMethod]
        public void BonFormat1()
        {
            string a = "aa@aa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, true);
        }
        [TestMethod]
        public void BonFormat2()
        {
            string a = "a-a@aa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, true);
        }
        [TestMethod]
        public void BonFormat3()
        {
            string a = "fr.caumartin@afpa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, true);
        }
        [TestMethod]
        public void BonFormat4()
        {
            string a = "fr.caumartin@afpa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, true);
        }
        [TestMethod]
        public void BonFormat5()
        {
            string a = "vince.sene@gmail.com";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, true);
        }
    }
    [TestClass]
    public class TestMailFalse
    {
        [TestMethod]
        public void MauvaisFormat1()
        {
            string a = "a-_a@aa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, false);
        }
        [TestMethod]
        public void MauvaisFormat2()
        {
            string a = "a@a@aa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, false);
        }

        [TestMethod]
        public void MauvaisFormat3()
        {
            string a = "@@.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, false);
        }
        [TestMethod]
        public void MauvaisFormat4()
        {
            string a = "a@aa.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, false);
        }
        [TestMethod]
        public void MauvaisFormat5()
        {
            string a = "aa@a.fr";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);

            Assert.AreEqual(b, false);
        }
    }
}
