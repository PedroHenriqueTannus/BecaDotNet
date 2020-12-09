using System;

namespace BecaDotNet
{
    class BubbleSort
    {
        public void BolhaSort(int[] arr)
        {

            int temp = 0; // seta variavel temporaria
            for (int i = 0; i < arr.Length; i++) //for para comparar os valores
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j]) //ve se um valor é maior que o outro
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            //imprime os valores em ordem separados por espaço
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

        }

    }
}
