using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.DivideyVenceras
{
    public class BusquedaBinariaIterativa
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Búsqueda Binaria Iterativa ===");
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

            int inicio = 0, fin = n - 1, pos = -1;
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (A[medio] == K)
                {
                    pos = medio;
                    break;
                }
                else if (K < A[medio])
                    fin = medio - 1;
                else
                    inicio = medio + 1;
            }

            if (pos != -1)
                Console.WriteLine($"Elemento encontrado en índice {pos}");
            else
                Console.WriteLine("Elemento no encontrado");

            Console.ReadKey();
        }
    }
}
