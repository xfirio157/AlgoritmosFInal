using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.DivideyVenceras
{
    public class MergeSort
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Merge Sort ===");
            Console.Write("Tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            MergeSortRec(A, 0, n - 1);

            Console.WriteLine("Arreglo ordenado:");
            foreach (var num in A)
                Console.Write(num + " ");

            Console.ReadKey();
        }

        private void MergeSortRec(int[] A, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int medio = (inicio + fin) / 2;
                MergeSortRec(A, inicio, medio);
                MergeSortRec(A, medio + 1, fin);
                Merge(A, inicio, medio, fin);
            }
        }

        private void Merge(int[] A, int inicio, int medio, int fin)
        {
            int n1 = medio - inicio + 1;
            int n2 = fin - medio;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++) L[i] = A[inicio + i];
            for (int j = 0; j < n2; j++) R[j] = A[medio + 1 + j];

            int iL = 0, iR = 0, k = inicio;

            while (iL < n1 && iR < n2)
            {
                if (L[iL] <= R[iR]) A[k++] = L[iL++];
                else A[k++] = R[iR++];
            }

            while (iL < n1) A[k++] = L[iL++];
            while (iR < n2) A[k++] = R[iR++];
        }
    }
}
