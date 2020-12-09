﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    public class BubbleSortAlg
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

        public void LerArray(int[] ordenado)
        {
            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.Write($"{ordenado[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("FEITO!");
        }
        public int[] BubbleExecuteCrescent(int[] desordem)
        {
            int mao = 0;

            for (int i = 0; i < desordem.Length - 1; i++)
            {
                for (int j = 0; j < desordem.Length - 1; j++)
                {
                    if (desordem[j] > desordem[j + 1])
                    {
                        mao = desordem[j + 1];
                        desordem[j + 1] = desordem[j];
                        desordem[j] = mao;
                    }
                }
            }
            return desordem;
        }

        public int[] BubbleExecuteDecrescent(int[] desordem)
        {
            int mao = 0;

            for (int i = desordem.Length - 1; i > 0; i--)
            {
                for (int j = desordem.Length - 1; j > 0; j--)
                {
                    if (desordem[j] > desordem[j - 1])
                    {
                        mao = desordem[j - 1];
                        desordem[j - 1] = desordem[j];
                        desordem[j] = mao;
                    }
                }
            }
            return desordem;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    public class BubbleSort
    {
        public static void Iniciar(int[] lista)
        {
            int contador, troca, fim, aux;

            int tamanho = lista.Length;
            string[] resultado = new string[tamanho + 2];

            // Atribuindo valores para um array do tipo String
            for (int i = 0; i < tamanho; i++)
            {
                if (i == 0)
                {
                    resultado[0] = "" + lista[i];
                }
                else
                {
                    resultado[0] += ", " + lista[i];
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
                    if (lista[i] > lista[i + 1])
                    {
                        aux = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux;
                        troca = 1;
                    }
                }
                //Armazenamento das sequências de cada varredura
                for (int i = 0; i < tamanho; i++)
                {
                    if (i == 0)
                    {
                        resultado[contador] = "" + lista[i];
                    }
                    else
                    {
                        resultado[contador] += ", " + lista[i];
                    }
                }
                fim = fim - 1;
            }
            //Saída mostrando o resultado do BubbleSort e todo o processo feito
            string resultados = "";
            for (int i = 0; i < contador; i++)
            {
                if (i != 0)
                {
                    resultados += i+1 + "a Varredura: " + resultado[i + 1] + "\n";
                } else
                {
                    resultados += i+1 + "a Varredura: " + resultado[i] + "\n";
                }
            }
            Console.WriteLine("Você colocou os seguintes valores: " + resultado[0] +
                "\n Os valores em ordem ficam: " + resultado[contador - 1] + "\n" +
                "\n Foram necessárias " + contador + " varreduras" + "\n" +
                "\n As ordens das varredauras ficam: " + "\n" + resultados);
            Console.ReadLine();
        }
    }
}