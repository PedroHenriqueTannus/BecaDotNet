using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Estevão Filipe Cardoso da Silva
namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria vetor
            int[] vet = { 9, 7, 8, 5, 2 };

            BubbleSort bb = new BubbleSort();

            // Estevão Filipe Cardoso da Silva
            // vetor destino da ordenação
            int[] ret = new int[5];
               
            // armazena o retorno da ordenação
            ret = bb.bbSort(vet);

            //printa na tela os valores ordenados
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ret[i] + " ");

            }

            Console.Read();

        }
    }
}
