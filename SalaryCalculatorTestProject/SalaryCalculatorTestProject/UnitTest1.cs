using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    /*
    To get hourly, divide annual salary by 2080
    $100,006.40 / 2080 = $48.08 hr

    To get annual, multiply hourly by 2080
    $48.08 * 2080 = $100,006,40
    */

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Setup
            SalaryCalculator sc = new SalaryCalculator();

            // Test
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
