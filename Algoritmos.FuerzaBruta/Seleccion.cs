using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.FuerzaBruta
{
    public class Seleccion
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Ordenamiento Selección ===");
            Console.Write("Tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                    if (A[j] < A[minIndex])
                        minIndex = j;

                if (minIndex != i)
                {
                    double temp = A[i];
                    A[i] = A[minIndex];
                    A[minIndex] = temp;
                }
            }

            Console.WriteLine("Arreglo ordenado:");
            foreach (var num in A)
                Console.Write(num + " ");

            Console.ReadKey();
        }
    }
}
