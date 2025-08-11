using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algortimos.Otros
{
    public class RepresentacionBinaria
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Representación binaria de un entero decimal positivo ===");
            Console.Write("Ingrese un entero positivo: ");
            int n = int.Parse(Console.ReadLine());

            // Algoritmo:
            // 1. Mientras n > 0:
            //     a) Obtener el residuo r = n % 2
            //     b) Guardar r en una pila o lista
            //     c) Actualizar n = n / 2 (división entera)
            // 2. Imprimir los restos en orden inverso para obtener el binario.

            if (n == 0)
            {
                Console.WriteLine("0");
                Console.ReadKey();
                return;
            }

            string binario = "";
            int numero = n;
            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo + binario;
                numero /= 2;
            }

            Console.WriteLine($"Representación binaria de {n} es: {binario}");
            Console.ReadKey();
        }
    }
}
