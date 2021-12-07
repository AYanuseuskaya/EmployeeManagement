using System;

namespace EmployeeManagement
{
    /// <summary>
    /// The Employee class describes an employee who cannot have subordinates. 
    /// Inherits from Person.
    /// Implements the mechanism for calculating the salary of an employee of this type
    /// </summary>
    class Employee : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The employee name</param>
        /// <param name="addOnDate">The day of employment</param>
        public Employee (string name, DateTime addOnDate) : base(name, addOnDate) { }
        /// <summary>
        /// The SalaryCalculation method overridden from Person.
        /// Implements the mechanism for calculating the salary of an employee of this type - base salary + 3% for each year of work since employment date, but no more than 30% over.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The employee salary of the decimal type.</returns>
        public override  decimal SalaryCalculation(DateTime data)
        {
            decimal premium = 0;
            int yearsOfWork = (int)base.SalaryCalculation(data);
            if (yearsOfWork > 0)
            {
                premium = 3 * yearsOfWork <= 30 ? Math.Round((decimal)0.03 * yearsOfWork * BaseRate, 2) : Math.Round((decimal)0.3 * BaseRate, 2);
            }
            decimal result = BaseRate + premium;
            return result;
        }
    }
}
