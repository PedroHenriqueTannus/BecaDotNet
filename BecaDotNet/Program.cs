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

            //chama o método de ordenação que retorna a lista ordenada
            int[] listaOrdenada = bubble.OrdenaLista(listaValores);

            //impressão da lista ordenada
            foreach (int item in listaOrdenada)
            {
                Console.Write(item + " ");
            }
            
            Console.Read();
        }
    }
}
