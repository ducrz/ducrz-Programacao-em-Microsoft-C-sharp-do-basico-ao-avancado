using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoCorteEControle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo Corte e Controle

            //12 linhas e 4 colunas de dados
            string[,] dadosProdutos = new string[,]

            {
                {"1","martelos","08/2021","10" },
                {"1","martelos","08/2021","14" },
                {"1","martelos","09/2021","5" },
                {"1","martelos","10/2021","12" },
                {"2","chave fenda","09/2021","2" },
                {"2","chave fenda","10/2021","1" },
                {"3","chave philips","08/2021","20" },
                {"3","chave philips","08/2021","30" },
                {"3","chave philips","08/2021","50" },
                {"4","balde","10/2021","100" },
                {"5","pá","09/2021","50" },
                {"5","pá","10/2021","150" },

            };

            int totalProduto = 0;
            int totalGeral = 0;
            string idProdutoAtual = "";
            string idProdutoAnterior = "";
            int linha = 0;

            Console.WriteLine("Id - Produto - Data - Qtd");

            while(linha < 12)
            {
                idProdutoAtual = idProdutoAnterior = dadosProdutos[linha, 0];
                while (linha < 12 && idProdutoAnterior == idProdutoAtual)
                {
                    Console.WriteLine($"{dadosProdutos[linha, 0]} - {dadosProdutos[linha, 1]} - {dadosProdutos[linha,2]} - {dadosProdutos[linha,3]}");
                    totalProduto += Convert.ToInt16(dadosProdutos[linha, 3]);
                    linha++;
                    if (linha < 12)
                        idProdutoAtual = dadosProdutos[linha,0];                
                }
                Console.WriteLine($"Total do Produto: {totalProduto}");
                Console.WriteLine();
                totalGeral += totalProduto;
                totalProduto = 0;
            }
            Console.WriteLine($"Total Geral: {totalGeral}");
            Console.ReadKey();
        }
    }
}
