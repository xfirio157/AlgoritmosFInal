using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.ProgramacionDInamica
{
    public class CorteVarilla
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Problema del Corte de Varilla ===");
            Console.Write("Ingrese longitud de la varilla: ");
            int n = int.Parse(Console.ReadLine());

            int[] precios = new int[n + 1];
            Console.WriteLine("Ingrese precios para longitudes 1 a n:");
            for (int i = 1; i <= n; i++)
                precios[i] = int.Parse(Console.ReadLine());

            int[] dp = new int[n + 1];
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int maxVal = int.MinValue;
                for (int j = 1; j <= i; j++)
                    maxVal = Math.Max(maxVal, precios[j] + dp[i - j]);
                dp[i] = maxVal;
            }

            Console.WriteLine($"Máximo ingreso posible para varilla de longitud {n}: {dp[n]}");
            Console.ReadKey();
        }
    }
}
