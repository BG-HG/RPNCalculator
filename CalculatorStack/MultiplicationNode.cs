using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    internal class MultiplicationNode : AbstractCalculationNode, INode
    {
        public MultiplicationNode(INode leftChild, INode rightChild) : base(leftChild, rightChild)
        {
        }

        public override decimal GetValue()
        {
            return _leftChild.GetValue() * _rightChild.GetValue();
        }
    }
}
