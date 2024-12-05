using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directed_graph
{
    internal class Graph<T> where T : IComparable
    {
        LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }


        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> curr in nodes)
            {
                if (curr.ID.CompareTo(id) == 0)
                {
                    return curr;
                }
            }
            return null;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if(n1!= null && n2!= null)
            {
                n1.AddEdge(n2);
            }
        }

        public bool ContainsGraph(T id)
        {
            foreach (GraphNode<T> curr in nodes)
            {
                if (curr.ID.CompareTo(id) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isEmptyGraph()
        {
            return nodes.Count == 0;
        }


    }
}
