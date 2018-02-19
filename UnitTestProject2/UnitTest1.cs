using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Owners o1 = new Owners();
            o1.Miejsce_zamieszkania = "Poznan";
            o1.PESEL = "12345678911";
            o1.Nazwisko = "Kowalskki";
            o1.Imie = "Jan";

            o1.ZmianaZamieszkania("Wroclaw");
            if(o1.Miejsce_zamieszkania == "Poznan")
            {
                throw new Exception("Error, nie zmieniono miejsca zamieszkania");
            }


        }
    }
}
