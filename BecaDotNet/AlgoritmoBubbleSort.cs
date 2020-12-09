using System;

namespace BecaDotNet
{
    class AlgoritmoBubbleSort
    {

        //metodo para ordenação de valores em um array
        public void OrdenaLista(int[] listaValores)
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
            //impressão da lista ordenada
            foreach (int item in listaValores)
            {
                Console.Write(item + " ");
            }
        }
        /// <summary>
        /// Ordena uma lista de inteiros com o algoritmo BubbleSort
        /// </summary>
        /// <param name="listaValores">lista de valores inteiros</param>
        public void OrdenacaoGuilhana(int[] listaValores)
        {
           
            int temp;
            for (int j = 0; j <= listaValores.Length - 2; j++)
            {
                for (int i = 0; i <= listaValores.Length - 2; i++)
                {
                    if (listaValores[i] > listaValores[i + 1])
                    {
                        temp = listaValores[i + 1];
                        listaValores[i + 1] = listaValores[i];
                        listaValores[i] = temp;
                    }
                }
            }
            Console.Write("Resultado da Ordenação: ");
            foreach (int p in listaValores)
                Console.Write(p + " ");
            
        }
    }
}
