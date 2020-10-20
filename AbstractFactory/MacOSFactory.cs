using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactory
{
    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacOSCheckBox();
        }
    }
}
