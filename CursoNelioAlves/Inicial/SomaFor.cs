using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class SomaFor
    {
        public static void Executar()
        {
            Console.Write("Quantos números você vai informar ? ");
            var x = int.Parse(Console.ReadLine());
            var soma = 0;
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"Valor #{i} : ");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine("Soma = {0}",soma);
        }
    }
}
