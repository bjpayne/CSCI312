using System;
using System.Collections.Generic;

namespace Calculator
{
    interface IMemento
    {
        String GetState();

        void SetState(String expression);
    }
}
