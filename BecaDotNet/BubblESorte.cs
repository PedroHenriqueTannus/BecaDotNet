using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    public class BubbleSorte    
    {

        // Metodo de ordenação 
        public int[] ordenacao(int[] entrada)
        {

            int troca = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; j < entrada.Length - 1; j++)
                {

                    if (entrada[j] > entrada[j + 1])
                    {
                        troca = entrada[j + 1];
                        entrada[j + 1] = entrada[j];
                        entrada[j] = troca;

                    }
                }
            }
             return entrada;
        }

        // metodo para retornar os dados do array
        public string saida(int[] entrada)
        {
            string dados = "";
            for (int i = 0; i < entrada.Length; i++)
            {
                dados += " " + entrada[i];
            }

            return dados;
        }
    }

}

