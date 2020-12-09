using System;

namespace BecaDotNet
{
    public class BubbleSort                  // Classe que contém o método para ordenar os valores
    {
        public void Sortear(int[] lista)     // Método que recebe um array como parâmetro e faz a ordenação BubbleSort
        {
            int[] arr = lista;

            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])     // Verifica se o valor atual é maior que o seguinte e faz o ajuste se necessário
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Lista Ordenada: ");      
            foreach (int n in arr)               // Retorna cada valor na lista
            {
                Console.Write($"{n} ");
            }

        }
    }
}
