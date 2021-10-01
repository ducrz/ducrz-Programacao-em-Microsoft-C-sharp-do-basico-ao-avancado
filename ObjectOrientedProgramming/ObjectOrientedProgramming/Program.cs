using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Classes;
using ObjectOrientedProgramming.Classes.ClassesAbstratas;

namespace ObjectOrientedProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Veiculo veiculo = new Veiculo("Volkswagem", "Nivus", "Cinza");
            

            Carro carro = new Carro("Volkswagem", "Nivus", "Cinza", 110)
            {
                //Marca = "Volkswagem",
                // Cor = "Cinza",
                //Modelo = "2022",
                //Preco = 110
            };

            //Nivus.Marca = "Volkswagem";
            //Nivus.Cor = "Cinza";
            //Nivus.Modelo = "2022";
            //Nivus.Preco = 110;


            Console.Write("Insira o novo preço do aluguel: ");
            var Preco = Convert.ToDouble(Console.ReadLine());

            carro.MudarPrecoAluguel(Preco);

            carro.Alugar(5);

            Console.WriteLine($"Primeiro Carro da Frota é: {carro.Marca} modelo { carro.Modelo} e com preço de aluguel { carro.Preco }");

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

