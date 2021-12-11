using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode LeftChild;
        public BinaryTreeNode RightChild;
        public char Value;
        public bool IsLeaf
        {
            get { return this.LeftChild == null && this.RightChild == null; }
        }
        public BinaryTreeNode(char value)
        {
            Value = value;
        }
    }
}
