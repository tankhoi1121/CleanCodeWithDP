using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactoryVer2
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
