using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directed_graph
{
    internal class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;
        private LinkedList<int> weights;

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
            weights = new LinkedList<int>();
        }

        public T ID
        {
            get { return id; }
            set { id = value; }
        }


        public void AddEdge(GraphNode<T> to, int weight)
        {
            adjList.AddLast(to.ID);
            weights.AddLast(weight);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList; 
        }

        //public void displayAdjList()
        //{
        //    foreach (T curr in GetAdjList())
        //    {
        //        Console.Write(curr);
        //    }
        //}

    }
}
