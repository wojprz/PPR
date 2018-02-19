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
            Service1 service = new Service1();

            service.NowyKlient("12345678911", "Nowak", "Jan", "Poznan");

            if(service)
        }
    }
}
