using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main()
        {
            Company company = new ("My company");

            Manager manager = new ("man1", DateTime.Now);
            company.AddEmployee(manager);

            Employee employee = new ("test", DateTime.Now.AddMonths(-26));
            employee.AddHead(manager);
            company.AddEmployee(employee);
            
            Sales sales = new ("sal1", DateTime.Now.AddYears(-5));
            company.AddEmployee(sales);
            sales.AddHead(manager);

            Manager manager1 = new ("man2", DateTime.Now.AddMonths(-13));
            company.AddEmployee(manager1);
            manager1.AddHead(manager);
            Employee employee1 = new ("emp1", DateTime.Now.AddMonths(-33));
            company.AddEmployee(employee1);
            employee1.AddHead(manager1);
            Sales sales1 = new ("sal1", DateTime.Now.AddYears(-5));
            company.AddEmployee(sales1);
            sales1.AddHead(manager1);
            Employee employee2 = new ("emp2", DateTime.Now.AddMonths(-48));
            company.AddEmployee(employee2);
            employee2.AddHead(sales1);

            decimal result = manager.SalaryCalculation(DateTime.Now);
            decimal allresult = company.AllSalaryCalculation(DateTime.Now);
            Console.WriteLine(result + allresult);
        }
    }
}
