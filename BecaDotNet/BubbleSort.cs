using System;
namespace BecaDotNet
{
    class BubbleSort
    {
        public static void Iniciar(int[] lista)
        {
            int contador, troca, fim, aux;
            int[] vetorOrdenar = new int[lista.Length];
            string[] resultado = new string[lista.Length + 1];

            // Entrada das variáveis
            for (int i = 0; i < lista.Length; i++)
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
            fim = lista.Length - 1;

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
                for (int i = 0; i < lista.Length; i++)
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
            Console.WriteLine("Os valores iniciais foram: " + resultado[0] +
                "\n Os valores em ordem ficam: " + resultado[contador - 1] + "\n" +
                "\n Foram necessárias " + contador + " varreduras" + "\n" +
                "\n As ordens das varredauras ficam: " + "\n" + resultados);
            Console.ReadLine();
        }
    }
}
