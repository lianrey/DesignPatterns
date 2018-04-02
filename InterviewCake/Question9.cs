using System;
using System.Collections;
using System.Collections.Generic;

namespace InterviewCake
{
    public class BinaryTreeNode
    {
        public int Value
        {
            get;
        }

        public BinaryTreeNode Left
        {
            get;
            set;
        }

        public BinaryTreeNode Right
        {
            get;
            set;
        }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public BinaryTreeNode InsertLeft(int leftValue)
        {
            Left = new BinaryTreeNode(leftValue);
            return Left;
        }

        public BinaryTreeNode InsertRight(int rightValue)
        {
            Right = new BinaryTreeNode(rightValue);
            return Right;
        }
    }

    public class NodeBounds
    {
        public BinaryTreeNode Node { get; }

        public int LowerBound { get; }

        public int UpperBound { get; }

        public NodeBounds(BinaryTreeNode node, int lowerBound, int upperBound)
        {
            Node = node;
            LowerBound = lowerBound;
            UpperBound = upperBound;
        }
    }

    public class Question9
    {
        public static bool IsBinarySearchTree(BinaryTreeNode root)
        {
            var nodeAndBoundsStack = new Stack<NodeBounds>();
            nodeAndBoundsStack.Push(new NodeBounds(root, int.MinValue, int.MaxValue));

            while(nodeAndBoundsStack.Count > 0)
            {
                var nb = nodeAndBoundsStack.Pop();
                var node = nb.Node;
                var lowerBound = nb.LowerBound;
                var upperBound = nb.UpperBound;

                if(node.Value <= lowerBound || node.Value >= upperBound)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
