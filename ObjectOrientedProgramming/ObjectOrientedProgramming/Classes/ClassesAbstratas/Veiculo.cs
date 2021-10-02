using System;

namespace ObjectOrientedProgramming.Classes.ClassesAbstratas
{
    abstract public class Veiculo //Classe-Pai
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }

        protected DateTime DataProximaManutenção { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string Marca, string Modelo, string Cor) //Construtor
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Cor = Cor;
            this.DataProximaManutenção = DateTime.Now;

        }
        public virtual void ProximaManutencao()
        {
            //if usuario == admin
            Console.WriteLine($"O Veículo tem manutenção padrão agendada para a data: { this.DataProximaManutenção } ");

        }
        //Sobrecarga - assinatura diferente
        abstract public void ProximaManutencao(int Dias);
    }
}
