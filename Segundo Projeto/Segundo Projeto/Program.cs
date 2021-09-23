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

            //Conversão implícita com Numero + DateTime
            int numero = 10;
            DateTime data = DateTime.Now;

            double decim = 3.14159265359;


            //Explícita
            //Console.WriteLine(numero.ToString()+data);

            Console.WriteLine(numero +" - "+ data);

            Console.WriteLine(decim);


            //Explicita to Int
            Console.WriteLine(Convert.ToInt16(decim));


            //Explícita Data ToString
            Console.WriteLine(data.ToString("dd/MM/yy"));

            Console.WriteLine(data.ToString("dd-MM-yy"));

            Console.WriteLine(data.ToString("MM-yy"));

            Console.WriteLine(data.ToString("MM-yyyy-HH:mm"));


            Console.ReadKey();


        }
    }
}
