using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.State
{
    public class AlertStateContext
    {
        private IMobileAlertState currentState;

        public AlertStateContext()
        {
            currentState = new Vibration();
        }

        public void SetState(IMobileAlertState state)
        {
            currentState = state;
        }

        public void alert()
        {
            currentState.alert(this);
        }
    }
}
