using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class NegativoOuPositivo
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número aleatório : ");
            var numero = double.Parse(Console.ReadLine());
            if(numero < 0)
            {
                Console.WriteLine($"O Número {numero} é Negativo !!");
            }
            else { Console.WriteLine($"O Número {numero} é Positivo !!"); }
        }
    }
}
