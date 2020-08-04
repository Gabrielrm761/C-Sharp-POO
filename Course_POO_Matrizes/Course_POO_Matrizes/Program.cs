using System;

namespace Course_POO_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // Mostra o tamanho da matriz

            Console.WriteLine(mat.Rank); // Mostra a primeira dimensão da matriz, ou seja, a quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // Mostra o tamanho da primeira dimensão da matriz 

            Console.WriteLine(mat.GetLength(1)); // Mostra o tamanho da segunda dimensão da matriz
        }
    }
}
