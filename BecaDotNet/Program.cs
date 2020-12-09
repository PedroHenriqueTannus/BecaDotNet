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
            int[] listaValores = { 78, 55, 45, 98, 13 };

            int[] listaOrdenada = BubbleSort.OrdenaLista(listaValores);

            foreach (int item in listaOrdenada)
            {
                Console.Write(item + " ");
            }
            
            Console.Read();
        }
    }
}
