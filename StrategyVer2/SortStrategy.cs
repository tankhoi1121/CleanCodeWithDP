using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.StrategyVer2
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<String> list);
    }
}
