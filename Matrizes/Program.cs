using System;

namespace MatrizAula79
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; // 2 linha e 3 colunas

            Console.WriteLine(mat.Length); //Quantos elementos a matriz tem no total. 
            Console.WriteLine();

            Console.WriteLine(mat.Rank); // Primeira dimensão da matriz(Qtde de linhas)
            Console.WriteLine();

            Console.WriteLine(mat.GetLength(0)); //Primeira dimensão(Qtde de linhas da Matriz)
            Console.WriteLine();

            Console.WriteLine(mat.GetLength(1)); // Segunda dimensão(Qtde de Colunas da Matriz)
            Console.WriteLine();

        }
    }
}