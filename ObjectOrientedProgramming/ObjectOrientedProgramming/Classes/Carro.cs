using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public bool EstaAlugado { get; set; }

        public double Preco { get; set; }
  
        //Construtores
        public Carro( string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
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
    }
}
