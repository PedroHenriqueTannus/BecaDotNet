using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class BubbleSort
    {
        public static void Iniciar()
        {
            int contador, troca, fim, aux;

            // Quantidade de Variáveis
            Console.WriteLine("Quantos valores deseja ordenar?");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetorOrdenar = new int[tamanho];
            string[] resultado = new string[tamanho + 1];

            // Entrada das variáveis
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Coloque o valor da posição " + i +
                    " digite o " + (i + 1) + "o valor");
                vetorOrdenar[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    resultado[0] = "" + vetorOrdenar[i];
                }
                else
                {
                    resultado[0] += ", " + vetorOrdenar[i];
                }
            }

            contador = 1;
            troca = 1;
            fim = tamanho - 1;

            // Aplicação do método Bubble Sort
            while (troca == 1)
            {
                contador = contador + 1;
                troca = 0;

                for (int i = 0; i < fim; i++)
                {

                    if (vetorOrdenar[i] > vetorOrdenar[i + 1])
                    {
                        aux = vetorOrdenar[i];
                        vetorOrdenar[i] = vetorOrdenar[i + 1];
                        vetorOrdenar[i + 1] = aux;
                        troca = 1;
                    }
                }

                //Armazenamento das sequências de cada varredura
                for (int i = 0; i < tamanho; i++)
                {

                    if (i == 0)
                    {
                        resultado[contador] = "" + vetorOrdenar[i];
                    }
                    else
                    {
                        resultado[contador] += ", " + vetorOrdenar[i];
                    }

                }
                fim = fim - 1;
            }

            //Saída mostrando o resultado do BubbleSort e todo o processo feito
            string resultados = "";
            for (int i = 0; i < contador; i++)
            {
                resultados += i + "a Varredura: " + resultado[i + 1] + "\n";
            }
            Console.WriteLine("Você colocou os seguintes valores: " + resultado[0] +
                "\n Os valores em ordem ficam: " + resultado[contador - 1] + "\n" +
                "\n Foram necessárias " + contador + " varreduras" + "\n" +
                "\n As ordens das varredauras ficam: " + "\n" + resultados);
            Console.ReadLine();
        }
    }
}
