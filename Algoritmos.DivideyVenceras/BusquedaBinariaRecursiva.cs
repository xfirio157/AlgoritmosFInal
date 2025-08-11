using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.DivideyVenceras
{
    public class BusquedaBinariaRecursiva
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Búsqueda Binaria Recursiva ===");
            Console.Write("Tamaño del arreglo ordenado: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elemento a buscar: ");
            int K = int.Parse(Console.ReadLine());

            int resultado = Buscar(A, 0, n - 1, K);

            if (resultado != -1)
                Console.WriteLine($"Elemento encontrado en índice {resultado}");
            else
                Console.WriteLine("Elemento no encontrado");

            Console.ReadKey();
        }

        private int Buscar(int[] A, int inicio, int fin, int K)
        {
            if (inicio > fin) return -1;
            int medio = (inicio + fin) / 2;
            if (A[medio] == K) return medio;
            if (K < A[medio]) return Buscar(A, inicio, medio - 1, K);
            return Buscar(A, medio + 1, fin, K);
        }
    }
}
