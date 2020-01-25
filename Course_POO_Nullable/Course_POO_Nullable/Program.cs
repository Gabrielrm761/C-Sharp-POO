using System;

namespace Course_POO_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null; -- o double é um valor, struct, portanto valor não Nullable
            //Nullable<double> x = null; -- dessa forma, se indica que o valor pode ser null, porém existe uma forma mais simples.
            double? x = null; // dessa forma indica que a variavel x é do tipo double, mas ela é opcional, Nullable
            double? y = 10.0;

            //Usando esse método ele vai pegar ou o valor existente ou , caso seja null, o padrão da variavel
            Console.WriteLine(x.GetValueOrDefault()); // ele vai pegar o padrão do tipo da variavel, que no caso 0 é o padrão do double
            Console.WriteLine(y.GetValueOrDefault());

            //Método usado para verificar se dentro da variavel existe valor ou não, retornando como boolean
            Console.WriteLine(x.HasValue); // false por não ter valor
            Console.WriteLine(y.HasValue); // true 

            //É importante ter uma verificação ao usar esse método, para que não cause um Exception, um objeto Nullable teve ter um valor.
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            //Operador de Coalescência nula
            double? q = null;
            double? w = 10;

            double a = q ?? 5;
            double b = w ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
