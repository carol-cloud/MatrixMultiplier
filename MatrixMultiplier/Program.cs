using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz_1 = new int[2, 3];
            int[,] matriz_2 = new int[3, 2];
            int[,] matriz_resultado = new int[2, 2];

            Console.WriteLine("Preencha a primeira matriz: ");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz_1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha a segunda matriz: ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz_2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado da multiplicação da primeira matriz pela segunda: ");
            matriz_resultado[0, 0] = (matriz_1[0, 0] * matriz_2[0, 0]) + (matriz_1[0, 1] * matriz_2[1, 0]) + (matriz_1[0, 2] * matriz_2[2, 0]);
            matriz_resultado[1, 0] = (matriz_1[1, 0] * matriz_2[0, 0]) + (matriz_1[1, 1] * matriz_2[1, 0]) + (matriz_1[1, 2] * matriz_2[2, 0]);
            matriz_resultado[0, 1] = (matriz_1[0, 0] * matriz_2[0, 1]) + (matriz_1[0, 1] * matriz_2[1, 1]) + (matriz_1[0, 2] * matriz_2[2, 1]);
            matriz_resultado[1, 1] = (matriz_1[1, 0] * matriz_2[0, 1]) + (matriz_1[1, 1] * matriz_2[1, 1]) + (matriz_1[1, 2] * matriz_2[2, 1]);

            Console.WriteLine("[" + matriz_resultado[0, 0] + "][" + matriz_resultado[0, 1] + "]");
            Console.WriteLine("[" + matriz_resultado[1, 0] + "][" + matriz_resultado[1, 1] + "]");

            Console.ReadKey();
        }
    }
}
