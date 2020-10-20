using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ProxyWithBank
{
    public class Transferer : ITransfer
    {
        public double LocalTransfer(double num, string currencyUnit, string fromAccount, string toAccount, ref bool Income)
        {
            Console.WriteLine($"{num} {currencyUnit} has tranfered from {fromAccount} to {toAccount}");
            return num;
        }

        public double OvercomeTransfer(double num, string fromCurrencyUnit, string toCurrencyUnit, string fromAccount, string toAccount, ref bool Income)
        {
            var moneyTransfered = 0.0;
            if (fromCurrencyUnit == "USD" && toCurrencyUnit == "VND")
                moneyTransfered = num * 23151.46;
            else if (fromCurrencyUnit == "VND" && toCurrencyUnit == "USD")
                moneyTransfered = num / 23151.46;
            else if (fromCurrencyUnit == "TWD" && toCurrencyUnit == "VND")
                moneyTransfered = num * 788.70;
            else if (fromCurrencyUnit == "VND" && toCurrencyUnit == "TWD")
                moneyTransfered = num / 788.70;

            return moneyTransfered;
        }
    }
}
