using System;

namespace BecaDotNet
{
    public class Algoritmos
    {
        int[] Numeros = new int[5] { 0, 0, 0, 0, 0 }; //armazena os números a serem ordenados

        public void Leitura() //Faz a leitura dos valores a serem ordenados
        {
            Console.WriteLine("insira os numeros a serem ordenados: ");
            Console.ReadLine();
            for (int x = 0; x < Numeros.Length; x++)//salva no array os numeros a serem ordenados
            {
                Numeros[x] = int.Parse(Console.ReadLine());//entra os valores que devem ser armazenados no array
            }
        }

        public void Bubblesort()
                                
        {
            for (int j = 0; j <= Numeros.Length - 2; j++)
            {
                for (int i = 0; i <= Numeros.Length - 2; i++)
                {
                    if (Numeros[i] > Numeros[i + 1])
                    {
                        int temp = Numeros[i + 1];
                        Numeros[i + 1] = Numeros[i];
                        Numeros[i] = temp;
                    }
                }
            }
            Console.WriteLine("Números em ordem:");
            foreach (int p in Numeros)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}