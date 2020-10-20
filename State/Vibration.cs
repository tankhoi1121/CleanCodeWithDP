using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.State
{
    public class Vibration : IMobileAlertState
    {
        public void alert(AlertStateContext alertState)
        {
            Console.WriteLine("vibration...");
        }
    }
}
