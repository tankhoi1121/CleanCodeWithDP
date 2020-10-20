using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace CleanCodeWithDP.Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;
        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(_sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
