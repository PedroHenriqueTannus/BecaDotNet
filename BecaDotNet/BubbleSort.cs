using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSort
    {
        // metodo que ordena o vetor 
        public int[] bbSort(int[] sort)
        {
            
            for (int i = 5 - 1; i >= 1; i--)
            {
                for (int n = 0; n < i; n++)
                {
                    
                    if (sort[n] > sort[n + 1])
                    {
                        int val = sort[n];
                        sort[n] = sort[n + 1];
                        sort[n + 1] = val;

                    }
                }
            }
            return sort;
        }
    }
}
