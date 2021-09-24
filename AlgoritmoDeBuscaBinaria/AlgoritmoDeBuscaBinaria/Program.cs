using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDeBuscaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Busca Binária

            int[] vetor = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23};
            Console.Write("Insira o valor que deseja efetuar a busca: ");
            int valorBuscado = Convert.ToInt16(Console.ReadLine());

            int inf, meio, sup;
            inf = -1;
            sup = vetor.Length;

            while(inf < sup - 1)
            {
                meio = (inf + sup) / 2;
                if (vetor[meio] < valorBuscado){
                    inf = meio;
                }
                else{
                    sup = meio;
                }
            }

            if (sup >= 0 && sup < vetor.Length){
                if (vetor[sup] == valorBuscado){
                    Console.WriteLine("Valor encontrado na posição "+sup);

                }
                else{
                    Console.WriteLine("Valor não foi encontrado");
                }

            }
            else{
                Console.WriteLine("Valor não foi encontrado!");
            }
            Console.ReadKey();
        }
    }
}
