using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSP_2
{
    /// <summary>
    /// Weighted graph implementation using an adjacency list.
    /// </summary>
    public class Graph
    {
        public Dictionary<Vertex, LinkedList<KeyValuePair<Vertex, Edge>>> Adj { get; }

        /// <summary>
        /// Creates new graph
        /// </summary>
        public Graph()
        {
            //adj = new Dictionary<Vertex, LinkedList<Vertex>>();
            Adj = new Dictionary<Vertex, LinkedList<KeyValuePair<Vertex, Edge>>>();
        }

        /// <summary>
        /// Adds unconnected vertex to graph
        /// </summary>
        /// <param name="v">Vertex to add</param>
        public void AddVertex(Vertex v)
        {
            Adj[v] = new LinkedList<KeyValuePair<Vertex, Edge>>();
        }

        /// <summary>
        /// Add u and v to adjacency matrix
        /// </summary>
        /// <param name="u">Vertex 1</param>
        /// <param name="v">Vertex 2</param>
        public void AddEdge(Vertex u, Vertex v)
        {
            Edge edge = new Edge(u, v);
            Adj[u].AddLast(new KeyValuePair<Vertex, Edge>(v, edge));
            Adj[v].AddLast(new KeyValuePair<Vertex, Edge>(u, edge));
        }
    }
}
