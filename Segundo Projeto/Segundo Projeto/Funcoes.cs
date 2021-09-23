using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Projeto
{
    class Funcoes
    {
        void Main(string[] args)
        {
            //Calculadora Simples

            Console.Write("Digite o primeiro valor: ");
            string valor1 = Console.ReadLine();

            int numero1 = Convert.ToInt32(valor1);

            while (Convert.ToInt32(valor1) == 0)
            {
                Console.WriteLine("Valor Inválido. Digite o Primeiro Valor Novamente: ");
                valor1 = Console.ReadLine();
                numero1 = Convert.ToInt32(valor1);

            }

            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            string valor2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(valor2);

            while (Convert.ToInt32(valor2) == 0)
            {
                Console.WriteLine("Valor Inválido. Digite o Segundo Valor Novamente: ");
                valor2 = Console.ReadLine();
                numero2 = Convert.ToInt32(valor2);

            }

            Console.WriteLine();

            Console.Write("Insira o Operador (+),(-),(*) ou (/): ");
            string operador = Console.ReadLine();
            
            if (operador == "+")
                Console.WriteLine($"Resultado: { Somatoria(numero1,numero2) }");
            if (operador == "-")
                Console.WriteLine($"Resultado: { Subtracao(numero1, numero2) }");
            if (operador == "*")
                Console.WriteLine($"Resultado: { Multiplicacao(numero1, numero2) }");
            if (operador == "/")
                Console.WriteLine($"Resultado: { Divisao(numero1, numero2) }");


            Console.ReadKey();
        }

        public void MostrarNome()
        {
            Console.WriteLine("Meu nome é: Eduardo");
        }
        ///<Summary>
        ///Esta função soma dois números e retorna o resultado
        ///</Summary>
        public int Somatoria(int numero1, int numero2)
        {
           return numero1 + numero2;
           
        }

        public int Subtracao(int numero1, int numero2)
        {
            return numero1 - numero2;

        }
        public int Multiplicacao(int numero1, int numero2)
        {
            return numero1 * numero2;

        }
        public int Divisao(int numero1, int numero2)
        {
            return numero1 / numero2;

        }


    }
}
