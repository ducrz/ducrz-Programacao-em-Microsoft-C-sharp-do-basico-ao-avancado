using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes.Interfaces
{
    public interface ICarro
    {
       void ProximaManutencao(int Dias);

        string EstadoALuguel();

        void mudarPrecoAluguel(double NovoPreco);
    }
}
