using System;
using System.Collections.Generic;

namespace HuffmanEncodingProject
{
    public class Node : IEquatable<Node>, IComparable<Node>
    {
        public Int32 CharacterCount { get; set; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; }
        public Char NodeSymbol { get; set; }
        
        /**
         * 1. If the node is leaf and the current Trees' symbol matches return the data or null
         * 2. If the left node is not null then initialize a new set of left nodes and add the data to each. Set next to bin 0
         * 3. If the right node is not null then initialize a new set of right nodes and add the data to each. Set next to bin 1
         */
        public List<Boolean> Walk(Char symbol, List<Boolean> data)
        {
            if (RightNode == null && LeftNode == null)
            {
                return symbol.Equals(NodeSymbol) ? data : null;
            }

            List<Boolean> left = null;
            List<Boolean> right = null;

            if (LeftNode != null)
            {
                List<Boolean> leftNodes = new List<Boolean>();

                for (Int32 i = 0; i < data.Count; i++)
                {
                    leftNodes.Add(data[i]);
                }
                
                // Set to bin 0
                leftNodes.Add(false);

                left = LeftNode.Walk(symbol, leftNodes);
            }

            if (RightNode != null)
            {
                List<Boolean> rightNodes = new List<Boolean>();

                for (Int32 i = 0; i < data.Count; i++)
                {
                    rightNodes.Add(data[i]);
                }
                
                // Set to bin 1
                rightNodes.Add(true);

                right = RightNode.Walk(symbol, rightNodes);
            }

            // Left is not null then left else right
            return left ?? right;
        }

        public Int32 CompareTo(Node node)
        {
            // A null value means that this object is greater.
            return node == null ? 1 : NodeSymbol.CompareTo(node.NodeSymbol);
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

            return NodeSymbol == other.NodeSymbol &&
                   CharacterCount == other.CharacterCount &&
                   Equals(RightNode, other.RightNode) &&
                   Equals(LeftNode, other.LeftNode);
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
            return HashCode.Combine(NodeSymbol, CharacterCount, RightNode, LeftNode);
        }
    }
}