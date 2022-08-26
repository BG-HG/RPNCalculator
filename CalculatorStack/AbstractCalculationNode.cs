using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    internal abstract class AbstractCalculationNode : INode
    {
        protected readonly INode _leftChild;
        protected readonly INode _rightChild;

        public AbstractCalculationNode(INode leftChild, INode rightChild)
        {
            _leftChild = leftChild;
            _rightChild = rightChild;
        }

        abstract public decimal GetValue();
    }
}
