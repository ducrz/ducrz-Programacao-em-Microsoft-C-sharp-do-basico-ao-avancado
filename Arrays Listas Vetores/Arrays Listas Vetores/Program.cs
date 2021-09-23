using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Listas_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array de uma unica dimensao
            string[] nomes = new string[] {"eduardo","paulo","joão","francisco","carlos","ana" };

            //Console.WriteLine($"Tamanho do Array: {nomes.Length}");

            //for (int i = 0; i < nomes.Length; i++)
            //{
            //    Console.WriteLine($"Nome: { nomes[i]} está na posição {i}");

            //}

            ////Buscando Nome
            //Console.WriteLine();
            //Console.WriteLine("Buscar um nome: ");

            //string nomeBuscar = Console.ReadLine();



            //int posicao = Array.IndexOf(nomes,nomeBuscar.ToLower());


            //if (posicao >= 0)
            //    Console.WriteLine($"Achei o nome: {nomes[posicao]} na posição: {posicao}");
            //else
            //    Console.WriteLine("Nome não encontrado!");
            ////Busca "Manual"
            //Console.WriteLine("Buscar um nome: ");

            //string nomeBuscar = Console.ReadLine();

            //foreach (string nome in nomes)
            //{

            //    if (nomeBuscar == nome)
            //    {

            //       Console.WriteLine($"Achei o nome: {nome}");
            //       break;
            //    }


            //}


            ////Foreach
            //Console.WriteLine("Lista de Nomes");

            //Console.WriteLine("ForEach");
            //int cont = 0;

            //foreach (var nome in nomes)
            //{
            //    //if (nome != "")
            //    if(!string.IsNullOrEmpty(nome))
            //        Console.WriteLine($"Nome: {nome}");
            //    else
            //        break;

            //    Console.WriteLine(cont++);

            //}

            //Console.WriteLine("Fim da Lista");


            //Try Catch Finally
            try
            {
                Console.WriteLine();
                Console.WriteLine("Buscar um nome: ");

                string nomeBuscar = Console.ReadLine();



                int posicao = Array.IndexOf(nomes, nomeBuscar.ToLower());


                Console.WriteLine($"Achei o nome: {nomes[posicao]} na posição: {posicao}");

                int valor = 0;
                int res = 10 / valor;
                
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido dividir por zero! ");

                //log
            }
            catch (Exception)
            {
                Console.WriteLine("O Nome não foi encontrado! ");
                //log
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
