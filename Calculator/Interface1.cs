using System;
using System.Collections.Generic;

namespace Calculator
{
    interface IMemento
    {
        List<String> GetState();

        void SetState(List<String> Expressions);
    }
}
