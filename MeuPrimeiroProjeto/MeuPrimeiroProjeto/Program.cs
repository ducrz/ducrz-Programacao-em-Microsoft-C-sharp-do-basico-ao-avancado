using System;
using System.Text;



namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)            
        {
            //variáveis
            int a;
            a = 100;
            Console.WriteLine("Valor de a: " + a);

            double area = 0;
            Console.WriteLine("Valor de área: " + area);

            int salario, imposto, soma;
            int contador = 10;
            Console.WriteLine("Valor de contador: " + contador);

            string nome;
            string nomeCompleto = "Eduardo Silva Monteiro";
            Console.WriteLine("Nome Completo: " + nomeCompleto);



            //Entrada do usuário

            Console.Write("Insira o seu nome completo: ");
            string nomeCompletoUsuario = Console.ReadLine();

            Console.WriteLine("Seu nome completo é: "+nomeCompletoUsuario);
            Console.ReadKey();



        }
    }
}
