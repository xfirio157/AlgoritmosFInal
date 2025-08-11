using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.FuerzaBruta
{
    public class Burbuja
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Ordenamiento Burbuja ===");
            Console.Write("Tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (A[j] > A[j + 1])
                    {
                        double temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }

            Console.WriteLine("Arreglo ordenado:");
            foreach (var num in A)
                Console.Write(num + " ");

            Console.ReadKey();
        }
    }
}
