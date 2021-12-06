using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Company
    {
        public string Name { get; set; }

        private List<Person> Employees { get; set; }

        public Company(string name)
        {
            Name = name;
            Employees = new List<Person>();
        }

        public void AddEmployee (Person person)
        {
            if (person != null && Employees != null)
            {
                Employees.Add(person);
            }
        }

        public decimal AllSalaryCalculation(DateTime data)
        {
            decimal result = 0;
            if (Employees != null && Employees.Count > 0)
            {
                foreach(Person employee in Employees)
                {
                    result += employee.SalaryCalculation(data);
                }
            }
            return result;
        }
    }
}
