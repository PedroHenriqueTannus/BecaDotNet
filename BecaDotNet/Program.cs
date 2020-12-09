using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe, tem como parâmetro de entrada uma lista de inteiros.
            int[] arr = { 78, 55, 45, 98, 13 };
            BubbleSort.BolhaSort(arr);
            Console.ReadLine();
        }
    }
}
