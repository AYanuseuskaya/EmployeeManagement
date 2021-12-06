using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Manager : PersonWithSubordinates
    {
        public Manager(string name, DateTime addInDate) : base(name, addInDate){}
        public override decimal SalaryCalculation(DateTime data)
        {
            decimal premium = 0;
            int yearsofwork = (int)base.SalaryCalculation(data);
            if (yearsofwork > 0)
            {
                premium = 5 * yearsofwork <= 40 ? Math.Round((decimal)0.05 * yearsofwork * BaseRate,2) : Math.Round((decimal)0.4 * BaseRate, 2);
            }
            decimal salarysubordinates = 0;
            if (Subordinates != null && Subordinates.Count > 0)
            {
                foreach (Person subordinate in Subordinates)
                {
                    salarysubordinates += subordinate.SalaryCalculation(data);
                }
            }
            decimal result = BaseRate + premium + Math.Round((decimal)0.005 * salarysubordinates, 2);
            return result;
        }
    }
}
