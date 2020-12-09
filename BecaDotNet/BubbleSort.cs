using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSort
    {
        // metodo que ordena o vetor 
        public int[] bbSort(int[] sort)
        {
            // for encadeado para a analise dos valores e andar de acordo ao tamanho do vetor
            for (int i = 5 - 1; i >= 1; i--)
            {
                 
                for (int n = 0; n < i; n++)
                {
                    // verifica se numero da posição atual é maior que o numero da proxima posição
                    if (sort[n] > sort[n + 1])
                    {
                        // valor auxiliar para armazenar o valor atual
                        int val = sort[n];
                        // troca os valores 
                        sort[n] = sort[n + 1];
                        sort[n + 1] = val;

                    }
                }
            }
            //retorna o vetor ordenado
            return sort;
        }
    }
}
