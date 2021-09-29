using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Classes;

namespace ObjectOrientedProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {

            Carro carro = new Carro("Volkswagem", "Nivus")
            {
                //Marca = "Volkswagem",
                // Cor = "Cinza",
                //Modelo = "2022",
                Preco = 110
            };

            //Nivus.Marca = "Volkswagem";
            //Nivus.Cor = "Cinza";
            //Nivus.Modelo = "2022";
            //Nivus.Preco = 110;

            Console.WriteLine($"Primeiro Carro da Frota é: {carro.Marca} modelo { carro.Modelo}");

            //Nivus.Alugar();

            //Nivus.Alugar(); //Alugando pela segunda vez, forçando o erro


            ////Operador Ternário
            //string respostaAlugado = Nivus.EstaAlugado == true ? "Sim" : "Não";


            //Console.WriteLine($"{Nivus.Marca} está alugado? {respostaAlugado}");

            //Console.WriteLine($"{Nivus.Marca} está alugado? {Nivus.EstadoAluguel()}");


            Console.ReadKey();

        }


    }
}

