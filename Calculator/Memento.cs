using System;
using System.Collections.Generic;

namespace Calculator
{
    class Memento : IMemento
    {
        private String expression;

        public Memento(string expression)
        {
            this.expression = expression;
        }

        public String GetState()
        {
            return expression;
        }

        public void SetState(String expression)
        {
            this.expression = expression;
        }
    }
}
