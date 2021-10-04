using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes.ClassesEstaticas
{
    public class CarroDadosBasicos
    {
        public static string NumeroDePneus { get { return "4"; } }

        public static void ConsumoMedio(int km, int litros)
        {
            Console.WriteLine($"O Consumo Médio do Trecho foi: { km / litros }");
        }
    }
}
