using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.StrategyVer2
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); //default is QuickSort;
            Console.WriteLine("QuickSorted list");
        }
    }
}
