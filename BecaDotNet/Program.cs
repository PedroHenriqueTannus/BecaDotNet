using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Read();

            //instancia o BubbleSortAlg
            //pedro luan
            //Executa o método OrdenaListaDeInteiros passando o array
            bubblesort.OrdenaListaDeInteiros(arr);
            Console.Read();

            //PAULA MACHADO TEIXEIRA
            //instancia um objeto do tipo BubbleSort
            AlgoritmoBubbleSort bubble = new AlgoritmoBubbleSort();
            //objeto chama o método de ordenação 
            bubble.OrdenaLista(arr);                      
            
            Console.ReadKey();
            Ordenador ordenador = new Ordenador();//Instancia Objeto Ordenador.
            int[] vetEntrada = { 98, 78, 55, 45, 13 };// Vetor de Entrada desordenado.
            //leticia sorrilha.
            ordenador.VetorEntrada = vetEntrada;
            ordenador.BubbleSort();//Inicia Ordenação pelo algoritmo BubbleSort.

            Console.Read();
        }
    }
}
