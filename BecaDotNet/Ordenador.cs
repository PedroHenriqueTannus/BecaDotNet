using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class Ordenador
    {
        public int[] VetorEntrada { get; set; }

        public int[] BubbleSort()
        {
            int[] vet = VetorEntrada;
            int lenght = vet.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = lenght - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vet[j] > vet[j + 1])
                    {
                        int aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vet;
        }
    }
}
