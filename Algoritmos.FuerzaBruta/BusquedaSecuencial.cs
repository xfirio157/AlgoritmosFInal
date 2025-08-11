using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.FuerzaBruta
{
    public class BusquedaSecuencial
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Búsqueda Secuencial ===");
            Console.Write("Tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            string[] A = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento[{i}]: ");
                A[i] = Console.ReadLine();
            }

            Console.Write("Elemento a buscar: ");
            string K = Console.ReadLine();

            int pos = -1;
            for (int i = 0; i < n; i++)
                if (A[i] == K)
                {
                    pos = i;
                    break;
                }

            if (pos != -1)
                Console.WriteLine($"Elemento encontrado en posición {pos}");
            else
                Console.WriteLine("Elemento no encontrado");

            Console.ReadKey();
        }
    }
}
