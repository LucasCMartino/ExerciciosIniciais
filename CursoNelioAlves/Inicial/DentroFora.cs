using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class DentroFora
    {
        public static void Executar()
        {
            Console.Write("Informe um número aleatório : ");
            var n = int.Parse(Console.ReadLine());
            var In = 0;
            var Out = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe um número para validação : ");
                var a = int.Parse(Console.ReadLine());
                if (a >= 10 && a <= 20)
                {
                    In = In + 1;
                }
                else Out = Out + 1;
            }
            Console.WriteLine($"{In} in");
            Console.WriteLine($"{Out} out");
           
        }
    }
}
