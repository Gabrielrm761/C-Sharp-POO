using System;

namespace Course_POO_Modificadores_Parametro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);*/

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
