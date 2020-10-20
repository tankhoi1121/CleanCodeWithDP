using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Visitor
{
    public interface IComputerPart
    {
        void accept(IComputerPartVisitor IComputerPartVisitor);
    }
}
