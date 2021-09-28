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


        public void DarPartida()
        {
            Console.WriteLine("Carro Ligado! ");
        }

        public void Desligar()
        {
            Console.WriteLine("Carro Desligado! ");
        }
        public void Alugar()
        {
            EstaAlugado = true;
            Console.WriteLine($"Carro { Marca } está Alugado! ");
        }
        public void RetornarCarro()
        {
            EstaAlugado = false;
            Console.WriteLine($"Carro { Marca } foi Devolvido! ");

        }
    }
}
