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
        int EdgeCount;

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
                EdgeCount++;
            }
            else
                Console.WriteLine("Node/s not found in the graph. Cannot add the edge");

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

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {

            foreach (GraphNode<T> n in nodes)
            {
                if(n.ID.CompareTo(from.ID) == 0)
                {
                    if (from.GetAdjList().Contains(to.ID))
                        return true;
                }
            }

            return false;
        }


        public int NumNodesGraph()
        {
            return(nodes.Count());
        }

        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {
            return EdgeCount;
        }

        public string displayNodesAndAdjs()
        {
            StringBuilder NodeAndAdj = new StringBuilder();
            foreach (GraphNode<T> curr in nodes)
            {
                NodeAndAdj.Append(curr.ID + " - " + displayAdjList(curr.ID) + Environment.NewLine);
            }
            return NodeAndAdj.ToString();
        }

        public string displayAdjList(T id)
        {
            StringBuilder adjLIst = new StringBuilder();
            foreach (T curr in GetNodeByID(id).GetAdjList())
            {
                adjLIst.Append(curr.ToString() + ",");
            }
            return adjLIst.ToString();
        }



        public bool isEmptyGraph()
        {
            return nodes.Count == 0;
        }


    }
}
