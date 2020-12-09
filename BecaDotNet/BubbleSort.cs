using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSortAlg
    {
        public void OrdenaListaDeInteiros(int[] arr)
        {
            int swapValue;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        swapValue = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = swapValue;
                    }
                }
            }


            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.Read();

        }
    }
}
