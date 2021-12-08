using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement;

namespace TestProjectEmployeeManagement
{
    [TestClass]
    public class UnitTestSales
    {
        readonly Sales sales = new("Янушевская Анастасия Геннадьевна", new(2020, 12, 15));
        private const decimal resultSalesSalaryCalculation0YearsOfWorkAnd0SalarySubordinates = 50000;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd0YearsOfWorkAnd0SalarySubordinates_resultSalesSalaryCalculation0YearsOfWorkAnd0SalarySubordinates()
        {
            decimal result = sales.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultSalesSalaryCalculation0YearsOfWorkAnd0SalarySubordinates, result);
        }
        private const decimal resultSalesSalaryCalculation20YearsOfWorkAnd0SalarySubordinates = 60000;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd20YearsOfWorkAnd0SalarySubordinates_resultSalesSalaryCalculation20YearsOfWorkAnd0SalarySubordinates()
        {
            sales.AddOnDate = new (2001, 12, 1);
            decimal result = sales.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultSalesSalaryCalculation20YearsOfWorkAnd0SalarySubordinates, result);
        }
        private const decimal resultSalesSalaryCalculation36YearsOfWorkAnd0SalarySubordinates = 67500;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd36YearsOfWorkAnd0SalarySubordinates_resultSalesSalaryCalculation36YearsOfWorkAnd0SalarySubordinates()
        {
            sales.AddOnDate = new(1986, 12, 1);
            decimal result = sales.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultSalesSalaryCalculation36YearsOfWorkAnd0SalarySubordinates, result);
        }
        private const decimal resultSalesSalaryCalculation36YearsOfWorkAnd115325SalarySubordinates = (decimal)67845.98;
        [TestMethod]
        public void SalesSalaryCalculation_50000BaserateAnd36YearsOfWorkAnd115325SalarySubordinates_resultSalesSalaryCalculation36YearsOfWorkAnd115325SalarySubordinates()
        {
            sales.AddOnDate = new(1986, 12, 1);
            Manager managerSuborgenate = new("Буйчик Екатерина Сергеевна", new(2020, 12, 15));
            Employee employee = new("Муха Константин Александрович", new(2009, 12, 15));
            employee.AddHead(managerSuborgenate);
            managerSuborgenate.AddHead(sales);
            decimal result = sales.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultSalesSalaryCalculation36YearsOfWorkAnd115325SalarySubordinates, result);
        }
    }
}
