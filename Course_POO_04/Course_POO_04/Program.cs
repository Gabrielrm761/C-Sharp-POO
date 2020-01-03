using System;
using System.Globalization;

namespace Course_POO_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");
            p.SetNome("T"); //não vai ser alterado devido a lógica no SetNome.


            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}
