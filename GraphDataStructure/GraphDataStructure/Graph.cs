using System;
using System.Collections.Generic;

namespace GraphDataStructure
{
    public class Graph<T>
    {
        private Dictionary<T, GraphNode<T>> Nodes { get; } = new Dictionary<T, GraphNode<T>>();

        public void AddNode(GraphNode<T> node)
        {
            Nodes[node.Data] = node;
        }

        public void AddEdge(Tuple<GraphNode<T>, GraphNode<T>> edge)
        {
            // If the edge does not exist in the set of nodes, ignore
            if (!Nodes.ContainsKey(edge.Item1.Data) || !Nodes.ContainsKey(edge.Item2.Data))
            {
                return;
            }
           
            Nodes[edge.Item1.Data].Add(edge.Item2);
            Nodes[edge.Item2.Data].Add(edge.Item1);
        }

        public HashSet<T> BreadthFirstSearch(T start)
        {
            HashSet<T> nodes = new HashSet<T>();

            // If the start node is not the set, return
            if (!Nodes.ContainsKey(start))
            {
                return nodes;
            }
            
            // Track edges of the graph
            Queue<T> visited = new Queue<T>();

            visited.Enqueue(start);

            while (visited.Count > 0)
            {
                T node = visited.Dequeue();

                if (nodes.Contains(node))
                {
                    continue;
                }

                nodes.Add(node);

                // Loop through the nodes connected nodes
                foreach (GraphNode<T> neighbor in Nodes[node].AdjacentNodes)
                {
                    // If the node has been visited already ignore it
                    if (nodes.Contains(neighbor.Data))
                    {
                        continue;
                    }
                    
                    visited.Enqueue(neighbor.Data);
                }
            }

            return nodes;
        }
    }
}