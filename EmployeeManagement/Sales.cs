using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Sales : PersonWithSubordinates
    {
        public Sales(string name, DateTime addOnDate) : base(name, addOnDate) {}
        public override decimal SalaryCalculation(DateTime data)
        {
            decimal premium = 0;
            int yearsofwork = (int)base.SalaryCalculation(data);
            if (yearsofwork > 0)
            {
                premium = 1 * yearsofwork <= 35 ? Math.Round((decimal)0.01 * yearsofwork * BaseRate, 2) : Math.Round((decimal)0.35 * BaseRate, 2);
            }
            decimal result = BaseRate + premium + Math.Round((decimal)0.003 * GetSubordinatesSalary(data), 2);
            return result;
        }
    }
}
