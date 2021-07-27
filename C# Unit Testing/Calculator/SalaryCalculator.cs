using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            const int HoursInYear = 40 * 50;
            decimal annualSalray = hourlyWage * HoursInYear;
            return annualSalray;
        }
    }
}
