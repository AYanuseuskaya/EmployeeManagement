using System;

namespace EmployeeManagement
{
    /// <summary>
    /// The abstract class Person describes the general type of employee.
    /// It is common to all components  in the tree structure.
    /// Implements a mechanism for adding a head to an employee, calculating the employee's salary and receiving the salaries of all subordinates.  
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// Gets or sets the employee name
        /// </summary>
        /// <value>
        /// The employee name
        /// </value>
        protected string Name { get; set; }
        /// <summary>
        /// Gets or sets the day of employment
        /// </summary>
        /// <value>
        /// The day of employment
        /// </value>
        protected DateTime AddOnDate { get; set; }
        /// <summary>
        /// Gets or sets the base rate
        /// </summary>
        /// <value>
        /// The base rate
        /// </value>
        protected decimal BaseRate { get; private set; }
        /// <summary>
        /// Gets or sets the head
        /// </summary>
        /// <value>
        /// The head
        /// </value>
        protected PersonWithSubordinates Head { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The employee name</param>
        /// <param name="addOnDate">The day of employment</param>
        public Person(string name, DateTime addOnDate)
        {
            Name = name;
            AddOnDate = addOnDate;
            BaseRate = 50000;
        }
        /// <summary>
        /// The AddHead virtual method.
        /// Implements the mechanism for adding a head to an employee.
        /// </summary>
        /// <param name="head">The head of the <see cref="PersonWithSubordinates"/> type</param>
        public virtual void AddHead(PersonWithSubordinates head)
        {
            Head = head;
            head.AddSubordinates(this);
        }
        /// <summary>
        /// The GetSubordinatesSalary virtual method.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The subordinates salary of the decimal type.</returns>
        public virtual decimal GetSubordinatesSalary (DateTime data) { return 0; }
        /// <summary>
        /// The SalaryCalculation virtual method.
        /// Implements the mechanism for calculating the number of years worked.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The employee salary of the decimal type.</returns>
        public virtual decimal SalaryCalculation(DateTime data)
        {
            int yearsOfWork = 0;
            if (data.Year > AddOnDate.Year)
            {
                var countYear = data.Year - AddOnDate.Year;
                yearsOfWork = AddOnDate.AddYears(countYear) <= data ? countYear : countYear - 1;
            }
            return yearsOfWork;
        }
    }
}
