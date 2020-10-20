using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.AbstractFactory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
