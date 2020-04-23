using System.Collections.Generic;

namespace GraphDataStructure
{
    public class GraphNode<T>
    {
        public List<GraphNode<T>> AdjacentNodes { get; }

        public T Data { get; }

        public GraphNode()
        {
            Data = default(T);
            AdjacentNodes = new List<GraphNode<T>>();
        }

        public GraphNode(T data)
        {
            Data = data;
            AdjacentNodes = new List<GraphNode<T>>();
        }

        public void Add(GraphNode<T> node)
        {
            AdjacentNodes.Add(node);
        }
    }
}
