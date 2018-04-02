using System;
using System.Collections.Generic;

namespace InterviewCake
{
    public class BinaryTreeNode1 
    {
        public int Value { get; }

        public BinaryTreeNode1 Left { get; private set; }
        public BinaryTreeNode1 Right { get; private set; }

        public BinaryTreeNode1(int value)
        {
            Value = value;
        }

        public BinaryTreeNode1 InsertLeft(int leftValue)
        {
            Left = new BinaryTreeNode1(leftValue);
            return Left;
        }

        public BinaryTreeNode1 InsertRight(int rightValue)
        {
            Right = new BinaryTreeNode1(rightValue);
            return Right;
        }
    }

    public class NodeDepthPair
    {
        public BinaryTreeNode1 Node { get; }

        public int Depth { get; }

        public NodeDepthPair(BinaryTreeNode1 node, int depth)
        {
            Node = node;
            Depth = depth;
        }
    }

    public class Question8
    {
        public static bool IsBalanced(BinaryTreeNode1 treeRoot)
        {
            if(treeRoot == null)
            {
                return true;
            }

            var depths = new List<int>(3);

            var nodes = new Stack<NodeDepthPair>();
            nodes.Push(new NodeDepthPair(treeRoot, 0));

            while(nodes.Count > 0){
                var nodeDepthPair = nodes.Pop();
                var node = nodeDepthPair.Node;
                var depth = nodeDepthPair.Depth;

                if(node.Left == null && node.Right == null)
                {
                    if(!depths.Contains(depth))
                    {
                        depths.Add(depth);

                        if(depths.Count > 2 
                           || (depths.Count == 2 && Math.Abs(depths[0] - depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if(node.Left != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Left, depth + 1));
                    }

                    if(node.Right != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Right, depth + 1));
                    }
                }
            }

            return true;
        }
    }
}
