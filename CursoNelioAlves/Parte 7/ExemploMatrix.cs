using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class ExemploMatrix
    {
        public static void Executar()
        {
            Console.Write("Informe o tamanho da matriz : ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');//vai percorrer os digitos com espaço
                for (int j = 0; j < n; j++)  //Esse For vai percorrer as colunas,alocando na linha
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }
            Console.WriteLine("Diagonal Principal : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i,i] + " " );
            }
            Console.WriteLine();
        }
    }
}
