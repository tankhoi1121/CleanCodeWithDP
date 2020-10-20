using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.StrategyVer2
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
            foreach (var name in _list)
                Console.WriteLine(" " + name);

            Console.WriteLine();
        }
    }
}
