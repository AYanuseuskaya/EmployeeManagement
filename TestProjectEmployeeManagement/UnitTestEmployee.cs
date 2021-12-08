using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement;

namespace TestProjectEmployeeManagement
{
    [TestClass]
    public class UnitTestEmployee
    {
        readonly Employee employee = new("Радцевич Константин Александрович", new(2020, 12, 15));
        private const decimal resultEmployeeSalaryCalculation0Years = 50000;
        [TestMethod]
        public void TestMethodEmployeeSalaryCalculation_50000BaserateAnd0YearsOfWork_resultEmployeeSalaryCalculation0Years()
        {
            decimal result = employee.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultEmployeeSalaryCalculation0Years, result);
        }

        private const decimal resultEmployeeSalaryCalculation5Years = 57500;
        [TestMethod]
        public void TestMethodEmployeeSalaryCalculation_50000BaserateAnd5YearsOfWork_resultEmployeeSalaryCalculation5Years()
        {
            employee.AddOnDate = new(2016, 11, 1);
            decimal result = employee.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultEmployeeSalaryCalculation5Years, result);
        }

        private const decimal resultEmployeeSalaryCalculation11Years = 65000;
        [TestMethod]
        public void TestMethodEmployeeSalaryCalculation_50000BaserateAnd11YearsOfWork_resultEmployeeSalaryCalculation11Years()
        {
            employee.AddOnDate = new(2009, 12, 15);
            decimal result = employee.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultEmployeeSalaryCalculation11Years, result);
        }
    }
}
