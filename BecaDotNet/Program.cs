﻿using System;
namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            BubbleSortAlg bubblesort = new BubbleSortAlg();

            //chamada Diego Prestes
            int[] ordemCresc = bubblesort.BubbleExecuteCrescent(arr);
            bubblesort.LerArray(ordemCresc);
            //chamada Diego Prestes
            int[] ordemDecresc = bubblesort.BubbleExecuteDecrescent(arr);
            bubblesort.LerArray(ordemDecresc);

            //instancia o BubbleSortAlg
            //pedro luan
            //Executa o método OrdenaListaDeInteiros passando o array
            bubblesort.OrdenaListaDeInteiros(arr);
            Console.Read();
        }
    }
}
