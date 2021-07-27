using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 40 * 50;

        public decimal GetAnnualSalary(decimal hourlyWage) =>  hourlyWage * HoursInYear;

        public decimal GetHourlyWage(int annualSalary) => (annualSalary / HoursInYear);

    }
}
