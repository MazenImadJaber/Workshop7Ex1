using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7Ex1
{
   public class Graph
    {
        private int N;
        private bool[,] graph;
        public Graph(int N)
        {
            this.N = N;
            // allocate space for the matrix
            graph = new bool[N, N];
            // initialise to false
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    graph[i, j] = false;
                }
            }
        }

        /// Destructor dealloctes the adjacency matrix
        ~Graph()
        {
            graph = null; 
           
        }

        /// Adds an undirected edge to the graph between the source and destination vertices.
        public void addEdge(int src, int dst)
        {
            graph[src, dst] = true;
            graph[dst, src] = true;

        }


        /// Produces a string representation of the graph.
        public static void write(Graph graph)
        {
            for (int i = 0; i < graph.N; i++)
            {
                for (int j = 0; j < graph.N; j++)
                {
                    Console.Write("  " + (graph.graph[i, j] ? 1 : 0));
                }
                Console.Write("\r\n");
            }

        }
    }
}

    