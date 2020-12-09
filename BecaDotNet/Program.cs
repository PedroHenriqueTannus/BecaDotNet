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
            BubbleSortAlg bubble = new BubbleSortAlg();
            bubble.OrdenaListaDeInteiros(arr);
        }
    }
}
