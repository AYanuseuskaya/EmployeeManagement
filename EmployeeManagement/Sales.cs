using System;

namespace EmployeeManagement
{
    /// <summary>
    /// The Sales class describes an employee who can have subordinates.
    /// Inherits from PersonWithSubordinates.
    /// Implements the mechanism for calculating the salary of an employee of this type.
    /// </summary>
    public class Sales : PersonWithSubordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sales"/> class.
        /// </summary>
        /// <param name="name">The employee name</param>
        /// <param name="addOnDate">The day of employment</param>
        public Sales(string name, DateTime addOnDate) : base(name, addOnDate) {}
        /// <summary>
        /// The SalaryCalculation method overridden from Person.
        /// Implements the mechanism for calculating the salary of an employee of this type - base salary + 1% for each year of work, but no more than 35% over + 0,3% of salary of all subordinates, direct or indirect.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The employee salary of the decimal type.</returns>
        public override decimal SalaryCalculation(DateTime data)
        {
            decimal premium = 0;
            int yearsOfWork = (int)base.SalaryCalculation(data);
            if (yearsOfWork > 0)
            {
                premium = 1 * yearsOfWork <= 35 ? Math.Round((decimal)0.01 * yearsOfWork * BaseRate, 2) : Math.Round((decimal)0.35 * BaseRate, 2);
            }
            decimal result = BaseRate + premium + Math.Round((decimal)0.003 * GetSubordinatesSalary(data), 2);
            return result;
        }
    }
}
