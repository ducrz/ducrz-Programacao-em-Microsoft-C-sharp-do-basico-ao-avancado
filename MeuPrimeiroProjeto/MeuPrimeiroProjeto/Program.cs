using System;
using System.Text;



namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)            
        {
            //Calculadora Simples

            //Console.Write("Digite o primeiro valor: ");
            //string valor1 = Console.ReadLine();

            //while (Convert.ToInt32(valor1) == 0)
            //{
            //    Console.WriteLine("Valor Inválido. Digite o Primeiro Valor Novamente: ");
            //    valor1 = Console.ReadLine();

            //}

            //Console.WriteLine();

            //Console.Write("Insira o segundo valor: ");
            //string valor2 = Console.ReadLine();


            //while (Convert.ToInt32(valor2) == 0)
            //{
            //    Console.WriteLine("Valor Inválido. Digite o Segundo Valor Novamente: ");
            //    valor2 = Console.ReadLine();

            //}

            //Console.WriteLine();

            //Console.Write("Insira o Operador (+),(-),(*) ou (/): ");
            //string operador = Console.ReadLine();
            //decimal resultado = 0;

            //if(operador == "+")
            //    resultado = Convert.ToInt32(valor1) + Convert.ToInt32(valor2);
            //if (operador == "-")
            //    resultado = Convert.ToInt32(valor1) - Convert.ToInt32(valor2);
            //if (operador == "*")
            //    resultado = Convert.ToInt32(valor1) * Convert.ToInt32(valor2);
            //if (operador == "/")
            //    resultado = Convert.ToInt32(valor1) / Convert.ToInt32(valor2);

            //Console.WriteLine("O Resultado é: "+resultado);

            //Console.ReadKey();


            //Sistema de Login

            string usuarioSistema = "usuario";
            string senhaSistema = "123";


            Console.Write("Digite o nome do Usuário: ");
            string usuarioInserido = Console.ReadLine();

            Console.WriteLine();


            Console.Write("Digite a senha: ");
            string senhaInserida = Console.ReadLine();

            Console.WriteLine();


            if (usuarioInserido != usuarioSistema || senhaInserida != senhaSistema){
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Usuario ou Senha Incorretos! ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bem-vindo ao Sistema!");
            }           

            Console.ReadKey();





        }
    }
}
