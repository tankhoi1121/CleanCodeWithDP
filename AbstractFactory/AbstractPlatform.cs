using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactory
{
    public class AbstractPlatform
    {
        private IButton _button;
        private ICheckBox _checkBox;

        public AbstractPlatform(IGUIFactory gUIFactory)
        {
            _button = gUIFactory.CreateButton();
            _checkBox = gUIFactory.CreateCheckBox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkBox.Paint();
        }
    }
}
