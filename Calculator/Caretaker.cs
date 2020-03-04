using System;
using System.Collections.Generic;

namespace Calculator
{
    class Caretaker
    {
        private Stack<IMemento> mementos = new Stack<IMemento>();

        private Calculator calculator;

        public Caretaker(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Backup()
        {
            mementos.Push(calculator.Save());
        }

        public void Undo()
        {
            if (this.mementos.Count == 0)
            {
                return;
            }

            IMemento memento = this.mementos.Pop();

            try
            {
                calculator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void Clear()
        {
            calculator.Clear();
        }
    }
}
