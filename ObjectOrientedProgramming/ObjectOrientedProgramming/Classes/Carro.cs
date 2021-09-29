using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes
{
    class Carro
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; set; }
        public bool EstaAlugado { get; set; }

        public double Preco { get; private set; }
  
        //Construtores
        public Carro(string Marca, string Modelo, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Preco = Preco;
        }

        public void Alugar()
        {
            if(EstaAlugado == true)
                Console.WriteLine($"Carro { Marca } já está Alugado! Escolha Outro! ");
            else
            {
                EstaAlugado = true;
                Console.WriteLine($"Carro { Marca } está Alugado! ");
            }
      
        }
        public void RetornarCarro()
        {
            EstaAlugado = false;
            Console.WriteLine($"Carro { Marca } foi Devolvido! ");

        }
        public string EstadoAluguel()
        {
            return EstaAlugado == true ? "Sim" : "Não";
        }

        public void MudarPrecoAluguel(double NovoPreco)
        {
            //Precisa de Aprovacao para Mudança de Preço
            //if(novoPreco < preco)
            this.Preco = NovoPreco;
        }
        public void AplicarDescontoAluguel(double Desconto)
        {
            this.Preco -= Desconto;
        }
    }
}
