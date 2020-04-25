using System;
using System.Collections.Generic;

namespace HuffmanEncodingProject
{
    public class Node : IEquatable<Node>, IComparable<Node>
    {
        public Char Symbol { get; set; }
        public Int32 Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        /**
         * 1. If the node is leaf and the current Trees' symbol matches return the data or null
         * 2. If the left node is not null then initialize a new set of left nodes and add the data to each. Set next to bin 0
         * 3. If the right node is not null then initialize a new set of right nodes and add the data to each. Set next to bin 1
         */
        public List<Boolean> Walk(Char symbol, List<Boolean> data)
        {
            if (Right == null && Left == null)
            {
                return symbol.Equals(Symbol) ? data : null;
            }

            List<Boolean> left = null;
            List<Boolean> right = null;

            if (Left != null)
            {
                List<Boolean> leftNodes = new List<Boolean>();

                for (Int32 i = 0; i < data.Count; i++)
                {
                    leftNodes.Add(data[i]);
                }
                
                // Set to bin 0
                leftNodes.Add(false);

                left = Left.Walk(symbol, leftNodes);
            }

            if (Right != null)
            {
                List<Boolean> rightNodes = new List<Boolean>();

                for (Int32 i = 0; i < data.Count; i++)
                {
                    rightNodes.Add(data[i]);
                }
                
                // Set to bin 1
                rightNodes.Add(true);

                right = Right.Walk(symbol, rightNodes);
            }

            // Left is not null then left else right
            return left ?? right;
        }

        public Int32 CompareTo(Node node)
        {
            // A null value means that this object is greater.
            return node == null ? 1 : Symbol.CompareTo(node.Symbol);
        }

        public Boolean Equals(Node other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Symbol == other.Symbol &&
                   Frequency == other.Frequency &&
                   Equals(Right, other.Right) &&
                   Equals(Left, other.Left);
        }

        public override Boolean Equals(Object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Node) obj);
        }

        public override Int32 GetHashCode()
        {
            return HashCode.Combine(Symbol, Frequency, Right, Left);
        }
    }
}