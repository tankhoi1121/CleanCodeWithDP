using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.StrategyVer2
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSort list");
        }
    }
}
