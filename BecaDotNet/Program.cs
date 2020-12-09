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
            BubbleSorte bubleSort = new BubbleSorte();

            int[] arr = { 78, 55, 45, 98, 13 };
            int[] saida = logica.ordenacao(arr);

            Console.WriteLine(logica.saida(saida));
            Console.Read();
        }
    }
}
