using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rejestracje r1 = new Rejestracje();
            DateTime data = DateTime.Now;
           
            DateTime tempdata = data.AddYears(3);
            
            if (r1.Przedluzenie(data, 3) != tempdata)
            {
                throw new Exception("Error zla data");
            }
            
        }
    }
}
