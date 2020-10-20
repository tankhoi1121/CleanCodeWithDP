using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.State
{
    public class Silent : IMobileAlertState
    {
        public void alert(AlertStateContext alertState)
        {
            Console.WriteLine("silent...");
        }
    }
}
