using NCalc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Calculator
{
    class Calculator
    {
        private String expression = "";

        private Int32 runningTotal = 0;

        public void Constant(String number)
        {
            expression += number;
        }

        public void Add()
        {
            expression += " + ";
        }

        public void Subtract()
        {
            expression += " - ";
        }

        public void Multiply()
        {
            if (expression.Length == 0)
            {
                return;
            }

            expression += " * ";
        }

        public void Divide()
        {
            if (expression.Length == 0)
            {
                return;
            }

            expression += " / ";
        }

        public void DecimalPoint()
        {
            if (expression.Length == 0)
            {
                return;
            }

            expression += " . ";
        }

        public String Solve()
        {
            try
            {
                Expression expression = new Expression(this.expression);

                String solution = expression.Evaluate().ToString();

                this.expression = "";

                Int32 addToRunningTotal = 0;

                Int32.TryParse(solution, out addToRunningTotal);

                this.runningTotal = addToRunningTotal;

                return solution;
            } catch (Exception e)
            {
                Debug.WriteLine(e);

                return "error";
            }
        }

        public IMemento Save()
        {
            return new Memento(expression);
        }

        public void Restore(IMemento memento)
        {
            expression = memento.GetState();
        }

        public void Clear()
        {
            expression = "";

            runningTotal = 0;
        }

        public override String ToString()
        {
            return expression;
        }
    }
}
