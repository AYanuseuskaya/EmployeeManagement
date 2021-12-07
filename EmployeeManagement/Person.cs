using System;

namespace EmployeeManagement
{
    abstract class Person
    {
        protected string Name { get; set; }
        protected DateTime AddOnDate { get; set; }
        protected decimal BaseRate { get; private set; }
        protected PersonWithSubordinates Head { get; set; }
        public Person(string name, DateTime addOnDate)
        {
            Name = name;
            AddOnDate = addOnDate;
            BaseRate = 50000;
        }
        public virtual void AddHead(PersonWithSubordinates head)
        {
            Head = head;
            head.AddSubordinates(this);
        }
        public virtual decimal GetSubordinatesSalary (DateTime data) { return 0; }
        public virtual decimal SalaryCalculation(DateTime data)
        {
            int yearsofwork = 0;
            if (data.Year > AddOnDate.Year)
            {
                var r = data.Year - AddOnDate.Year;
                yearsofwork = AddOnDate.AddYears(r) <= data ? r : r - 1;
            }
            return yearsofwork;
        }
    }
}
