using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Divisores
    {
        public static void Executar()
        {
            Console.Write("Informe um número : ");
            var x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
