using System;
using ApliCommercial.Ajout;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestAjoutFournisseur
{
    [TestClass]
    public class TestMail
    {
        [TestMethod]
        public void ControleMail1()
        {
            string a="aa-aa@aa.fr",attendu= "gkhk565-_@gkh.com";
            bool b = ApliCommercial.AjoutFourni.MailValide(a);
            if (b==true)
            {
                a = attendu;
            }
            Assert.AreEqual(a, attendu);
        }
    }
}
