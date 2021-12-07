using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main()
        {
            Company company = new ("My company");
            Console.WriteLine("Компания {0}", company.Name);

            Manager manager = new ("Иванов Александр Сергеевич", new (2015,10,15));
            company.AddEmployee(manager);
            Console.WriteLine("В компанию поступил новый менеджер. Его имя {0}. Дата устройства на работу {1}", manager.Name, manager.AddOnDate.ToLongDateString());
            decimal managerSalary = manager.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", manager.Name, managerSalary);

            Employee employee = new ("Петров Сергей Иванович", new (2016,5,1));
            employee.AddHead(manager);
            company.AddEmployee(employee);
            Console.WriteLine("В компанию поступил новый сотрудник. Его имя {0}. Дата устройства на работу {1} Его начальник {2}", employee.Name, employee.AddOnDate.ToLongDateString(), employee.Head.Name);
            decimal employeeSalary = employee.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", employee.Name, employeeSalary);

            Sales sales = new ("Янушевская Анастасия Геннадьевна", new(2016,11,26));
            company.AddEmployee(sales);
            sales.AddHead(manager);
            Console.WriteLine("В компанию поступил новый сотрудник. Его имя {0}. Дата устройства на работу {1} Его начальник {2}", sales.Name, sales.AddOnDate.ToLongDateString(), sales.Head.Name);
            decimal salesSalary = sales.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", sales.Name, salesSalary);


            Manager manager1 = new ("Буйчик Екатерина Сергеевна", new(2018,1,2));
            company.AddEmployee(manager1);
            manager1.AddHead(manager);
            Console.WriteLine("В компанию поступил новый сотрудник. Его имя {0}. Дата устройства на работу {1} Его начальник {2}", manager1.Name, manager1.AddOnDate.ToLongDateString(), manager1.Head.Name);
            decimal manager1Salary = manager1.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", manager1.Name, manager1Salary);

            Employee employee1 = new ("Дещеня Николай Петрович", new(2001,10,22));
            company.AddEmployee(employee1);
            employee1.AddHead(manager1);
            Console.WriteLine("В компанию поступил новый сотрудник. Его имя {0}. Дата устройства на работу {1} Его начальник {2}", employee1.Name, employee1.AddOnDate.ToLongDateString(), employee1.Head.Name);
            decimal employe1Salary = employee1.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", employee1.Name, employe1Salary);


            Sales sales1 = new ("Лущинская Ольга Викторовна", new(2019,7,1));
            company.AddEmployee(sales1);
            sales1.AddHead(manager1);
            Console.WriteLine("В компанию поступил новый сотрудник. Его имя {0}. Дата устройства на работу {1} Его начальник {2}", sales1.Name, sales1.AddOnDate.ToLongDateString(), sales1.Head.Name);
            decimal sales1Salary = sales1.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", sales1.Name, sales1Salary);

            Employee employee2 = new ("Муха Константин Александрович", new(2020,12,15));
            company.AddEmployee(employee2);
            employee2.AddHead(sales1);
            Console.WriteLine("В компанию поступил новый сотрудник. Его имя {0}. Дата устройства на работу {1} Его начальник {2}", employee2.Name, employee2.AddOnDate.ToLongDateString(), employee2.Head.Name);
            decimal employee2Salary = employee2.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", employee2.Name, employee2Salary);
            decimal newsales1Salary = sales1.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", sales1.Name, newsales1Salary);

            decimal newmanager1Salary = manager1.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", manager1.Name, newmanager1Salary);

            decimal result = manager.SalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата {0} на текущий момент - {1}", manager.Name, result);
            decimal allresult = company.AllSalaryCalculation(DateTime.Now);
            Console.WriteLine("Зарплата всех сотрудников компании на текущий момент - {0}", allresult);
        }
    }
}
