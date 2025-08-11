using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.Codiciosos
{
    public class Kruskal
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Algoritmo de Kruskal ===");
            Console.Write("Número de vértices: ");
            int V = int.Parse(Console.ReadLine());
            Console.Write("Número de aristas: ");
            int E = int.Parse(Console.ReadLine());

            Edge[] edges = new Edge[E];
            for (int i = 0; i < E; i++)
            {
                Console.WriteLine($"Arista {i + 1}:");
                Console.Write("Origen: ");
                int src = int.Parse(Console.ReadLine());
                Console.Write("Destino: ");
                int dest = int.Parse(Console.ReadLine());
                Console.Write("Peso: ");
                int weight = int.Parse(Console.ReadLine());
                edges[i] = new Edge(src, dest, weight);
            }

            Array.Sort(edges, (a, b) => a.Weight.CompareTo(b.Weight));

            int[] parent = new int[V];
            for (int i = 0; i < V; i++)
                parent[i] = i;

            int edgeCount = 0;
            Console.WriteLine("Aristas del árbol de expansión mínima:");
            foreach (var edge in edges)
            {
                if (Find(parent, edge.Src) != Find(parent, edge.Dest))
                {
                    Console.WriteLine($"{edge.Src} - {edge.Dest}  peso: {edge.Weight}");
                    Union(parent, edge.Src, edge.Dest);
                    edgeCount++;
                    if (edgeCount == V - 1)
                        break;
                }
            }

            Console.ReadKey();
        }

        private int Find(int[] parent, int i)
        {
            if (parent[i] == i)
                return i;
            return parent[i] = Find(parent, parent[i]);
        }

        private void Union(int[] parent, int x, int y)
        {
            int xset = Find(parent, x);
            int yset = Find(parent, y);
            parent[xset] = yset;
        }

        struct Edge
        {
            public int Src, Dest, Weight;
            public Edge(int s, int d, int w)
            {
                Src = s; Dest = d; Weight = w;
            }
        }
    }
}
