using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PYATAYALABA;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        join g = new join();
        [TestMethod]
        public void TestMethod1()
        {
            var log = "latyp";
            var pas = "cdb3ed3adef3c0d1e7407d36843f3712";
            var isEntry = g.entryTest(log, pas);
            Assert.AreEqual(true, isEntry);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var name = "Булат";
            var surname = "Шарипов";
            var login = "bilka";
            var pass = "asasa";
            var mail = "awdwdw@mail.ru";
            var role = "User";
            var isReg = g.checkReg(name, surname, login, pass, mail, role);
            Assert.AreEqual(true, isReg);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string login = "latyp";
            var isDel = g.deleteUs(login);
            Assert.AreEqual(true, isDel);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string login = "zaidd";
            string pass = "asdsad";
            var isDel = g.entryNullTest(login, pass);
            Assert.AreEqual(true, isDel);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var name = "Булат";
            var surname = "Шарипов";
            var login = "";
            var pass = "asasa";
            var mail = "awdwdw@mail.ru";
            var role = "User";
            var isReg = g.checkRegNull(name, surname, login, pass, mail, role);
            Assert.AreEqual(true, isReg);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var one = "";
            var two = "";
            var isReg = g.Perevod(one, two);
            Assert.AreEqual(true, isReg);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var one = "5555";           
            var isReg = g.Popoln(one);
            Assert.AreEqual(true, isReg);
        }
        [TestMethod]
        public void TestMethod8()
        {
            var one = "";
            var isReg = g.PopolnNull(one);
            Assert.AreEqual(true, isReg);
        }
        [TestMethod]
        public void TestMethod9()
        {
            var name = "";
            var surname = "Шарипов";
            var login = "";
            var pass = "asasa";
            var mail = "awdwdw@mail.ru";
            var role = "User";
            var isReg = g.checkRegNullName(name, surname, login, pass, mail, role);
            Assert.AreEqual(true, isReg);
        }
        [TestMethod]
        public void TestMethod10()
        {
            var name = "Шарип";
            var surname = "";
            var login = "";
            var pass = "asasa";
            var mail = "awdwdw@mail.ru";
            var role = "User";
            var isReg = g.checkRegNullSurname(name, surname, login, pass, mail, role);
            Assert.AreEqual(true, isReg);
        }
        [TestMethod]
        public void TestMethod11()
        {
            var name = "Шарип";
            var surname = "";
            var login = "";
            var pass = "";
            var mail = "awdwdw@mail.ru";
            var role = "User";
            var isReg = g.checkRegNullPass(name, surname, login, pass, mail, role);
            Assert.AreEqual(true, isReg);
        }
        [TestMethod]
        public void TestMethod12()
        {
            var name = "Шарип";
            var surname = "";
            var login = "";
            var pass = "";
            var mail = "";
            var role = "User";
            var isReg = g.checkRegNullMail(name, surname, login, pass, mail, role);
            Assert.AreEqual(true, isReg);
        }


        [TestMethod]
        public void TestMethod13()
        {
            string login = "";
            var isDel = g.deleteUsNull(login);
            Assert.AreEqual(true, isDel);
        }


        [TestMethod]
        public void TestMethod14()
        {
            var log = "";
            var pas = "cdb3ed3adef3c0d1e7407d36843f3712";
            var isEntry = g.entryTestLog(log, pas);
            Assert.AreEqual(true, isEntry);
        }
        [TestMethod]
        public void TestMethod15()
        {
            var log = "asdasd";
            var pas = "";
            var isEntry = g.entryTestPas(log, pas);
            Assert.AreEqual(true, isEntry);
        }

        [TestMethod]
        public void TestMethod16()
        {
            int sum = 10000000;
            var isDel = g.PopolnLong(sum);
            Assert.AreEqual(true, isDel);
        }
        [TestMethod]

        public void TestMethod17()
        {
            string num = "";
            var isDel = g.DeleteChisl(num);
            Assert.AreEqual(true, isDel);
        }

        [TestMethod]
        public void TestMethod18()
        {
            string srok = "";
            string stavka = "";
            string sum = "";
            var isDel = g.Raschet(sum, stavka, srok);
            Assert.AreEqual(true, isDel);
        }
        [TestMethod]
        public void TestMethod19()
        {
            string srok = "";
            string stavka = "";
            string sum = "";
            var isDel = g.RaschetSrok(sum, stavka, srok);
            Assert.AreEqual(true, isDel);
        }
        [TestMethod]
        public void TestMethod20()
        {
            string srok = "";
            string stavka = "";
            string sum = "";
            var isDel = g.RaschetStavka(sum, stavka, srok);
            Assert.AreEqual(true, isDel);
        }


        [TestMethod]
        public void TestMethod21()
        {
            string sum = "";
            var isDel = g.Pozhertv(sum);
            Assert.AreEqual(true, isDel);
        }
        [TestMethod]



        public void TestMethod22()
        {
            string num = "-";
            var isDel = g.NomerKart(num);
            Assert.AreEqual(true, isDel);
        }


        [TestMethod]
        public void TestMethod23()
        {
            string first = "0";
            var isDel = g.CheckFirst(first);
            Assert.AreEqual(true, isDel);
        }
        [TestMethod]
       

    }
}
