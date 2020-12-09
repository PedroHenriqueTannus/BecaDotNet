using System;
namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            Bubblesort bs = new Bubblesort();
            //chamada Diego Prestes
            int[] ordemCresc = bs.BubbleExecuteCrescent(arr);
            bs.LerArray(ordemCresc);
            //chamada Diego Prestes
            int[] ordemDecresc = bs.BubbleExecuteDecrescent(arr);
            bs.LerArray(ordemDecresc);

            Console.Read();
        }
    }
}
