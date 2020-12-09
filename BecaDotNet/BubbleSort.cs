using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSort
    {
        public static int[] OrdenaLista(int[] listaValores)
        {
            int count = 0;

            for (int j = 0; j <= listaValores.Length - 2; j++)
            {

                for (int i = 0; i <= listaValores.Length - 2; i++)
                {
                    count = count + 1;
                    if (listaValores[i] > listaValores[i + 1])
                    {
                        int temp = listaValores[i + 1];
                        listaValores[i + 1] = listaValores[i];
                        listaValores[i] = temp;
                    }
                }
            }
            return listaValores;

        }
    }
}
