using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SalaryCalcTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary();

            // Assert
            Assert.AreEqual(120000, annualSalary);

        }
    }
}
