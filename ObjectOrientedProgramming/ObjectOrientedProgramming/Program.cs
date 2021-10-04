using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Classes;
using ObjectOrientedProgramming.Classes.ClassesAbstratas;
using ObjectOrientedProgramming.Classes.ClassesEstaticas;

namespace ObjectOrientedProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Veiculo VeiculoVolkswagem = new Veiculo("Volkswagem", "Nivus", "Cinza");

            //Veiculo veiculo = new Veiculo("Volkswagem", "Nivus", "Cinza");


            Moto Honda = new Moto("Honda", "CB-1000", "Branco");
            Honda.ProximaManutencao();

            Carro carro = new Carro("Volkswagem", "Nivus", "Cinza", 110);
            //Carro carro = new Carro("Volkswagem", "Nivus", "Cinza", 110)
            //{
            //Marca = "Volkswagem",
            // Cor = "Cinza",
            //Modelo = "2022",
            //Preco = 110
            // };


            //carro.ProximaManutencao();
            carro.ProximaManutencao(10);


            Console.WriteLine($"Número de Pneus { carro.NumeroDePneus }");

            CarroDadosBasicos.ConsumoMedio(335, 30);



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


            //Listas de Objetos
            List<Carro> listaDeCarros = new List<Carro>();

            listaDeCarros.Add(carro);

            listaDeCarros.Add(new Carro("Honda", "HRV", "Cinza", 160));

          

            Console.WriteLine($"Número de Elementos da Lista { listaDeCarros.Count }");

            foreach (var item in listaDeCarros)
            {
                Console.WriteLine($"Carro Marca { item.Marca } , Modelo { item.Modelo } e cor { item.Cor}");
                carro.ProximaManutencao();
            }
            Console.ReadKey();


            //LINQ

            List<Carro> listaDeCarrosPremium = new List<Carro>()
            {
                new Carro("BMW", "320", "Preto", 279),
                new Carro("BMW", "530e", "Preto", 425),
                new Carro("Mercedes", "C180", "Preto", 238),
                new Carro("Audi", "A4", "Preto", 272)
            };

            //LINQ
            //var listaFiltrada = from MeuCarro in listaDeCarrosPremium
            //                    where MeuCarro.Preco > 150 &&  MeuCarro.Marca == "BMW"
            //                    select MeuCarro;

            //var listaFiltrada = listaDeCarrosPremium.Where(meuCarro => meuCarro.Marca == "BMW" && meuCarro.Preco > 200);

            //Lambda
            Func<Carro, bool> filtroCarroBMW = meuCarro => meuCarro.Marca == "BMW";

            //var listaFiltrada = listaDeCarrosPremium.Where(meuCarro => meuCarro.Marca == "BMW")
            //                                        .Where(meuCarro => meuCarro.Preco >= 200);

            var listaFiltrada = listaDeCarrosPremium.Where(filtroCarroBMW)
                                        .Where(meuCarro => meuCarro.Preco >= 200);

            foreach (var carroPremium in listaFiltrada)
            {
                Console.WriteLine($"Carro Marca { carroPremium.Marca }, Modelo { carroPremium.Modelo} e cor { carroPremium.Cor } ");

            }

            Console.ReadKey();

        }


    }
}

