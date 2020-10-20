using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.CompositePattern
{
    public class Cashier : BaseProperties, IEmployee
    {
        public Cashier(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        protected override int Id { get; set; }
        protected override string Name { get; set; }
        protected override int Salary { get; set; }

        public void Add(IEmployee employee)
        {

        }

        public IEmployee GetChild(int i)
        {
            return null;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetSalary()
        {
            return Salary;
        }

        public void Print()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Id =" + GetId());
            Console.WriteLine("Name =" + GetName());
            Console.WriteLine("Salary =" + GetSalary());
            Console.WriteLine("==========================");
        }

        public void Remove(IEmployee employee)
        {

        }
    }
}
