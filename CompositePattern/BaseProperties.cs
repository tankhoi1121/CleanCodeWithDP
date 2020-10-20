using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.CompositePattern
{
    public abstract class BaseProperties
    {
        abstract protected int Id { get; set; }
        abstract protected string Name { get; set; }
        abstract protected int Salary { get; set; }
    }
}
