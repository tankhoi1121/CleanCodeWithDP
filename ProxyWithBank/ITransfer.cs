using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ProxyWithBank
{
    public interface ITransfer
    {
        double LocalTransfer(double num, string currencyUnit,
                              string fromAccount, string toAccount,
                              ref bool Income);
        double OvercomeTransfer(double num, string fromCurrencyUnit,
                                string toCurrencyUnit, string fromAccount,
                                string toAccount, ref bool Income);
    }
}
