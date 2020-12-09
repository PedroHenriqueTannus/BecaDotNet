using System;

namespace ExemploCSharp
{
    class BubbleSort
    {
        public static void BolhaSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.WriteLine();
            }

        }

    }
}
