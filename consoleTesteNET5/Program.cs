using System;
using System.Collections.Generic;

namespace consoleTesteNET5
{
    class Program
    {
        static void Main(string[] args)
        {
        //C#9 - Dictionary
        Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
        
        meuDicionario.Add(1,"Eduardo");
        meuDicionario.Add(2, "Roberto");
        meuDicionario.Add(3, "Carlos");

        meuDicionario.Remove(2);

        foreach(var item in meuDicionario)
            Console.WriteLine($"Elemento: { item.Key}, valor { item.Value}");
        }

       
    }
}


public class cliente{
   public int id { get; set; }
   public string nome { get; set; }

}