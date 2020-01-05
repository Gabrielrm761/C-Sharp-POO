using System;
using System.Globalization;

namespace Course_POO_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";
            p.Nome = "T"; //não vai ser alterado devido a lógica no SetNome.
            //p.Preco = 400.00; não é aceito por apenas ter acesso a leitura.


            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
