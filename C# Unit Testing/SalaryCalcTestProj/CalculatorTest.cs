using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SalaryCalcTestProj
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(65);

            // Assert
            Assert.AreEqual(130000, annualSalary);

        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(90000);

            // Assert
            Assert.IsTrue(hourlyWage > 40, "Hourly wage must be more than $50.");

        }

    }
}
