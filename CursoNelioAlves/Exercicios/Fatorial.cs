using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Fatorial
    {
        public static void Executar()
        {
            Console.Write("Informe um número para o fatorial ");
            var x = int.Parse(Console.ReadLine());
            var fatorial = 1;
            for (int i = 1; i <= x; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
