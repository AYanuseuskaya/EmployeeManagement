using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    /// <summary>
    /// The Company class describes an existing company.
    /// Implements a mechanism for adding a new employee to the company and calculating the total salary of all employees.
    /// </summary>
    class Company
    {
        /// <summary>
        /// Gets or sets the name of the company
        /// </summary>
        /// <value>
        /// The name of the company
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the company employees
        /// </summary>
        /// <value>
        /// The company employees
        /// </value>
        private List<Person> Employees { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="name">The name of the company</param>
        public Company(string name)
        {
            Name = name;
            Employees = new List<Person>();
        }
        /// <summary>
        /// The AddEmployee method.
        /// Implements the mechanism for adding a new employee to the company.
        /// </summary>
        /// <param name="person">The company employee of the <see cref="Person"/> type</param>
        public void AddEmployee (Person person)
        {
            if (person != null && Employees != null)
            {
                Employees.Add(person);
            }
        }
        /// <summary>
        /// The AllSalaryCalculation method.
        /// Implements the mechanism for calculating the total salary of all employees.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The total salary of all employees of the decimal type.</returns>
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
