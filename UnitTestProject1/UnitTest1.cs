using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Samochody s1 = new Samochody();
            s1.Rejestracja = "test";
            
            if(s1.Rej() != "test")
            {
                throw new Exception("Error");
             }
           
            

        }
    }
}
