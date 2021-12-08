using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    /// <summary>
    /// The abstract class PersonWithSubordinates describes an employee who can have subordinates.
    /// Inherits from the Person class.
    /// Implements a mechanism for adding a subordinate and calculating the salaries of all subordinates.
    /// </summary>
    public abstract class PersonWithSubordinates : Person
    {
        /// <summary>
        /// Gets or sets the subordinates
        /// </summary>
        /// <value>
        /// The subordinates
        /// </value>
        protected List<Person> Subordinates { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonWithSubordinates"/> class.
        /// </summary>
        /// <param name="name">The employee name</param>
        /// <param name="addOnDate">The day of employment</param>
        public PersonWithSubordinates(string name, DateTime addOnDate) : base(name, addOnDate)
        {
            Subordinates = new List<Person>();
        }
        /// <summary>
        /// The SalaryCalculation method.
        /// Implements the mechanism for adding a subordinate.
        /// </summary>
        /// <param name="subordinates">The subordinate of the <see cref="Person"/> type</param>
        public void AddSubordinates(Person subordinates)
        {
            Subordinates.Add(subordinates);
        }
        /// <summary>
        /// The GetSubordinatesSalary method overridden from Person.
        /// Implements the mechanism for calculating the salaries of all subordinates.
        /// </summary>
        /// <param name="data">Time of salary calculation of the DateTime type.</param>
        /// <returns>The subordinates salary of the decimal type.</returns>
        public override decimal GetSubordinatesSalary(DateTime data)
        {
            decimal salarySubordinates = 0;
            if (Subordinates != null && Subordinates.Count > 0)
            {
                foreach (Person subordinate in Subordinates)
                {
                    salarySubordinates += subordinate.SalaryCalculation(data);
                    decimal salaryChild = subordinate.GetSubordinatesSalary(data);
                    salarySubordinates += salaryChild;
                }
            }
            return salarySubordinates;
        }
    }
}
