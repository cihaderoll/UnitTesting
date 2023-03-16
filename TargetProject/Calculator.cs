using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetProject
{
    public class Calculator
    {
        public int Value { get; private set; }

        public int Add(int val)
        {
            return Value += val;
        }

        public int Subtract(int val)
        {
            return Value -= val;
        }

        public int Multiply(int val)
        {
            if (Value == 0)
                return Value = val;

            return Value *= val;
        }

        public int Divide(int val)
        {
            if (Value == 0)
                return Value = val;

            return Value /= val;
        }
    }
}
