using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactory
{
    public class WindowsCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("You have created WindowsCheckBox");
        }
    }
}
