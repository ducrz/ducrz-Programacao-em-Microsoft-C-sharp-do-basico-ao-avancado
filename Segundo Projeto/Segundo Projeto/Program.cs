using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Seção 4: C# Intermediário


            //Conversão Implícita

            //int numero = 10;

            //Console.WriteLine(10);
            //Console.ReadKey();


            ////Outra conversão implícita
            //int numero = 10;


            //Console.WriteLine("Valor de "+numero);
            //Console.ReadKey();


            ////Conversão implícita com DateTime
            //int numero = 10;
            //DateTime data = DateTime.Now;


            //Console.WriteLine(data);
            //Console.ReadKey();

            ////Conversão implícita com Numero + DateTime
            //int numero = 10;
            //DateTime data = DateTime.Now;

            //double decim = 3.14159265359;


            ////Explícita
            ////Console.WriteLine(numero.ToString()+data);

            //Console.WriteLine(numero +" - "+ data);

            //Console.WriteLine(decim);


            ////Explicita to Int
            //Console.WriteLine(Convert.ToInt16(decim));


            ////Explícita Data ToString
            //Console.WriteLine(data.ToString("dd/MM/yy"));

            //Console.WriteLine(data.ToString("dd-MM-yy"));

            //Console.WriteLine(data.ToString("MM-yy"));

            //Console.WriteLine(data.ToString("MM-yyyy-HH:mm"));


            //Console.ReadKey();



            //Operações úteis em Strings


            string mensagem = "         Texto da aula de tratamento de strings        ";

            //Da posicao 10 para frente
            Console.WriteLine(mensagem.Substring(10));

            //A partir da posicao 10, 5 caracteres
            Console.WriteLine(mensagem.Substring(10,5));

            //Removendo espaços em branco
            Console.WriteLine("-"+ mensagem.Trim() + "-");

            Console.WriteLine("-" + mensagem.TrimStart() + "-");

            Console.WriteLine("-" + mensagem.TrimEnd() + "-");

            //Substituir com Replace
            Console.WriteLine("-" + mensagem.Replace("o","A"));

            //Contains

            Console.WriteLine("A mensagem contém a palavra 'aula' ? " + mensagem.Contains("aula"));

            Console.WriteLine("A mensagem contém a palavra 'csharp' ? " + mensagem.Contains("csharp"));


            if (mensagem.Contains("aula"))
                Console.WriteLine("O texto contêm 'aula'.");
            else
                Console.WriteLine("O texto não contêm 'aula'.");


            //Strings para formatos

            int numero = 10;

            DateTime data = DateTime.Now;

            string nome = "Eduardo";

            Console.WriteLine("Meu nome é: " + nome);

            Console.WriteLine(string.Format("Meu nome é: {0}", nome));


            Console.WriteLine($"Meu Nome é: {nome}");


            StringBuilder sb = new StringBuilder();

            sb.Append("texto 1");
            sb.Append($"Meu nome é: {nome}");
            sb.Append($"Hora atual é: {data}");
            sb.Append($"Este é o valor da variável: {numero}");


            Console.WriteLine(sb);

            Console.ReadKey();



        }
    }
}
