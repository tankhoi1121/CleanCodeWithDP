using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ChainOfReposibility
{
    public class Purchase
    {
        private int _number;
        private double _amount;
        private string _purpose;

        // Constructor

        public Purchase(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

        public int Number { get => _number; set => _number = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public string Purpose { get => _purpose; set => _purpose = value; }
    }
}
