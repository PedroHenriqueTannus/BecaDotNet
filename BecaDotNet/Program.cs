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

            // chamada Bruno Alexandre
            BubbleSorte bubleSort = new BubbleSorte();
            int[] saida = bubleSort.ordenacao(arr);
            Console.WriteLine(bubleSort.saida(saida));
            Console.Read();

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
           
        }
    }
}
