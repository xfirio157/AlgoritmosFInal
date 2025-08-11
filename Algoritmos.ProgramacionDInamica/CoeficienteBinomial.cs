using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algoritmos.ProgramacionDInamica
{
    public class CoeficienteBinomial
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Coeficiente Binomial C(n,k) ===");
            Console.Write("Ingrese n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese k: ");
            int k = int.Parse(Console.ReadLine());

            int resultado = CalcularC(n, k);
            Console.WriteLine($"C({n},{k}) = {resultado}");

            Console.ReadKey();
        }

        private int CalcularC(int n, int k)
        {
            int[,] C = new int[n + 1, k + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= Math.Min(i, k); j++)
                {
                    if (j == 0 || j == i)
                        C[i, j] = 1;
                    else
                        C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
                }
            }
            return C[n, k];
        }
    }
}
