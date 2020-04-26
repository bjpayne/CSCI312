using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

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
                nodes.Add(new Node() {NodeSymbol = key, CharacterCount = value});
            }
            
            nodes.Sort();

            while (nodes.Count > 1)
            {
                if (nodes.Count >= 2)
                {
                    List<Node> taken = nodes.Take(2).ToList();

                    Node characterParentNode = new Node()
                    {
                        NodeSymbol = '+',
                        CharacterCount = taken[0].CharacterCount + taken[1].CharacterCount,
                        LeftNode = taken[0],
                        RightNode = taken[1]
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
                // Recursively walk through the nodes to find a leaf node
                List<Boolean> encodedBits = ParentNode.Walk(input[i], new List<Boolean>());

                 // Append the symbols to the end of the list
                for (Int32 j = 0; j < encodedBits.Count; j++)
                {
                    encodedInputCharacters.Add(encodedBits[j]);
                }
            }

            BitArray bits = new BitArray(encodedInputCharacters.ToArray());
            
            StringBuilder encodedBuilder = new StringBuilder();

            for (Int32 i = 0; i < bits.Count; i++)
            {
                encodedBuilder.Append(bits[i]);
            }

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

            StringBuilder decodedBuilder = new StringBuilder();
            
            for (Int32 i = 0; i < bits.Count; i++)
            {
                Boolean bit = bits[i];
                
                 if (bit)
                 {
                     if (current.RightNode != null)
                     {
                         current = current.RightNode;
                     }
                 }
                 else
                 {
                     if (current.LeftNode != null)
                     {
                         current = current.LeftNode;
                     }
                 }
 
                 if (IsLeaf(current))
                 {
                     decodedBuilder.Append(current.NodeSymbol);
                     
                     current = ParentNode;
                 }               
            }

            String decoded = decodedBuilder.ToString();

            return decoded;
        }

        // If both adjacent nodes are null, the node is a leaf node
        private static Boolean IsLeaf(Node node)
        {
            return (node.LeftNode == null && node.RightNode == null);
        }
    }
}