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
    public class Menu
    {
        public void MenuFuerzaBruta()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== FUERZA BRUTA ===");
                Console.WriteLine("1) Búsqueda Secuencial");
                Console.WriteLine("2) Ordenamiento Burbuja");
                Console.WriteLine("3) Ordenamiento Selección");
                Console.WriteLine("4) Coincidencia de Cadenas");
                Console.WriteLine("5) Problema de Partición (Búsqueda Exhaustiva)");
                Console.WriteLine("0) Regresar al menú principal");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new BusquedaSecuencial().Ejecutar();
                        break;
                    case "2":
                        new Burbuja().Ejecutar();
                        break;
                    case "3":
                        new Seleccion().Ejecutar();
                        break;
                    case "4":
                        new StringMatching().Ejecutar();
                        break;
                    case "5":
                        new Particion().Ejecutar();
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

        public void MenuDivideYVenceras()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== DIVIDE Y VENCERÁS ===");
                Console.WriteLine("1) Merge Sort");
                Console.WriteLine("2) Quick Sort");
                Console.WriteLine("3) Búsqueda Binaria Recursiva");
                Console.WriteLine("4) Búsqueda Binaria Iterativa");
                Console.WriteLine("0) Regresar al menú principal");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new MergeSort().Ejecutar();
                        break;
                    case "2":
                        new QuickSort().Ejecutar();
                        break;
                    case "3":
                        new BusquedaBinariaRecursiva().Ejecutar();
                        break;
                    case "4":
                        new BusquedaBinariaIterativa().Ejecutar();
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

        public void MenuCodiciosos()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ALGORITMOS CODICIOSOS ===");
                Console.WriteLine("1) Algoritmo de Prim");
                Console.WriteLine("2) Algoritmo de Kruskal");
                Console.WriteLine("3) Algoritmo de Dijkstra");
                Console.WriteLine("0) Regresar al menú principal");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new Prim().Ejecutar();
                        break;
                    case "2":
                        new Kruskal().Ejecutar();
                        break;
                    case "3":
                        new Dijkstra().Ejecutar();
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

        public void MenuHuffman()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== HUFFMAN ===");
                Console.WriteLine("1) Codificación Huffman");
                Console.WriteLine("2) Decodificación Huffman");
                Console.WriteLine("0) Regresar al menú principal");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new HuffmanCodificacion().Ejecutar();
                        break;
                    case "2":
                        new HuffmanDecodificacion().Ejecutar();
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

        public void MenuProgramacionDinamica()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== PROGRAMACIÓN DINÁMICA ===");
                Console.WriteLine("1) Coeficiente Binomial C(n,k)");
                Console.WriteLine("2) Algoritmo de Floyd");
                Console.WriteLine("3) Problema del Corte de Varilla");
                Console.WriteLine("0) Regresar al menú principal");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new CoeficienteBinomial().Ejecutar();
                        break;
                    case "2":
                        new Floyd().Ejecutar();
                        break;
                    case "3":
                        new CorteVarilla().Ejecutar();
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

        public void MenuOtros()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== OTROS ALGORITMOS ===");
                Console.WriteLine("1) Representación binaria de un entero");
                Console.WriteLine("2) Cálculo de raíz cuadrada (método iterativo)");
                Console.WriteLine("0) Regresar al menú principal");
                Console.Write("Seleccione opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new RepresentacionBinaria().Ejecutar();
                        break;
                    case "2":
                        new RaizCuadrada().Ejecutar();
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
