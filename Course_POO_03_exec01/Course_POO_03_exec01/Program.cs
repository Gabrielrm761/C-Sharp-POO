using System;
using System.Globalization;

namespace Course_POO_03_exec01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Valor(cotacao, dolar);


            Console.WriteLine("Valor a ser pago em reais é: " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
