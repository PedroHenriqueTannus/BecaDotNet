using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 78, 55, 45, 98, 13 };
            BubbleSortAlg bubblesort = new BubbleSortAlg();

            // chamada Bruno Alexandre
            BubbleSorte bubleSort = new BubbleSorte();
            int[] saida = bubleSort.ordenacao(arr);
            Console.WriteLine(bubleSort.saida(saida));
            Console.Read();

            //chamada Diego Prestes
            int[] ordemCresc = bubblesort.BubbleExecuteCrescent(arr);
            bubblesort.LerArray(ordemCresc);
            //chamada Diego Prestes
            int[] ordemDecresc = bubblesort.BubbleExecuteDecrescent(arr);
            bubblesort.LerArray(ordemDecresc);
            Console.Read();

            //instancia o BubbleSortAlg
            //pedro luan
            //Executa o método OrdenaListaDeInteiros passando o array
            bubblesort.OrdenaListaDeInteiros(arr);
            Console.Read();

            //PAULA MACHADO TEIXEIRA
            //instancia um objeto do tipo BubbleSort
            AlgoritmoBubbleSort bubble = new AlgoritmoBubbleSort();
            //objeto chama o método de ordenação 
            bubble.OrdenaLista(arr);                      
            
            Console.ReadKey();
            Ordenador ordenador = new Ordenador();//Instancia Objeto Ordenador.
            
            //leticia sorrilha.
            ordenador.VetorEntrada = arr;
            ordenador.BubbleSort();//Inicia Ordenação pelo algoritmo BubbleSort.

            Console.ReadKey();



            //pedro luan e stevao
            // instacia o BubbleSortAlg 
            BubbleSortAlg bubble2 = new BubbleSortAlg();

            // chamada do metodo que cria o vetor 
            int[] vet = CriaVetor();

            // chamada do metodo 
            bubble2.OrdenaListaDeInteiros2(vet);
        }

        private static int[] CriaVetor()
        {
            // Mine menu incial
            Console.WriteLine("Quatidade de numeros do array: ");
            // Leitura da quatidade escolhida 
            int qtd = int.Parse(Console.ReadLine());
            // instancia do vetor com quantidade escolhida de indices 
            int[] vet = new int[qtd];
            // adiciona ao vetor cada valor digitado
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            return vet;
        }
    }
}
