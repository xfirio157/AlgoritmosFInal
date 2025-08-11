using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.Codiciosos
{
    public class Dijkstra
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Algoritmo de Dijkstra ===");
            Console.Write("Número de vértices: ");
            int V = int.Parse(Console.ReadLine());

            int[,] graph = new int[V, V];

            Console.WriteLine("Ingrese la matriz de adyacencia (0 si no hay arista):");
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    graph[i, j] = int.Parse(Console.ReadLine());

            Console.Write("Vértice fuente: ");
            int src = int.Parse(Console.ReadLine());

            int[] dist = new int[V];
            bool[] sptSet = new bool[V];
            int[] prev = new int[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
                prev[i] = -1;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinDistance(dist, sptSet, V);
                sptSet[u] = true;

                for (int v = 0; v < V; v++)
                {
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue
                        && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        prev[v] = u;
                    }
                }
            }

            Console.WriteLine("Distancias mínimas desde el vértice fuente:");
            for (int i = 0; i < V; i++)
            {
                Console.Write($"Distancia a {i}: {dist[i]} - Camino: ");
                PrintPath(prev, i);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private int MinDistance(int[] dist, bool[] sptSet, int V)
        {
            int min = int.MaxValue, minIndex = -1;
            for (int v = 0; v < V; v++)
                if (!sptSet[v] && dist[v] <= min)
                {
                    min = dist[v];
                    minIndex = v;
                }
            return minIndex;
        }

        private void PrintPath(int[] prev, int j)
        {
            if (j == -1)
                return;
            PrintPath(prev, prev[j]);
            Console.Write(j + " ");
        }
    }
}
