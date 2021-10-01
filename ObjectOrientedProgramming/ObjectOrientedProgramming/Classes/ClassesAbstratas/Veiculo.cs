using System;

namespace ObjectOrientedProgramming.Classes.ClassesAbstratas
{
    public class Veiculo //Classe-Pai
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }

        protected DateTime DataProximaManutenção { get; set; }

        public Veiculo(string Marca, string Modelo, string Cor) //Construtor
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Cor = Cor;

        }

    }
}
