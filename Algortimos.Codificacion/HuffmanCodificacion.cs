using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Common.Utilities;
using Lucene.Net.Util;
using NetTopologySuite.Utilities;

namespace Algoritmos.Algortimos.Codificacion
{
    public class HuffmanCodificacion
    {
        private class Nodo
        {
            public char Caracter;
            public int Frecuencia;
            public Nodo Izquierdo, Derecho;

            public Nodo(char c, int f)
            {
                Caracter = c;
                Frecuencia = f;
                Izquierdo = Derecho = null;
            }
        }

        // Implementación propia de PriorityQueue para .NET Framework 4.8
        private class PriorityQueue<T>
        {
            private List<(T item, int priority)> data = new List<(T, int)>();

            public int Count => data.Count;

            public void Enqueue(T item, int priority)
            {
                data.Add((item, priority));
                int ci = data.Count - 1;

                while (ci > 0)
                {
                    int pi = (ci - 1) / 2;
                    if (data[ci].priority >= data[pi].priority)
                        break;
                    var tmp = data[ci];
                    data[ci] = data[pi];
                    data[pi] = tmp;
                    ci = pi;
                }
            }

            public T Dequeue()
            {
                if (data.Count == 0)
                    throw new InvalidOperationException("La cola está vacía");

                int li = data.Count - 1;
                var frontItem = data[0];
                data[0] = data[li];
                data.RemoveAt(li);
                --li;

                int pi = 0;
                while (true)
                {
                    int ci = pi * 2 + 1;
                    if (ci > li) break;

                    int rc = ci + 1;
                    if (rc <= li && data[rc].priority < data[ci].priority)
                        ci = rc;

                    if (data[pi].priority <= data[ci].priority)
                        break;

                    var tmp = data[pi];
                    data[pi] = data[ci];
                    data[ci] = tmp;
                    pi = ci;
                }
                return frontItem.item;
            }
        }

        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Codificación Huffman ===");
            Console.Write("Ingrese texto en español: ");
            string texto = Console.ReadLine();

            var frecuencias = texto.GroupBy(c => c)
                                  .ToDictionary(g => g.Key, g => g.Count());

            var queue = new PriorityQueue<Nodo>();
            foreach (var par in frecuencias)
                queue.Enqueue(new Nodo(par.Key, par.Value), par.Value);

            while (queue.Count > 1)
            {
                var left = queue.Dequeue();
                var right = queue.Dequeue();
                var sumFreq = left.Frecuencia + right.Frecuencia;
                var node = new Nodo('\0', sumFreq) { Izquierdo = left, Derecho = right };
                queue.Enqueue(node, sumFreq);
            }

            Nodo raiz = queue.Dequeue();
            var codigos = new Dictionary<char, string>();
            GenerarCodigos(raiz, "", codigos);

            Console.WriteLine("\nCódigos Huffman:");
            foreach (var c in codigos)
                Console.WriteLine($"{c.Key}: {c.Value}");

            string textoCodificado = string.Concat(texto.Select(c => codigos[c]));
            Console.WriteLine("\nTexto codificado:");
            Console.WriteLine(textoCodificado);

            Console.ReadKey();
        }

        private void GenerarCodigos(Nodo nodo, string codigo, Dictionary<char, string> codigos)
        {
            if (nodo == null) return;
            if (nodo.Izquierdo == null && nodo.Derecho == null)
            {
                codigos[nodo.Caracter] = codigo == "" ? "0" : codigo;
            }
            GenerarCodigos(nodo.Izquierdo, codigo + "0", codigos);
            GenerarCodigos(nodo.Derecho, codigo + "1", codigos);
        }
    }
}
