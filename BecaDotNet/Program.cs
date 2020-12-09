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
            //inicializa um array de inteiros
            int[] arr = { 78, 55, 45, 98, 13 };

            //instancia o BubbleSortAlg
            //pedro luan
            BubbleSortAlg bubble = new BubbleSortAlg();

            //Executa o método OrdenaListaDeInteiros passando o array
            bubble.OrdenaListaDeInteiros(arr);
        }
    }
}
