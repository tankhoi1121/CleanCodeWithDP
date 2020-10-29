using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.ChainOfReposibility
{
    public abstract class Approver
    {
        protected Approver _successor;

        public void SetSuccessor(Approver successor)
        {
            _successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
