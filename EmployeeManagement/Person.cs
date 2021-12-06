using System;

namespace EmployeeManagement
{
    abstract class Person
    {
        protected string Name { get; set; }
        protected DateTime AddInDate { get; set; }
        protected decimal BaseRate { get; private set; }
        protected PersonWithSubordinates Head { get; set; }
        public Person(string name, DateTime addInDate)
        {
            Name = name;
            AddInDate = addInDate;
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
            if (data.Year > AddInDate.Year)
            {
                var r = data.Year - AddInDate.Year;
                yearsofwork = AddInDate.AddYears(r) <= data ? r : r - 1;
            }
            return yearsofwork;
        }
    }
}
