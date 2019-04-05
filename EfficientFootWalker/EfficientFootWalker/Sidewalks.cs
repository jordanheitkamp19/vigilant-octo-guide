using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficientFootWalker
{
    struct Edge
    {
        private int dest, weight;

        public Edge(int Dest, int Weight)
        {
            this.dest = Dest;
            this.weight = Weight;
        }

        public int Dest
        {
            get { return this.dest; }
            set { this.dest = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    }

    class AdjacencyList
    {
        private List< List<Edge> > Adjacencies;    //a 2d list to represent the graph of sidewalks

        
        public AdjacencyList(int numVertices)
        {
            List<Edge> newVertex = new List<Edge>();

            for (int j = 0; j < numVertices; j++)
                Adjacencies.Add(newVertex);
        }

        public bool IsConnected(int src, int dest)
        {
            foreach (Edge e in Adjacencies[src])
            {
                if (e.Dest == dest)
                    return true;
            }

            return false;
        }

        public int GetWeightOf(int src, int dest)
        {
            foreach(Edge e in Adjacencies[src])
            {
                if (e.Dest == dest)
                    return e.Weight;
            }
            return int.MaxValue;
        }

        public void AddEdge(int src, int dest, int weight)
        {
            Edge newEdge = new Edge(dest, weight);
            Adjacencies[src].Add(newEdge);
        }

        public void RemoveEdge(int src, int dest)
        {
            foreach(Edge e in Adjacencies[src])
            {
                if (e.Dest == dest)
                    Adjacencies[src].Remove(e);
            }
        }

        public void RemoveVertex(int index)
        {
            Adjacencies.Remove( Adjacencies.ElementAt(index) );
        }
    }
}
