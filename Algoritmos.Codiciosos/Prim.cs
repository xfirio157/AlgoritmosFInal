using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.Codiciosos
{
    public class Prim
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Algoritmo de Prim ===");
            Console.Write("Número de vértices: ");
            int n = int.Parse(Console.ReadLine());
            int[,] graph = new int[n, n];

            Console.WriteLine("Ingrese la matriz de adyacencia (0 si no hay arista):");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    graph[i, j] = int.Parse(Console.ReadLine());

            int[] parent = new int[n];
            int[] key = new int[n];
            bool[] mstSet = new bool[n];

            for (int i = 0; i < n; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < n - 1; count++)
            {
                int u = MinKey(key, mstSet, n);
                mstSet[u] = true;

                for (int v = 0; v < n; v++)
                    if (graph[u, v] != 0 && !mstSet[v] && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
            }

            Console.WriteLine("Aristas del árbol de expansión mínima:");
            for (int i = 1; i < n; i++)
                Console.WriteLine($"{parent[i]} - {i}  peso: {graph[i, parent[i]]}");

            Console.ReadKey();
        }

        private int MinKey(int[] key, bool[] mstSet, int n)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < n; v++)
                if (!mstSet[v] && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            return minIndex;
        }
    }
}
