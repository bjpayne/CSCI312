using System;
using System.Collections.Generic;

namespace Calculator
{
    class Memento : IMemento
    {
        private List<String> Expressions { get; set; }

        public Memento(List<String> Expressions)
        {
            this.Expressions = Expressions;
        }

        public List<string> GetState()
        {
            return Expressions;
        }

        public void SetState(List<String> Expressions)
        {
            this.Expressions = Expressions;
        }
    }
}
