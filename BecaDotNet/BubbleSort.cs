using System;

namespace BecaDotNet
{
    public class BubbleSort
    {
        int[] a = { 78, 55, 45, 98, 13 };

        public void OrdenarArray()
        {
            for(int i = a.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i ; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int aux = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = aux;
                    }
                }
            }
            
        }
        public void VetorInicial()
        {
            Console.WriteLine("VETOR:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");

            }

        }
        public void SaidaDeDados()
        {
            Console.WriteLine("RESULTADO:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();

        }
        
    }
    

}
