using ObjectOrientedProgramming.Classes.ClassesAbstratas;
using ObjectOrientedProgramming.Classes.ClassesEstaticas;
using ObjectOrientedProgramming.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes
{
    public class Carro  : Veiculo, ICarro, ICarroVolkswagem
    {

        public bool EstaAlugado { get; private set; }

        public double Preco { get; private set; }

        public string NumeroDePneus { get; set; }

        public Carro() 
        {

        }
  
        //Construtores
        public Carro(string Marca, string Modelo, string Cor, double Preco, string Placa) : base (Marca, Modelo, Cor)
        {
           this.Preco = Preco;
            this.NumeroDePneus = CarroDadosBasicos.NumeroDePneus;
        }
        //Sobrecarga de Construtor
        public Carro(string Marca, string Modelo, string Cor, double Preco) : base(Marca, Modelo, Cor)
        {
            this.Preco = Preco;
            this.NumeroDePneus = CarroDadosBasicos.NumeroDePneus;
        }

        public void Alugar()
        {
            if(EstaAlugado == true)
                Console.WriteLine($"Carro { Marca } já está Alugado! Escolha Outro! ");
            else
            {
                EstaAlugado = true;
                Console.WriteLine($"Carro { Marca } está Alugado por 30 dias! ");
            }
      
        }
        public void Alugar(int dias)
        {
            if (EstaAlugado == true)
                Console.WriteLine($"Carro { Marca } já está Alugado por { dias } dias ! Escolha Outro! ");
            else
            {
                EstaAlugado = true;
                Console.WriteLine($"Carro { Marca } está Alugado por { dias} dias! ");
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
        
        //Sobrecarga de método
        public override void ProximaManutencao()
        {
            //if usuario == admin
            Console.WriteLine($"O Carro tem manutenção especial agendada para a data: { this.DataProximaManutenção.AddDays(30) } ");

        }

        public void ProximaManutencao(int Dias)
        {
            Console.WriteLine($"Próxima manutenção do Carro em dias: { Dias }");
        }

        public string EstadoALuguel()
        {
            throw new NotImplementedException();
        }

        public void mudarPrecoAluguel(double NovoPreco)
        {
            throw new NotImplementedException();
        }
    }
}
