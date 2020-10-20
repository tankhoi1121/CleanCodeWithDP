using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Template
{
    public class Football : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine($"{this.GetType().Name} Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine($"{this.GetType().Name} Game Initialize! Start Playing!!!");
        }

        public override void StartPlay()
        {
            Console.WriteLine($"{this.GetType().Name} Game Started. Enjoy the game!");
        }
    }
}
