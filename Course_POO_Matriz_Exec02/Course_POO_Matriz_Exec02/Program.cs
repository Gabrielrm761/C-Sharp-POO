using System;

namespace Course_POO_Matriz_Exec02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Fazer um programa para ler dois números inteiros M e N, e depois ler
                uma matriz de M linhas por N colunas contendo números inteiros,
                podendo haver repetições. Em seguida, ler um número inteiro X que
                pertence à matriz. Para cada ocorrência de X, mostrar os valores à
                esquerda, acima, à direita e abaixo de X, quando houver 
            */
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]); // Número de linhas
            int n = int.Parse(line[1]); // Númeor de Colunas

            int[,] mat = new int[m, n]; // Criando a Matriz

            for (int i = 0; i < m; i++) // For usado para popular a matriz
            {
                string[] values = Console.ReadLine().Split(' '); // Array criado para separar cada componente apresentado 
                for (int j = 0; j < n; j++) // Inserindo os componentes já separados dentro da matriz
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine()); // Valor que será usado para procurar os valores ao redor

            for (int i = 0; i < m; i++) // For para percorrer as linhas da matriz
            {
                for ( int j = 0; j < n; j++) // For para percorrer as colunas da matriz
                {
                    if(mat[i,j] == x) // Usado para encontrar o valor X dentro da matriz
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) // Saber se está na primeira coluna
                        {
                            Console.WriteLine("Left: " + mat[i,j - 1]);
                        }
                        if (i > 0) // Saber se está na primeira linha
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) // Saber se a coluna é menor do que o número de colunas, se j = n-1 significa que já está na última coluna, então não poderia adicionar
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) // Saber se a linha é menor do que o número de linhas, se i = m-1 significa que já está na última linha, então não poderia adicionar
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }

                }
            }
        }
    }
}
