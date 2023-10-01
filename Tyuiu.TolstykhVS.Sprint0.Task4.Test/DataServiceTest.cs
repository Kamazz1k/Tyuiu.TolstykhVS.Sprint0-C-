using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint0.Task4.Lib;
namespace Tyuiu.TolstykhVS.Sprint0.Task4.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        public void CheckDivisionValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));
        }
    }
}