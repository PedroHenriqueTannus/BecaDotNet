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
            Ordenador ordenador = new Ordenador();
            int[] vetEntrada = { 98, 78, 55, 45, 13 };
            ordenador.VetorEntrada = vetEntrada;
            int[] vet = ordenador.BubbleSort();

            Console.Write("Vetor Ordenado: ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + ", ");
            }

            Console.Read();
        }
    }
}
