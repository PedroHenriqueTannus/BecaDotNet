using System;

namespace BecaDotNet
{
    public static class BubbleSort
    {
        public static void Sortear(int[] lista)
        {
            int[] arr = lista;

            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Lista Ordenada: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }

        }
    }
}
