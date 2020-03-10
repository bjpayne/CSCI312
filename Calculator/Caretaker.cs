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

        public Int32 Undo()
        {
            try
            {
                if (this.mementos.Count == 0)
                {
                    return 0;
                }

                IMemento memento = this.mementos.Pop();

                calculator.Restore(memento);

                return this.mementos.Count;
            }
            catch (Exception)
            {
                return this.mementos.Count;
            }
        }

        public void Clear()
        {
            mementos.Clear();
        }
    }
}
