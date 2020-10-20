using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Stragery
{
    public interface ISalaryCalculator
    {
        double CalcTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
