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
        /*
         É um método de ordenação que analiza o vetor fazendo ir para o topo o maior elemento no caso número da sequência do vetor*/
        public void BubbleSort()
        {
            int[] vet = VetorEntrada;// Recebe vetor de entrada.
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
            Imprimir(vet);
        }
        //Imprime vetor ordenado
        public void Imprimir(int[] vet)
        {
            Console.Write("\nVetor Ordenado: ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i]);
                if (i < vet.Length - 1)
                {
                    Console.Write(", ");
                }
            }

        }
    }
}
