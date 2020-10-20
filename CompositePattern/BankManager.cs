using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace CleanCodeWithDP.CompositePattern
{
    public class BankManager : BaseProperties, IEmployee
    {
        public BankManager(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        List<IEmployee> Employees = new List<IEmployee>();

        protected override int Id { get; set; }
        protected override string Name { get; set; }
        protected override int Salary { get; set; }

        public void Add(IEmployee employee)
        {
            Employees.Add(employee);
        }

        public IEmployee GetChild(int i)
        {
            return Employees[i];
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
            Console.WriteLine("=====================================");
            Console.WriteLine($"Id: {GetId()}");
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Salary: {GetSalary()}");
            Console.WriteLine("=====================================");

            foreach (var emp in Employees)
            {
                emp.Print();
            }
        }

        public void Remove(IEmployee employee)
        {
            Employees.Remove(employee);
        }
    }
}
