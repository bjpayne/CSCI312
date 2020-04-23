using System;
using System.Collections.Generic;

namespace GraphDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<String> graph = new Graph<String>();

            Int32[] nodes = {0, 1, 2, 3, 4};

            foreach (Int32 node in nodes)
            {
                GraphNode<String> graphNode = new GraphNode<String>(node.ToString());

                graph.AddNode(graphNode);
            }

            Tuple<Int32, Int32>[] edges = {
                Tuple.Create(0, 4),
                Tuple.Create(0, 1),
                Tuple.Create(4, 1),
                Tuple.Create(4, 3),
                Tuple.Create(1, 3),
                Tuple.Create(1, 2),
                Tuple.Create(3, 2)
            };

            foreach ((Int32 item1, Int32 item2) in edges)
            {
                GraphNode<String> firstEdge = new GraphNode<String>(item1.ToString());
                GraphNode<String> secondEdge = new GraphNode<String>(item2.ToString());

                Tuple<GraphNode<String>, GraphNode<String>> graphNodeEdges =
                    new Tuple<GraphNode<String>, GraphNode<String>>(firstEdge, secondEdge);

                graph.AddEdge(graphNodeEdges);
            }
            
            Console.WriteLine("Beginning search...");
            
            HashSet<String> results = graph.BreadthFirstSearch("0");

            foreach (String result in results)
            {
                Console.WriteLine($"Visiting node {result}");
            }

            Console.WriteLine("Done.");
        }
    }
}