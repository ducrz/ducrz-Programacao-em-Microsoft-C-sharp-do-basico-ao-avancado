using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDeOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bubble Sort

            int[] vetor = { 99, 2, 97, 23, 10, 51, 76 };
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];

                        vetor[i] = vetor[j]; //Flutuando o valor da direita para esquerda
                        vetor[j] = aux; //Elemento do segundo loop igual ao aux

                    }

                }

            }
            //Imprimindo o vetor já ordenado em ordem crescente
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Resultado");
            Console.ReadKey();
        }
    }
}
