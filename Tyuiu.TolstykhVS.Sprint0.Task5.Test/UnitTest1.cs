﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint0.Task5.Lib;

namespace Tyuiu.TolstykhVS.Sprint0.Task5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void CheckedAdditionVaklid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(0, DataService.Substraction(5, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }

        public void CheckedDivisonValid()
        {
            Assert.AreEqual(1, DataService.Divison(5, 5));
        }
    }
}
