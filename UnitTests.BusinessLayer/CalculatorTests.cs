using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Calculator.DataAccessInterfaces;

namespace UnitTests.BusinessLayer
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]        
        public void Calculator_AddTwoInts_Overflow()
        {
            Mock<IRepository> repoMock = new Mock<IRepository>();

            Calculator.BusinessLayer.Calculator target = new Calculator.BusinessLayer.Calculator(repoMock.Object);

            var result = target.AddTwoInts(0, 0);

            Assert.AreEqual(0, result);
        }
    }
}
