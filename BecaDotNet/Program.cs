using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenador ordenador = new Ordenador();//Instancia Objeto Ordenador.
            int[] vetEntrada = { 98, 78, 55, 45, 13 };// Vetor de Entrada desordenado.
            //leticia sorrilha.
            ordenador.VetorEntrada = vetEntrada;
            ordenador.BubbleSort();//Inicia Ordenação pelo algoritmo BubbleSort.

            Console.Read();
        }
    }
}
