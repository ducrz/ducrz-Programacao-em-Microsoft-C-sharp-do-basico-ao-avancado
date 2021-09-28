using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        public static void Main(string[] args) {
            int valor = 40;
            Console.WriteLine("Insira um valor que será somado:");
            int valorInseridoPeloUsuario = Convert.ToInt32(Console.ReadLine();
      

            SomarValor(ref valor, valorInseridoPeloUsuario);

            Console.WriteLine("Resultado: " +valor);

            Console.ReadKey();

        }

        private static void SomarValor(ref int valor, int intervalo =0) //Assinatura do Método
        {
            if (intervalo == 0)
                valor++;
            else
                valor = valor + intervalo;
        }
    }
}

