using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    internal class NumberNode : INode
    {
        private decimal _value;

        public NumberNode(decimal value)
        {
            _value = value;
        }

        public decimal GetValue()
        {
            return _value;
        }
    }
}
