using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Multiplos
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o primeiro número : ");
            var numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número : ");
            var numero2 = double.Parse(Console.ReadLine());
            if(numero1 % numero2 == 0 || numero2 % numero1 ==0)
            {
                Console.WriteLine("Os números {0} e {1} são multiplos !",numero1 , numero2);
            }
            else { Console.WriteLine("Os números {0} e {1} não são multiplos !",numero1,numero2); }
        }
    }
}
