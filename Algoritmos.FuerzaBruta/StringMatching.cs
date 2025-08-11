using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.FuerzaBruta
{
    public class StringMatching
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Coincidencia de Cadenas ===");
            Console.Write("Texto (T): ");
            string T = Console.ReadLine();
            Console.Write("Patrón (P): ");
            string P = Console.ReadLine();

            int n = T.Length;
            int m = P.Length;
            int posicion = -1;

            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                    if (T[i + j] != P[j])
                        break;

                if (j == m)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
                Console.WriteLine($"Patrón encontrado en posición {posicion}");
            else
                Console.WriteLine("Patrón no encontrado");

            Console.ReadKey();
        }
    }
}
