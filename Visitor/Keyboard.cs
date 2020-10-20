using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Visitor
{
    public class Keyboard : IComputerPart
    {
        public void accept(IComputerPartVisitor IComputerPartVisitor)
        {
            IComputerPartVisitor.visit(this);
        }
    }
}
