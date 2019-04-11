using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficientFootWalker
{
    class DistanceFinder
    {
        private List<List<double>> Distances;
        private AdjacencyList adjacencyList;
        private int Size;

        public DistanceFinder(int size)
        {
            Distances = new List<List<double>>();
            adjacencyList = new AdjacencyList(size);

            for (int i = 0; i < size; i++)
            {
                Distances.Add(new List<double>());

                for (int j = 0; j < size; j++)
                {
                    Distances[i].Add(double.MaxValue);
                }
            }
        }

        private void Calc(int source)
        {
            //do relaxing from single source
        }

    }
}
