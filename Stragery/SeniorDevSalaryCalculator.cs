using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeWithDP.Stragery
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalcTotalSalary(IEnumerable<DeveloperReport> reports)
             => reports.Where(r => r.Level == DeveloperLevel.Senior)
             .Select(r => r.CalcSalary() * 1.2)
             .Sum();
    }
}
