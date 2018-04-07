using System;
using System.Collections.Generic;

namespace InterviewCake
{
    public class BinaryTreeNode10
    {
        public int Value { get; }

        public BinaryTreeNode10 Left { get; private set; }

        public BinaryTreeNode10 Right { get; private set; }

        public BinaryTreeNode10(int value)
        {
            Value = value;
        }

        public BinaryTreeNode10 InsertLeft(int leftValue)
        {
            Left = new BinaryTreeNode10(leftValue);
            return Left;
        }

        public BinaryTreeNode10 InsertRight(int rightValue)
        {
            Right = new BinaryTreeNode10(rightValue);
            return Right;
        }
    }

    public class Question10
    {
        public int FindLargest(BinaryTreeNode10 rootNode)
        {
            var current = rootNode;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }

        public int FindSecondLargest(BinaryTreeNode10 rootNode)
        {
            if(rootNode == null
               || rootNode.Left == null && rootNode.Right == null)
            {
                throw new ArgumentException("Tree must have at least 2 nodes", nameof(rootNode));
            }

            var current = rootNode;

            while(true)
            {
                if(current.Left != null && current.Right == null)
                {
                    return FindLargest(current.Right);
                }

                if (current.Right != null
                    && current.Right.Left == null
                    && current.Right.Right == null)
                {
                    return current.Value;
                }

                current = current.Right;
            }
;        }
    }
}
