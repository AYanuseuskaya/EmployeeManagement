using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class PersonWithSubordinates : Person
    {
        protected List<Person> Subordinates { get; set; }
        public PersonWithSubordinates(string name, DateTime addInDate) : base(name, addInDate)
        {
            Subordinates = new List<Person>();
        }
        public void AddSubordinates(Person subordinates)
        {
            Subordinates.Add(subordinates);
        }
        public override decimal GetSubordinatesSalary(DateTime data)
        {
            decimal salarysubordinates = 0;
            if (Subordinates != null && Subordinates.Count > 0)
            {
                foreach (Person subordinate in Subordinates)
                {
                    salarysubordinates += subordinate.SalaryCalculation(data);
                    decimal salarychild = subordinate.GetSubordinatesSalary(data);
                    salarysubordinates += salarychild;
                }
            }
            return salarysubordinates;
        }
    }
}
