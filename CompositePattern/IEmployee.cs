using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.CompositePattern
{
    public interface IEmployee
    {
        int GetId();
        string GetName();
        double GetSalary();
        void Print();
        void Add(IEmployee employee);
        void Remove(IEmployee employee);
        IEmployee GetChild(int i);
    }
}
