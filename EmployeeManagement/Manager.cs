using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    /// <summary>
    /// The Manager class describes an employee who can have subordinates.
    /// Inherits from PersonWithSubordinates.
    /// Implements the mechanism for calculating the salary of an employee of this type.
    /// </summary>
    class Manager : PersonWithSubordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">The employee name</param>
        /// <param name="addOnDate">The day of employment</param>
        public Manager(string name, DateTime addOnDate) : base(name, addOnDate) {}
        /// <summary>
        /// The SalaryCalculation method overridden from Person.
        /// Implements the mechanism for calculating the salary of an employee of this type - base salary + 5% for each year of work, but no more than 40% over + 0,5% of salary of all direct(first level) subordinates.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The employee salary of the decimal type.</returns>
        public override decimal SalaryCalculation(DateTime data)
        {
            decimal premium = 0;
            int yearsOfWork = (int)base.SalaryCalculation(data);
            if (yearsOfWork > 0)
            {
                premium = 5 * yearsOfWork <= 40 ? Math.Round((decimal)0.05 * yearsOfWork * BaseRate,2) : Math.Round((decimal)0.4 * BaseRate, 2);
            }
            decimal salarySubordinates = 0;
            if (Subordinates != null && Subordinates.Count > 0)
            {
                foreach (Person subordinate in Subordinates)
                {
                    salarySubordinates += subordinate.SalaryCalculation(data);
                }
            }
            decimal result = BaseRate + premium + Math.Round((decimal)0.005 * salarySubordinates, 2);
            return result;
        }
    }
}
