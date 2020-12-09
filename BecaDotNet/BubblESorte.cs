using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSorte
    {


        public int[] ordenacao(int[] entrada)
        {

            int troca = 0;



            for (int i = 0; i < entrada.Length - 1; i++)
            {

                if (entrada[i] > entrada[i + 1])
                {
                    troca = entrada[];
                    entrada[i] = entrada[i + 1];
                    entrada[i + 1] = troca;

                }




            }


            return entrada;


        }

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
}
