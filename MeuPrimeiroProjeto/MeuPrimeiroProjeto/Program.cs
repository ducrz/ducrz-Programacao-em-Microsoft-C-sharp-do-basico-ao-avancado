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

            //string usuarioSistema = "usuario";
            //string senhaSistema = "123";


            //Console.Write("Digite o nome do Usuário: ");
            //string usuarioInserido = Console.ReadLine();

            //Console.WriteLine();


            //Console.Write("Digite a senha: ");
            //string senhaInserida = Console.ReadLine();

            //Console.WriteLine();


            //if (usuarioInserido != usuarioSistema || senhaInserida != senhaSistema){
            //    Console.ForegroundColor = ConsoleColor.Red;

            //    Console.WriteLine("Usuario ou Senha Incorretos! ");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Bem-vindo ao Sistema!");
            //}           

            //Console.ReadKey();

            //Controle de Idade
            //int regraIdadeLimite = 18;

            //Console.Write("Digite a sua idade: ");
            //string idade = Console.ReadLine();
            //int idadeUsuario = Convert.ToInt16(idade);

            //if(idadeUsuario >= regraIdadeLimite)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Entrada Permitida! ");
            //}
            //else if(idadeUsuario >= 13 && idadeUsuario < regraIdadeLimite)
            //{
            //    Console.Write("Consentimento Parental? (S) ou (N) ");
            //    string consentimento = Console.ReadLine();
            //    if(consentimento == "S")
            //    {
            //        if(idadeUsuario == 15)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("Entrada Permitida! Você têm 15 anos! ");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("Entrada Permitida! ");
            //        }                
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Entrada Não Permitida! ");
            //    }

            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Entrada Não Permitida! ");
            //}
            //Console.ReadKey();


            ////Sistema de Login Exercício

            //string usuarioSistema = "usuario";
            //string senhaSistema = "123";


            //Console.Write("Digite o nome do Usuário: ");
            //string usuarioInserido = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Digite a Idade do Usuário: ");
            //string idadeUsuario = Console.ReadLine();
            //int idadeInformada = Convert.ToInt32(idadeUsuario);


            //Console.WriteLine();

            //Console.Write("Digite o Sexo do Usuário: (M) ou (F) ");
            //string sexoUsuario = Console.ReadLine();


            //Console.WriteLine();


            //Console.Write("Digite a senha: ");
            //string senhaInserida = Console.ReadLine();

            //Console.WriteLine();


            //if (usuarioInserido != usuarioSistema || senhaInserida != senhaSistema)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;

            //    Console.WriteLine("Usuario ou Senha Incorretos! ");
            //}
            //else
            //{

            //    if (idadeInformada > 18 && sexoUsuario == "M")
            //    {
            //        //Homem
            //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        Console.WriteLine("Bem-vindo ao Sistema!");
            //    }
            //    else if (idadeInformada > 18 && sexoUsuario == "F")
            //    {
            //        //Mulher
            //        Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //        Console.WriteLine("Bem-vindo ao Sistema!");
            //    }
            //    else if (idadeInformada > 12 && idadeInformada < 18)
            //    {
            //        //Adolescente
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine("Bem-vindo ao Sistema!");
            //    }
            //    else if (idadeInformada < 12)
            //    {
            //        //Criança
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("Bem-vindo ao Sistema!");
            //    }

            //}

            //Console.ReadKey();

            //FOR

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine("Valor de i: " + i);

            //}
            //Console.ReadKey();

            //WHILE
            //int i = 10;
            //while (i >0)
            //{
            //    Console.WriteLine("Valor de i: "+i);
            //    i--;

            //}
            //Console.ReadKey();


            //DO WHILE

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Valor de i: "+i);
            //    i++;
            //    if (i == 5)
            //        break;
            //} while (i < 5);
            //Console.ReadKey();


         
            //Controle de Idade usando DO WHILE
            int regraIdadeLimite = 18;

            do
            {
                Console.Write("Digite a sua idade ou Escreva Sair para finalizar o programa. ");
                string idade = Console.ReadLine();

                if (idade == "Sair") //Se escreveu Sair
                    break;

                int idadeUsuario = Convert.ToInt16(idade);

                if (idadeUsuario >= regraIdadeLimite)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Entrada Permitida! ");
                }
                else if (idadeUsuario >= 13 && idadeUsuario < regraIdadeLimite)
                {
                    Console.Write("Consentimento Parental? (S) ou (N) ");
                    string consentimento = Console.ReadLine();
                    if (consentimento == "S")
                    {
                        if (idadeUsuario == 15)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Entrada Permitida! Você têm 15 anos! ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Entrada Permitida! ");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada Não Permitida! ");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada Não Permitida! ");
                }
                Console.ReadKey();

            } while (true);

           
        }

    }
}
