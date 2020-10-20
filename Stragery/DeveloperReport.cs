using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Stragery
{
    public enum DeveloperLevel
    {
        Senior,
        Junior
    }
    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeveloperLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }

        public double CalcSalary() => WorkingHours * HourlyRate;
    }
}
