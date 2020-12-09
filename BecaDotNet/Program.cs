using System;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 78, 55, 45, 98, 13 };

            BubbleSort.Sortear(lista);  // Chamada para o método Sortear passando a lista como parâmetro. (Victor Castro)
            Console.ReadLine();
        }
    }
}
