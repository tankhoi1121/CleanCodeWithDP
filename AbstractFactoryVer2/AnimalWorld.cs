using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactoryVer2
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continent)
        {
            _herbivore = continent.CreateHerbivore();
            _carnivore = continent.CreateCarnivore();
        }

        public void AnimalEatOthers()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
