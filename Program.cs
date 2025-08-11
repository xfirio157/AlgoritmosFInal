using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.Algoritmos.Codiciosos;
using Algoritmos.Algoritmos.DivideyVenceras;
using Algoritmos.Algoritmos.FuerzaBruta;
using Algoritmos.Algoritmos.ProgramacionDInamica;
using Algoritmos.Algortimos.Codificacion;
using Algoritmos.Algortimos.Otros;

namespace Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL - ALGORITMOS ===");
                Console.WriteLine("1) Fuerza Bruta");
                Console.WriteLine("2) Divide y Vencerás");
                Console.WriteLine("3) Algoritmos Codiciosos");
                Console.WriteLine("4) Huffman (Codificación y Decodificación)");
                Console.WriteLine("5) Programación Dinámica");
                Console.WriteLine("6) Otros Algoritmos");
                Console.WriteLine("0) Salir");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        menu.MenuFuerzaBruta();
                        break;
                    case "2":
                        menu.MenuDivideYVenceras();
                        break;
                    case "3":
                        menu.MenuCodiciosos();
                        break;
                    case "4":
                        menu.MenuHuffman();
                        break;
                    case "5":
                        menu.MenuProgramacionDinamica();
                        break;
                    case "6":
                        menu.MenuOtros();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

      
    }
}

