using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class QualIntervalo
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número entre 0 e 100 : ");
            var numero = double.Parse(Console.ReadLine());
            if ( numero < 0.0 || numero > 100)
            {
                Console.WriteLine("Fora de Intervalo");
            }else if (numero <= 25)
            {
                Console.WriteLine("Intervalo 0 25 ");
            }else if(numero <= 50)
            {
                Console.WriteLine("Intervalo 25 50");
            }else if (numero <= 75)
            {
                Console.WriteLine("Intervalo 50 75");
            }
            else { Console.WriteLine("Intervalo 75 100"); }
        }
    }
}
