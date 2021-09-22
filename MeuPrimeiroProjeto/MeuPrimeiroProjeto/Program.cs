using System;
using System.Text;



namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)            
        {
            //Calculadora Simples

            Console.Write("Digite o primeiro valor: ");
            string valor1 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            string valor2 = Console.ReadLine();

            Boolean resultado = valor1 == valor2;

            Console.WriteLine("Resultado é igual: "+resultado);
            Console.WriteLine();


            Boolean comparacaoMaiorQue = Convert.ToInt16(valor1) > Convert.ToInt16(valor2);

            Console.WriteLine("Resultado é valor 1 maior que valor 2 : "+comparacaoMaiorQue);

            Console.ReadKey();


        }
    }
}
