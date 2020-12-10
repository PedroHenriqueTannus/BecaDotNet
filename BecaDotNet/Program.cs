using System;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bs = new BubbleSort();

            //chamada do Christofer
            bs.VetorInicial();
            Console.ReadLine();
            bs.OrdenarArray();
            bs.SaidaDeDados();

        }
    }
}
