using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint0.Task2.V0.Lib;


namespace Tyuiu.TolstykhVS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void CheckGetMessageValid()
        {
            var name = "Слава";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Слава", res);
        }


    }
}