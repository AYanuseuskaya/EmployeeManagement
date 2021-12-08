using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement;

namespace TestProjectEmployeeManagement
{
    [TestClass]
    public class UnitTestManager
    {
        readonly Manager manager = new("Иванов Александр Сергеевич", new(2020, 12, 15));
        readonly Manager managerSuborgenate = new("Буйчик Екатерина Сергеевна", new(2020, 12, 15));
        readonly Employee employee = new("Муха Константин Александрович", new(2009, 12, 15));
        private const decimal resultManagerSalaryCalculation0YearsOfWorkAnd0SalarySubordinates = 50000;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd0YearsOfWorkAnd0SalarySubordinates_resultManagerSalaryCalculation0YearsOfWorkAnd0SalarySubordinates()
        {
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation0YearsOfWorkAnd0SalarySubordinates, result);
        }
        private const decimal resultManagerSalaryCalculation0YearsOfWorkAnd65000SalarySubordinates = 50325;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd0YearsOfWorkAnd65000SalarySubordinates_resultManagerSalaryCalculation0YearsOfWorkAnd65000SalarySubordinates()
        {
            employee.AddHead(manager);
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation0YearsOfWorkAnd65000SalarySubordinates, result);
        }
        private const decimal resultManagerSalaryCalculation0YearsOfWorkAndSubordinates2Level = (decimal)50251.62;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd0YearsOfWorkAndSubordinates2Level_resultManagerSalaryCalculation0YearsOfWorkAndSubordinates2Level()
        {
            employee.AddHead(managerSuborgenate);
            managerSuborgenate.AddHead(manager);
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation0YearsOfWorkAndSubordinates2Level, result);
        }
        private const decimal resultManagerSalaryCalculation3YearsOfWorkAnd0SalarySubordinates = 57500;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd3YearsOfWorkAnd0SalarySubordinates_resultManagerSalaryCalculation3YearsOfWorkAnd0SalarySubordinates()
        {
            manager.AddOnDate = new (2018,11,1);
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation3YearsOfWorkAnd0SalarySubordinates, result);
        }
        private const decimal resultManagerSalaryCalculation3YearsOfWorkAnd65000SalarySubordinates = 57825;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd3YearsOfWorkAnd65000SalarySubordinates_resultManagerSalaryCalculation3YearsOfWorkAnd65000SalarySubordinates()
        {
            employee.AddHead(manager);
            manager.AddOnDate = new(2018, 11, 1);
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation3YearsOfWorkAnd65000SalarySubordinates, result);
        }
        private const decimal resultManagerSalaryCalculation9YearsOfWorkAnd0SalarySubordinates = 70000;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd9YearsOfWorkAnd0SalarySubordinates_resultManagerSalaryCalculation9YearsOfWorkAnd0SalarySubordinates()
        {
            manager.AddOnDate = new(2012, 11, 1);
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation9YearsOfWorkAnd0SalarySubordinates, result);
        }
        private const decimal resultManagerSalaryCalculation9YearsOfWorkAnd65000SalarySubordinates = 70325;
        [TestMethod]
        public void SalaryCalculation_50000BaserateAnd9YearsOfWorkAnd65000SalarySubordinates_resultManagerSalaryCalculation9YearsOfWorkAnd65000SalarySubordinates()
        {
            employee.AddHead(manager);
            manager.AddOnDate = new(2012, 11, 1);
            decimal result = manager.SalaryCalculation(System.DateTime.Now);
            Assert.AreEqual(resultManagerSalaryCalculation9YearsOfWorkAnd65000SalarySubordinates, result);
        }

        private const decimal resultSalarySubordinateEmployee = 65000;
        [TestMethod]
        public void GetSubordinatesSalary_65000SalarySubordinates_resultSalarySubordinates()
        {
            employee.AddHead(manager);
            decimal result = manager.GetSubordinatesSalary(System.DateTime.Now);
            Assert.AreEqual(resultSalarySubordinateEmployee, result);
        }
        private const decimal resultSalarySubordinates = 115325;
        [TestMethod]
        public void GetSubordinatesSalary_115325SalarySubordinates_resultSalarySubordinates()
        {
            employee.AddHead(managerSuborgenate);
            managerSuborgenate.AddHead(manager);
            decimal result = manager.GetSubordinatesSalary(System.DateTime.Now);
            Assert.AreEqual(resultSalarySubordinates, result);
        }

    }
}
