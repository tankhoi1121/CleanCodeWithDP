using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Visitor
{
    public class Computer : IComputerPart
    {
        IComputerPart[] parts;

        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void accept(IComputerPartVisitor IComputerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(IComputerPartVisitor);
            }
            IComputerPartVisitor.visit(this);
        }
    }
}
