using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algortimos.Otros
{
    public class RaizCuadrada
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Cálculo de raíz cuadrada por aproximación ===");
            Console.Write("Ingrese un entero positivo n: ");
            double n = double.Parse(Console.ReadLine());
            double epsilon = 0.00001;
            double guess = n / 2.0;
            double diff;

            do
            {
                double newGuess = (guess + n / guess) / 2.0;
                diff = Math.Abs(newGuess - guess);
                guess = newGuess;
            } while (diff > epsilon);

            Console.WriteLine($"Raíz cuadrada aproximada de {n} es {guess}");
            Console.ReadKey();
        }
    }
}
