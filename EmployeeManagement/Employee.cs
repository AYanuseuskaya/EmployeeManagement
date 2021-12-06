using System;

namespace EmployeeManagement
{
    class Employee : Person
    {
        public Employee (string name, DateTime addInDate) : base(name, addInDate) { }

        public override  decimal SalaryCalculation(DateTime data)
        {
            decimal premium = 0;
            int yearsofwork = (int)base.SalaryCalculation(data);
            if (yearsofwork > 0)
            {
                premium = 3 * yearsofwork <= 30 ? Math.Round((decimal)0.03 * yearsofwork * BaseRate, 0) : Math.Round((decimal)0.3 * BaseRate);
            }
            decimal result = BaseRate + premium;
            return result;
        }
    }
}
