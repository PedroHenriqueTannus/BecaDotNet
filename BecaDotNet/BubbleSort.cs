using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSortAlg
    {
        public void OrdenaListaDeInteiros(int[] arr)
        {
            //declara uma variável que recebe o valor que será trocado
            int swapValue;

            //realiza um loop for dentro de outro 
            //para que todos os números sejam comparados entre si
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    
                    if (arr[i + 1] < arr[i])
                    {
                        //troca numeros que estão em sequência 
                        //caso o segundo seja menor que o primeiro
                        swapValue = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = swapValue;
                    }
                }
            }

            //realiza um foreach para passar por cada um dos números do array arr
            foreach (int i in arr)
            {
                //escreve cada item i 
                Console.WriteLine(i + " ");
            }
            //le os dados escritos no console
            Console.Read();

        }
    }
}
