using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Algortimos.Codificacion
{
    public class HuffmanDecodificacion
    {
        private class Nodo
        {
            public char Caracter;
            public Nodo Izquierdo, Derecho;

            public Nodo(char c)
            {
                Caracter = c;
                Izquierdo = Derecho = null;
            }
            public Nodo()
            {
                Caracter = '\0';
            }
        }

        // Se necesita el árbol (o el diccionario de códigos) para decodificar, aquí para ejemplo simple
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Decodificación Huffman ===");
            Console.Write("Ingrese código binario: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Para decodificar correctamente se necesita el árbol o los códigos. Esta implementación es básica.");

            // Aquí se puede pedir código y diccionario o árbol para decodificar.
            Console.WriteLine("Funcionalidad completa requiere almacenar árbol o tabla de códigos.");

            Console.ReadKey();
        }
    }
}
