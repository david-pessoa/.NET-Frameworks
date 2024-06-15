using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas da matriz A: ");
            int linhas_de_A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz A: ");
            int colunas_de_A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de linhas da matriz B: ");
            int linhas_de_B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz B: ");
            int colunas_de_B = int.Parse(Console.ReadLine());
            if (colunas_de_A == linhas_de_B)
            {
                int linhas_de_resul = linhas_de_A;
                int colunas_de_resul = colunas_de_B;
                int[,] resultante = new int[linhas_de_resul, colunas_de_resul];
                int[,] matriz_A = new int[linhas_de_A, colunas_de_A];
                int[,] matriz_B = new int[linhas_de_B, colunas_de_B];

                #region Input das matrizes

                for (int i = 0; i < linhas_de_A; i++)
                {
                    for(int j = 0; j < colunas_de_A; j++)
                    {
                        Console.WriteLine("Digite o número na posição ("+ i+","+j+ ") da matriz A");
                        int num_A = int.Parse(Console.ReadLine());
                        matriz_A[i, j] = num_A;
                    }
                }
                for (int k = 0; k < linhas_de_B; k++)
                {
                    for (int l = 0; l < colunas_de_B; l++)
                    {
                        Console.WriteLine("Digite o número na posição (" + k + "," + l + ") da matriz B");
                        int num_B = int.Parse(Console.ReadLine());
                        matriz_B[k, l] = num_B;
                    }
                }

                #endregion
                /*
                resultante[0, 0] = (matriz_A[0, 0] * matriz_B[0, 0]) + (matriz_A[0, 1] * matriz_B[1, 0]) + (matriz_A[0, 2] * matriz_B[2, 0]);
                resultante[0, 1] = (matriz_A[0, 0] * matriz_B[0, 1]) + (matriz_A[0, 1] * matriz_B[1, 1]) + (matriz_A[0, 2] * matriz_B[2, 1]);
                resultante[1, 0] = (matriz_A[1, 0] * matriz_B[0, 0]) + (matriz_A[1, 1] * matriz_B[1, 0]) + (matriz_A[1, 2] * matriz_B[2, 0]);
                resultante[1, 1] = (matriz_A[1, 0] * matriz_B[0, 1]) + (matriz_A[1, 1] * matriz_B[1, 1]) + (matriz_A[1, 2] * matriz_B[2, 1]);
                Console.WriteLine(" ("+ resultante[0,0]+ ")  ("+ resultante[0,1] + ")");
                Console.WriteLine(" (" + resultante[1, 0] + ")  (" + resultante[1, 1] + ")");
                */
                for (int i = 0; i < linhas_de_resul; i++)
                {
                    for (int j = 0; j < colunas_de_resul; j++)
                    {
                        for (int k = 0; k < colunas_de_A; k++)
                        {
                            resultante[i, j] += matriz_A[i, k] * matriz_B[k, j];
                        }
                        Console.Write(" ("+resultante[i, j]+") ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Impossível multiplicar uma matriz " + linhas_de_A + "X" + colunas_de_A
                    + " por uma matriz " + linhas_de_B + "X" + colunas_de_B);
            }


        }
    }
}
