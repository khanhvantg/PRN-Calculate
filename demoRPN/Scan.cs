using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    class Scan:Token
    {
        string _input;
        public Scan(string input)
        {
            this._input = input;
        }
        public void xuat()
        {

            BinaryTreeNode a = Infix2ExpressionTree();
            InfixtoProfix(a);
        }
        private static void CreateSubTree(Stack<BinaryTreeNode> opStack, Stack<BinaryTreeNode> nodeStack)
        {
            BinaryTreeNode node = opStack.Pop();
            node.RightChild = nodeStack.Pop();
            node.LeftChild = nodeStack.Pop();
            nodeStack.Push(node);
        }

        public BinaryTreeNode Infix2ExpressionTree()
        {
            Stack<BinaryTreeNode> operatorStack = new Stack<BinaryTreeNode>(50);
            Stack<BinaryTreeNode> nodeStack = new Stack<BinaryTreeNode>(50);
            foreach (char s in _input)
            {
                if (char.IsLetter(s) || char.IsDigit(s) == true)
                    nodeStack.Push(new BinaryTreeNode(s));
                else if (s == '(')
                    operatorStack.Push(new BinaryTreeNode(s));
                else if (s == ')')
                {
                    while (operatorStack.Peek().Value != '(')
                        CreateSubTree(operatorStack, nodeStack);
                    operatorStack.Pop();
                }
                else if (IsOperator(s)==true)
                {

                    while (operatorStack.Count > 0 && GetPriority(operatorStack.Peek().Value) >= GetPriority(s))
                        CreateSubTree(operatorStack, nodeStack);
                    operatorStack.Push(new BinaryTreeNode(s));
                }
            }

            while (operatorStack.Count > 0)
                CreateSubTree(operatorStack, nodeStack);
            return nodeStack.Peek();
        }
        public static void InfixtoProfix(BinaryTreeNode node)
        {
            if (node != null)
            {
                InfixtoProfix(node.LeftChild);
                InfixtoProfix(node.RightChild);
                Console.Write(node.Value + " ");
            }
        }


    }
}
