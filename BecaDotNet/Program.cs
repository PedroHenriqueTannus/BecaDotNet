using System;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //seta os valores de entrada 
            int[] listaValores = { 78, 55, 45, 98, 13 };

            //PAULA MACHADO TEIXEIRA
            //instancia um objeto do tipo BubbleSort
            AlgoritmoBubbleSort bubble = new AlgoritmoBubbleSort();

            //objeto chama o método de ordenação 
            bubble.OrdenaLista(listaValores);                      
            
            Console.Read();
        }
    }
}
