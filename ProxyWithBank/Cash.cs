using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ProxyWithBank
{
    public class Casher : ICash
    {


        public double Cash(double num, ref bool Income)
        {
            return num;
        }
    }
}
