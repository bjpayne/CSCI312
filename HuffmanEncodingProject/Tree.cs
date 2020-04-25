using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace HuffmanEncodingProject
{
    public class Tree
    {
        private readonly List<Node> nodes = new List<Node>();
        private Node ParentNode { get; set; }

        private readonly Dictionary<Char, Int32> characterCounts = new Dictionary<Char, Int32>();

        /**
         * 1. Determine the counts of all the characters of the input
         * 2. Sort the nodes by character
         * 3. Group nodes adjacent characters, combining their counts
         */
        public void Hydrate(String input)
        {
            for (Int32 i = 0; i < input.Length; i++)
            {
                if (!characterCounts.ContainsKey(input[i]))
                {
                    characterCounts.Add(input[i], 0);
                }

                characterCounts[input[i]]++;
            }

            foreach ((Char key, Int32 value) in characterCounts)
            {
                nodes.Add(new Node() {Symbol = key, Frequency = value});
            }
            
            nodes.Sort();

            while (nodes.Count > 1)
            {
                if (nodes.Count >= 2)
                {
                    List<Node> taken = nodes.Take(2).ToList();

                    Node characterParentNode = new Node()
                    {
                        Symbol = '+',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(characterParentNode);
                }

                ParentNode = nodes.FirstOrDefault();
            }
        }

        /**
         * 1. Initialize list to hold encoded values
         * 2. Loop through source and recursively walk through each character building out the grouped nodes
         * 3. Append the grouped nodes to the encoded source
         */
        public BitArray Encode(String input)
        {
            List<Boolean> encodedInputCharacters = new List<Boolean>();

            for (Int32 i = 0; i < input.Length; i++)
            {
                List<Boolean> encodedSymbol = ParentNode.Walk(input[i], new List<Boolean>());
                
                // Append the symbols to the end of the list
                encodedInputCharacters.AddRange(encodedSymbol);
            }

            BitArray bits = new BitArray(encodedInputCharacters.ToArray());

            return bits;
        }

        /**
         * 1. Grab the current node
         * 2. Loop through the bits from the encoded source
         * 3. If the bit is 1 and the current Node does not have a right node set the current node to that adjacency
         * 4. If the bit is 0 and the current Node does not have a left node set the current node to that adjacency
         * 5. If it's a leaf, no left or right nodes set the current node to the parent node
         */
        public String Decode(BitArray bits)
        {
            Node current = ParentNode;
            
            String decoded = "";

            foreach (Boolean bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = ParentNode;
                }
            }

            return decoded;
        }

        // If both adjacent nodes are null, the node is a leaf node
        private static Boolean IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }
    }
}