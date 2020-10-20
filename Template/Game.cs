using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Template
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //template method
        public void Play()
        {
            this.Initialize();
            this.StartPlay();
            this.EndPlay();
            Console.WriteLine();
        }
    }
}
