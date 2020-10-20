using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.State
{
    public interface IMobileAlertState
    {
        public void alert(AlertStateContext alertState);
    }
}
