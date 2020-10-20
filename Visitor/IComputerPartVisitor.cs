using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Visitor
{
    public interface IComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
}
