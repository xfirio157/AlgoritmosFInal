using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.DivideyVenceras
{
    public class QuickSort
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Quick Sort ===");
            Console.Write("Tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            QuickSortRec(A, 0, n - 1);

            Console.WriteLine("Arreglo ordenado:");
            foreach (var num in A)
                Console.Write(num + " ");

            Console.ReadKey();
        }

        private void QuickSortRec(int[] A, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particionar(A, inicio, fin);
                QuickSortRec(A, inicio, pivote - 1);
                QuickSortRec(A, pivote + 1, fin);
            }
        }

        private int Particionar(int[] A, int inicio, int fin)
        {
            int pivote = A[fin];
            int i = inicio - 1;
            for (int j = inicio; j < fin; j++)
            {
                if (A[j] <= pivote)
                {
                    i++;
                    (A[i], A[j]) = (A[j], A[i]);
                }
            }
            (A[i + 1], A[fin]) = (A[fin], A[i + 1]);
            return i + 1;
        }
    }
}
