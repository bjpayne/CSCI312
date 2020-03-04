using NCalc;
using System;
using System.Collections.Generic;

namespace Calculator
{
    class Calculator
    {
        private List<String> expressions = new List<string>();

        public void Constant(String number)
        {
            expressions.Add(number);
        }

        public void Add()
        {
            expressions.Add("+");
        }

        public void Subtract()
        {
            if (expressions.Count == 0)
            {
                Constant("0");
            }

            expressions.Add("-");
        }

        public void Multiply()
        {
            if (expressions.Count == 0)
            {
                return;
            }

            expressions.Add("*");
        }

        public void Divide()
        {
            if (expressions.Count == 0)
            {
                return;
            }

            expressions.Add("/");
        }

        public void DecimalPoint()
        {
            if (expressions.Count == 0)
            {
                return;
            }

            expressions.Add(".");
        }

        public String Solve()
        {
            try
            {
                Expression expression = new Expression(String.Join(" ", expressions.ToArray()));

                String solution = expression.Evaluate().ToString();

                Clear();

                return solution;
            } catch (Exception)
            {
                return "Invalid input.";
            }
        }

        public IMemento Save()
        {
            return new Memento(expressions);
        }

        public void Restore(IMemento memento)
        {
            expressions = memento.GetState();
        }

        public void Clear()
        {
            expressions.Clear();
        }
    }
}
