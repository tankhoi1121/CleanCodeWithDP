using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactory
{
    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("You have created MacOSButton!");
        }
    }
}
