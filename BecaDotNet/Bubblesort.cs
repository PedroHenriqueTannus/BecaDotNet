using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class Bubblesort
    {
        public void LerArray(int[] ordenado)
        {
            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.Write($"{ordenado[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("FEITO!");
        }
        public int[] BubbleExecuteCrescent(int[] desordem)
        {
            int mao = 0;

            for (int i = 0; i < desordem.Length - 1; i++)
            {
                for (int j = 0; j < desordem.Length - 1; j++)
                {
                    if (desordem[j] > desordem[j + 1])
                    {
                        mao = desordem[j + 1];
                        desordem[j + 1] = desordem[j];
                        desordem[j] = mao;
                    }
                }
            }
            return desordem;
        }

        public int[] BubbleExecuteDecrescent(int[] desordem)
        {
            int mao = 0;

            for (int i = desordem.Length - 1; i > 0; i--)
            {
                for (int j = desordem.Length - 1; j > 0; j--)
                {
                    if (desordem[j] > desordem[j - 1])
                    {
                        mao = desordem[j - 1];
                        desordem[j - 1] = desordem[j];
                        desordem[j] = mao;
                    }
                }
            }
            return desordem;
        }
    }
}
