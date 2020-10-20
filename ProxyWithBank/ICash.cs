using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ProxyWithBank
{
    public interface ICash
    {
        double Cash(double num, ref bool Income);
    }
}
