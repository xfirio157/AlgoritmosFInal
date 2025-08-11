using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.ProgramacionDInamica
{
    public class Floyd
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Algoritmo de Floyd ===");
            Console.Write("Número de vértices: ");
            int n = int.Parse(Console.ReadLine());
            int[,] W = new int[n, n];

            Console.WriteLine("Ingrese matriz de pesos (use 99999 o similar para infinito):");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    W[i, j] = int.Parse(Console.ReadLine());

            int[,] dist = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dist[i, j] = W[i, j];

            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                            dist[i, j] = dist[i, k] + dist[k, j];

            Console.WriteLine("Matriz de distancias mínimas:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(dist[i, j] + "\t");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
