using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Date;
namespace DateTest
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void ProvjeraDefaultniKonstruktor()
        {
            DateClass Date = new DateClass();
            Assert.AreEqual(1, Date.Dan, "krivi dan u defaultnom");
            Assert.AreEqual(1, Date.Mjesec, "krivi Mjesec u defaultnom");
            Assert.AreEqual(1, Date.Godina, "krivi Godina u defaultnom");
        }

        [TestMethod]
        public void ProvjeraOverrideKonstruktor()
        {
            DateClass Date = new DateClass(2, 10, 2015);
            Assert.AreEqual(2, Date.Dan, "krivi dan u konstruktoru");
            Assert.AreEqual(10, Date.Mjesec, "krivi Mjesec u konstruktoru");
            Assert.AreEqual(2015, Date.Godina, "kriva Godina u konstruktoru");
        }
        [TestMethod]
        public void Provjera_getMjesecName()
        {
            DateClass Date = new DateClass(2, 10, 2015);
            Assert.AreEqual("Listopad", Date.getMounthName(Date.Mjesec), "kriv ispis mjeseca");
        }
       
        [TestMethod]
        public void Provjera_getNumberOfRemaingDaysInMonth31()
        {
            DateClass Date = new DateClass(2, 10, 2015);
            int broj=31-2;
            Assert.AreEqual(broj, Date.getNumberOfRemaingDaysInMonth(Date.Dan,Date.Mjesec,Date.Godina), "kriv ispis preostalih dana 31");
        }

        [TestMethod]
        public void Provjera_getNumberOfRemaingDaysInMonth30()
        {
            DateClass Date = new DateClass(2, 11, 2015);
            int broj = 30 - 2;
            Assert.AreEqual(broj, Date.getNumberOfRemaingDaysInMonth(Date.Dan, Date.Mjesec, Date.Godina), "kriv ispis preostalih dana 30");
        }
        
        [TestMethod]
        public void Provjera_getNumberOfRemaingDaysInMonth2NotLeap()
        {
            DateClass Date = new DateClass(2, 2, 2015);
            int broj = 28 - 2;
            Assert.AreEqual(broj, Date.getNumberOfRemaingDaysInMonth(Date.Dan, Date.Mjesec, Date.Godina), "kriv ispis preostalih dana Veljače,Ne-Prijestupne god");
        }

        [TestMethod]
        public void Provjera_getNumberOfRemaingDaysInMonth2Leap()
        {
            DateClass Date = new DateClass(2, 2, 2000);
            int broj = 29 - 2;
            Assert.AreEqual(broj, Date.getNumberOfRemaingDaysInMonth(Date.Dan, Date.Mjesec, Date.Godina), "kriv ispis preostalih dana Veljače,Prijestupne god");
        }
        [TestMethod]
        public void Provjera_isLeapYear()
        {
            DateClass Date = new DateClass(2, 10, 2012);
            Boolean da = true;
            Assert.AreEqual(da, Date.isLeapYear(Date.Godina), "Kriva provjera prijestupne");
        }

        [TestMethod]
        public void Provjera_isNotLeapYear()
        {
            DateClass Date = new DateClass(2, 10, 2001);
            Boolean ne = false;
            Assert.AreEqual(ne, Date.isLeapYear(Date.Godina), "Kriva provjera ne-prijestupne");
        }
        [TestMethod]
        public void Provjera_isLeapYear400()
        {
            DateClass Date = new DateClass(2, 10, 2000);
            Boolean da = true;
            Assert.AreEqual(da, Date.isLeapYear(Date.Godina), "Kriva  provjera prijestupne % 400");
        }

        [TestMethod]
        public void Provjera_isLeapYear100()
        {
            DateClass Date = new DateClass(2, 10, 1000);
            Boolean ne = false;
            Assert.AreEqual(ne, Date.isLeapYear(Date.Godina), "Kriva  provjera prijestupne % 100");
        }

        [TestMethod]
        public void Provjera_isLeapYear4()
        {
            DateClass Date = new DateClass(2, 10, 32);
            Boolean da = true;
            Assert.AreEqual(da, Date.isLeapYear(Date.Godina), "Kriva  provjera prijestupne % 4");
        }
   }
}
