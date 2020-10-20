using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ProxyWithBank
{
    public class Credit : ICash, ITransfer
    {
        private double remainNumberAccount = 0;

        private Casher _casher = new Casher();

        private Transferer _transferer = new Transferer();

        public double Cash(double num, ref bool Income)
        {
            if (Income == true)
                remainNumberAccount += _casher.Cash(num, ref Income);
            else
            {
                if (remainNumberAccount >= num)
                {
                    remainNumberAccount -= _casher.Cash(num, ref Income);
                }
                else
                {
                    Console.WriteLine("Not enough money to Cash !!!!");
                }
            }
            return num;
        }

        public void CheckAccount()
        {
            Console.WriteLine($"Remain Number Account: {remainNumberAccount}");
        }

        public double LocalTransfer(double num, string currencyUnit, string fromAccount, string toAccount, ref bool Income)
        {
            if (Income == true)
            {
                remainNumberAccount += _transferer.LocalTransfer(num, currencyUnit,
                                                                 fromAccount, toAccount,
                                                                 ref Income);
            }
            else
            {
                if (remainNumberAccount >= num)
                {
                    remainNumberAccount -= _transferer.LocalTransfer(num, currencyUnit,
                                                                     fromAccount, toAccount,
                                                                     ref Income);
                }
                else
                {
                    Console.WriteLine("Not enough money to transfer !!!");
                }
            }
            return num;
        }

        public double OvercomeTransfer(double num, string fromCurrencyUnit, string toCurrencyUnit, string fromAccount, string toAccount, ref bool Income)
        {
            var moneyTransfered = 0.0;
            if (Income == true)
            {
                moneyTransfered = _transferer.OvercomeTransfer(num, fromCurrencyUnit,
                                                                    toCurrencyUnit, fromAccount,
                                                                    toAccount, ref Income);

                remainNumberAccount += _transferer.OvercomeTransfer(num, fromCurrencyUnit,
                                                                    toCurrencyUnit, fromAccount,
                                                                    toAccount, ref Income);
            }
            else
            {
                if (remainNumberAccount >= num)
                {
                    moneyTransfered = _transferer.OvercomeTransfer(num, fromCurrencyUnit,
                                                                    toCurrencyUnit, fromAccount,
                                                                    toAccount, ref Income);

                    remainNumberAccount -= _transferer.OvercomeTransfer(num, fromCurrencyUnit,
                                                                    toCurrencyUnit, fromAccount,
                                                                    toAccount, ref Income);
                }
                else
                {
                    Console.WriteLine("Not enough money to transfer !!!");
                }
            }
            return moneyTransfered;
        }
    }
}
