using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directed_graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a graph with ID of nodes as 'char'
            Graph<char> myGraph = new Graph<char>();

            // add nodes in the graph
            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');
            myGraph.AddNode('E');

            // add connections between the nodes. these are direct edges
            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');
            myGraph.AddEdge('B', 'C');
            myGraph.AddEdge('D', 'A');
            myGraph.AddEdge('D', 'E');

            myGraph.AddEdge('A', 'E');

            Console.WriteLine("Is myGraph empty? Answer: {0}", myGraph.isEmptyGraph());


            // is there an edge from 'A' to 'B' ?

            Console.WriteLine("Is there an edge from {0} to {1}? {2}",
            myGraph.GetNodeByID('A').ID, myGraph.GetNodeByID('B').ID,
            myGraph.GetNodeByID('A').GetAdjList().Contains('B'));


            // is there an edge from 'B' to 'A' ?

            Console.WriteLine("Is there an edge from {0} to {1}? {2}",
            myGraph.GetNodeByID('B').ID, myGraph.GetNodeByID('A').ID,
            myGraph.GetNodeByID('B').GetAdjList().Contains('A'));

            Console.WriteLine("is there an edge from A to B?  {0}",
            myGraph.IsAdjacent(myGraph.GetNodeByID('A'), myGraph.GetNodeByID('B')));

            Console.WriteLine("is there an edge from A to B?  {0}",
            myGraph.IsAdjacent(myGraph.GetNodeByID('B'), myGraph.GetNodeByID('A')));

            Console.WriteLine("there are {0} nodes",
                myGraph.NumNodesGraph());

            Console.WriteLine("there are {0} edges",
                myGraph.NumEdgesGraph());


            Console.WriteLine(myGraph.displayNodesAndAdjs());
            Console.ReadLine();


        }
    }
}
