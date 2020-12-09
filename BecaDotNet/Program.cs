using System;
namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            BubbleSort bs = new BubbleSort();
            //chamada Diego Prestes
            int[] ordemCresc = bs.BubbleExecuteCrescent(arr);
            bs.LerArray(ordemCresc);
            //chamada Diego Prestes
            int[] ordemDecresc = bs.BubbleExecuteDecrescent(arr);
            bs.LerArray(ordemDecresc);

            //instancia o BubbleSortAlg
            //pedro luan
            BubbleSortAlg bubble = new BubbleSortAlg();

            //Executa o método OrdenaListaDeInteiros passando o array
            bubble.OrdenaListaDeInteiros(arr);
            Console.Read();
        }
    }
}
