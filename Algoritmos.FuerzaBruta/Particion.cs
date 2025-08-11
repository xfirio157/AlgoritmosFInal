using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.FuerzaBruta
{
    public class Particion
    {
        private int[] numeros;
        private int n;
        private int totalSum;
        private bool encontrado = false;

        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Problema de Partición ===");
            Console.Write("Número de elementos: ");
            n = int.Parse(Console.ReadLine());
            numeros = new int[n];

            Console.WriteLine("Ingrese los elementos (enteros positivos):");
            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            totalSum = 0;
            foreach (var num in numeros)
                totalSum += num;

            if (totalSum % 2 != 0)
            {
                Console.WriteLine("No es posible partir en dos subconjuntos con la misma suma (suma total impar).");
                Console.ReadKey();
                return;
            }

            List<int> subset1 = new List<int>();
            List<int> subset2 = new List<int>();
            Backtrack(0, 0, 0, subset1, subset2);

            if (!encontrado)
                Console.WriteLine("No se encontró solución.");
            Console.ReadKey();
        }

        private void Backtrack(int index, int sum1, int sum2, List<int> s1, List<int> s2)
        {
            if (encontrado)
                return;

            if (index == n)
            {
                if (sum1 == sum2)
                {
                    encontrado = true;
                    Console.WriteLine("Subconjunto 1: " + string.Join(", ", s1));
                    Console.WriteLine("Subconjunto 2: " + string.Join(", ", s2));
                }
                return;
            }

            // Añadir número al subconjunto 1 (si no excede suma)
            if (sum1 + numeros[index] <= totalSum / 2)
            {
                s1.Add(numeros[index]);
                Backtrack(index + 1, sum1 + numeros[index], sum2, s1, s2);
                s1.RemoveAt(s1.Count - 1);
            }

            // Añadir número al subconjunto 2 (si no excede suma)
            if (sum2 + numeros[index] <= totalSum / 2)
            {
                s2.Add(numeros[index]);
                Backtrack(index + 1, sum1, sum2 + numeros[index], s1, s2);
                s2.RemoveAt(s2.Count - 1);
            }
        }
    }
}
