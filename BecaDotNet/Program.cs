using System;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args) // Victor Castro
        {
            int[] lista = { 78, 55, 45, 98, 13 };

            BubbleSort BS = new BubbleSort();

            BS.Sortear(lista);  // Chamada para o método Sortear passando a lista como parâmetro
            Console.ReadLine();
        }
    }
}
