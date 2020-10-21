using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class NumeroPar
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um número aleatório : ");
            var numero = double.Parse(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine($"O Número {numero} é Par !!");
            }
            else { Console.WriteLine($"O Número {numero} é Ímpar !!"); }
        }
    }
}
