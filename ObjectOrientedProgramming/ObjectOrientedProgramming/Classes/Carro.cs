using ObjectOrientedProgramming.Classes.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes
{
    public class Carro  : Veiculo  {

        public bool EstaAlugado { get; private set; }

        public double Preco { get; private set; }
  
        //Construtores
        public Carro(string Marca, string Modelo, string Cor, double Preco) : base (Marca, Modelo, Cor)
        {
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

        public void ProximaManutencao()
        {
            //if usuario == admin
            Console.WriteLine($"Carro tem manutenção agendada para { this.DataProximaManutenção } ");

        }
    }
}
